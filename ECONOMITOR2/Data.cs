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
            // inicializo los vectores a graficar
            ECG = new double[5000];
            SPO2 = new double[1000];
            RESP = new double[1000];
        }

        // declaro e inicializo variables privadas de clase
        private static int lastPositionInECGArray = 0;
        private static int lastPositionInRESPArray = 0;
        private static int lastPositionInSPO2Array = 0;
        private static int newECGpackages = 0;
        private static int newRESPpackages = 0;
        private static int newSPO2packages = 0;


        private static double Temperatura;
        private static double RR;
        private static double Diastolica;
        private static double Sistolica;
        private static double SPo2;
        private static double [] ECG;
        private static double[] SPO2;
        private static double[] RESP;
        
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

        // metodos para devolver doubles de variables lentas
        public static double getCurrentTemperatura()
        {
            return Temperatura;
        }

        public static double getCurrentRR()
        {
            return RR;
        }

        public static double getCurrentDiastolica()
        {
            return Diastolica;
        }

        public static double getCurrentSistolica()
        {
            return Sistolica;
        }


        // metodos para devolver paquetes sin leer de variables rapidas doubles[] 
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

        public static double[] getNewRESPpackages()
        {
            if (newRESPpackages == 0)
                return null;
            else
            {
                double[] newRESPdata = new double[newRESPpackages * 5];
                int newDataStartsAt = lastPositionInRESPArray - newRESPpackages * 5;
                for (int k = 0; k < newRESPpackages * 5; k++)
                    if (newDataStartsAt + k < 0)
                        newRESPdata[k] = RESP[1000 + newDataStartsAt + k];
                    else
                        newRESPdata[k] = RESP[newDataStartsAt + k];

                newRESPpackages = 0;
                return newRESPdata;
            }
        }

        public static double[] getNewSPO2packages()
        {
            if (newSPO2packages == 0)
                return null;
            else
            {
                double[] newSPO2data = new double[newSPO2packages * 5];
                int newDataStartsAt = lastPositionInSPO2Array - newSPO2packages * 5;
                for (int k = 0; k < newSPO2packages * 5; k++)
                    if (newDataStartsAt + k < 0)
                        newSPO2data[k] = SPO2[1000 + newDataStartsAt + k];
                    else
                        newSPO2data[k] = SPO2[newDataStartsAt + k];

                newSPO2packages = 0;
                return newSPO2data;
            }
        }
    }
}
