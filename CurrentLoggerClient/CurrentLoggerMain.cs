using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;



namespace CurrentLoggerClient
{
    // All incoming datapackets are stored in the format of this struct.
    public struct InaData 
    {
        public double time;
        public int i2cReadings;
        public float voltage;
        public float current;
        public float power;
        public float mAh;
        public float mWh;
    }

    public partial class CurrentLogger : Form
    {
        private List<InaData> logData = new List<InaData>(); // All readings are stored here
        private double logDataCount = 0; // How many readings do we have
        private bool isSampling = false;


        /* Form constructor */
        public CurrentLogger()
        {
            InitializeComponent();
            SetupListboxes();
        }


        /* When form is loaded we call the setup dialog and then we start the UDP listener thread */
        private void CurrentLoggerMain_Load(object sender, EventArgs e)
        {
            Setup setupDlg = new Setup();
            setupDlg.ShowDialog();

            UpdateVisibility();
            Thread UDPListenerThread = new Thread(new ThreadStart(UdpListenerThread));
            UDPListenerThread.Start();
        }

        #region Network communication


        /* Send a string to the ESP */
        private void UdpSend(String msg)
        {
            IPEndPoint RemoteEndPoint = new IPEndPoint(IPAddress.Parse(Properties.Settings.Default.RemoteIp), Properties.Settings.Default.RemotePort);
            Socket server = new Socket(AddressFamily.InterNetwork,
                                       SocketType.Dgram, ProtocolType.Udp);
            byte[] rxData = Encoding.ASCII.GetBytes(msg);
            server.SendTo(rxData, rxData.Length, SocketFlags.None, RemoteEndPoint);
        }


        /* A worker thread that handles all incoming UDP packets.
           When a packet is received it is stored in the dataLog list. */
        public void UdpListenerThread()
        {
            // Setup the formats of the float's that are comming from the ESP.
            var fmt = new NumberFormatInfo();
            fmt.NegativeSign = "-"; // not ordinary minus from arduino!
            fmt.NumberDecimalSeparator = ".";

            UdpClient udpClient = new UdpClient(Properties.Settings.Default.ListenPort);
            while (true)
            {
                // Get the received packet as a string
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes).ToString();

                // Split the packet (format="time:i2creadings:voltage:current:power:mAh:mWh")
                string[] parameters = returnData.Split( ':' );
                InaData dataEntry = new InaData();
                dataEntry.time = float.Parse(parameters[0]);
                dataEntry.i2cReadings = int.Parse(parameters[1], fmt);
                dataEntry.voltage = float.Parse(parameters[2], fmt);
                dataEntry.current = float.Parse(parameters[3], fmt);
                dataEntry.power = float.Parse(parameters[4], fmt);
                dataEntry.mAh = float.Parse(parameters[5], fmt);
                dataEntry.mWh = float.Parse(parameters[6], fmt);

                if (isSampling) 
                {
                    logData.Add(dataEntry); // Only if we are sampling we add the reading. (To avoid other thread colliding with this thread)
                    logDataCount++;

                    InvokeUI(() => // Update the UI elements
                    {
                        LB_DataCount.Text = logDataCount.ToString();
                        LB_Read.Text = dataEntry.i2cReadings.ToString();
                        LB_Voltage.Text = dataEntry.voltage.ToString();
                        LB_Current.Text = dataEntry.current.ToString();
                        LB_Power.Text = dataEntry.power.ToString();
                        LB_mAh.Text = dataEntry.mAh.ToString();
                        LB_mWh.Text = dataEntry.mWh.ToString();
                    });
                }
            }
        }

        # endregion


        /* Helper method to update UI elements from a foreign thread */
        private void InvokeUI(Action a)
        {
            this.BeginInvoke(new MethodInvoker(a));
        }


        /* When a new sampling cycle is started we start from scratch by resetting logged data */
        private void ResetLogdata()
        {
            logData.Clear();
            logDataCount = 0;
            LB_DataCount.Text = "0";
        }


        /* Takes all the UI configuration and sends it to ESP (normally before sampling is started) */
        private void SendConfig()
        {
            string msg = "C:" + CB_Range.SelectedValue + ":" + CB_Gain.SelectedValue + ":" + CB_BusAdc.SelectedValue + ":" + CB_ShuntAdc.SelectedValue + ":" + TB_ShuntResistor.Text;
            UdpSend(msg);
        }


        /* When sampling is stopped this is called to write a CSV file in the storage folder that was set up */
        private void WriteCsv()
        {
            // The filename is "x:\storagefolder\CurrentLog yyyy-mm-dd hhmmss.csv". Provided Storage folder expected to end with back-slash.
            DateTime now = DateTime.Now; 
            var file = Properties.Settings.Default.StorageFolder + "CurrentLog " + now.ToString("yyyy-MM-dd HHmmss") + ".csv"; 

            using (var stream = File.CreateText(file))
            {
                foreach (var e in logData) // All collected data are traversed
                {
                    string csvRow = string.Format("{0};{1};{2};{3};{4};{5};{6}", e.time, e.i2cReadings, e.voltage, e.current, e.power, e.mAh, e.mWh);
                    stream.WriteLine(csvRow);
                }
            }
        }


        #region User interface


        /* When triggering is started we want the UI stats to be removed */
        void ClearMeasurementStats()
        {
            LB_DataCount.Text = "";
            LB_Read.Text = "";
            LB_Current.Text = "";
            LB_Voltage.Text = "";
            LB_Power.Text = "";
            LB_mAh.Text = "";
            LB_mWh.Text = "";
        }


