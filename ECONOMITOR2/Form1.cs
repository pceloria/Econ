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
        private double[] data;
        private int counter;
        private double currentTemperatura;
        private int currentHR;
        private int currentRR;
        private int currentspo2;
        private int currentSistolica;
        private int currentDiastolica;
        private int currentMean_Pressure;
        

        //para probar graficar rampas
        //private double s;
        //private double temp;


        public Economitor()
        {
            InitializeComponent();
            
            // para probar graifcar rampas
            //s = 0;

            //data = new double[100];
            //for (int j = 0; j < data.Length; j++)
            //    data[j] = s;
            //s = s + 0.1;

            AudioVisual.init_Draw(derivacion1);
            //AudioVisual.init_Draw(derivacion2);
            //AudioVisual.init_Draw(derivacion3);
            AudioVisual.init_Draw(spo2);
            AudioVisual.init_Draw(respiracion);
            Data.init();
            
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
                if (Acqsign.init(textPort.Text))
                {
                    // Se inicia el timer si se logro abrir el puerto
                    timer1.Tick += new EventHandler(timer1_Tick);  // Everytime timer ticks, timer_Tick will be called
                    timer1.Interval = (50);                     // Timer will tick evert second
                    timer1.Enabled = true;                       // Enable the timer
                    timer1.Start();                              // Start the timer
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

            if (Alarmas.counter1 == 100 && Alarmas.flag_alarma == false) {
                Alarmas.flag_alarma = true;
                Alarmas.counter1 = 0;
            }


            if (counter == 20) {
                //temp = GetRandomNumber(37, 40);
                currentHR = Data.getCurrentHeartRate();
                currentSistolica = Data.getCurrentSistolica();
                currentDiastolica = Data.getCurrentDiastolica();
                currentRR = Data.getCurrentRespRate();
                currentspo2 = Data.getCurrentSpo2Sat();
                currentTemperatura = Data.getCurrentTemperatura();
                currentMean_Pressure = Data.getCurrentMean_Pressure();

                AudioVisual.actualiza_text(textTemperatura, currentTemperatura);
                AudioVisual.actualiza_text(textRR, currentRR);
                AudioVisual.actualiza_text(textHeartRate, currentHR);
                AudioVisual.actualiza_text(textSpO2, currentspo2);
                AudioVisual.actualiza_text(textDiastolica, currentDiastolica);
                AudioVisual.actualiza_text(textSistolica, currentSistolica);
                AudioVisual.actualiza_text(textMean_Pressure, currentMean_Pressure);

                Alarmas.toma_de_decisiones(currentHR, currentRR, currentTemperatura, currentDiastolica,
                    currentSistolica, currentspo2,textHRbajo,textHRalto,textRRbajo,textRRalto,textSpO2bajo,
                    textTEMPbajo,textTEMPalto,textNIBPbajo,textNIBPalto);
                counter = 0;
            }
            
            //para probar graficar
            //AudioVisual.Draw(derivacion1, data);

            if (newECGData != null)
            {
                AudioVisual.Draw(derivacion1, newECGData);
            }

            if (newSPO2Data != null)
            {
                AudioVisual.Draw(spo2, newSPO2Data);
            }

            if (newRESPData != null)
            {
                AudioVisual.Draw(respiracion, newRESPData);
            }

            // no encontramos en el protocolo de comunicacion como se pasan las otras leads
            //AudioVisual.Draw(derivacion2, data);
            //AudioVisual.Draw(derivacion3, data);


            counter++;
            Alarmas.counter1++;
        
        }

        void buttonSilenciar_Click(object sender, EventArgs e) {
        
            Alarmas.silenciarAlarma();
        
        }

        private void textHRbajo_TextChanged(object sender, EventArgs e)
        {
            Alarmas.set_low_HR(textHRbajo);
        }

        private void textHRalto_TextChanged(object sender, EventArgs e)
        {
            Alarmas.set_high_HR(textHRalto);
        }

        private void textRRbajo_TextChanged(object sender, EventArgs e)
        {
            Alarmas.set_low_RR(textRRbajo);
        }

        private void textRRalto_TextChanged(object sender, EventArgs e)
        {
            Alarmas.set_high_RR(textRRalto);
        }

        private void textSpO2bajo_TextChanged(object sender, EventArgs e)
        {
            Alarmas.set_low_Spo2(textSpO2bajo);
        }

        private void textNIBPbajo_TextChanged(object sender, EventArgs e)
        {
            Alarmas.set_low_NIBP(textNIBPbajo);
        }

        private void textNIBPalto_TextChanged(object sender, EventArgs e)
        {
            Alarmas.set_high_NIBP(textNIBPalto);
        }

        private void textTEMPbajo_TextChanged(object sender, EventArgs e)
        {
            Alarmas.set_low_temperatura(textTEMPbajo);
        }

        private void textTEMPalto_TextChanged(object sender, EventArgs e)
        {
            Alarmas.set_high_temperatura(textTEMPalto);
        }
    }
}
