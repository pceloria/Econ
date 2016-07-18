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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Economitor));
            this.derivacion1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.respiracion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.spo2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTemperatura = new System.Windows.Forms.Label();
            this.textTemperatura = new System.Windows.Forms.TextBox();
            this.labelRR = new System.Windows.Forms.Label();
            this.labelSpO2 = new System.Windows.Forms.Label();
            this.textRR = new System.Windows.Forms.TextBox();
            this.textSpO2 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.textHeartRate = new System.Windows.Forms.TextBox();
            this.buttonShutdown = new System.Windows.Forms.Button();
            this.buttonConfiguration = new System.Windows.Forms.Button();
            this.buttonSilenciar = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonAlarma = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.exclamationMark = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.derivacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.respiracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exclamationMark)).BeginInit();
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
            chartArea10.AxisY.IsLabelAutoFit = false;
            chartArea10.AxisY.Maximum = 6D;
            chartArea10.AxisY.Minimum = -6D;
            chartArea10.BackColor = System.Drawing.Color.Black;
            chartArea10.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            chartArea10.Name = "ChartArea1";
            this.derivacion1.ChartAreas.Add(chartArea10);
            this.derivacion1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend10.Enabled = false;
            legend10.Name = "Legend1";
            this.derivacion1.Legends.Add(legend10);
            this.derivacion1.Location = new System.Drawing.Point(0, 108);
            this.derivacion1.Name = "derivacion1";
            series10.BackImageTransparentColor = System.Drawing.Color.Black;
            series10.BackSecondaryColor = System.Drawing.Color.Black;
            series10.BorderColor = System.Drawing.Color.Black;
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series10.Color = System.Drawing.Color.Red;
            series10.LabelBackColor = System.Drawing.Color.White;
            series10.LabelBorderColor = System.Drawing.Color.White;
            series10.Legend = "Legend1";
            series10.MarkerBorderColor = System.Drawing.Color.White;
            series10.Name = "Series1";
            this.derivacion1.Series.Add(series10);
            this.derivacion1.Size = new System.Drawing.Size(749, 108);
            this.derivacion1.TabIndex = 0;
            this.derivacion1.TabStop = false;
            this.derivacion1.Tag = "derivacion1";
            this.derivacion1.Text = "chart1";
            title10.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            title10.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            title10.DockingOffset = 30;
            title10.ForeColor = System.Drawing.Color.White;
            title10.Name = "DI";
            title10.Text = "DI";
            this.derivacion1.Titles.Add(title10);
            // 
            // respiracion
            // 
            this.respiracion.BackColor = System.Drawing.Color.Black;
            chartArea11.AxisX.MajorGrid.Enabled = false;
            chartArea11.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea11.AxisY.Maximum = 250D;
            chartArea11.AxisY.Minimum = -50D;
            chartArea11.BackColor = System.Drawing.Color.Black;
            chartArea11.Name = "ChartArea1";
            this.respiracion.ChartAreas.Add(chartArea11);
            this.respiracion.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend11.Enabled = false;
            legend11.Name = "Legend1";
            this.respiracion.Legends.Add(legend11);
            this.respiracion.Location = new System.Drawing.Point(0, 216);
            this.respiracion.Name = "respiracion";
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.respiracion.Series.Add(series11);
            this.respiracion.Size = new System.Drawing.Size(749, 108);
            this.respiracion.TabIndex = 3;
            this.respiracion.Text = "chart4";
            title11.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            title11.DockingOffset = 30;
            title11.ForeColor = System.Drawing.Color.White;
            title11.Name = "Title1";
            title11.Text = "RESP";
            this.respiracion.Titles.Add(title11);
            // 
            // spo2
            // 
            this.spo2.BackColor = System.Drawing.Color.Black;
            chartArea12.AxisY.Maximum = 100D;
            chartArea12.AxisY.Minimum = 0D;
            chartArea12.BackColor = System.Drawing.Color.Black;
            chartArea12.Name = "ChartArea1";
            this.spo2.ChartAreas.Add(chartArea12);
            this.spo2.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend12.Enabled = false;
            legend12.Name = "Legend1";
            this.spo2.Legends.Add(legend12);
            this.spo2.Location = new System.Drawing.Point(0, 324);
            this.spo2.Name = "spo2";
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series12.Color = System.Drawing.Color.Lime;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.spo2.Series.Add(series12);
            this.spo2.Size = new System.Drawing.Size(749, 108);
            this.spo2.TabIndex = 4;
            this.spo2.Text = "chart5";
            title12.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title12.DockingOffset = 30;
            title12.ForeColor = System.Drawing.Color.White;
            title12.Name = "Title1";
            title12.Text = "SpO2";
            this.spo2.Titles.Add(title12);
            // 
            // labelTemperatura
            // 
            this.labelTemperatura.AutoSize = true;
            this.labelTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperatura.ForeColor = System.Drawing.Color.Yellow;
            this.labelTemperatura.Location = new System.Drawing.Point(134, 28);
            this.labelTemperatura.Name = "labelTemperatura";
            this.labelTemperatura.Size = new System.Drawing.Size(52, 20);
            this.labelTemperatura.TabIndex = 6;
            this.labelTemperatura.Tag = "labelTemperatura";
            this.labelTemperatura.Text = "TEMP";
            // 
            // textTemperatura
            // 
            this.textTemperatura.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textTemperatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTemperatura.ForeColor = System.Drawing.Color.Yellow;
            this.textTemperatura.Location = new System.Drawing.Point(209, 11);
            this.textTemperatura.Name = "textTemperatura";
            this.textTemperatura.ReadOnly = true;
            this.textTemperatura.Size = new System.Drawing.Size(57, 55);
            this.textTemperatura.TabIndex = 7;
            this.textTemperatura.Tag = "textTemperatura";
            this.textTemperatura.Text = "-";
            this.textTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRR
            // 
            this.labelRR.AutoSize = true;
            this.labelRR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRR.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelRR.Location = new System.Drawing.Point(12, 26);
            this.labelRR.Name = "labelRR";
            this.labelRR.Size = new System.Drawing.Size(33, 20);
            this.labelRR.TabIndex = 8;
            this.labelRR.Tag = "labelRR";
            this.labelRR.Text = "RR";
            // 
            // labelSpO2
            // 
            this.labelSpO2.AutoSize = true;
            this.labelSpO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpO2.ForeColor = System.Drawing.Color.Lime;
            this.labelSpO2.Location = new System.Drawing.Point(136, 73);
            this.labelSpO2.Name = "labelSpO2";
            this.labelSpO2.Size = new System.Drawing.Size(50, 20);
            this.labelSpO2.TabIndex = 9;
            this.labelSpO2.Tag = "labelSpO2";
            this.labelSpO2.Text = "SpO2";
            // 
            // textRR
            // 
            this.textRR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textRR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRR.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRR.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textRR.Location = new System.Drawing.Point(56, 11);
            this.textRR.Name = "textRR";
            this.textRR.ReadOnly = true;
            this.textRR.Size = new System.Drawing.Size(57, 55);
            this.textRR.TabIndex = 10;
            this.textRR.Tag = "textRR";
            this.textRR.Text = "-";
            this.textRR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSpO2
            // 
            this.textSpO2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textSpO2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSpO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSpO2.ForeColor = System.Drawing.Color.Lime;
            this.textSpO2.Location = new System.Drawing.Point(209, 57);
            this.textSpO2.Name = "textSpO2";
            this.textSpO2.ReadOnly = true;
            this.textSpO2.Size = new System.Drawing.Size(57, 55);
            this.textSpO2.TabIndex = 11;
            this.textSpO2.Tag = "textSpO2";
            this.textSpO2.Text = "-";
            this.textSpO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(12, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 20);
            this.label10.TabIndex = 22;
            this.label10.Tag = "labelDiastolica";
            this.label10.Text = "HR";
            // 
            // textHeartRate
            // 
            this.textHeartRate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textHeartRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textHeartRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHeartRate.ForeColor = System.Drawing.Color.Red;
            this.textHeartRate.Location = new System.Drawing.Point(56, 57);
            this.textHeartRate.Name = "textHeartRate";
            this.textHeartRate.ReadOnly = true;
            this.textHeartRate.Size = new System.Drawing.Size(57, 55);
            this.textHeartRate.TabIndex = 23;
            this.textHeartRate.Tag = "";
            this.textHeartRate.Text = "-";
            this.textHeartRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonShutdown
            // 
            this.buttonShutdown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonShutdown.BackgroundImage")));
            this.buttonShutdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonShutdown.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShutdown.Location = new System.Drawing.Point(698, 13);
            this.buttonShutdown.Name = "buttonShutdown";
            this.buttonShutdown.Size = new System.Drawing.Size(39, 35);
            this.buttonShutdown.TabIndex = 18;
            this.buttonShutdown.Tag = "buttonShutdown";
            this.buttonShutdown.UseVisualStyleBackColor = true;
            this.buttonShutdown.Click += new System.EventHandler(this.buttonShutdown_Click);
            // 
            // buttonConfiguration
            // 
            this.buttonConfiguration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConfiguration.BackgroundImage")));
            this.buttonConfiguration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfiguration.Location = new System.Drawing.Point(609, 61);
            this.buttonConfiguration.Name = "buttonConfiguration";
            this.buttonConfiguration.Size = new System.Drawing.Size(39, 35);
            this.buttonConfiguration.TabIndex = 30;
            this.buttonConfiguration.UseVisualStyleBackColor = true;
            this.buttonConfiguration.Click += new System.EventHandler(this.buttonConfiguration_Click);
            // 
            // buttonSilenciar
            // 
            this.buttonSilenciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSilenciar.BackgroundImage")));
            this.buttonSilenciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSilenciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSilenciar.Location = new System.Drawing.Point(423, 28);
            this.buttonSilenciar.Name = "buttonSilenciar";
            this.buttonSilenciar.Size = new System.Drawing.Size(67, 65);
            this.buttonSilenciar.TabIndex = 28;
            this.buttonSilenciar.UseVisualStyleBackColor = true;
            this.buttonSilenciar.Click += new System.EventHandler(this.buttonSilenciar_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPause.BackgroundImage")));
            this.buttonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPause.ForeColor = System.Drawing.Color.White;
            this.buttonPause.Location = new System.Drawing.Point(610, 13);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(39, 35);
            this.buttonPause.TabIndex = 27;
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonAlarma
            // 
            this.buttonAlarma.BackColor = System.Drawing.Color.Black;
            this.buttonAlarma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAlarma.BackgroundImage")));
            this.buttonAlarma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAlarma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAlarma.Location = new System.Drawing.Point(565, 61);
            this.buttonAlarma.Name = "buttonAlarma";
            this.buttonAlarma.Size = new System.Drawing.Size(39, 35);
            this.buttonAlarma.TabIndex = 26;
            this.buttonAlarma.UseVisualStyleBackColor = false;
            this.buttonAlarma.Click += new System.EventHandler(this.botonAlarma_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Black;
            this.buttonStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStart.BackgroundImage")));
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(565, 13);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(39, 35);
            this.buttonStart.TabIndex = 17;
            this.buttonStart.Tag = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // exclamationMark
            // 
            this.exclamationMark.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exclamationMark.BackgroundImage")));
            this.exclamationMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exclamationMark.Location = new System.Drawing.Point(320, 20);
            this.exclamationMark.Name = "exclamationMark";
            this.exclamationMark.Size = new System.Drawing.Size(97, 76);
            this.exclamationMark.TabIndex = 31;
            this.exclamationMark.TabStop = false;
            this.exclamationMark.Visible = false;
            // 
            // Economitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.buttonShutdown;
            this.ClientSize = new System.Drawing.Size(749, 432);
            this.ControlBox = false;
            this.Controls.Add(this.exclamationMark);
            this.Controls.Add(this.buttonConfiguration);
            this.Controls.Add(this.derivacion1);
            this.Controls.Add(this.respiracion);
            this.Controls.Add(this.buttonSilenciar);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonAlarma);
            this.Controls.Add(this.textHeartRate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonShutdown);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textSpO2);
            this.Controls.Add(this.textRR);
            this.Controls.Add(this.labelSpO2);
            this.Controls.Add(this.labelRR);
            this.Controls.Add(this.textTemperatura);
            this.Controls.Add(this.labelTemperatura);
            this.Controls.Add(this.spo2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Economitor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Economitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.derivacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.respiracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exclamationMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart derivacion1;
        private System.Windows.Forms.DataVisualization.Charting.Chart respiracion;
        private System.Windows.Forms.Label labelTemperatura;
        private System.Windows.Forms.TextBox textTemperatura;
        private System.Windows.Forms.Label labelRR;
        private System.Windows.Forms.Label labelSpO2;
        private System.Windows.Forms.TextBox textRR;
        private System.Windows.Forms.TextBox textSpO2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonShutdown;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textHeartRate;
        private System.Windows.Forms.Button buttonAlarma;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.DataVisualization.Charting.Chart spo2;
        private System.Windows.Forms.Button buttonSilenciar;
        private System.Windows.Forms.Button buttonConfiguration;
        private System.Windows.Forms.PictureBox exclamationMark;
    }
}