        /* Turns on/off visibility on labels/input fields/buttons depending on if we are doing sampling*/
        private void UpdateVisibility()
        {
            BT_Start.Enabled = !isSampling;
            BT_SetTrigger.Enabled = !isSampling;
            CB_Gain.Enabled = !isSampling;
            CB_Range.Enabled = !isSampling;
            CB_ShuntAdc.Enabled = !isSampling;
            CB_BusAdc.Enabled = !isSampling;
            TB_ShuntResistor.Enabled = !isSampling;
            CB_TriggerSource.Enabled = !isSampling;
            CB_TriggerOn.Enabled = !isSampling;
            TB_TriggerValue.Enabled = !isSampling;
            BT_Stop.Enabled = isSampling;
            LB_DataCount.Visible = isSampling;
            LB_Read.Visible = isSampling;
            LB_Voltage.Visible = isSampling;
            LB_Current.Visible = isSampling;
            LB_Power.Visible = isSampling;
            LB_mAh.Visible = isSampling;
            LB_mWh.Visible = isSampling;
        }


        /* Setup all listboxes. Lots of key/values are used here */
        private void SetupListboxes()
        {
            CB_Gain.DisplayMember = "Text";
            CB_Gain.ValueMember = "Value";
            var gainItems = new[] {
                new { Text = "40mV", Value = "0" },
                new { Text = "80mV", Value = "1" },
                new { Text = "160mV", Value = "2" },
                new { Text = "320mV", Value = "3" }
            };
            CB_Gain.DataSource = gainItems;
            CB_Gain.SelectedIndex = 0;


            CB_Range.DisplayMember = "Text";
            CB_Range.ValueMember = "Value";
            var rangeItems = new[] {
                new { Text = "16V", Value = "0" },
                new { Text = "32V", Value = "1" }
            };
            CB_Range.DataSource = rangeItems;
            CB_Range.SelectedIndex = 0;


            CB_BusAdc.DisplayMember = "Text";
            CB_BusAdc.ValueMember = "Value";
            var busAdcItems = new[] {
                new { Text = "84us 9bit", Value = "0" },
                new { Text = "148us 10bit", Value = "1" },
                new { Text = "276us 11bit", Value = "2" },
                new { Text = "532us 12bit", Value = "3" },
                new { Text = "1.06ms 2samples", Value = "9" },
                new { Text = "2.13ms 4samples", Value = "10" },
                new { Text = "4.26ms 8samples", Value = "11" },
                new { Text = "8.51ms 16samples *", Value = "12" },
                new { Text = "17.02ms 32samples *", Value = "13" },
                new { Text = "34.05ms 64samples *", Value = "14" },
                new { Text = "68.10ms 128samples *", Value = "15" }
            };
            CB_BusAdc.DataSource = busAdcItems;
            CB_BusAdc.SelectedIndex = 0;


            CB_ShuntAdc.DisplayMember = "Text";
            CB_ShuntAdc.ValueMember = "Value";
            var shuntAdcItems = new[] {
                new { Text = "84us 9bit", Value = "0" },
                new { Text = "148us 10bit", Value = "1" },
                new { Text = "276us 11bit", Value = "2" },
                new { Text = "532us 12bit", Value = "3" },
                new { Text = "1.06ms 2samples", Value = "9" },
                new { Text = "2.13ms 4samples", Value = "10" },
                new { Text = "4.26ms 8samples", Value = "11" },
                new { Text = "8.51ms 16samples *", Value = "12" },
                new { Text = "17.02ms 32samples *", Value = "13" },
                new { Text = "34.05ms 64samples *", Value = "14" },
                new { Text = "68.10ms 128samples *", Value = "15" }
            };
            CB_ShuntAdc.DataSource = shuntAdcItems;
            CB_ShuntAdc.SelectedIndex = 10;


            CB_TriggerSource.DisplayMember = "Text";
            CB_TriggerSource.ValueMember = "Value";
            var triggerSourceItems = new[] {
                new { Text = "Current", Value = "C" },
                new { Text = "Voltage", Value = "V" },
                new { Text = "Power", Value = "P" }
            };
            CB_TriggerSource.DataSource = triggerSourceItems;
            CB_TriggerSource.SelectedIndex = 0;


            CB_TriggerOn.DisplayMember = "Text";
            CB_TriggerOn.ValueMember = "Value";
            var triggerOnItems = new[] {
                new { Text = "Greather than", Value = "G" },
                new { Text = "Less than", Value = "L" }
            };
            CB_TriggerOn.DataSource = triggerOnItems;
            CB_TriggerOn.SelectedIndex = 0;
        }


        /* Start button clicked. Send configuration and start command to ESP */
        private void BT_Start_Click(object sender, EventArgs e)
        {
            SendConfig();
            UdpSend("A");
            ResetLogdata();
            isSampling = true;
            UpdateVisibility();
        }


        /* Stop button clicked. Send stop command to ESP */
        private void BT_Stop_Click(object sender, EventArgs e)
        {
            UdpSend("O");
            isSampling = false;
            UpdateVisibility();
            WriteCsv();
        }


        /* Trigger button clicked. Send configuration and trigger command to ESP */
        private void BT_SetTrigger_Click(object sender, EventArgs e)
        {
            SendConfig();
            string msg = "T:" + CB_TriggerSource.SelectedValue + ":" + CB_TriggerOn.SelectedValue + ":" + TB_TriggerValue.Text;
            UdpSend(msg);
            ResetLogdata();
            ClearMeasurementStats();
            isSampling = true;
            UpdateVisibility();
        }


        #endregion

    }
}