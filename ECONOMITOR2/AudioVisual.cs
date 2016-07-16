using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECONOMITOR2
{
    class AudioVisual
    {
        // init variables de la clase
        private static double[] s;

        public static void Draw(System.Windows.Forms.DataVisualization.Charting.Chart chart, double[] data, int currentIndex) {

            if (currentIndex != 0)
                for (int j = 0; j < 5; j++)
                    chart.Series["Series1"].Points[currentIndex+j].IsEmpty = false;
            
            for (int j = 0; j < data.Length; j++)
            {
                //chart.Series["Series1"].Points.AddY(data[j]);
                //chart.Series["Series1"].Points.RemoveAt(0);
                chart.Series["Series1"].Points[j+currentIndex].SetValueY(data[j]);
            }
            if (data.Length + 4 + currentIndex < 1000)
                for (int j = 0; j < 5; j++)
                    chart.Series["Series1"].Points[data.Length + currentIndex + j].IsEmpty = true;
            
            chart.ResetAutoValues();
        }

        public static void init_Draw(System.Windows.Forms.DataVisualization.Charting.Chart chart) {


            s = new double[1000];

            for (int j = 0; j < s.Length; j++)
                    chart.Series["Series1"].Points.AddY(s[j]);

            //chart.ChartAreas[0].AxisY.Minimum = -5;
            //chart.ChartAreas[0].AxisY.Maximum = 5;
        }
        public static void actualiza_text(System.Windows.Forms.TextBox text, double data) {

            text.Text = data + "";
        } 
    }
}
