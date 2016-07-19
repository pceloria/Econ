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
            LoadStates();
            LoadComboBoxes();
        }

        public void LoadStates()
        {
            checkBox_ECGwave.Checked = ECGwave;
            checkBox_RESPwave.Checked = RESPwave;
            checkBox_SpO2wave.Checked = SPO2wave;
            checkBox_HR_RR.Checked = ECGparam;
            checkBox_SpO2.Checked = SPO2param;
            checkBox_TEMP.Checked = TEMPparam;

            comboBox1.SelectedIndex = ECGgain;
            comboBox2.SelectedIndex = RESPgain;
            comboBox4.SelectedIndex = ECGfilter; 
              //  checkBox_HR_RR

        }
        public void LoadComboBoxes()
        {
            switch (Alarmas.silenceDurationInSeconds)
            {
                case 10:
                    // 10 segundos
                    comboBoxSilence.SelectedIndex = 0;
                    break;
                case 120:
                    // 2 minutos
                    comboBoxSilence.SelectedIndex = 1;
                    break;
                case 300:
                    // 5 minutos
                    comboBoxSilence.SelectedIndex = 2;
                    break;
                case 600:
                    // 10 minutos
                    comboBoxSilence.SelectedIndex = 3;
                    break;
                case 1800:
                    // 30 minutos
                    comboBoxSilence.SelectedIndex = 4;
                    break;
                default:
                    break;
            }
        }

        private static bool firstOpen = true;

        private static bool ECGwave = true;
        private static bool RESPwave = true;
        private static bool SPO2wave = true;
        private static bool SPO2param = true;
        private static bool ECGparam = true;
        private static bool TEMPparam = true;

        private static int ECGgain = 2;
        private static int RESPgain = 2;
        private static int ECGfilter = 0;
        
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
                ECGwave = true;
            }
            else {
                Acqsign.enableECGwave(false);
                ECGwave = false;
            }

            if (checkBox_RESPwave.Checked)
            {
                Acqsign.enableRESPwave(true);
                RESPwave = true;
            }
            else
            {
                Acqsign.enableRESPwave(false);
                RESPwave = false;
            }

            if (checkBox_SpO2wave.Checked)
            {
                Acqsign.enableSPO2wave(true);
                SPO2wave = true;
            }
            else
            {
                Acqsign.enableSPO2wave(false);
                SPO2wave = false;
            }

            if (checkBox_HR_RR.Checked)
            {
                Acqsign.enableECG(true);
                ECGparam = true;
            }
            else
            {
                Acqsign.enableECG(false);
                ECGparam = false;
            }
            if (checkBox_SpO2.Checked)
            {
                Acqsign.enableSPO2(true);
                SPO2param = true;
            }
            else
            {
                Acqsign.enableSPO2(false);
                SPO2param = false;
            }

            if (checkBox_TEMP.Checked)
            {
                Acqsign.enableTEMP(true);
                TEMPparam = true;
            }
            else
            {
                Acqsign.enableTEMP(false);
                TEMPparam = false;
            }



            if (comboBox1.SelectedIndex == 0)
            {
                Acqsign.setECGgain(Acqsign.GAINX025);
                ECGgain = 0;
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                Acqsign.setECGgain(Acqsign.GAINX050);
                ECGgain = 1;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Acqsign.setECGgain(Acqsign.GAINX100);
                ECGgain = 2;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Acqsign.setECGgain(Acqsign.GAINX200);
                ECGgain = 3;
            }


            if (comboBox2.SelectedIndex == 0)
            {
                Acqsign.setRESPgain(Acqsign.GAINX025);
                RESPgain = 0;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                Acqsign.setRESPgain(Acqsign.GAINX050);
                RESPgain = 1;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                Acqsign.setRESPgain(Acqsign.GAINX100);
                RESPgain = 2;
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                Acqsign.setRESPgain(Acqsign.GAINX200);
                RESPgain = 3;
            }


            if (comboBox4.SelectedIndex == 0)
            {
                Acqsign.setECGfilter(Acqsign.OPERATION);
                ECGfilter = 0; 
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                Acqsign.setECGfilter(Acqsign.MONITOR);
                ECGfilter = 1;
            }
            else if (comboBox4.SelectedIndex == 2)
            {
                Acqsign.setECGfilter(Acqsign.DIAGNOSE);
                ECGfilter = 2;
            }


            switch (comboBoxSilence.SelectedIndex)
            {
                case 0:
                    // 10 segundos
                    Alarmas.silenceDurationInSeconds = 10;
                    break;
                case 1:
                    // 2 minutos
                    Alarmas.silenceDurationInSeconds = 2*60;
                    break;
                case 2:
                    // 5 minutos
                    Alarmas.silenceDurationInSeconds = 5*60;
                    break;
                case 3:
                    // 10 minutos
                    Alarmas.silenceDurationInSeconds = 10*60;
                    break;
                case 4:
                    // 30 minutos
                    Alarmas.silenceDurationInSeconds = 30*60;
                    break;
                default:
                    break;
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
