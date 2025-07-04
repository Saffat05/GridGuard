namespace SmartSubstationDashboard
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblBreaker = new System.Windows.Forms.Label();
            this.lblVoltage = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.chartLive = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSaveLog = new System.Windows.Forms.Button();
            this.chkAutoMode = new System.Windows.Forms.CheckBox();
            this.sliderVoltage = new System.Windows.Forms.TrackBar();
            this.btnTrip = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSaveChart_Click = new System.Windows.Forms.Button();
            this.pictureBoxAlarm = new System.Windows.Forms.PictureBox();
            this.lblPowerFactor = new System.Windows.Forms.Label();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.chkDarkMode = new System.Windows.Forms.CheckBox();
            this.lblSystemHealth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartLive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBreaker
            // 
            this.lblBreaker.AutoSize = true;
            this.lblBreaker.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreaker.Location = new System.Drawing.Point(12, 141);
            this.lblBreaker.Name = "lblBreaker";
            this.lblBreaker.Size = new System.Drawing.Size(128, 16);
            this.lblBreaker.TabIndex = 2;
            this.lblBreaker.Text = "Breaker: --\t";
            this.lblBreaker.Click += new System.EventHandler(this.lblBreaker_Click);
            // 
            // lblVoltage
            // 
            this.lblVoltage.AutoSize = true;
            this.lblVoltage.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltage.Location = new System.Drawing.Point(12, 17);
            this.lblVoltage.Name = "lblVoltage";
            this.lblVoltage.Size = new System.Drawing.Size(128, 16);
            this.lblVoltage.TabIndex = 3;
            this.lblVoltage.Text = "Voltage: --";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(12, 69);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(128, 16);
            this.lblCurrent.TabIndex = 4;
            this.lblCurrent.Text = "Current: --\t";
            this.lblCurrent.Click += new System.EventHandler(this.lblCurrent_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(12, 167);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(158, 212);
            this.listBoxLog.TabIndex = 5;
            this.listBoxLog.SelectedIndexChanged += new System.EventHandler(this.listBoxLog_SelectedIndexChanged);
            // 
            // chartLive
            // 
            chartArea3.Name = "ChartArea1";
            this.chartLive.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartLive.Legends.Add(legend3);
            this.chartLive.Location = new System.Drawing.Point(176, 141);
            this.chartLive.Name = "chartLive";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartLive.Series.Add(series3);
            this.chartLive.Size = new System.Drawing.Size(435, 238);
            this.chartLive.TabIndex = 6;
            this.chartLive.Text = "chart1";
            this.chartLive.Click += new System.EventHandler(this.chartLive_Click);
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.Location = new System.Drawing.Point(629, 340);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(126, 38);
            this.btnSaveLog.TabIndex = 7;
            this.btnSaveLog.Text = "Save Log --> File";
            this.btnSaveLog.UseVisualStyleBackColor = true;
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            // 
            // chkAutoMode
            // 
            this.chkAutoMode.AutoSize = true;
            this.chkAutoMode.Location = new System.Drawing.Point(642, 146);
            this.chkAutoMode.Name = "chkAutoMode";
            this.chkAutoMode.Size = new System.Drawing.Size(78, 17);
            this.chkAutoMode.TabIndex = 8;
            this.chkAutoMode.Text = "Auto Mode";
            this.chkAutoMode.UseVisualStyleBackColor = true;
            this.chkAutoMode.CheckedChanged += new System.EventHandler(this.chkAutoMode_CheckedChanged);
            // 
            // sliderVoltage
            // 
            this.sliderVoltage.Location = new System.Drawing.Point(12, 404);
            this.sliderVoltage.Maximum = 13000;
            this.sliderVoltage.Minimum = 10000;
            this.sliderVoltage.Name = "sliderVoltage";
            this.sliderVoltage.Size = new System.Drawing.Size(760, 45);
            this.sliderVoltage.TabIndex = 9;
            this.sliderVoltage.Value = 10000;
            // 
            // btnTrip
            // 
            this.btnTrip.Location = new System.Drawing.Point(629, 189);
            this.btnTrip.Name = "btnTrip";
            this.btnTrip.Size = new System.Drawing.Size(126, 43);
            this.btnTrip.TabIndex = 10;
            this.btnTrip.Text = "Trip Breaker";
            this.btnTrip.UseVisualStyleBackColor = true;
            this.btnTrip.Click += new System.EventHandler(this.btnTrip_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(629, 238);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(126, 44);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset Breaker";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnSaveChart_Click
            // 
            this.btnSaveChart_Click.Location = new System.Drawing.Point(629, 288);
            this.btnSaveChart_Click.Name = "btnSaveChart_Click";
            this.btnSaveChart_Click.Size = new System.Drawing.Size(126, 46);
            this.btnSaveChart_Click.TabIndex = 13;
            this.btnSaveChart_Click.Text = "Save Chart";
            this.btnSaveChart_Click.UseVisualStyleBackColor = true;
            this.btnSaveChart_Click.Click += new System.EventHandler(this.btnSaveChart_Click_Click);
            // 
            // pictureBoxAlarm
            // 
            this.pictureBoxAlarm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAlarm.Image")));
            this.pictureBoxAlarm.Location = new System.Drawing.Point(535, 96);
            this.pictureBoxAlarm.Name = "pictureBoxAlarm";
            this.pictureBoxAlarm.Size = new System.Drawing.Size(42, 23);
            this.pictureBoxAlarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAlarm.TabIndex = 14;
            this.pictureBoxAlarm.TabStop = false;
            this.pictureBoxAlarm.Visible = false;
            // 
            // lblPowerFactor
            // 
            this.lblPowerFactor.AutoSize = true;
            this.lblPowerFactor.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.lblPowerFactor.Location = new System.Drawing.Point(626, 17);
            this.lblPowerFactor.Name = "lblPowerFactor";
            this.lblPowerFactor.Size = new System.Drawing.Size(183, 16);
            this.lblPowerFactor.TabIndex = 15;
            this.lblPowerFactor.Text = "Power Factor: --";
            this.lblPowerFactor.Click += new System.EventHandler(this.lblPowerFactor_Click);
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.lblEnergy.Location = new System.Drawing.Point(626, 69);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(194, 16);
            this.lblEnergy.TabIndex = 16;
            this.lblEnergy.Text = "Energy: 0.000 kWh";
            // 
            // chkDarkMode
            // 
            this.chkDarkMode.AutoSize = true;
            this.chkDarkMode.Location = new System.Drawing.Point(642, 171);
            this.chkDarkMode.Name = "chkDarkMode";
            this.chkDarkMode.Size = new System.Drawing.Size(94, 17);
            this.chkDarkMode.TabIndex = 17;
            this.chkDarkMode.Text = "Dark Mode 🌙";
            this.chkDarkMode.UseVisualStyleBackColor = true;
            this.chkDarkMode.CheckedChanged += new System.EventHandler(this.chkDarkMode_CheckedChanged);
            // 
            // lblSystemHealth
            // 
            this.lblSystemHealth.AutoSize = true;
            this.lblSystemHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSystemHealth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSystemHealth.Font = new System.Drawing.Font("Lucida Console", 13F, System.Drawing.FontStyle.Bold);
            this.lblSystemHealth.Location = new System.Drawing.Point(255, 99);
            this.lblSystemHealth.Name = "lblSystemHealth";
            this.lblSystemHealth.Size = new System.Drawing.Size(274, 20);
            this.lblSystemHealth.TabIndex = 18;
            this.lblSystemHealth.Text = "System Health: Healthy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblSystemHealth);
            this.Controls.Add(this.chkDarkMode);
            this.Controls.Add(this.lblEnergy);
            this.Controls.Add(this.lblPowerFactor);
            this.Controls.Add(this.pictureBoxAlarm);
            this.Controls.Add(this.btnSaveChart_Click);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTrip);
            this.Controls.Add(this.sliderVoltage);
            this.Controls.Add(this.chkAutoMode);
            this.Controls.Add(this.btnSaveLog);
            this.Controls.Add(this.chartLive);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblVoltage);
            this.Controls.Add(this.lblBreaker);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartLive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBreaker;
        private System.Windows.Forms.Label lblVoltage;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLive;
        private System.Windows.Forms.Button btnSaveLog;
        private System.Windows.Forms.CheckBox chkAutoMode;
        private System.Windows.Forms.TrackBar sliderVoltage;
        private System.Windows.Forms.Button btnTrip;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSaveChart_Click;
        private System.Windows.Forms.PictureBox pictureBoxAlarm;
        private System.Windows.Forms.Label lblPowerFactor;
        private System.Windows.Forms.Label lblEnergy;
        private System.Windows.Forms.CheckBox chkDarkMode;
        private System.Windows.Forms.Label lblSystemHealth;
    }
}

