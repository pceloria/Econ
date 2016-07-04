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
            this.groupAlarmas = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textTEMPbajo = new System.Windows.Forms.TextBox();
            this.textTEMPalto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textNIBPbajo = new System.Windows.Forms.TextBox();
            this.textNIBPalto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textSpO2bajo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textRRalto = new System.Windows.Forms.TextBox();
            this.textRRbajo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textHRalto = new System.Windows.Forms.TextBox();
            this.textHRbajo = new System.Windows.Forms.TextBox();
            this.labelTaquicardia = new System.Windows.Forms.Label();
            this.labelBradicardia = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonShutdown = new System.Windows.Forms.Button();
            this.buttonSilenciar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.textHeartRate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textMean_Pressure = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.derivacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.respiracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spo2)).BeginInit();
            this.groupAlarmas.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // derivacion1
            // 
            this.derivacion1.BorderSkin.BackSecondaryColor = System.Drawing.Color.Yellow;
            this.derivacion1.BorderSkin.PageColor = System.Drawing.Color.DarkGray;
            chartArea4.Name = "ChartArea1";
            this.derivacion1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.derivacion1.Legends.Add(legend4);
            this.derivacion1.Location = new System.Drawing.Point(1, 96);
            this.derivacion1.Name = "derivacion1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.derivacion1.Series.Add(series4);
            this.derivacion1.Size = new System.Drawing.Size(536, 138);
            this.derivacion1.TabIndex = 0;
            this.derivacion1.Tag = "derivacion1";
            this.derivacion1.Text = "chart1";
            // 
            // respiracion
            // 
            chartArea5.Name = "ChartArea1";
            this.respiracion.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.respiracion.Legends.Add(legend5);
            this.respiracion.Location = new System.Drawing.Point(1, 239);
            this.respiracion.Name = "respiracion";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.respiracion.Series.Add(series5);
            this.respiracion.Size = new System.Drawing.Size(536, 138);
            this.respiracion.TabIndex = 3;
            this.respiracion.Text = "chart4";
            // 
            // spo2
            // 
            chartArea6.Name = "ChartArea1";
            this.spo2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.spo2.Legends.Add(legend6);
            this.spo2.Location = new System.Drawing.Point(1, 382);
            this.spo2.Name = "spo2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.spo2.Series.Add(series6);
            this.spo2.Size = new System.Drawing.Size(536, 138);
            this.spo2.TabIndex = 4;
            this.spo2.Text = "chart5";
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
            this.textRR.Size = new System.Drawing.Size(46, 20);
            this.textRR.TabIndex = 10;
            this.textRR.Tag = "textRR";
            // 
            // textSpO2
            // 
            this.textSpO2.Location = new System.Drawing.Point(152, 46);
            this.textSpO2.Name = "textSpO2";
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
            this.textDiastolica.Location = new System.Drawing.Point(253, 8);
            this.textDiastolica.Name = "textDiastolica";
            this.textDiastolica.Size = new System.Drawing.Size(51, 20);
            this.textDiastolica.TabIndex = 15;
            this.textDiastolica.Tag = "textDiastolica";
            // 
            // groupAlarmas
            // 
            this.groupAlarmas.Controls.Add(this.groupBox5);
            this.groupAlarmas.Controls.Add(this.groupBox4);
            this.groupAlarmas.Controls.Add(this.groupBox3);
            this.groupAlarmas.Controls.Add(this.groupBox2);
            this.groupAlarmas.Controls.Add(this.groupBox1);
            this.groupAlarmas.Controls.Add(this.buttonSilenciar);
            this.groupAlarmas.Location = new System.Drawing.Point(543, 63);
            this.groupAlarmas.Name = "groupAlarmas";
            this.groupAlarmas.Size = new System.Drawing.Size(175, 457);
            this.groupAlarmas.TabIndex = 16;
            this.groupAlarmas.TabStop = false;
            this.groupAlarmas.Tag = "groupAlarmas";
            this.groupAlarmas.Text = "Alarmas";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textTEMPbajo);
            this.groupBox5.Controls.Add(this.textTEMPalto);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(23, 309);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(151, 66);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TEMP";
            // 
            // textTEMPbajo
            // 
            this.textTEMPbajo.Location = new System.Drawing.Point(8, 40);
            this.textTEMPbajo.Name = "textTEMPbajo";
            this.textTEMPbajo.Size = new System.Drawing.Size(39, 20);
            this.textTEMPbajo.TabIndex = 9;
            this.textTEMPbajo.Tag = "textTEMPbajo";
            this.textTEMPbajo.TextChanged += new System.EventHandler(this.textTEMPbajo_TextChanged);
            // 
            // textTEMPalto
            // 
            this.textTEMPalto.Location = new System.Drawing.Point(72, 40);
            this.textTEMPalto.Name = "textTEMPalto";
            this.textTEMPalto.Size = new System.Drawing.Size(39, 20);
            this.textTEMPalto.TabIndex = 4;
            this.textTEMPalto.Tag = "textTEMPalto";
            this.textTEMPalto.TextChanged += new System.EventHandler(this.textTEMPalto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "High";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Low";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textNIBPbajo);
            this.groupBox4.Controls.Add(this.textNIBPalto);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(20, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(155, 63);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "NIBP";
            // 
            // textNIBPbajo
            // 
            this.textNIBPbajo.Location = new System.Drawing.Point(8, 36);
            this.textNIBPbajo.Name = "textNIBPbajo";
            this.textNIBPbajo.Size = new System.Drawing.Size(39, 20);
            this.textNIBPbajo.TabIndex = 10;
            this.textNIBPbajo.Tag = "textNIBPbajo";
            this.textNIBPbajo.TextChanged += new System.EventHandler(this.textNIBPbajo_TextChanged);
            // 
            // textNIBPalto
            // 
            this.textNIBPalto.Location = new System.Drawing.Point(72, 37);
            this.textNIBPalto.Name = "textNIBPalto";
            this.textNIBPalto.Size = new System.Drawing.Size(39, 20);
            this.textNIBPalto.TabIndex = 5;
            this.textNIBPalto.Tag = "textNIBPalto";
            this.textNIBPalto.TextChanged += new System.EventHandler(this.textNIBPalto_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "High";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Low";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textSpO2bajo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(19, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(156, 64);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sp02";
            // 
            // textSpO2bajo
            // 
            this.textSpO2bajo.Location = new System.Drawing.Point(6, 38);
            this.textSpO2bajo.Name = "textSpO2bajo";
            this.textSpO2bajo.Size = new System.Drawing.Size(39, 20);
            this.textSpO2bajo.TabIndex = 11;
            this.textSpO2bajo.Tag = "textSpO2bajo";
            this.textSpO2bajo.TextChanged += new System.EventHandler(this.textSpO2bajo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Low";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textRRalto);
            this.groupBox2.Controls.Add(this.textRRbajo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(18, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 62);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RR";
            // 
            // textRRalto
            // 
            this.textRRalto.Location = new System.Drawing.Point(74, 36);
            this.textRRalto.Name = "textRRalto";
            this.textRRalto.Size = new System.Drawing.Size(39, 20);
            this.textRRalto.TabIndex = 7;
            this.textRRalto.Tag = "textRRalto";
            this.textRRalto.TextChanged += new System.EventHandler(this.textRRalto_TextChanged);
            // 
            // textRRbajo
            // 
            this.textRRbajo.Location = new System.Drawing.Point(6, 32);
            this.textRRbajo.Name = "textRRbajo";
            this.textRRbajo.Size = new System.Drawing.Size(39, 20);
            this.textRRbajo.TabIndex = 12;
            this.textRRbajo.Tag = "textRRbajo";
            this.textRRbajo.TextChanged += new System.EventHandler(this.textRRbajo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "High";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Low";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textHRalto);
            this.groupBox1.Controls.Add(this.textHRbajo);
            this.groupBox1.Controls.Add(this.labelTaquicardia);
            this.groupBox1.Controls.Add(this.labelBradicardia);
            this.groupBox1.Location = new System.Drawing.Point(21, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 67);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HR";
            // 
            // textHRalto
            // 
            this.textHRalto.Location = new System.Drawing.Point(71, 32);
            this.textHRalto.Name = "textHRalto";
            this.textHRalto.Size = new System.Drawing.Size(39, 20);
            this.textHRalto.TabIndex = 3;
            this.textHRalto.Tag = "textHRalto";
            this.textHRalto.TextChanged += new System.EventHandler(this.textHRalto_TextChanged);
            // 
            // textHRbajo
            // 
            this.textHRbajo.BackColor = System.Drawing.Color.White;
            this.textHRbajo.Location = new System.Drawing.Point(7, 32);
            this.textHRbajo.Name = "textHRbajo";
            this.textHRbajo.Size = new System.Drawing.Size(39, 20);
            this.textHRbajo.TabIndex = 2;
            this.textHRbajo.Tag = "textHRbajo";
            this.textHRbajo.TextChanged += new System.EventHandler(this.textHRbajo_TextChanged);
            // 
            // labelTaquicardia
            // 
            this.labelTaquicardia.AutoSize = true;
            this.labelTaquicardia.Location = new System.Drawing.Point(75, 16);
            this.labelTaquicardia.Name = "labelTaquicardia";
            this.labelTaquicardia.Size = new System.Drawing.Size(29, 13);
            this.labelTaquicardia.TabIndex = 1;
            this.labelTaquicardia.Tag = "labelTaquicardia";
            this.labelTaquicardia.Text = "High";
            // 
            // labelBradicardia
            // 
            this.labelBradicardia.AutoSize = true;
            this.labelBradicardia.Location = new System.Drawing.Point(6, 16);
            this.labelBradicardia.Name = "labelBradicardia";
            this.labelBradicardia.Size = new System.Drawing.Size(27, 13);
            this.labelBradicardia.TabIndex = 0;
            this.labelBradicardia.Tag = "labelBradicardia";
            this.labelBradicardia.Text = "Low";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(441, 41);
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
            // buttonSilenciar
            // 
            this.buttonSilenciar.Location = new System.Drawing.Point(35, 394);
            this.buttonSilenciar.Name = "buttonSilenciar";
            this.buttonSilenciar.Size = new System.Drawing.Size(123, 33);
            this.buttonSilenciar.TabIndex = 19;
            this.buttonSilenciar.Tag = "buttonSilenciar";
            this.buttonSilenciar.Text = "Silence";
            this.buttonSilenciar.UseVisualStyleBackColor = true;
            this.buttonSilenciar.Click += new System.EventHandler(this.buttonSilenciar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(438, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 20;
            this.label9.Tag = "labelDiastolica";
            this.label9.Text = "PORT";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(481, 11);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(37, 20);
            this.textPort.TabIndex = 21;
            this.textPort.Tag = "textPort";
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
            this.textMean_Pressure.Size = new System.Drawing.Size(51, 20);
            this.textMean_Pressure.TabIndex = 25;
            this.textMean_Pressure.Tag = "";
            // 
            // Economitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.buttonShutdown;
            this.ClientSize = new System.Drawing.Size(733, 523);
            this.ControlBox = false;
            this.Controls.Add(this.textMean_Pressure);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textHeartRate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonShutdown);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupAlarmas);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Economitor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Economitor";
            ((System.ComponentModel.ISupportInitialize)(this.derivacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.respiracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spo2)).EndInit();
            this.groupAlarmas.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupAlarmas;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTaquicardia;
        private System.Windows.Forms.Label labelBradicardia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonShutdown;
        private System.Windows.Forms.Button buttonSilenciar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox textTEMPbajo;
        private System.Windows.Forms.TextBox textTEMPalto;
        private System.Windows.Forms.TextBox textNIBPbajo;
        private System.Windows.Forms.TextBox textNIBPalto;
        private System.Windows.Forms.TextBox textSpO2bajo;
        private System.Windows.Forms.TextBox textRRalto;
        private System.Windows.Forms.TextBox textRRbajo;
        private System.Windows.Forms.TextBox textHRalto;
        private System.Windows.Forms.TextBox textHRbajo;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textHeartRate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textMean_Pressure;
    }
}

