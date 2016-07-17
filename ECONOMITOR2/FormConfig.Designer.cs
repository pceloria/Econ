namespace ECONOMITOR2
{
    partial class FormConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ECG = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_ECGwave = new System.Windows.Forms.CheckBox();
            this.checkBox_HR_RR = new System.Windows.Forms.CheckBox();
            this.checkBox_SpO2 = new System.Windows.Forms.CheckBox();
            this.checkBox_TEMP = new System.Windows.Forms.CheckBox();
            this.checkBox_SpO2wave = new System.Windows.Forms.CheckBox();
            this.checkBox_RESPwave = new System.Windows.Forms.CheckBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDiscardAlarms = new System.Windows.Forms.Button();
            this.botonSaveConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "x 0.25",
            "x 0.5",
            "x 1",
            "x 2"});
            this.comboBox1.Location = new System.Drawing.Point(224, 237);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(70, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ECG
            // 
            this.ECG.AutoSize = true;
            this.ECG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ECG.ForeColor = System.Drawing.Color.Red;
            this.ECG.Location = new System.Drawing.Point(129, 227);
            this.ECG.Name = "ECG";
            this.ECG.Size = new System.Drawing.Size(73, 31);
            this.ECG.TabIndex = 4;
            this.ECG.Text = "ECG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(129, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "RESP";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "x 0.25",
            "x 0.5",
            "x 1",
            "x 2"});
            this.comboBox2.Location = new System.Drawing.Point(223, 275);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(71, 28);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(238, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "ENABLE/DISABLE";
            // 
            // checkBox_ECGwave
            // 
            this.checkBox_ECGwave.AutoSize = true;
            this.checkBox_ECGwave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox_ECGwave.Checked = true;
            this.checkBox_ECGwave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ECGwave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ECGwave.ForeColor = System.Drawing.Color.Red;
            this.checkBox_ECGwave.Location = new System.Drawing.Point(117, 70);
            this.checkBox_ECGwave.Name = "checkBox_ECGwave";
            this.checkBox_ECGwave.Size = new System.Drawing.Size(145, 33);
            this.checkBox_ECGwave.TabIndex = 10;
            this.checkBox_ECGwave.Text = "ECG wave";
            this.checkBox_ECGwave.UseVisualStyleBackColor = false;
            this.checkBox_ECGwave.CheckedChanged += new System.EventHandler(this.checkBox_ECGwave_CheckedChanged);
            // 
            // checkBox_HR_RR
            // 
            this.checkBox_HR_RR.AutoSize = true;
            this.checkBox_HR_RR.Checked = true;
            this.checkBox_HR_RR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_HR_RR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_HR_RR.ForeColor = System.Drawing.Color.Red;
            this.checkBox_HR_RR.Location = new System.Drawing.Point(338, 74);
            this.checkBox_HR_RR.Name = "checkBox_HR_RR";
            this.checkBox_HR_RR.Size = new System.Drawing.Size(146, 33);
            this.checkBox_HR_RR.TabIndex = 11;
            this.checkBox_HR_RR.Text = "Heart Rate";
            this.checkBox_HR_RR.UseVisualStyleBackColor = true;
            this.checkBox_HR_RR.CheckedChanged += new System.EventHandler(this.checkBox_HR__RR_CheckedChanged);
            // 
            // checkBox_SpO2
            // 
            this.checkBox_SpO2.AutoSize = true;
            this.checkBox_SpO2.Checked = true;
            this.checkBox_SpO2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_SpO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_SpO2.ForeColor = System.Drawing.Color.Lime;
            this.checkBox_SpO2.Location = new System.Drawing.Point(338, 110);
            this.checkBox_SpO2.Name = "checkBox_SpO2";
            this.checkBox_SpO2.Size = new System.Drawing.Size(100, 33);
            this.checkBox_SpO2.TabIndex = 13;
            this.checkBox_SpO2.Text = "SpO2 ";
            this.checkBox_SpO2.UseVisualStyleBackColor = true;
            this.checkBox_SpO2.CheckedChanged += new System.EventHandler(this.checkBox_SpO2_CheckedChanged);
            // 
            // checkBox_TEMP
            // 
            this.checkBox_TEMP.AutoSize = true;
            this.checkBox_TEMP.Checked = true;
            this.checkBox_TEMP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_TEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_TEMP.ForeColor = System.Drawing.Color.Yellow;
            this.checkBox_TEMP.Location = new System.Drawing.Point(338, 151);
            this.checkBox_TEMP.Name = "checkBox_TEMP";
            this.checkBox_TEMP.Size = new System.Drawing.Size(172, 33);
            this.checkBox_TEMP.TabIndex = 14;
            this.checkBox_TEMP.Text = "Temperature";
            this.checkBox_TEMP.UseVisualStyleBackColor = true;
            this.checkBox_TEMP.CheckedChanged += new System.EventHandler(this.checkBox_TEMP_CheckedChanged);
            // 
            // checkBox_SpO2wave
            // 
            this.checkBox_SpO2wave.AutoSize = true;
            this.checkBox_SpO2wave.Checked = true;
            this.checkBox_SpO2wave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_SpO2wave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_SpO2wave.ForeColor = System.Drawing.Color.Lime;
            this.checkBox_SpO2wave.Location = new System.Drawing.Point(117, 151);
            this.checkBox_SpO2wave.Name = "checkBox_SpO2wave";
            this.checkBox_SpO2wave.Size = new System.Drawing.Size(156, 33);
            this.checkBox_SpO2wave.TabIndex = 15;
            this.checkBox_SpO2wave.Text = "SpO2 wave";
            this.checkBox_SpO2wave.UseVisualStyleBackColor = true;
            this.checkBox_SpO2wave.CheckedChanged += new System.EventHandler(this.checkBox_SpO2wave_CheckedChanged);
            // 
            // checkBox_RESPwave
            // 
            this.checkBox_RESPwave.AutoSize = true;
            this.checkBox_RESPwave.Checked = true;
            this.checkBox_RESPwave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RESPwave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_RESPwave.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox_RESPwave.Location = new System.Drawing.Point(117, 110);
            this.checkBox_RESPwave.Name = "checkBox_RESPwave";
            this.checkBox_RESPwave.Size = new System.Drawing.Size(159, 33);
            this.checkBox_RESPwave.TabIndex = 16;
            this.checkBox_RESPwave.Text = "RESP wave";
            this.checkBox_RESPwave.UseVisualStyleBackColor = true;
            this.checkBox_RESPwave.CheckedChanged += new System.EventHandler(this.checkBox_RESPwave_CheckedChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox4.Items.AddRange(new object[] {
            "OPERATION",
            "MONITOR",
            "DIAGNOSE"});
            this.comboBox4.Location = new System.Drawing.Point(316, 237);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(114, 28);
            this.comboBox4.TabIndex = 17;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(221, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "GAIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(333, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "MODE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(491, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Respiratory Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(478, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "/";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "x 0.25",
            "x 0.5",
            "x 1",
            "x 2"});
            this.comboBox3.Location = new System.Drawing.Point(223, 341);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(70, 28);
            this.comboBox3.TabIndex = 26;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ECONOMITOR2.Properties.Resources.buttonSilenciar_BackgroundImage;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(135, 331);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDiscardAlarms
            // 
            this.buttonDiscardAlarms.BackgroundImage = global::ECONOMITOR2.Properties.Resources.buttonShutdown_BackgroundImage;
            this.buttonDiscardAlarms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDiscardAlarms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDiscardAlarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiscardAlarms.ForeColor = System.Drawing.Color.Black;
            this.buttonDiscardAlarms.Location = new System.Drawing.Point(627, 341);
            this.buttonDiscardAlarms.Name = "buttonDiscardAlarms";
            this.buttonDiscardAlarms.Size = new System.Drawing.Size(47, 31);
            this.buttonDiscardAlarms.TabIndex = 22;
            this.buttonDiscardAlarms.UseVisualStyleBackColor = false;
            this.buttonDiscardAlarms.Click += new System.EventHandler(this.buttonDiscardAlarms_Click);
            // 
            // botonSaveConfig
            // 
            this.botonSaveConfig.BackColor = System.Drawing.Color.Black;
            this.botonSaveConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonSaveConfig.BackgroundImage")));
            this.botonSaveConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonSaveConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSaveConfig.ForeColor = System.Drawing.Color.Black;
            this.botonSaveConfig.Location = new System.Drawing.Point(518, 341);
            this.botonSaveConfig.Name = "botonSaveConfig";
            this.botonSaveConfig.Size = new System.Drawing.Size(47, 31);
            this.botonSaveConfig.TabIndex = 21;
            this.botonSaveConfig.UseVisualStyleBackColor = false;
            this.botonSaveConfig.Click += new System.EventHandler(this.botonSaveConfig_Click);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(749, 410);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDiscardAlarms);
            this.Controls.Add(this.botonSaveConfig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.checkBox_RESPwave);
            this.Controls.Add(this.checkBox_SpO2wave);
            this.Controls.Add(this.checkBox_TEMP);
            this.Controls.Add(this.checkBox_SpO2);
            this.Controls.Add(this.checkBox_HR_RR);
            this.Controls.Add(this.checkBox_ECGwave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ECG);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Name = "FormConfig";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ECG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_ECGwave;
        private System.Windows.Forms.CheckBox checkBox_HR_RR;
        private System.Windows.Forms.CheckBox checkBox_SpO2;
        private System.Windows.Forms.CheckBox checkBox_TEMP;
        private System.Windows.Forms.CheckBox checkBox_SpO2wave;
        private System.Windows.Forms.CheckBox checkBox_RESPwave;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botonSaveConfig;
        private System.Windows.Forms.Button buttonDiscardAlarms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}