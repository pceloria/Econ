using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ECONOMITOR2
{
    class AudioVisual
    {
        // init variables de la clase
        private static double[] s;
        private static int secondsToShow = 10;
        public static int getPointsOfECG()
        {
            return 250*secondsToShow;
        }
        public static int getPointsOfRESP()
        {
            return 50*secondsToShow;
        }
        public static int getPointsOfSPO2()
        {
            return 50*secondsToShow;
        }

        private static Chart chartECG;
        private static Chart chartSPO2;
        private static Chart chartRESP;

        public static void DrawECG(double[] data, int currentIndex) {

            if (currentIndex != 0)
                for (int j = 0; j < 5; j++)
                    chartECG.Series["Series1"].Points[currentIndex+j].IsEmpty = false;
            
            for (int j = 0; j < data.Length; j++)
            {
                chartECG.Series["Series1"].Points[j + currentIndex].SetValueY(data[j]);
            }
            if (data.Length + 4 + currentIndex < getPointsOfECG())
                for (int j = 0; j < 5; j++)
                    chartECG.Series["Series1"].Points[data.Length + currentIndex + j].IsEmpty = true;

            chartECG.ResetAutoValues();
        }
        public static void DrawRESP(double[] data, int currentIndex)
        {

            if (currentIndex != 0)
                for (int j = 0; j < 5; j++)
                    chartRESP.Series["Series1"].Points[currentIndex + j].IsEmpty = false;

            for (int j = 0; j < data.Length; j++)
            {
                chartRESP.Series["Series1"].Points[j + currentIndex].SetValueY(data[j]);
            }
            if (data.Length + 4 + currentIndex < getPointsOfRESP())
                for (int j = 0; j < 5; j++)
                    chartRESP.Series["Series1"].Points[data.Length + currentIndex + j].IsEmpty = true;

            chartRESP.ResetAutoValues();
        }
        public static void DrawSPO2(double[] data, int currentIndex)
        {

            if (currentIndex != 0)
                for (int j = 0; j < 5; j++)
                    chartSPO2.Series["Series1"].Points[currentIndex + j].IsEmpty = false;

            for (int j = 0; j < data.Length; j++)
            {
                chartSPO2.Series["Series1"].Points[j + currentIndex].SetValueY(data[j]);
            }
            if (data.Length + 4 + currentIndex < getPointsOfSPO2())
                for (int j = 0; j < 5; j++)
                    chartSPO2.Series["Series1"].Points[data.Length + currentIndex + j].IsEmpty = true;

            chartSPO2.ResetAutoValues();
        }

        public static void init_Draw(Chart chartECG, Chart chartRESP, Chart chartSPO2)
        {

            AudioVisual.chartECG = chartECG;
            AudioVisual.chartSPO2 = chartSPO2;
            AudioVisual.chartRESP = chartRESP;

            // Se inicializa el grafico de ECG
            int pointsECG = secondsToShow*250;
            for (int j = 0; j < pointsECG; j++)
                    chartECG.Series["Series1"].Points.AddY(0);

            // Se inicializa el grafico de RESP y SPO2
            int pointsOthers = secondsToShow * 50;
            for (int j = 0; j < pointsOthers; j++)
            {
                chartRESP.Series["Series1"].Points.AddY(0);
                chartSPO2.Series["Series1"].Points.AddY(0);
            }
               

        }
        public static void actualiza_text(System.Windows.Forms.TextBox text, double data) {

            text.Text = data + "";
        } 
    }
}
