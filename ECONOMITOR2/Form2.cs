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
    }
}
