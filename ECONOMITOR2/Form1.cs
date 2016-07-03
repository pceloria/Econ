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
        public SerialPort myport;
        public double[] s;
        public int index = 0;
        public double tiempo = 0;

        public Economitor()
        {
            InitializeComponent();

            timer1.Tick += new EventHandler(timer1_Tick);  // Everytime timer ticks, timer_Tick will be called
            timer1.Interval = (50);                     // Timer will tick evert second
            timer1.Enabled = true;                       // Enable the timer
            timer1.Start();                              // Start the timer

            s = new double[100];
            for (int j = 0; j < s.Length; j++)
                derivacion1.Series["D1"].Points.AddY(s[j]);
            
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
            //if (index == 100)
            //    index = 0;

            //s[index] = Math.Sin(tiempo);

            //derivacion1.Series["D1"].Points.ElementAt(index).SetValueY(s[index]);
            //derivacion1.Refresh();
            tiempo = tiempo + 0.05;
            //index++;

            derivacion1.Series["D1"].Points.AddY(Math.Sin(tiempo));
            derivacion1.Update();
            derivacion1.Series["D1"].Points.RemoveAt(0);
            // llamar a funciones de data (ej: fetch(ECG))
            // actualizo el grafico llamando a audiovisual(data y eje x)
        }

    }
}
