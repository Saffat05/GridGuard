using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SmartSubstationDashboard
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        private int timeCounter = 0;
        private bool autoMode = true;
        private bool alarmTriggered = false;
        private double totalEnergy_kWh = 0;


        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.WhiteSmoke; // Light background
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
    {
         // Simulated random data
         double voltage = autoMode ? 11000 + rand.NextDouble() * 1000 : sliderVoltage.Value;
         double current = 100 + rand.NextDouble() * 100;

         // Simulated phase angle between voltage and current in degrees
         double phaseAngle = 10 + rand.NextDouble() * 10; // 10° to 20°
         double powerFactor = Math.Cos(phaseAngle * Math.PI / 180);

         double powerW = voltage * current;
         totalEnergy_kWh += powerW / 3600000; // convert W·s to kWh
         lblEnergy.Text = $"Energy: {totalEnergy_kWh:F3} kWh";


            // Display
            lblPowerFactor.Text = $"Power Factor: {powerFactor:F2}";
         lblPowerFactor.ForeColor = (powerFactor > 0.9) ? Color.Green :
                                       (powerFactor > 0.8) ? Color.Orange : Color.Red;


         // Update UI labels
         lblVoltage.Text = $"Voltage: {voltage:F2} V";
         lblCurrent.Text = $"Current: {current:F2} A";

            // Voltage Alarm logic
            if (voltage > 12000)
            {
                pictureBoxAlarm.Visible = true;

                if (!alarmTriggered)
                {
                    MessageBox.Show(
                        "Overvoltage Alert!\nVoltage exceeded 12,000 V.",
                        "Alarm",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    alarmTriggered = true;

                    listBoxLog.Items.Insert(0, $"[{DateTime.Now:HH:mm:ss}] ⚠️ Voltage alarm triggered");
                }
            }
            else
            {
                pictureBoxAlarm.Visible = false;
                alarmTriggered = false; // Reset once voltage goes back to normal
            }



            if (autoMode)
            {
                // Breaker logic (simple toggle for simulation)
                string breakerState = (voltage > 11500) ? "OPENED" : "CLOSED";
                lblBreaker.Text = breakerState == "OPENED" ? "Breaker: 🔴 OPENED" : "Breaker: 🟢 CLOSED";  // Beautified with emoji
                lblBreaker.ForeColor = (breakerState == "OPENED") ? Color.Red : Color.Green;

                // Log breaker event
                string time = DateTime.Now.ToString("HH:mm:ss");
                listBoxLog.Items.Insert(0, $"[{time}] ⚡ Breaker {breakerState}");
            }

            string systemHealth;
            Color healthColor;

            if (voltage > 11800 || current > 180)
            {
                systemHealth = "Critical";
                healthColor = Color.Red;
            }
            else if (voltage > 11500 || current > 150)
            {
                systemHealth = "Warning";
                healthColor = Color.Goldenrod;
            }
            else
            {
                systemHealth = "Healthy";
                healthColor = Color.Green;
            }

            lblSystemHealth.Text = $"System Health: {systemHealth}";
            lblSystemHealth.ForeColor = Color.White;
            lblSystemHealth.BackColor = healthColor;
            // Add to chart
            chartLive.Series[0].Points.AddXY(timeCounter, voltage);
        chartLive.Series[1].Points.AddXY(timeCounter, current);

        // Keep chart to 15 points
        if (chartLive.Series[0].Points.Count > 15)
        {
            chartLive.Series[0].Points.RemoveAt(0);
            chartLive.Series[1].Points.RemoveAt(0);
            chartLive.ChartAreas[0].AxisX.Minimum++;
            chartLive.ChartAreas[0].AxisX.Maximum++;
        }

          timeCounter++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set up chart
            chartLive.Series.Clear();

            // Voltage Series
            Series voltageSeries = new Series("Voltage (V)");
            voltageSeries.ChartType = SeriesChartType.Line;
            voltageSeries.Color = Color.Blue;
            voltageSeries.BorderWidth = 2;
            chartLive.Series.Add(voltageSeries);

            // Current Series
            Series currentSeries = new Series("Current (A)");
            currentSeries.ChartType = SeriesChartType.Line;
            currentSeries.Color = Color.Orange;
            currentSeries.BorderWidth = 2;
            chartLive.Series.Add(currentSeries);

            // Chart area setup
            ChartArea chartArea = chartLive.ChartAreas[0];
            chartArea.AxisX.Title = "Time (s)";
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = 15;
            chartArea.AxisX.Interval = 2; // Show only even numbers
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Maximum = 13000;
            chartArea.AxisY.Title = "Values";

            chartArea.BackColor = Color.WhiteSmoke;  // Beautification
            chartLive.BorderlineDashStyle = ChartDashStyle.Solid;
            chartLive.BorderlineColor = Color.LightGray;
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

            // Labels
            //Label lblTitle = new Label();
            //lblTitle.Text = " Smart Substation Dashboard";
            //lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            //lblTitle.ForeColor = Color.DarkBlue;
            //lblTitle.AutoSize = true;
            //lblTitle.Location = new Point(20, 10); // or center manually
            //this.Controls.Add(lblTitle);

            //lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
            //lblTitle.Anchor = AnchorStyles.Top;




            lblVoltage.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblCurrent.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblBreaker.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblPowerFactor.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblEnergy.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            // Timer setup
            timer1.Interval = 1000; // 1 second
            timer1.Start();

            // Set manual controls initially disabled
            sliderVoltage.Enabled = false;
            btnTrip.Enabled = false;
            btnReset.Enabled = false;

            pictureBoxAlarm.Image = Image.FromFile("error.png");
            pictureBoxAlarm.Visible = false;
        }



        private void listBoxLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chartLive_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            if (listBoxLog.Items.Count == 0)
            {
                MessageBox.Show("No log entries to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Text Files (*.txt)|*.txt";
                saveDialog.Title = "Save Log to File";
                saveDialog.FileName = $"substation_log_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                    {
                        foreach (var item in listBoxLog.Items)
                        {
                            writer.WriteLine(item.ToString());
                        }
                    }

                    MessageBox.Show("Log saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void chkAutoMode_CheckedChanged(object sender, EventArgs e)
        {
            autoMode = chkAutoMode.Checked;
            sliderVoltage.Enabled = !autoMode;
            btnTrip.Enabled = !autoMode;
            btnReset.Enabled = !autoMode;

            string time = DateTime.Now.ToString("HH:mm:ss");
            listBoxLog.Items.Insert(0, $"[{time}] Mode switched to {(autoMode ? "AUTO" : "MANUAL")}");
        }

        private void btnTrip_Click(object sender, EventArgs e)
        {
            lblBreaker.Text = "Breaker: OPENED";
            lblBreaker.ForeColor = Color.Red;
            string time = DateTime.Now.ToString("HH:mm:ss");
            listBoxLog.Items.Insert(0, $"[{time}] Manual Trip");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblBreaker.Text = "Breaker: CLOSED";
            lblBreaker.ForeColor = Color.Green;
            string time = DateTime.Now.ToString("HH:mm:ss");
            listBoxLog.Items.Insert(0, $"[{time}] Manual Reset");
        }

        private void lblCurrent_Click(object sender, EventArgs e)
        {

        }

        private void lblBreaker_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveChart_Click_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                chartLive.SaveImage(sfd.FileName, ChartImageFormat.Png);
            }
        }

        private void lblPowerFactor_Click(object sender, EventArgs e)
        {

        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            
        
            if (chkDarkMode.Checked)
            {
                // Dark Mode colors
                this.BackColor = Color.FromArgb(30, 30, 30); // dark gray
                lblVoltage.ForeColor = Color.White;
                lblCurrent.ForeColor = Color.White;
                lblBreaker.ForeColor = lblBreaker.ForeColor; // unchanged
                lblPowerFactor.ForeColor = lblPowerFactor.ForeColor;
                lblEnergy.ForeColor = Color.White;
                chartLive.BackColor = Color.FromArgb(45, 45, 45);
                chartLive.ChartAreas[0].BackColor = Color.FromArgb(45, 45, 45);
                chartLive.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                chartLive.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
                listBoxLog.BackColor = Color.Black;
                listBoxLog.ForeColor = Color.White;
            }
            else
            {
                // Light Mode colors
                this.BackColor = Color.White;
                lblVoltage.ForeColor = Color.Black;
                lblCurrent.ForeColor = Color.Black;
                lblBreaker.ForeColor = lblBreaker.ForeColor;
                lblPowerFactor.ForeColor = lblPowerFactor.ForeColor;
                lblEnergy.ForeColor = Color.Black;
                chartLive.BackColor = Color.White;
                chartLive.ChartAreas[0].BackColor = Color.White;
                chartLive.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
                chartLive.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;
                listBoxLog.BackColor = Color.White;
                listBoxLog.ForeColor = Color.Black;
            }

            bool isDark = chkDarkMode.Checked;

            // Update form background
            this.BackColor = isDark ? Color.FromArgb(30, 30, 30) : Color.White;

            // Label text colors
            lblVoltage.ForeColor = isDark ? Color.White : Color.Black;
            lblCurrent.ForeColor = isDark ? Color.White : Color.Black;
            lblBreaker.ForeColor = lblBreaker.ForeColor; // keep dynamic logic unchanged
            lblPowerFactor.ForeColor = lblPowerFactor.ForeColor; // if dynamic logic exists
            lblEnergy.ForeColor = isDark ? Color.White : Color.Black;

            // Chart styling
            chartLive.BackColor = isDark ? Color.FromArgb(45, 45, 45) : Color.White;
            chartLive.ChartAreas[0].BackColor = chartLive.BackColor;
            chartLive.ChartAreas[0].AxisX.LabelStyle.ForeColor = isDark ? Color.White : Color.Black;
            chartLive.ChartAreas[0].AxisY.LabelStyle.ForeColor = isDark ? Color.White : Color.Black;
            chartLive.ChartAreas[0].AxisX.TitleForeColor = isDark ? Color.White : Color.Black;
            chartLive.ChartAreas[0].AxisY.TitleForeColor = isDark ? Color.White : Color.Black;

            // Log box styling
            listBoxLog.BackColor = isDark ? Color.Black : Color.White;
            listBoxLog.ForeColor = isDark ? Color.White : Color.Black;

            // Checkbox text color
            chkDarkMode.ForeColor = isDark ? Color.White : Color.Black;

            
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is CheckBox cb)
                {
                    cb.ForeColor = isDark ? Color.White : Color.Black;
                }
            }


        }
}
}
