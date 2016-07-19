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
        private static int secondsToShowECG = 8;
        private static int secondsToShowRESP = 25;
        private static int secondsToShowSPO2 = 8;
        public static int getPointsOfECG()
        {
            return 250*secondsToShowECG;
        }
        public static int getPointsOfRESP()
        {
            return 50*secondsToShowRESP;
        }
        public static int getPointsOfSPO2()
        {
            return 50*secondsToShowSPO2;
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
                for (int j = 0; j < 2; j++)
                    chartSPO2.Series["Series1"].Points[currentIndex + j].IsEmpty = false;

            for (int j = 0; j < data.Length; j++)
            {
                chartSPO2.Series["Series1"].Points[j + currentIndex].SetValueY(data[j]);
            }
            if (data.Length + 4 + currentIndex < getPointsOfSPO2())
                for (int j = 0; j < 2; j++)
                    chartSPO2.Series["Series1"].Points[data.Length + currentIndex + j].IsEmpty = true;

            chartSPO2.ResetAutoValues();
        }

        public static void init_Draw(Chart chartECG, Chart chartRESP, Chart chartSPO2)
        {

            AudioVisual.chartECG = chartECG;
            AudioVisual.chartSPO2 = chartSPO2;
            AudioVisual.chartRESP = chartRESP;

            // Se inicializa el grafico de ECG
            int pointsECG = secondsToShowECG*250;
            for (int j = 0; j < pointsECG; j++)
                    chartECG.Series["Series1"].Points.AddY(0);

            // Se inicializa el grafico de RESP
            int pointsRESP = secondsToShowRESP * 50;
            for (int j = 0; j < pointsRESP; j++)
                chartRESP.Series["Series1"].Points.AddY(0);

            // Se inicializa el grafico de SPO2
            int pointsSPO2 = secondsToShowSPO2 * 50;
            for (int j = 0; j < pointsSPO2; j++)
                chartSPO2.Series["Series1"].Points.AddY(0);
               

        }
        public static void actualiza_text(System.Windows.Forms.TextBox text, double data) {

            text.Text = data + "";
        }

        public static void DrawECGtoZero()
        {
            for (int j = 0; j < getPointsOfECG(); j++)
                chartECG.Series["Series1"].Points[].SetValueY(0);
            
        }
        public static void DrawRESPtoZero()
        {
            for (int j = 0; j < getPointsOfRESP(); j++)
                chartRESP.Series["Series1"].Points[].SetValueY(0);
            
        }
        public static void DrawSPO2toZero()
        {
            for (int j = 0; j < getPointsOfSPO2(); j++)
                chartSPO2.Series["Series1"].Points[].SetValueY(0);
            
        }
    }
}
