using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECONOMITOR2
{
    public partial class Form2 : Form
    {
        System.Diagnostics.Process keyboard;

        public Form2()
        {
            InitializeComponent();
            loadLimits();

        }

        private void loadLimits()
        {
            textHRalto.Text = Alarmas.get_high_HR() + "";
            textHRbajo.Text = Alarmas.get_low_HR() + "";
            textRRalto.Text = Alarmas.get_high_RR() + "";
            textRRalto.Text = Alarmas.get_low_RR() + "";
            textSpO2bajo.Text = Alarmas.get_low_Spo2() + "";
            textTEMPalto.Text = Alarmas.get_high_temperatura() + "";
            textTEMPbajo.Text = Alarmas.get_low_temperatura() + "";

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void botonOKalarma_Click(object sender, EventArgs e)
        {
            // Extraer de los textbox los datos y actualizar las alarmas

            // Cerrar Form
            this.Dispose();
            this.Close();
        }

        private void buttonDiscardAlarms_Click(object sender, EventArgs e)
        {
            // Cerrar Form
            this.Dispose();
            this.Close();
        }

        private void thresholdsClick(object sender, EventArgs e)
        {

            if (keyboard == null || keyboard.HasExited)
            {
                keyboard = new System.Diagnostics.Process();
                keyboard = System.Diagnostics.Process.Start("osk.exe");
                
            }
            else
            {
                
                keyboard.Kill();
                keyboard.Dispose();
                
                keyboard.Start();
                ((TextBox)sender).Focus();
            }
            //((TextBox)sender).Focus();
            //keyboard.Kill();
        }

        private void thrasholdsKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.'){
                e.Handled = true;
            }
        }

        private void thresholdsTextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(((TextBox)sender).Text, " ^ [0-9]")||
                System.Text.RegularExpressions.Regex.IsMatch(((TextBox)sender).Text, "(\\.){2,}")||
                System.Text.RegularExpressions.Regex.IsMatch(((TextBox)sender).Text, "([0-9]\\.){2,}"))
            {
                ((TextBox)sender).Text = "";
            }
        }
    }
}
