using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ECONOMITOR2
{
    public partial class Economitor : Form
    {
        private SerialPort myport;
        public Economitor()
        {
            InitializeComponent();
        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
            
        }

        private void labelTaquicardia_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void buttonShutdown_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void labelBradicardia_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click_1(object sender, EventArgs e)
        {
            this.textTemperatura.Text = "100";
        }

        private void buttonShutdown_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

    }
}
