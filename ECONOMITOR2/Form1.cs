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
        private SerialPort myport;
        private double[] data;
        private int counter;
        
        //para probar graficar rampas
        //private double s;
        //private double temp;


        public Economitor()
        {
            InitializeComponent();
            
            timer1.Tick += new EventHandler(timer1_Tick);  // Everytime timer ticks, timer_Tick will be called
            timer1.Interval = (50);                     // Timer will tick evert second
            timer1.Enabled = true;                       // Enable the timer
            timer1.Start();                              // Start the timer

            // para probar graifcar rampas
            //s = 0;

            //data = new double[100];
            //for (int j = 0; j < data.Length; j++)
            //    data[j] = s;
            //    s = s + 0.1;

            AudioVisual.init_Draw(derivacion1);
            AudioVisual.init_Draw(derivacion2);
            AudioVisual.init_Draw(derivacion3);
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
                Acqsign.init(textPort.Text);

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

            if (counter == 20) {
                //temp = GetRandomNumber(37, 40);

                AudioVisual.actualiza_text(textTemperatura, Data.getCurrentTemperatura());


                AudioVisual.actualiza_text(textRR, Data.getCurrentRR());
                
                // recuperamos el primer valor de los 5 paquetes de SPO2 
                if (newSPO2Data != null)
                {
                    AudioVisual.actualiza_text(textSpO2, newSPO2Data[0]);
                }
                
                AudioVisual.actualiza_text(textDiastolica,Data.getCurrentDiastolica());
                AudioVisual.actualiza_text(textSistolica,Data.getCurrentSistolica());
                counter = 0;
            }


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
        
        }

        void buttonSilenciar_Click(object sender, EventArgs e) { 
        
        }

     }
}
