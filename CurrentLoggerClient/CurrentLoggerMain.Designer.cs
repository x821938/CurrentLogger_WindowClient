namespace CurrentLoggerClient
{
    partial class CurrentLogger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CB_Gain = new System.Windows.Forms.ComboBox();
            this.LB_Gain = new System.Windows.Forms.Label();
            this.LB_Range = new System.Windows.Forms.Label();
            this.CB_Range = new System.Windows.Forms.ComboBox();
            this.LB_ShuntAdc = new System.Windows.Forms.Label();
            this.CB_ShuntAdc = new System.Windows.Forms.ComboBox();
            this.LB_BusAdc = new System.Windows.Forms.Label();
            this.CB_BusAdc = new System.Windows.Forms.ComboBox();
            this.TB_ShuntResistor = new System.Windows.Forms.TextBox();
            this.LB_ShuntResistor = new System.Windows.Forms.Label();
            this.CB_TriggerSource = new System.Windows.Forms.ComboBox();
            this.TB_TriggerValue = new System.Windows.Forms.TextBox();
            this.BT_SetTrigger = new System.Windows.Forms.Button();
            this.BT_Start = new System.Windows.Forms.Button();
            this.BT_Stop = new System.Windows.Forms.Button();
            this.CB_TriggerOn = new System.Windows.Forms.ComboBox();
            this.LB_DataCount = new System.Windows.Forms.Label();
            this.LB_Voltage = new System.Windows.Forms.Label();
            this.LB_Current = new System.Windows.Forms.Label();
            this.LB_Power = new System.Windows.Forms.Label();
            this.LB_mAh = new System.Windows.Forms.Label();
            this.LB_mWh = new System.Windows.Forms.Label();
            this.GB_Configuration = new System.Windows.Forms.GroupBox();
            this.GB_Trigger = new System.Windows.Forms.GroupBox();
            this.LB_LB_mWh = new System.Windows.Forms.Label();
            this.LB_LB_mAh = new System.Windows.Forms.Label();
            this.LB_LB_Power = new System.Windows.Forms.Label();
            this.LB_LB_Current = new System.Windows.Forms.Label();
            this.LB_LB_Voltage = new System.Windows.Forms.Label();
            this.LB_LB_Count = new System.Windows.Forms.Label();
            this.GB_Manual = new System.Windows.Forms.GroupBox();
            this.GB_Measurements = new System.Windows.Forms.GroupBox();
            this.LB_Read = new System.Windows.Forms.Label();
            this.LB_LB_Reads = new System.Windows.Forms.Label();
            this.LB_LB_CurrentRange = new System.Windows.Forms.Label();
            this.LB_CurrentRange = new System.Windows.Forms.Label();
            this.GB_Configuration.SuspendLayout();
            this.GB_Trigger.SuspendLayout();
            this.GB_Manual.SuspendLayout();
            this.GB_Measurements.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_Gain
            // 
            this.CB_Gain.FormattingEnabled = true;
            this.CB_Gain.Location = new System.Drawing.Point(128, 41);
            this.CB_Gain.Name = "CB_Gain";
            this.CB_Gain.Size = new System.Drawing.Size(121, 24);
            this.CB_Gain.TabIndex = 0;
            this.CB_Gain.SelectedIndexChanged += new System.EventHandler(this.CB_Gain_SelectedIndexChanged);
            // 
            // LB_Gain
            // 
            this.LB_Gain.AutoSize = true;
            this.LB_Gain.Location = new System.Drawing.Point(21, 43);
            this.LB_Gain.Name = "LB_Gain";
            this.LB_Gain.Size = new System.Drawing.Size(38, 17);
            this.LB_Gain.TabIndex = 1;
            this.LB_Gain.Text = "Gain";
            // 
            // LB_Range
            // 
            this.LB_Range.AutoSize = true;
            this.LB_Range.Location = new System.Drawing.Point(21, 80);
            this.LB_Range.Name = "LB_Range";
            this.LB_Range.Size = new System.Drawing.Size(50, 17);
            this.LB_Range.TabIndex = 3;
            this.LB_Range.Text = "Range";
            // 
            // CB_Range
            // 
            this.CB_Range.FormattingEnabled = true;
            this.CB_Range.Location = new System.Drawing.Point(128, 77);
            this.CB_Range.Name = "CB_Range";
            this.CB_Range.Size = new System.Drawing.Size(121, 24);
            this.CB_Range.TabIndex = 2;
            // 
            // LB_ShuntAdc
            // 
            this.LB_ShuntAdc.AutoSize = true;
            this.LB_ShuntAdc.Location = new System.Drawing.Point(21, 116);
            this.LB_ShuntAdc.Name = "LB_ShuntAdc";
            this.LB_ShuntAdc.Size = new System.Drawing.Size(77, 17);
            this.LB_ShuntAdc.TabIndex = 5;
            this.LB_ShuntAdc.Text = "Shunt ADC";
            // 
            // CB_ShuntAdc
            // 
            this.CB_ShuntAdc.FormattingEnabled = true;
            this.CB_ShuntAdc.Location = new System.Drawing.Point(128, 113);
            this.CB_ShuntAdc.Name = "CB_ShuntAdc";
            this.CB_ShuntAdc.Size = new System.Drawing.Size(206, 24);
            this.CB_ShuntAdc.TabIndex = 4;
            // 
            // LB_BusAdc
            // 
            this.LB_BusAdc.AutoSize = true;
            this.LB_BusAdc.Location = new System.Drawing.Point(21, 152);
            this.LB_BusAdc.Name = "LB_BusAdc";
            this.LB_BusAdc.Size = new System.Drawing.Size(64, 17);
            this.LB_BusAdc.TabIndex = 7;
            this.LB_BusAdc.Text = "Bus ADC";
            // 
            // CB_BusAdc
            // 
            this.CB_BusAdc.FormattingEnabled = true;
            this.CB_BusAdc.Location = new System.Drawing.Point(128, 149);
            this.CB_BusAdc.Name = "CB_BusAdc";
            this.CB_BusAdc.Size = new System.Drawing.Size(188, 24);
            this.CB_BusAdc.TabIndex = 6;
            // 
            // TB_ShuntResistor
            // 
            this.TB_ShuntResistor.Location = new System.Drawing.Point(128, 185);
            this.TB_ShuntResistor.Name = "TB_ShuntResistor";
            this.TB_ShuntResistor.Size = new System.Drawing.Size(100, 22);
            this.TB_ShuntResistor.TabIndex = 8;
            this.TB_ShuntResistor.Text = "0.1";
            this.TB_ShuntResistor.TextChanged += new System.EventHandler(this.TB_ShuntResistor_TextChanged);
            // 
            // LB_ShuntResistor
            // 
            this.LB_ShuntResistor.AutoSize = true;
            this.LB_ShuntResistor.Location = new System.Drawing.Point(21, 188);
            this.LB_ShuntResistor.Name = "LB_ShuntResistor";
            this.LB_ShuntResistor.Size = new System.Drawing.Size(101, 17);
            this.LB_ShuntResistor.TabIndex = 9;
            this.LB_ShuntResistor.Text = "Shunt Resistor";
            // 
            // CB_TriggerSource
            // 
            this.CB_TriggerSource.FormattingEnabled = true;
            this.CB_TriggerSource.Location = new System.Drawing.Point(35, 35);
            this.CB_TriggerSource.Name = "CB_TriggerSource";
            this.CB_TriggerSource.Size = new System.Drawing.Size(121, 24);
            this.CB_TriggerSource.TabIndex = 14;
            // 
            // TB_TriggerValue
            // 
            this.TB_TriggerValue.Location = new System.Drawing.Point(35, 108);
            this.TB_TriggerValue.Name = "TB_TriggerValue";
            this.TB_TriggerValue.Size = new System.Drawing.Size(100, 22);
            this.TB_TriggerValue.TabIndex = 15;
            this.TB_TriggerValue.Text = "3";
            // 
            // BT_SetTrigger
            // 
            this.BT_SetTrigger.Location = new System.Drawing.Point(24, 154);
            this.BT_SetTrigger.Name = "BT_SetTrigger";
            this.BT_SetTrigger.Size = new System.Drawing.Size(121, 23);
            this.BT_SetTrigger.TabIndex = 16;
            this.BT_SetTrigger.Text = "Set trigger";
            this.BT_SetTrigger.UseVisualStyleBackColor = true;
            this.BT_SetTrigger.Click += new System.EventHandler(this.BT_SetTrigger_Click);
            // 
            // BT_Start
            // 
            this.BT_Start.Location = new System.Drawing.Point(60, 29);
            this.BT_Start.Name = "BT_Start";
            this.BT_Start.Size = new System.Drawing.Size(75, 23);
            this.BT_Start.TabIndex = 17;
            this.BT_Start.Text = "Start";
            this.BT_Start.UseVisualStyleBackColor = true;
            this.BT_Start.Click += new System.EventHandler(this.BT_Start_Click);
            // 
            // BT_Stop
            // 
            this.BT_Stop.Location = new System.Drawing.Point(60, 58);
            this.BT_Stop.Name = "BT_Stop";
            this.BT_Stop.Size = new System.Drawing.Size(75, 23);
            this.BT_Stop.TabIndex = 18;
            this.BT_Stop.Text = "Stop";
            this.BT_Stop.UseVisualStyleBackColor = true;
            this.BT_Stop.Click += new System.EventHandler(this.BT_Stop_Click);
            // 
            // CB_TriggerOn
            // 
            this.CB_TriggerOn.FormattingEnabled = true;
            this.CB_TriggerOn.Location = new System.Drawing.Point(35, 72);
            this.CB_TriggerOn.Name = "CB_TriggerOn";
            this.CB_TriggerOn.Size = new System.Drawing.Size(121, 24);
            this.CB_TriggerOn.TabIndex = 19;
            // 
            // LB_DataCount
            // 
            this.LB_DataCount.AutoSize = true;
            this.LB_DataCount.Location = new System.Drawing.Point(100, 37);
            this.LB_DataCount.Name = "LB_DataCount";
            this.LB_DataCount.Size = new System.Drawing.Size(43, 17);
            this.LB_DataCount.TabIndex = 21;
            this.LB_DataCount.Text = "count";
            // 
            // LB_Voltage
            // 
            this.LB_Voltage.AutoSize = true;
            this.LB_Voltage.Location = new System.Drawing.Point(100, 79);
            this.LB_Voltage.Name = "LB_Voltage";
            this.LB_Voltage.Size = new System.Drawing.Size(56, 17);
            this.LB_Voltage.TabIndex = 22;
            this.LB_Voltage.Text = "Voltage";
            // 
            // LB_Current
            // 
            this.LB_Current.AutoSize = true;
            this.LB_Current.Location = new System.Drawing.Point(100, 100);
            this.LB_Current.Name = "LB_Current";
            this.LB_Current.Size = new System.Drawing.Size(55, 17);
            this.LB_Current.TabIndex = 23;
            this.LB_Current.Text = "Current";
            // 
            // LB_Power
            // 
            this.LB_Power.AutoSize = true;
            this.LB_Power.Location = new System.Drawing.Point(100, 121);
            this.LB_Power.Name = "LB_Power";
            this.LB_Power.Size = new System.Drawing.Size(47, 17);
            this.LB_Power.TabIndex = 24;
            this.LB_Power.Text = "Power";
            // 
            // LB_mAh
            // 
            this.LB_mAh.AutoSize = true;
            this.LB_mAh.Location = new System.Drawing.Point(100, 142);
            this.LB_mAh.Name = "LB_mAh";
            this.LB_mAh.Size = new System.Drawing.Size(36, 17);
            this.LB_mAh.TabIndex = 25;
            this.LB_mAh.Text = "mAh";
            // 
            // LB_mWh
            // 
            this.LB_mWh.AutoSize = true;
            this.LB_mWh.Location = new System.Drawing.Point(100, 163);
            this.LB_mWh.Name = "LB_mWh";
            this.LB_mWh.Size = new System.Drawing.Size(40, 17);
            this.LB_mWh.TabIndex = 26;
            this.LB_mWh.Text = "mWh";
            // 
            // GB_Configuration
            // 
            this.GB_Configuration.Controls.Add(this.LB_CurrentRange);
            this.GB_Configuration.Controls.Add(this.LB_LB_CurrentRange);
            this.GB_Configuration.Controls.Add(this.LB_Range);
            this.GB_Configuration.Controls.Add(this.CB_Gain);
            this.GB_Configuration.Controls.Add(this.LB_Gain);
            this.GB_Configuration.Controls.Add(this.CB_Range);
            this.GB_Configuration.Controls.Add(this.CB_ShuntAdc);
            this.GB_Configuration.Controls.Add(this.LB_ShuntAdc);
            this.GB_Configuration.Controls.Add(this.CB_BusAdc);
            this.GB_Configuration.Controls.Add(this.LB_BusAdc);
            this.GB_Configuration.Controls.Add(this.TB_ShuntResistor);
            this.GB_Configuration.Controls.Add(this.LB_ShuntResistor);
            this.GB_Configuration.Location = new System.Drawing.Point(34, 29);
            this.GB_Configuration.Name = "GB_Configuration";
            this.GB_Configuration.Size = new System.Drawing.Size(361, 273);
            this.GB_Configuration.TabIndex = 27;
            this.GB_Configuration.TabStop = false;
            this.GB_Configuration.Text = "Configuration";
            // 
            // GB_Trigger
            // 
            this.GB_Trigger.Controls.Add(this.CB_TriggerSource);
            this.GB_Trigger.Controls.Add(this.TB_TriggerValue);
            this.GB_Trigger.Controls.Add(this.BT_SetTrigger);
            this.GB_Trigger.Controls.Add(this.CB_TriggerOn);
            this.GB_Trigger.Location = new System.Drawing.Point(470, 29);
            this.GB_Trigger.Name = "GB_Trigger";
            this.GB_Trigger.Size = new System.Drawing.Size(184, 201);
            this.GB_Trigger.TabIndex = 28;
            this.GB_Trigger.TabStop = false;
            this.GB_Trigger.Text = "Trigger";
            // 
            // LB_LB_mWh
            // 
            this.LB_LB_mWh.AutoSize = true;
            this.LB_LB_mWh.Location = new System.Drawing.Point(33, 163);
            this.LB_LB_mWh.Name = "LB_LB_mWh";
            this.LB_LB_mWh.Size = new System.Drawing.Size(44, 17);
            this.LB_LB_mWh.TabIndex = 34;
            this.LB_LB_mWh.Text = "mWh:";
            // 
            // LB_LB_mAh
            // 
            this.LB_LB_mAh.AutoSize = true;
            this.LB_LB_mAh.Location = new System.Drawing.Point(33, 142);
            this.LB_LB_mAh.Name = "LB_LB_mAh";
            this.LB_LB_mAh.Size = new System.Drawing.Size(40, 17);
            this.LB_LB_mAh.TabIndex = 33;
            this.LB_LB_mAh.Text = "mAh:";
            // 
            // LB_LB_Power
            // 
            this.LB_LB_Power.AutoSize = true;
            this.LB_LB_Power.Location = new System.Drawing.Point(33, 121);
            this.LB_LB_Power.Name = "LB_LB_Power";
            this.LB_LB_Power.Size = new System.Drawing.Size(51, 17);
            this.LB_LB_Power.TabIndex = 32;
            this.LB_LB_Power.Text = "Power:";
            // 
            // LB_LB_Current
            // 
            this.LB_LB_Current.AutoSize = true;
            this.LB_LB_Current.Location = new System.Drawing.Point(33, 100);
            this.LB_LB_Current.Name = "LB_LB_Current";
            this.LB_LB_Current.Size = new System.Drawing.Size(59, 17);
            this.LB_LB_Current.TabIndex = 31;
            this.LB_LB_Current.Text = "Current:";
            // 
            // LB_LB_Voltage
            // 
            this.LB_LB_Voltage.AutoSize = true;
            this.LB_LB_Voltage.Location = new System.Drawing.Point(33, 79);
            this.LB_LB_Voltage.Name = "LB_LB_Voltage";
            this.LB_LB_Voltage.Size = new System.Drawing.Size(60, 17);
            this.LB_LB_Voltage.TabIndex = 30;
            this.LB_LB_Voltage.Text = "Voltage:";
            // 
            // LB_LB_Count
            // 
            this.LB_LB_Count.AutoSize = true;
            this.LB_LB_Count.Location = new System.Drawing.Point(33, 37);
            this.LB_LB_Count.Name = "LB_LB_Count";
            this.LB_LB_Count.Size = new System.Drawing.Size(47, 17);
            this.LB_LB_Count.TabIndex = 29;
            this.LB_LB_Count.Text = "count:";
            // 
            // GB_Manual
            // 
            this.GB_Manual.Controls.Add(this.BT_Start);
            this.GB_Manual.Controls.Add(this.BT_Stop);
            this.GB_Manual.Location = new System.Drawing.Point(470, 250);
            this.GB_Manual.Name = "GB_Manual";
            this.GB_Manual.Size = new System.Drawing.Size(184, 113);
            this.GB_Manual.TabIndex = 35;
            this.GB_Manual.TabStop = false;
            this.GB_Manual.Text = "Manual";
            // 
            // GB_Measurements
            // 
            this.GB_Measurements.Controls.Add(this.LB_Read);
            this.GB_Measurements.Controls.Add(this.LB_LB_Reads);
            this.GB_Measurements.Controls.Add(this.LB_LB_Voltage);
            this.GB_Measurements.Controls.Add(this.LB_DataCount);
            this.GB_Measurements.Controls.Add(this.LB_LB_mWh);
            this.GB_Measurements.Controls.Add(this.LB_Voltage);
            this.GB_Measurements.Controls.Add(this.LB_LB_mAh);
            this.GB_Measurements.Controls.Add(this.LB_Current);
            this.GB_Measurements.Controls.Add(this.LB_LB_Power);
            this.GB_Measurements.Controls.Add(this.LB_Power);
            this.GB_Measurements.Controls.Add(this.LB_LB_Current);
            this.GB_Measurements.Controls.Add(this.LB_mAh);
            this.GB_Measurements.Controls.Add(this.LB_mWh);
            this.GB_Measurements.Controls.Add(this.LB_LB_Count);
            this.GB_Measurements.Location = new System.Drawing.Point(716, 29);
            this.GB_Measurements.Name = "GB_Measurements";
            this.GB_Measurements.Size = new System.Drawing.Size(190, 207);
            this.GB_Measurements.TabIndex = 36;
            this.GB_Measurements.TabStop = false;
            this.GB_Measurements.Text = "Measurements";
            // 
            // LB_Read
            // 
            this.LB_Read.AutoSize = true;
            this.LB_Read.Location = new System.Drawing.Point(100, 58);
            this.LB_Read.Name = "LB_Read";
            this.LB_Read.Size = new System.Drawing.Size(49, 17);
            this.LB_Read.TabIndex = 35;
            this.LB_Read.Text = "Reads";
            // 
            // LB_LB_Reads
            // 
            this.LB_LB_Reads.AutoSize = true;
            this.LB_LB_Reads.Location = new System.Drawing.Point(33, 58);
            this.LB_LB_Reads.Name = "LB_LB_Reads";
            this.LB_LB_Reads.Size = new System.Drawing.Size(53, 17);
            this.LB_LB_Reads.TabIndex = 36;
            this.LB_LB_Reads.Text = "Reads:";
            // 
            // LB_LB_CurrentRange
            // 
            this.LB_LB_CurrentRange.AutoSize = true;
            this.LB_LB_CurrentRange.Location = new System.Drawing.Point(21, 221);
            this.LB_LB_CurrentRange.Name = "LB_LB_CurrentRange";
            this.LB_LB_CurrentRange.Size = new System.Drawing.Size(105, 17);
            this.LB_LB_CurrentRange.TabIndex = 10;
            this.LB_LB_CurrentRange.Text = "Current Range:";
            // 
            // LB_CurrentRange
            // 
            this.LB_CurrentRange.AutoSize = true;
            this.LB_CurrentRange.Location = new System.Drawing.Point(125, 221);
            this.LB_CurrentRange.Name = "LB_CurrentRange";
            this.LB_CurrentRange.Size = new System.Drawing.Size(0, 17);
            this.LB_CurrentRange.TabIndex = 11;
            // 
            // CurrentLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 412);
            this.Controls.Add(this.GB_Measurements);
            this.Controls.Add(this.GB_Manual);
            this.Controls.Add(this.GB_Trigger);
            this.Controls.Add(this.GB_Configuration);
            this.Name = "CurrentLogger";
            this.Text = "Current Logger";
            this.Load += new System.EventHandler(this.CurrentLoggerMain_Load);
            this.GB_Configuration.ResumeLayout(false);
            this.GB_Configuration.PerformLayout();
            this.GB_Trigger.ResumeLayout(false);
            this.GB_Trigger.PerformLayout();
            this.GB_Manual.ResumeLayout(false);
            this.GB_Measurements.ResumeLayout(false);
            this.GB_Measurements.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Gain;
        private System.Windows.Forms.Label LB_Gain;
        private System.Windows.Forms.Label LB_Range;
        private System.Windows.Forms.ComboBox CB_Range;
        private System.Windows.Forms.Label LB_ShuntAdc;
        private System.Windows.Forms.ComboBox CB_ShuntAdc;
        private System.Windows.Forms.Label LB_BusAdc;
        private System.Windows.Forms.ComboBox CB_BusAdc;
        private System.Windows.Forms.TextBox TB_ShuntResistor;
        private System.Windows.Forms.Label LB_ShuntResistor;
        private System.Windows.Forms.ComboBox CB_TriggerSource;
        private System.Windows.Forms.TextBox TB_TriggerValue;
        private System.Windows.Forms.Button BT_SetTrigger;
        private System.Windows.Forms.Button BT_Start;
        private System.Windows.Forms.Button BT_Stop;
        private System.Windows.Forms.ComboBox CB_TriggerOn;
        private System.Windows.Forms.Label LB_DataCount;
        private System.Windows.Forms.Label LB_Voltage;
        private System.Windows.Forms.Label LB_Current;
        private System.Windows.Forms.Label LB_Power;
        private System.Windows.Forms.Label LB_mAh;
        private System.Windows.Forms.Label LB_mWh;
        private System.Windows.Forms.GroupBox GB_Configuration;
        private System.Windows.Forms.GroupBox GB_Trigger;
        private System.Windows.Forms.Label LB_LB_mWh;
        private System.Windows.Forms.Label LB_LB_mAh;
        private System.Windows.Forms.Label LB_LB_Power;
        private System.Windows.Forms.Label LB_LB_Current;
        private System.Windows.Forms.Label LB_LB_Voltage;
        private System.Windows.Forms.Label LB_LB_Count;
        private System.Windows.Forms.GroupBox GB_Manual;
        private System.Windows.Forms.GroupBox GB_Measurements;
        private System.Windows.Forms.Label LB_Read;
        private System.Windows.Forms.Label LB_LB_Reads;
        private System.Windows.Forms.Label LB_CurrentRange;
        private System.Windows.Forms.Label LB_LB_CurrentRange;
    }
}

