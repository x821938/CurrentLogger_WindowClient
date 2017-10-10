using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrentLoggerClient
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }


        /* Read configuration file and populate it to the input fields
           There is no input validation! I know I am lazy - but this program is for me! */
        private void Setup_Load(object sender, EventArgs e)
        {
            TB_ListenPort.Text = Properties.Settings.Default.ListenPort.ToString();
            TB_RemotePort.Text = Properties.Settings.Default.RemotePort.ToString();
            TB_RemoteIP.Text = Properties.Settings.Default.RemoteIp;
            TB_StorageFolder.Text = Properties.Settings.Default.StorageFolder; // Must end in back-slash.
        }


        /* When OK is clicked we take all fields and store them back in configuration file */
        private void BT_OK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ListenPort = int.Parse(TB_ListenPort.Text);
            Properties.Settings.Default.RemotePort = int.Parse(TB_RemotePort.Text);
            Properties.Settings.Default.RemoteIp = TB_RemoteIP.Text;
            Properties.Settings.Default.StorageFolder = TB_StorageFolder.Text;
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }
}
