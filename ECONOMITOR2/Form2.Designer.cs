namespace ECONOMITOR2
{
    partial class Form2
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
            this.onoffRR = new System.Windows.Forms.CheckBox();
            this.textRRalto = new System.Windows.Forms.TextBox();
            this.textRRbajo = new System.Windows.Forms.TextBox();
            this.labelhigh = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.onoffTEMP = new System.Windows.Forms.CheckBox();
            this.textTEMPalto = new System.Windows.Forms.TextBox();
            this.textTEMPbajo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.onoffSpO2 = new System.Windows.Forms.CheckBox();
            this.textSpO2bajo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.onoffHR = new System.Windows.Forms.CheckBox();
            this.textHRbajo = new System.Windows.Forms.TextBox();
            this.textHRalto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.botonOKalarma = new System.Windows.Forms.Button();
            this.buttonDiscardAlarms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // onoffRR
            // 
            this.onoffRR.AutoSize = true;
            this.onoffRR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onoffRR.ForeColor = System.Drawing.Color.DodgerBlue;
            this.onoffRR.Location = new System.Drawing.Point(131, 344);
            this.onoffRR.Name = "onoffRR";
            this.onoffRR.Size = new System.Drawing.Size(112, 28);
            this.onoffRR.TabIndex = 10;
            this.onoffRR.Text = "ON / OFF";
            this.onoffRR.UseVisualStyleBackColor = true;
            // 
            // textRRalto
            // 
            this.textRRalto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.textRRalto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRRalto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRRalto.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textRRalto.Location = new System.Drawing.Point(57, 300);
            this.textRRalto.MaxLength = 4;
            this.textRRalto.Name = "textRRalto";
            this.textRRalto.Size = new System.Drawing.Size(100, 29);
            this.textRRalto.TabIndex = 0;
            this.textRRalto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textRRalto.Click += new System.EventHandler(this.thresholdsClick);
            this.textRRalto.TextChanged += new System.EventHandler(this.thresholdsTextChanged);
            this.textRRalto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thrasholdsKeyPress);
            // 
            // textRRbajo
            // 
            this.textRRbajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.textRRbajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRRbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRRbajo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textRRbajo.Location = new System.Drawing.Point(200, 299);
            this.textRRbajo.MaxLength = 4;
            this.textRRbajo.Name = "textRRbajo";
            this.textRRbajo.Size = new System.Drawing.Size(100, 29);
            this.textRRbajo.TabIndex = 1;
            this.textRRbajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textRRbajo.Click += new System.EventHandler(this.thresholdsClick);
            this.textRRbajo.TextChanged += new System.EventHandler(this.thresholdsTextChanged);
            this.textRRbajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thrasholdsKeyPress);
            // 
            // labelhigh
            // 
            this.labelhigh.AutoSize = true;
            this.labelhigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhigh.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelhigh.Location = new System.Drawing.Point(79, 272);
            this.labelhigh.Name = "labelhigh";
            this.labelhigh.Size = new System.Drawing.Size(50, 24);
            this.labelhigh.TabIndex = 7;
            this.labelhigh.Text = "High";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(233, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Low";
            // 
            // onoffTEMP
            // 
            this.onoffTEMP.AutoSize = true;
            this.onoffTEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onoffTEMP.ForeColor = System.Drawing.Color.Yellow;
            this.onoffTEMP.Location = new System.Drawing.Point(456, 344);
            this.onoffTEMP.Name = "onoffTEMP";
            this.onoffTEMP.Size = new System.Drawing.Size(112, 28);
            this.onoffTEMP.TabIndex = 10;
            this.onoffTEMP.Text = "ON / OFF";
            this.onoffTEMP.UseVisualStyleBackColor = true;
            // 
            // textTEMPalto
            // 
            this.textTEMPalto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.textTEMPalto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTEMPalto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTEMPalto.ForeColor = System.Drawing.Color.Yellow;
            this.textTEMPalto.Location = new System.Drawing.Point(397, 299);
            this.textTEMPalto.MaxLength = 4;
            this.textTEMPalto.Name = "textTEMPalto";
            this.textTEMPalto.Size = new System.Drawing.Size(100, 29);
            this.textTEMPalto.TabIndex = 0;
            this.textTEMPalto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textTEMPalto.Click += new System.EventHandler(this.thresholdsClick);
            this.textTEMPalto.TextChanged += new System.EventHandler(this.thresholdsTextChanged);
            this.textTEMPalto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thrasholdsKeyPress);
            // 
            // textTEMPbajo
            // 
            this.textTEMPbajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.textTEMPbajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTEMPbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTEMPbajo.ForeColor = System.Drawing.Color.Yellow;
            this.textTEMPbajo.Location = new System.Drawing.Point(534, 299);
            this.textTEMPbajo.MaxLength = 4;
            this.textTEMPbajo.Name = "textTEMPbajo";
            this.textTEMPbajo.Size = new System.Drawing.Size(100, 29);
            this.textTEMPbajo.TabIndex = 1;
            this.textTEMPbajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textTEMPbajo.Click += new System.EventHandler(this.thresholdsClick);
            this.textTEMPbajo.TextChanged += new System.EventHandler(this.thresholdsTextChanged);
            this.textTEMPbajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thrasholdsKeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(426, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 24);
            this.label11.TabIndex = 7;
            this.label11.Text = "High";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(560, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 24);
            this.label12.TabIndex = 8;
            this.label12.Text = "Low";
            // 
            // onoffSpO2
            // 
            this.onoffSpO2.AutoSize = true;
            this.onoffSpO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onoffSpO2.ForeColor = System.Drawing.Color.Lime;
            this.onoffSpO2.Location = new System.Drawing.Point(456, 141);
            this.onoffSpO2.Name = "onoffSpO2";
            this.onoffSpO2.Size = new System.Drawing.Size(112, 28);
            this.onoffSpO2.TabIndex = 10;
            this.onoffSpO2.Text = "ON / OFF";
            this.onoffSpO2.UseVisualStyleBackColor = true;
            // 
            // textSpO2bajo
            // 
            this.textSpO2bajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.textSpO2bajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSpO2bajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSpO2bajo.ForeColor = System.Drawing.Color.Lime;
            this.textSpO2bajo.Location = new System.Drawing.Point(456, 97);
            this.textSpO2bajo.MaxLength = 4;
            this.textSpO2bajo.Name = "textSpO2bajo";
            this.textSpO2bajo.Size = new System.Drawing.Size(100, 29);
            this.textSpO2bajo.TabIndex = 0;
            this.textSpO2bajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textSpO2bajo.Click += new System.EventHandler(this.thresholdsClick);
            this.textSpO2bajo.TextChanged += new System.EventHandler(this.thresholdsTextChanged);
            this.textSpO2bajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thrasholdsKeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Lime;
            this.label14.Location = new System.Drawing.Point(484, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 24);
            this.label14.TabIndex = 7;
            this.label14.Text = "Low";
            // 
            // onoffHR
            // 
            this.onoffHR.AutoSize = true;
            this.onoffHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onoffHR.ForeColor = System.Drawing.Color.Red;
            this.onoffHR.Location = new System.Drawing.Point(131, 141);
            this.onoffHR.Name = "onoffHR";
            this.onoffHR.Size = new System.Drawing.Size(112, 28);
            this.onoffHR.TabIndex = 15;
            this.onoffHR.Text = "ON / OFF";
            this.onoffHR.UseVisualStyleBackColor = true;
            // 
            // textHRbajo
            // 
            this.textHRbajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.textHRbajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textHRbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHRbajo.ForeColor = System.Drawing.Color.Red;
            this.textHRbajo.Location = new System.Drawing.Point(57, 97);
            this.textHRbajo.MaxLength = 4;
            this.textHRbajo.Name = "textHRbajo";
            this.textHRbajo.Size = new System.Drawing.Size(100, 29);
            this.textHRbajo.TabIndex = 11;
            this.textHRbajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textHRbajo.Click += new System.EventHandler(this.thresholdsClick);
            this.textHRbajo.TextChanged += new System.EventHandler(this.thresholdsTextChanged);
            this.textHRbajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thrasholdsKeyPress);
            // 
            // textHRalto
            // 
            this.textHRalto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.textHRalto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textHRalto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHRalto.ForeColor = System.Drawing.Color.Red;
            this.textHRalto.Location = new System.Drawing.Point(200, 97);
            this.textHRalto.MaxLength = 4;
            this.textHRalto.Name = "textHRalto";
            this.textHRalto.Size = new System.Drawing.Size(100, 29);
            this.textHRalto.TabIndex = 12;
            this.textHRalto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textHRalto.Click += new System.EventHandler(this.thresholdsClick);
            this.textHRalto.TextChanged += new System.EventHandler(this.thresholdsTextChanged);
            this.textHRalto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thrasholdsKeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(85, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "High";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(233, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Low";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(121, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Heart Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(86, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Respiration Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(468, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "SpO2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(434, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Temperature";
            // 
            // botonOKalarma
            // 
            this.botonOKalarma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.botonOKalarma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonOKalarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonOKalarma.ForeColor = System.Drawing.SystemColors.Control;
            this.botonOKalarma.Location = new System.Drawing.Point(208, 406);
            this.botonOKalarma.Name = "botonOKalarma";
            this.botonOKalarma.Size = new System.Drawing.Size(97, 40);
            this.botonOKalarma.TabIndex = 20;
            this.botonOKalarma.Text = "Save";
            this.botonOKalarma.UseVisualStyleBackColor = false;
            this.botonOKalarma.Click += new System.EventHandler(this.botonOKalarma_Click);
            // 
            // buttonDiscardAlarms
            // 
            this.buttonDiscardAlarms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonDiscardAlarms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDiscardAlarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiscardAlarms.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDiscardAlarms.Location = new System.Drawing.Point(397, 406);
            this.buttonDiscardAlarms.Name = "buttonDiscardAlarms";
            this.buttonDiscardAlarms.Size = new System.Drawing.Size(97, 40);
            this.buttonDiscardAlarms.TabIndex = 21;
            this.buttonDiscardAlarms.Text = "Discard";
            this.buttonDiscardAlarms.UseVisualStyleBackColor = false;
            this.buttonDiscardAlarms.Click += new System.EventHandler(this.buttonDiscardAlarms_Click);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(674, 477);
            this.ControlBox = false;
            this.Controls.Add(this.buttonDiscardAlarms);
            this.Controls.Add(this.botonOKalarma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.onoffHR);
            this.Controls.Add(this.textHRbajo);
            this.Controls.Add(this.textHRalto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.onoffRR);
            this.Controls.Add(this.textRRalto);
            this.Controls.Add(this.onoffSpO2);
            this.Controls.Add(this.textRRbajo);
            this.Controls.Add(this.onoffTEMP);
            this.Controls.Add(this.labelhigh);
            this.Controls.Add(this.textSpO2bajo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textTEMPalto);
            this.Controls.Add(this.textTEMPbajo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox onoffRR;
        private System.Windows.Forms.TextBox textRRalto;
        private System.Windows.Forms.TextBox textRRbajo;
        private System.Windows.Forms.Label labelhigh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox onoffTEMP;
        private System.Windows.Forms.TextBox textTEMPalto;
        private System.Windows.Forms.TextBox textTEMPbajo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox onoffSpO2;
        private System.Windows.Forms.TextBox textSpO2bajo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox onoffHR;
        private System.Windows.Forms.TextBox textHRbajo;
        private System.Windows.Forms.TextBox textHRalto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button botonOKalarma;
        private System.Windows.Forms.Button buttonDiscardAlarms;
    }
}