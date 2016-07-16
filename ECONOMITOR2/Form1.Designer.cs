namespace ECONOMITOR2
{
    partial class Economitor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.derivacion1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.respiracion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.spo2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTemperatura = new System.Windows.Forms.Label();
            this.textTemperatura = new System.Windows.Forms.TextBox();
            this.labelRR = new System.Windows.Forms.Label();
            this.labelSpO2 = new System.Windows.Forms.Label();
            this.textRR = new System.Windows.Forms.TextBox();
            this.textSpO2 = new System.Windows.Forms.TextBox();
            this.labelSistolica = new System.Windows.Forms.Label();
            this.textSistolica = new System.Windows.Forms.TextBox();
            this.labelDiastolica = new System.Windows.Forms.Label();
            this.textDiastolica = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonShutdown = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.textHeartRate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textMean_Pressure = new System.Windows.Forms.TextBox();
            this.botonAlarma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.derivacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.respiracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spo2)).BeginInit();
            this.SuspendLayout();
            // 
            // derivacion1
            // 
            this.derivacion1.BackColor = System.Drawing.Color.Black;
            this.derivacion1.BackSecondaryColor = System.Drawing.Color.Black;
            this.derivacion1.BorderlineColor = System.Drawing.Color.Black;
            this.derivacion1.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.derivacion1.BorderSkin.BackSecondaryColor = System.Drawing.Color.Yellow;
            this.derivacion1.BorderSkin.PageColor = System.Drawing.Color.Gray;
            chartArea4.BackColor = System.Drawing.Color.Black;
            chartArea4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            chartArea4.Name = "ChartArea1";
            this.derivacion1.ChartAreas.Add(chartArea4);
            this.derivacion1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend4.Name = "Legend1";
            this.derivacion1.Legends.Add(legend4);
            this.derivacion1.Location = new System.Drawing.Point(0, 324);
            this.derivacion1.Name = "derivacion1";
            series4.BackImageTransparentColor = System.Drawing.Color.Black;
            series4.BackSecondaryColor = System.Drawing.Color.Black;
            series4.BorderColor = System.Drawing.Color.Black;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Color = System.Drawing.Color.Red;
            series4.LabelBackColor = System.Drawing.Color.White;
            series4.LabelBorderColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.MarkerBorderColor = System.Drawing.Color.White;
            series4.Name = "Series1";
            this.derivacion1.Series.Add(series4);
            this.derivacion1.Size = new System.Drawing.Size(749, 108);
            this.derivacion1.TabIndex = 0;
            this.derivacion1.TabStop = false;
            this.derivacion1.Tag = "derivacion1";
            this.derivacion1.Text = "chart1";
            // 
            // respiracion
            // 
            this.respiracion.BackColor = System.Drawing.Color.Black;
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea5.BackColor = System.Drawing.Color.Black;
            chartArea5.Name = "ChartArea1";
            this.respiracion.ChartAreas.Add(chartArea5);
            this.respiracion.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend5.Name = "Legend1";
            this.respiracion.Legends.Add(legend5);
            this.respiracion.Location = new System.Drawing.Point(0, 216);
            this.respiracion.Name = "respiracion";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.respiracion.Series.Add(series5);
            this.respiracion.Size = new System.Drawing.Size(749, 108);
            this.respiracion.TabIndex = 3;
            this.respiracion.Text = "chart4";
            // 
            // spo2
            // 
            this.spo2.BackColor = System.Drawing.Color.Black;
            chartArea6.BackColor = System.Drawing.Color.Black;
            chartArea6.Name = "ChartArea1";
            this.spo2.ChartAreas.Add(chartArea6);
            this.spo2.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend6.Name = "Legend1";
            this.spo2.Legends.Add(legend6);
            this.spo2.Location = new System.Drawing.Point(0, 108);
            this.spo2.Name = "spo2";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Color = System.Drawing.Color.LightSalmon;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.spo2.Series.Add(series6);
            this.spo2.Size = new System.Drawing.Size(749, 108);
            this.spo2.TabIndex = 4;
            this.spo2.Text = "chart5";
            this.spo2.Click += new System.EventHandler(this.spo2_Click);
            // 
            // labelTemperatura
            // 
            this.labelTemperatura.AutoSize = true;
            this.labelTemperatura.Location = new System.Drawing.Point(12, 50);
            this.labelTemperatura.Name = "labelTemperatura";
            this.labelTemperatura.Size = new System.Drawing.Size(37, 13);
            this.labelTemperatura.TabIndex = 6;
            this.labelTemperatura.Tag = "labelTemperatura";
            this.labelTemperatura.Text = "TEMP";
            // 
            // textTemperatura
            // 
            this.textTemperatura.Location = new System.Drawing.Point(50, 46);
            this.textTemperatura.Name = "textTemperatura";
            this.textTemperatura.ReadOnly = true;
            this.textTemperatura.Size = new System.Drawing.Size(46, 20);
            this.textTemperatura.TabIndex = 7;
            this.textTemperatura.Tag = "textTemperatura";
            // 
            // labelRR
            // 
            this.labelRR.AutoSize = true;
            this.labelRR.Location = new System.Drawing.Point(23, 14);
            this.labelRR.Name = "labelRR";
            this.labelRR.Size = new System.Drawing.Size(23, 13);
            this.labelRR.TabIndex = 8;
            this.labelRR.Tag = "labelRR";
            this.labelRR.Text = "RR";
            // 
            // labelSpO2
            // 
            this.labelSpO2.AutoSize = true;
            this.labelSpO2.Location = new System.Drawing.Point(112, 51);
            this.labelSpO2.Name = "labelSpO2";
            this.labelSpO2.Size = new System.Drawing.Size(34, 13);
            this.labelSpO2.TabIndex = 9;
            this.labelSpO2.Tag = "labelSpO2";
            this.labelSpO2.Text = "SpO2";
            // 
            // textRR
            // 
            this.textRR.Location = new System.Drawing.Point(49, 11);
            this.textRR.Name = "textRR";
            this.textRR.ReadOnly = true;
            this.textRR.Size = new System.Drawing.Size(46, 20);
            this.textRR.TabIndex = 10;
            this.textRR.Tag = "textRR";
            // 
            // textSpO2
            // 
            this.textSpO2.Location = new System.Drawing.Point(152, 46);
            this.textSpO2.Name = "textSpO2";
            this.textSpO2.ReadOnly = true;
            this.textSpO2.Size = new System.Drawing.Size(51, 20);
            this.textSpO2.TabIndex = 11;
            this.textSpO2.Tag = "textSpO2";
            // 
            // labelSistolica
            // 
            this.labelSistolica.AutoSize = true;
            this.labelSistolica.Location = new System.Drawing.Point(219, 50);
            this.labelSistolica.Name = "labelSistolica";
            this.labelSistolica.Size = new System.Drawing.Size(28, 13);
            this.labelSistolica.TabIndex = 12;
            this.labelSistolica.Tag = "labelSistolica";
            this.labelSistolica.Text = "SYS";
            // 
            // textSistolica
            // 
            this.textSistolica.Location = new System.Drawing.Point(253, 46);
            this.textSistolica.Name = "textSistolica";
            this.textSistolica.ReadOnly = true;
            this.textSistolica.Size = new System.Drawing.Size(51, 20);
            this.textSistolica.TabIndex = 13;
            this.textSistolica.Tag = "textSistolica";
            // 
            // labelDiastolica
            // 
            this.labelDiastolica.AutoSize = true;
            this.labelDiastolica.Location = new System.Drawing.Point(222, 15);
            this.labelDiastolica.Name = "labelDiastolica";
            this.labelDiastolica.Size = new System.Drawing.Size(25, 13);
            this.labelDiastolica.TabIndex = 14;
            this.labelDiastolica.Tag = "labelDiastolica";
            this.labelDiastolica.Text = "DIA";
            // 
            // textDiastolica
            // 
            this.textDiastolica.Location = new System.Drawing.Point(253, 14);
            this.textDiastolica.Name = "textDiastolica";
            this.textDiastolica.ReadOnly = true;
            this.textDiastolica.Size = new System.Drawing.Size(51, 20);
            this.textDiastolica.TabIndex = 15;
            this.textDiastolica.Tag = "textDiastolica";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(474, 16);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(93, 32);
            this.buttonStart.TabIndex = 17;
            this.buttonStart.Tag = "buttonStart";
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonShutdown
            // 
            this.buttonShutdown.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonShutdown.Location = new System.Drawing.Point(599, 14);
            this.buttonShutdown.Name = "buttonShutdown";
            this.buttonShutdown.Size = new System.Drawing.Size(88, 37);
            this.buttonShutdown.TabIndex = 18;
            this.buttonShutdown.Tag = "buttonShutdown";
            this.buttonShutdown.Text = "Shutdown";
            this.buttonShutdown.UseVisualStyleBackColor = true;
            this.buttonShutdown.Click += new System.EventHandler(this.buttonShutdown_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(123, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 22;
            this.label10.Tag = "labelDiastolica";
            this.label10.Text = "HR";
            // 
            // textHeartRate
            // 
            this.textHeartRate.Location = new System.Drawing.Point(152, 12);
            this.textHeartRate.Name = "textHeartRate";
            this.textHeartRate.ReadOnly = true;
            this.textHeartRate.Size = new System.Drawing.Size(51, 20);
            this.textHeartRate.TabIndex = 23;
            this.textHeartRate.Tag = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(314, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 24;
            this.label11.Tag = "labelDiastolica";
            this.label11.Text = "MEAN";
            // 
            // textMean_Pressure
            // 
            this.textMean_Pressure.Location = new System.Drawing.Point(358, 31);
            this.textMean_Pressure.Name = "textMean_Pressure";
            this.textMean_Pressure.ReadOnly = true;
            this.textMean_Pressure.Size = new System.Drawing.Size(51, 20);
            this.textMean_Pressure.TabIndex = 25;
            this.textMean_Pressure.Tag = "";
            // 
            // botonAlarma
            // 
            this.botonAlarma.Location = new System.Drawing.Point(474, 79);
            this.botonAlarma.Name = "botonAlarma";
            this.botonAlarma.Size = new System.Drawing.Size(93, 23);
            this.botonAlarma.TabIndex = 26;
            this.botonAlarma.Text = "Alarms";
            this.botonAlarma.UseVisualStyleBackColor = true;
            this.botonAlarma.Click += new System.EventHandler(this.botonAlarma_Click);
            // 
            // Economitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.buttonShutdown;
            this.ClientSize = new System.Drawing.Size(749, 432);
            this.ControlBox = false;
            this.Controls.Add(this.botonAlarma);
            this.Controls.Add(this.textMean_Pressure);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textHeartRate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonShutdown);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textDiastolica);
            this.Controls.Add(this.labelDiastolica);
            this.Controls.Add(this.textSistolica);
            this.Controls.Add(this.labelSistolica);
            this.Controls.Add(this.textSpO2);
            this.Controls.Add(this.textRR);
            this.Controls.Add(this.labelSpO2);
            this.Controls.Add(this.labelRR);
            this.Controls.Add(this.textTemperatura);
            this.Controls.Add(this.labelTemperatura);
            this.Controls.Add(this.spo2);
            this.Controls.Add(this.respiracion);
            this.Controls.Add(this.derivacion1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Economitor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Economitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.derivacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.respiracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart derivacion1;
        private System.Windows.Forms.DataVisualization.Charting.Chart respiracion;
        private System.Windows.Forms.DataVisualization.Charting.Chart spo2;
        private System.Windows.Forms.Label labelTemperatura;
        private System.Windows.Forms.TextBox textTemperatura;
        private System.Windows.Forms.Label labelRR;
        private System.Windows.Forms.Label labelSpO2;
        private System.Windows.Forms.TextBox textRR;
        private System.Windows.Forms.TextBox textSpO2;
        private System.Windows.Forms.Label labelSistolica;
        private System.Windows.Forms.TextBox textSistolica;
        private System.Windows.Forms.Label labelDiastolica;
        private System.Windows.Forms.TextBox textDiastolica;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonShutdown;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textHeartRate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textMean_Pressure;
        private System.Windows.Forms.Button botonAlarma;
    }
}

