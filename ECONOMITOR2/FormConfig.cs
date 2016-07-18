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

    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        public void LoadStates()
        {
            //checkBox_ECGwave = 
              //  checkBox_HR_RR

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormConfig_Load(object sender, EventArgs e)
        {

        }

        private void buttonDiscardAlarms_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonSaveConfig_Click(object sender, EventArgs e)
        {
            if (checkBox_ECGwave.Checked)
            {
                Acqsign.enableECGwave(true);
            }
            else {
                Acqsign.enableECGwave(false);
            }

            if (checkBox_RESPwave.Checked)
            {
                Acqsign.enableRESPwave(true);
            }
            else
            {
                Acqsign.enableRESPwave(false);
            }

            if (checkBox_SpO2wave.Checked)
            {
                Acqsign.enableSPO2wave(true);
            }
            else
            {
                Acqsign.enableSPO2wave(false);
            }

            if (checkBox_HR_RR.Checked)
            {
                Acqsign.enableECG(true);
            }
            else
            {
                Acqsign.enableECG(false);
                
            }
            if (checkBox_SpO2.Checked)
            {
                Acqsign.enableSPO2(true);
            }
            else
            {
                Acqsign.enableSPO2(false);
            }

            if (checkBox_TEMP.Checked)
            {
                Acqsign.enableTEMP(true);
            }
            else
            {
                Acqsign.enableTEMP(false);
            }

            if (comboBox1.SelectedIndex == 0)
            {
                Acqsign.setECGgain(Acqsign.GAINX025);
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                Acqsign.setECGgain(Acqsign.GAINX050);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Acqsign.setECGgain(Acqsign.GAINX100);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Acqsign.setECGgain(Acqsign.GAINX200);
            }


            if (comboBox2.SelectedIndex == 0)
            {
                Acqsign.setRESPgain(Acqsign.GAINX025);
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                Acqsign.setRESPgain(Acqsign.GAINX050);
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                Acqsign.setRESPgain(Acqsign.GAINX100);
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                Acqsign.setRESPgain(Acqsign.GAINX200);
            }


            if (comboBox4.SelectedIndex == 0)
            {
                Acqsign.setECGfilter(Acqsign.OPERATION);
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                Acqsign.setECGfilter(Acqsign.MONITOR);
            }
            else if (comboBox4.SelectedIndex == 2)
            {
                Acqsign.setECGfilter(Acqsign.DIAGNOSE);
            }



            this.Close();
        }

        private void checkBox_SpO2wave_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void checkBox_ECGwave_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_RESPwave_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_HR_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void checkBox_SpO2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_TEMP_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_HR__RR_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
