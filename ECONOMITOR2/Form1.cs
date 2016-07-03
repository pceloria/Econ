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
        public SerialPort myport;

        // prueba para graficar data
        private double[] data;
        private double s;
        private double temp;
        private int counter;


        public Economitor()
        {
            InitializeComponent();

            timer1.Tick += new EventHandler(timer1_Tick);  // Everytime timer ticks, timer_Tick will be called
            timer1.Interval = (50);                     // Timer will tick evert second
            timer1.Enabled = true;                       // Enable the timer
            timer1.Start();                              // Start the timer

            //pruena para graficar data
            data = new double[25];
            s = 0;
            counter = 0;

            for (int j = 0; j < data.Length; j++){
                data[j] = s;
                s = s + 0.1;
            }

            AudioVisual.init_Draw(derivacion1);
            AudioVisual.init_Draw(derivacion2);
            AudioVisual.init_Draw(derivacion3);
            AudioVisual.init_Draw(respiracion);
            AudioVisual.init_Draw(spo2);


        }

        private void buttonShutdown_Click(object sender, EventArgs e)
        {
            Acqsign.close();
            Application.Exit();
            

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Acqsign.init(textPort.Text);

        }

        void timer1_Tick(object sender, EventArgs e)
        {


            if (counter == 20)
            {
                temp = GetRandomNumber(37, 40);
                AudioVisual.actualiza_text(textTemperatura, temp);
                AudioVisual.actualiza_text(textRR, temp);
                AudioVisual.actualiza_text(textSpO2, temp);
                AudioVisual.actualiza_text(textSistolica, temp);
                AudioVisual.actualiza_text(textDiastolica, temp);
                counter = 0;
            }

            AudioVisual.Draw(derivacion1,data);
            AudioVisual.Draw(derivacion2,data);
            AudioVisual.Draw(derivacion3,data);
            AudioVisual.Draw(respiracion,data);
            AudioVisual.Draw(spo2,data);

            counter++;

        }

        // genero temp random para testear AudioVisual.actualiza_text()
        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        private void buttonSilenciar_Click(object sender, EventArgs e)
        {
            //derivacion1.Update();
            //derivacion2.Update();

        }
    }
}
