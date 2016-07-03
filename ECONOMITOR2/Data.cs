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
            SPO2 = new int[1000];
            RESP = new int[1000];
        }

        private static int lastPositionInECGArray = 0;
        private static int lastPositionInRESPArray = 0;
        private static int lastPositionInSPO2Array = 0;
        private static int newECGpackages = 0;
        private static int newRESPpackages = 0;
        private static int newSPO2packages = 0;


        private static int Temperatura;
        private static int[] ECG;
        private static int[] SPO2;
        private static int[] RESP;
        
        public static void updateTemperatura(int Temperatura)
        {
            Data.Temperatura = Temperatura;

        }


        public static void updateECG(int[] newData)
        {
            // hacer un for a partir del indice j (guardar ese dato) y actualizar con newData
            // Data.ECG[lastPositionInECGArray: (lastPositionInECGArray + newData.Length)] = newData;
            // chequear que no se haya llegado al final del array

            for (int i = 0; i < newData.Length; i++)
                Data.ECG[i + lastPositionInECGArray] = newData[i];
           
            lastPositionInECGArray = lastPositionInECGArray + newData.Length;

            if (lastPositionInECGArray + newData.Length > 5000)
                lastPositionInECGArray = 0;

            newECGpackages++;
        }
        public static void updateRESP(int[] newData)
        {
            // hacer un for a partir del indice j (guardar ese dato) y actualizar con newData
            // Data.ECG[lastPositionInECGArray: (lastPositionInECGArray + newData.Length)] = newData;
            // chequear que no se haya llegado al final del array

            for (int i = 0; i < newData.Length; i++)
                Data.RESP[i + lastPositionInRESPArray] = newData[i];

            lastPositionInRESPArray = lastPositionInRESPArray + newData.Length;

            if (lastPositionInRESPArray + newData.Length > 1000)
                lastPositionInRESPArray = 0;

            newRESPpackages++;
        }
        public static void updateSPO2(int[] newData)
        {
            // hacer un for a partir del indice j (guardar ese dato) y actualizar con newData
            // Data.ECG[lastPositionInECGArray: (lastPositionInECGArray + newData.Length)] = newData;
            // chequear que no se haya llegado al final del array

            for (int i = 0; i < newData.Length; i++)
                Data.SPO2[i + lastPositionInSPO2Array] = newData[i];

            lastPositionInSPO2Array = lastPositionInSPO2Array + newData.Length;

            if (lastPositionInSPO2Array + newData.Length > 1000)
                lastPositionInSPO2Array = 0;

            newSPO2packages++;
        }

        public static double getCurrentTemperatura()
        {
            return Temperatura;
        }

        public static double[] getNewECGpackages()
        {
            if (newECGpackages == 0)
                return null;
            else
            {
                double[] newECGdata = new double[newECGpackages * 25];
                int newDataStartsAt = lastPositionInECGArray - newECGpackages * 25;
                for (int k = 0; k < newECGpackages * 25; k++)
                    if (newDataStartsAt + k < 0)
                        newECGdata[k] = ECG[5000 + newDataStartsAt + k];
                    else
                        newECGdata[k] = ECG[newDataStartsAt + k];
               
                newECGpackages = 0;
                return newECGdata;
            }
        }
    }
}
