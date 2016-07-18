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

        public Form2()
        {
            InitializeComponent();
            loadLimits();
            loadEnables();

        }
        private void loadEnables()
        {
            onoffHR.Checked = Alarmas.flag_HR_enable;
            onoffRR.Checked = Alarmas.flag_RR_enable;
            onoffSpO2.Checked = Alarmas.flag_SpO2_enable;
            onoffTEMP.Checked = Alarmas.flag_TEMP_enable;

        }
        private void loadLimits()
        {
            textHRbajo.Text = Alarmas.get_high_HR() + "";
            textHRalto.Text = Alarmas.get_low_HR() + "";
            textRRalto.Text = Alarmas.get_high_RR() + "";
            textRRbajo.Text = Alarmas.get_low_RR() + "";
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
            Alarmas.set_high_HR(textHRbajo);
            Alarmas.set_low_HR(textHRalto);
            Alarmas.set_high_RR(textRRalto);
            Alarmas.set_low_RR(textRRbajo);
            Alarmas.set_low_Spo2(textSpO2bajo);
            Alarmas.set_high_temperatura(textTEMPalto);
            Alarmas.set_low_temperatura(textTEMPbajo);

            // Enables
            Alarmas.flag_HR_enable = onoffHR.Checked;
            Alarmas.flag_RR_enable = onoffRR.Checked;
            Alarmas.flag_SpO2_enable = onoffSpO2.Checked;
            Alarmas.flag_TEMP_enable = onoffTEMP.Checked;

            // Cerrar Form
            Close();
        }

        private void buttonDiscardAlarms_Click(object sender, EventArgs e)
        {
            // Cerrar Form
            this.Dispose();
            this.Close();
        }

        private void thresholdsClick(object sender, EventArgs e)
        {

            Form numericPad = new teclado_numerico(((TextBox)sender));
            numericPad.ShowDialog();
            
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
