using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECONOMITOR2
{
    class Data
    {
        public static void init()
        {
            Temperatura = 0;
            ECG = new int[5000];
            lastPositionInECGArray = 0;
        }
       
        private static int lastPositionInECGArray;

        private static int Temperatura;
        private static int[] ECG;


        public static void updateTemperatura(int Temperatura){
            Data.Temperatura = Temperatura;
            drawTemperatura();
        }
        public static void updateECG(int[] newData)
        {
            // hacer un for a partir del indice j (guardar ese dato) y actualizar con newData
            Data.ECG[lastPositionInECGArray: (lastPositionInECGArray + newData.Length)] = newData;
            // chequear que no se haya llegado al final del array

            drawECG();
        }

        private static void drawTemperatura()
        {
            // llamar a funcion de Nacho y Pau que actualice en pantalla el valor de temperatura
        }
        private static void drawECG()
        {
            // llamar a funcion de Nacho y Pau que actualice en pantalla el plot de ECG
        }
    }
}
