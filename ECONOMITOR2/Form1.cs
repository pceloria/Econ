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
using System.Diagnostics;

namespace ECONOMITOR2
{
    public partial class Economitor : Form
    {
        private int counter;
        private double currentTemperatura;
        private int currentHR;
        private int currentRR;
        private int currentspo2;
        private int currentMean_Pressure;

        private int currentIndexECG = 0;
        private int currentIndexSPO2 = 0;
        private int currentIndexRESP = 0;
        private Form Welcome;
        private Boolean flag_pause;
   

        public Economitor()
        {

            //Welcome_init();
            InitializeComponent();
            Alarmas.Alarm_init(exclamationMark);
            currentIndexECG = 0;
            currentIndexSPO2 = 0;
            currentIndexRESP = 0;
            flag_pause = false;

            // para probar graifcar rampas
            //s = 0;

            //data = new double[100];
            //for (int j = 0; j < data.Length; j++)
            //    data[j] = s;
            //s = s + 0.1;

            AudioVisual.init_Draw(derivacion1, respiracion, spo2);;
            Data.init();


            Welcome_init();
        }

        private void buttonShutdown_Click(object sender, EventArgs e)
        {
            Acqsign.close();
            Application.Exit();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!Acqsign.isPortOpen)
            {
                //                if (Acqsign.init(textPort.Text))
                if (Acqsign.init("COM14"))
                {
                    // Se inicia el timer si se logro abrir el puerto
                    timer1.Tick += new EventHandler(timer1_Tick);  // Everytime timer ticks, timer_Tick will be called
                    timer1.Interval = (50);                     // Timer will tick evert second
                    timer1.Enabled = true;                       // Enable the timer
                    timer1.Start();                              // Start the timer
                }
                else
                    MessageBox.Show("Cannot find COM port");
                if (flag_pause == true)
                {
                    timer1.Start();
                    flag_pause = false;
                }
            }
                
        }
        
        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        void timer1_Tick(object sender, EventArgs e){

            double[] newECGData = Data.getNewECGpackages();
            double[] newSPO2Data = Data.getNewSPO2packages();
            double[] newRESPData = Data.getNewRESPpackages();

            if (Alarmas.counter1 == 100 && Alarmas.flag_alarma == false ) {
                Alarmas.flag_alarma = true;
                Alarmas.counter1 = 0;
            }

            if (Alarmas.counter_color == 20)
            {
               
                Alarmas.counter_color = 0;

            }

            if (counter == 20 ) {
                //temp = GetRandomNumber(37, 40);
                currentHR = Data.getCurrentHeartRate();
                currentRR = Data.getCurrentRespRate();
                currentspo2 = Data.getCurrentSpo2Sat();
                currentTemperatura = Data.getCurrentTemperatura();
                currentMean_Pressure = Data.getCurrentMean_Pressure();

                AudioVisual.actualiza_text(textTemperatura, currentTemperatura);
                AudioVisual.actualiza_text(textRR, currentRR);
                AudioVisual.actualiza_text(textHeartRate, currentHR);
                AudioVisual.actualiza_text(textSpO2, currentspo2);


                Alarmas.toma_de_decisiones(currentHR, currentRR, currentTemperatura, currentspo2, 
                                            textHeartRate, textRR, textSpO2, textTemperatura);
                counter = 0;
            }
            
           

            if (newECGData != null )
            {
                if (currentIndexECG + newECGData.Length > AudioVisual.getPointsOfECG())
                    currentIndexECG = 0;
                AudioVisual.DrawECG(newECGData, currentIndexECG);
                currentIndexECG += newECGData.Length;
                
            }

            if (newSPO2Data != null)
            {
                if (currentIndexSPO2 + newSPO2Data.Length > AudioVisual.getPointsOfSPO2())
                    currentIndexSPO2 = 0;
                AudioVisual.DrawSPO2(newSPO2Data, currentIndexSPO2);
                currentIndexSPO2 += newSPO2Data.Length;
            }

            if (newRESPData != null) {
                if (currentIndexRESP + newRESPData.Length > AudioVisual.getPointsOfRESP())
                    currentIndexRESP = 0;
                AudioVisual.DrawRESP(newRESPData, currentIndexRESP);
                currentIndexRESP += newRESPData.Length;
            }

            // no encontramos en el protocolo de comunicacion como se pasan las otras leads
            //AudioVisual.Draw(derivacion2, data);
            //AudioVisual.Draw(derivacion3, data);

            setStatus();

            counter++;
            Alarmas.counter1++;
            Alarmas.counter_color++;
        
        }

        void buttonSilenciar_Click(object sender, EventArgs e) {
            
            
            Alarmas.silenciarAlarma();
            
        
        }



        private void spo2_Click(object sender, EventArgs e)
        {

        }

        private void textPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void Economitor_Load(object sender, EventArgs e)
        {

        }

        private void botonAlarma_Click(object sender, EventArgs e)
        {
            Form2 alarmsSetupForm = new Form2();
            alarmsSetupForm.Show();
        }

        
        private void buttonConfiguration_Click(object sender, EventArgs e)
        {   
            FormConfig configForm = new FormConfig();        
            configForm.Show();
            //configForm.Close();
        }

        private void Welcome_init()
        {
            Welcome = new Welcome(); 
            Welcome.Show();

            Welcome.TopMost = true;
            Welcome.Focus();
            Welcome.BringToFront();
            
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            flag_pause = true;
            timer1.Stop();
        }

        private void setStatus() {

            if (Data.TempStatus == 0) {
                textBox2.Text = "Sensor off";
            }
            else {
                textBox2.Text = "Normal";
            }


            if (Data.flagECGleadOFF) {
                textBox1.Text = "Lead off";
            }
            else  {
                textBox1.Text = "Normal";
            }


            if (Data.SPO2_Status == 0) {
                textBox3.Text = "Normal";
            }
            else if(Data.SPO2_Status == 1) {
                textBox3.Text = "Sensor off";
            }
            else if (Data.SPO2_Status == 2) {
                textBox3.Text = "No finger insert";
            }
            else if (Data.SPO2_Status == 3) {
                textBox3.Text = "Searching pulse signal";
            }
            else if (Data.SPO2_Status == 4) {
                textBox3.Text = "Searching time out";
                    
            }

        }
    }
}
