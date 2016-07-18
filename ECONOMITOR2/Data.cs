using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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

            HeartRate = 80;
            RespRate = 60;
            Spo2Sat = 99;
            Temperatura = 37;
            Sys_Pressure = 110;
            Dia_Pressure = 90;
            Mean_Pressure = 100;
            
        }

        // declaro e inicializo variables privadas de clase
        private static int lastPositionInECGArray = 0;
        private static int lastPositionInRESPArray = 0;
        private static int lastPositionInSPO2Array = 0;
        private static int newECGpackages = 0;
        private static int newRESPpackages = 0;
        private static int newSPO2packages = 0;


        // Parametro de Temperatura
        private static double Temperatura;
        public static int TempStatus;
        // Parametros del ECG
        private static byte ECG_Status;
        private static int HeartRate;
        private static int RespRate;
        private static int ST_Level;
        // Parametros del SPO2
        public static int SPO2_Status;
        private static int Spo2Sat;
        private static int PulseRate;
        // Parametros del NIBP
        private static int NIBP_Status;
        private static int Cuff_Pressure;
        private static int Sys_Pressure;
        private static int Mean_Pressure;
        private static int Dia_Pressure;
        // Señales para plotear
        private static double[] ECG;
        private static double[] SPO2;
        private static double[] RESP;

        // Flags
        public static bool flagECGleadOFF;
        public static int ECGgain;
        public static int ECGfilter;


        // Guardado de variables lentas luego de la adquisicion
        public static void updateTemperatura(double Temperatura, int TempStatus )
        {
            Data.Temperatura = Temperatura;
            Data.TempStatus = TempStatus;

        }
        public static void updateECGparams(int ECG_Status, int HeartRate, int RespRate, int ST_Level)
        {
            // No recibe el arritmia code porque no esta disponible en esta version

            //
            Data.ECG_Status = (Byte)ECG_Status;
            BitArray bitsECG_Status = new BitArray(new byte[] { Data.ECG_Status });
            ECGgain = (Data.ECG_Status & 0x0C)>>2;
            ECGfilter = (Data.ECG_Status & 0x30) >> 4;
            flagECGleadOFF = (bool)bitsECG_Status[1];
            
            Data.HeartRate = HeartRate;
            Data.RespRate = RespRate;
            Data.ST_Level = ST_Level;
        }
        public static void updateSPO2params(int SPO2_Status, int Spo2Sat, int PulseRate)
        {
            Data.SPO2_Status = SPO2_Status;
            Data.Spo2Sat = Spo2Sat;
            Data.PulseRate = PulseRate;
        }
        public static void updateNIBPparams(int NIBP_Status, int Cuff_Pressure, int Sys_Pressure, int Mean_Pressure, int Dia_Pressure)
        {
            Data.NIBP_Status = NIBP_Status;
            Data.Cuff_Pressure = Cuff_Pressure;
            Data.Sys_Pressure = Sys_Pressure;
            Data.Mean_Pressure = Mean_Pressure;
            Data.Dia_Pressure = Dia_Pressure;
        }
        // Guardado de variables rapidas luego de la adquisicion
        public static void updateECG(double[] newData)
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
            if (newECGpackages > 24)
                newECGpackages = 24;
        }
        public static void updateRESP(double[] newData)
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
            if (newRESPpackages > 24)
                newRESPpackages = 24;
            
        }
        public static void updateSPO2(double[] newData)
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
            if (newSPO2packages > 24)
                newSPO2packages = 24;
        }

        // metodos para devolver doubles de variables lentas
        public static double getCurrentTemperatura()
        {
            return Temperatura;
        }
        public static int getCurrentRespRate()
        {
            return RespRate;
        }
        public static int getCurrentHeartRate()
        {
            return HeartRate;
        }
        public static int getCurrentSpo2Sat()
        {
            return Spo2Sat;
        }
        public static int getCurrentMean_Pressure()
        {
            return Mean_Pressure;
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
