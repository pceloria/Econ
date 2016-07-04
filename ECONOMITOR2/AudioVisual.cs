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

        public static void Draw(System.Windows.Forms.DataVisualization.Charting.Chart chart, double[] data) {


            for (int j = 0; j < data.Length; j++) 
                chart.Series["Series1"].Points.AddY(data[j]);

            chart.Update();

            for (int j = 0; j < data.Length; j++)
                chart.Series["Series1"].Points.RemoveAt(0);
                
        }

        public static void init_Draw(System.Windows.Forms.DataVisualization.Charting.Chart chart) {


            s = new double[1000];

            for (int j = 0; j < s.Length; j++)
  
                    chart.Series["Series1"].Points.AddY(s[j]);

        }
        public static void actualiza_text(System.Windows.Forms.TextBox text, double data) {

            text.Text = data + "";
        } 
    }
}
