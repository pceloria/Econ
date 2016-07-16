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
            {
                chart.Series["Series1"].Points[currentIndex].IsEmpty = false;
                chart.Series["Series1"].Points[currentIndex+1].IsEmpty = false;
                chart.Series["Series1"].Points[currentIndex+2].IsEmpty = false;
                chart.Series["Series1"].Points[currentIndex+3].IsEmpty = false;
                chart.Series["Series1"].Points[currentIndex+4].IsEmpty = false;
            }
            for (int j = 0; j < data.Length; j++)
            {
                //chart.Series["Series1"].Points.AddY(data[j]);
                //chart.Series["Series1"].Points.RemoveAt(0);
                chart.Series["Series1"].Points[j+currentIndex].SetValueY(data[j]);
            }
            if (data.Length + 4 + currentIndex < 1000)
            {
                chart.Series["Series1"].Points[data.Length + currentIndex].IsEmpty = true;
                chart.Series["Series1"].Points[data.Length + 1 + currentIndex].IsEmpty = true;
                chart.Series["Series1"].Points[data.Length + 2 + currentIndex].IsEmpty = true;
                chart.Series["Series1"].Points[data.Length + 3 + currentIndex].IsEmpty = true;
                chart.Series["Series1"].Points[data.Length + 4 + currentIndex].IsEmpty = true;
            }
            
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
