﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.Diagnostics;



namespace ECONOMITOR2
{
    public class Acqsign
    {

        const int ECG_WAVE = 1;
        const int ECG_PARAM = 2;
        const int NIBP_PARAM = 3;
        const int SPO2_PARAM = 4;
        const int TEMP = 5;
        const int SOFT_VERSION = 252;
        const int HARD_VERSION = 253;
        const int SPO2_WAVE = 254;
        const int RESP_WAVE = 255;

        private static double ECG_Wave_Amplitud;

        private static int ECG_Status;
        private static int HeartRate;
        private static int RespRate;
        private static int ST_Level;
        private static int ARR_code;

        private static int NIBP_Status;
        private static int Cuff_Pressure;
        private static int Sys_Pressure;
        private static int Mean_Pressure;
        private static int Dia_Pressure;

        private static int SPO2_Status;
        private static int Spo2Sat;
        private static int PulseRate;

        private static int TEMP_Status;
        private static int TEMP1_Integral;
        private static int TEMP1_Decimal;

        private static int SPO2_Wave_amplitude;
        private static int RR_Wave_amplitude;

        private static int ECG_WAVEval;
        private static int ECG_PARAMval;
        private static int NIBP_PARAMval;
        private static int SPO2_PARAMval1;
        private static double TEMPval;
        private static int SPO2_WAVEval;
        private static int RESP_WAVEval;

        const int ECG_WAVEfreq = 250;
        const int ECG_PARAMfreq = 1;
        const int NIBP_PARAMfreq = 2;
        const int SPO2_PARAMfreq = 1;
        const int TEMPfreq = 1;
        const int SPO2_WAVEfreq = 50;
        const int RESP_WAVEfreq = 50;

        const int TIME = 1;
        //const double TIMEpackage = 0.1;

        static double[] ECG_WAVEdat = new double[Data.ECGpackagesSize];
        static int[] ECG_PARAMdat = new int[TIME * ECG_PARAMfreq];
        static int[] NIBP_PARAMdat = new int[TIME * NIBP_PARAMfreq];
        static int[] SPO2_PARAMdat = new int[TIME * SPO2_PARAMfreq];
        static int[] TEMPdat = new int[TIME * TEMPfreq];
        static double[] SPO2_WAVEdat = new double[Data.SPO2packagesSize];
        static double[] RESP_WAVEdat = new double[Data.RESPpackagesSize];

        static int indexECG = 0;
        static int indexSPO2 = 0;
        static int indexRESP = 0;

        public static bool isPortOpen = false;
        static bool reading = false;
        private static SerialPort port;

        // Incia la comunicación con el puerto serie que se elige 
        // Si se logra abrir el puerto devuelve true. Si hubo algun problema devuelve false
        public static bool init(String portName)
        {
            if (portName != null && !portName.Equals(""))
            {
                port = new SerialPort();
                port.BaudRate = 115200;
                port.PortName = portName;
                port.Parity = Parity.None;
                port.DataBits = 8;
                port.StopBits = StopBits.One;



                try
                {
                    port.Open();
                    isPortOpen = true;
                    port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(DataRecievedHandler);
                    enableECG(true);
                    enableECGwave(true);
                    enableRESPwave(true);
                    enableSPO2(true);
                    enableSPO2wave(true);
                    enableTEMP(true);

                    setECGgain(GAINX100);
                    setRESPgain(GAINX100);
                    setECGfilter(OPERATION);


                    //enableSPO2();
                    //enableRESP();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Se debe asignar el nombre del puerto que se desea leer", "Error");
            }
            return false;
        }

        //Cierra la comunicación con el puerto serie
        public static void close()
        {
            if (port != null)
                try
                {
                    port.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
        }

        private static void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {

            SerialPort sp = (SerialPort)sender;

            // Leo todo lo que haya en el buffer y si me queda un paquete por la mitad espero a que lleguen
            // los bytes que faltan.
            int byteCount = sp.BytesToRead;
            if (!reading)
                armarPaquetes(byteCount);
            if (byteCount > 5000)
                MessageBox.Show("Procesamiento lento. Se acumularon " + byteCount + " bytes en el buffer", "Warning");
            else
            {
                if (byteCount > 500)
                    Console.WriteLine("Procesando paquetes. Bytes acumulados = " + byteCount);
            }

        }

        private static int armarPaquetes(int BytesToRead)
        {
            int package_length;
            int checksum;
            reading = true;
            int bytesRead = 0;

            while (bytesRead < BytesToRead)
            {

                bytesRead++;
                if (port.ReadByte() == 85)
                {              //verifica primer byte de header asd
                    bytesRead++;
                    if (port.ReadByte() == 170)
                    {                //verifica segundo
                        bytesRead++;
                        package_length = port.ReadByte();
                        int[] data = new int[package_length - 3];
                        bytesRead++;
                        int tiposenal = port.ReadByte();

                        for (int i = 0; i < package_length - 3; i++)
                        {
                            bytesRead++;
                            data[i] = port.ReadByte();
                        }

                        bytesRead++;
                        checksum = port.ReadByte();
                        int sum = (255 - (package_length + tiposenal + data.Sum()));
                        if (sum < 0)
                            sum = 256 + sum;
                        if (checksum == sum)
                        {
                            switch (tiposenal)
                            {
                                case ECG_WAVE:
                                    ECG_Wave_Amplitud = (data[0] - 128.0) * 5.0 / 127;
                                    ECG_WAVEdat[indexECG] = ECG_Wave_Amplitud;
                                    indexECG++;
                                    if (indexECG == ECG_WAVEdat.LongLength)
                                    {
                                        // Enviar datos a Data
                                        Data.updateECG(ECG_WAVEdat);
                                        indexECG = 0;
                                    }
                                    break;

                                case ECG_PARAM:
                                    ECG_Status = data[0];
                                    HeartRate = data[1];
                                    RespRate = data[2];
                                    ST_Level = data[3];
                                    ARR_code = data[4];
                                    Data.updateECGparams(ECG_Status, HeartRate, RespRate, ST_Level);
                                    break;

                                case NIBP_PARAM:
                                    NIBP_Status = data[0];
                                    Cuff_Pressure = data[1];
                                    Sys_Pressure = data[2];
                                    Mean_Pressure = data[3];
                                    Dia_Pressure = data[4];
                                    Data.updateNIBPparams(NIBP_Status, Cuff_Pressure, Sys_Pressure, Mean_Pressure, Dia_Pressure);
                                    break;

                                case SPO2_PARAM:
                                    SPO2_Status = data[0];
                                    Spo2Sat = data[1];
                                    PulseRate = data[2];
                                    Data.updateSPO2params(SPO2_Status, Spo2Sat, PulseRate);
                                    break;

                                case TEMP:
                                    TEMP_Status = data[0];
                                    TEMP1_Integral = data[1];
                                    TEMP1_Decimal = data[2];
                                    TEMPval = TEMP1_Integral + ((double)TEMP1_Decimal) / 10;
                                    Data.updateTemperatura(TEMPval, TEMP_Status);
                                    break;

                                case SOFT_VERSION:
                                    break;

                                case HARD_VERSION:
                                    break;

                                case SPO2_WAVE:
                                    SPO2_Wave_amplitude = data[0];
                                    SPO2_WAVEdat[indexSPO2] = SPO2_Wave_amplitude;
                                    indexSPO2++;
                                    if (indexSPO2 == SPO2_WAVEdat.Length)
                                    {
                                        // Enviar datos a Data
                                        Data.updateSPO2(SPO2_WAVEdat);
                                        indexSPO2 = 0;
                                    }
                                    break;

                                case RESP_WAVE:
                                    RESP_WAVEval = data[0];
                                    RESP_WAVEdat[indexRESP] = RESP_WAVEval;
                                    indexRESP++;
                                    if (indexRESP == RESP_WAVEdat.Length)
                                    {
                                        // Enviar datos a Data
                                        Data.updateRESP(RESP_WAVEdat);
                                        indexRESP = 0;
                                    }
                                    break;

                                default:
                                    break;
                            }
                        }
                    }
                }
            }

            reading = false;
            return 0;
        }


        // Communication user --> board
        public const int NEONATE = 1;
        public const int CHILD = 2;
        public const int ADULT = 3;
        public static void sendNewPatientMode(int patientMode)
        {
            if (isPortOpen)
            {
                Byte[] buffer = new Byte[6];
                buffer[0] = 0x55;
                buffer[1] = 0xAA;
                buffer[2] = 0x04;
                buffer[3] = 0x09;
                switch (patientMode)
                {
                    case ADULT:
                        // Adult (default)
                        buffer[4] = 0x01;
                        buffer[5] = 0xF1;
                        break;
                    case CHILD:
                        // Child
                        buffer[4] = 0x02;
                        buffer[5] = 0xF2;
                        break;
                    case NEONATE:
                        // Neonate
                        buffer[4] = 0x03;
                        buffer[5] = 0xF3;
                        break;
                }

                port.Write(buffer, 0, 6);
            }
        }

        public static void enableECG(bool enable)
        {
            if (isPortOpen)
            {

                Byte[] buffer = new Byte[6];
                buffer[0] = 0x55;
                buffer[1] = 0xAA;
                buffer[2] = 0x04;
                buffer[3] = 0x01;
                if (enable == true)
                {
                    buffer[4] = 0x01;
                    buffer[5] = 0xF9;
                }
                else
                {
                    buffer[4] = 0x00;
                    buffer[5] = 0xFA;
                }
                port.Write(buffer, 0, 6);
            }
        }

        public static void enableSPO2(bool enable)
        {
            if (isPortOpen)
            {

                Byte[] buffer = new Byte[6];
                buffer[0] = 0x55;
                buffer[1] = 0xAA;
                buffer[2] = 0x04;
                buffer[3] = 0x03;
                if (enable == true)
                {
                    buffer[4] = 0x01;
                    buffer[5] = 0xF7;
                }
                else
                {
                    buffer[4] = 0x00;
                    buffer[5] = 0xF8;
                }
                port.Write(buffer, 0, 6);
            }
        }

        public static void enableTEMP(bool enable)
        {
            if (isPortOpen)
            {

                Byte[] buffer = new Byte[6];
                buffer[0] = 0x55;
                buffer[1] = 0xAA;
                buffer[2] = 0x04;
                buffer[3] = 0x04;
                if (enable == true)
                {
                    buffer[4] = 0x01;
                    buffer[5] = 0xF6;
                }
                else
                {
                    buffer[4] = 0x00;
                    buffer[5] = 0xF7;
                }
                port.Write(buffer, 0, 6);
            }
        }

        public const int GAINX025 = 1;
        public const int GAINX050 = 2;
        public const int GAINX100 = 3;
        public const int GAINX200 = 4;
        public static void setECGgain(int gain)
        {
            if (isPortOpen)
            {
                Byte[] buffer = new Byte[6];
                buffer[0] = 0x55;
                buffer[1] = 0xAA;
                buffer[2] = 0x04;
                buffer[3] = 0x07;
                switch (gain)
                {
                    case GAINX025:
                        // x0.25
                        buffer[4] = 0x01;
                        buffer[5] = 0xF3;
                        break;
                    case GAINX050:
                        // x0.5
                        buffer[4] = 0x02;
                        buffer[5] = 0xF2;
                        break;
                    case GAINX100:
                        // x1
                        buffer[4] = 0x03;
                        buffer[5] = 0xF1;
                        break;

                    case GAINX200:
                        buffer[4] = 0x04;
                        buffer[5] = 0xF0;
                        break;
                }
                port.Write(buffer, 0, 6);
            }

        }

        //operation mode，1 ~ 25Hz (3dB)
        //monitor mode，0.5 ~ 75Hz (3dB)
        //diagnose mode，0.05 ~ 100Hz (3dB)
        public const int OPERATION = 1;
        public const int MONITOR = 2;
        public const int DIAGNOSE = 3;
        public static void setECGfilter(int mode)
        {
            if (isPortOpen)
            {
                Byte[] buffer = new Byte[6];
                buffer[0] = 0x55;
                buffer[1] = 0xAA;
                buffer[2] = 0x04;
                buffer[3] = 0x08;
                switch (mode)
                {
                    case OPERATION:
                        // operation
                        buffer[4] = 0x01;
                        buffer[5] = 0xF2;
                        break;
                    case MONITOR:
                        // monitor
                        buffer[4] = 0x02;
                        buffer[5] = 0xF1;
                        break;
                    case DIAGNOSE:
                        // diagnose
                        buffer[4] = 0x03;
                        buffer[5] = 0xF0;
                        break;
                }
                port.Write(buffer, 0, 6);
            }

        }

        public static void setRESPgain(int gain)
        {
            if (isPortOpen)
            {
                Byte[] buffer = new Byte[6];
                buffer[0] = 0x55;
                buffer[1] = 0xAA;
                buffer[2] = 0x04;
                buffer[3] = 0x0F;
                switch (gain)
                {
                    case GAINX025:
                        // x0.25
                        buffer[4] = 0x01;
                        buffer[5] = 0xEB;
                        break;
                    case GAINX050:
                        // x0.5
                        buffer[4] = 0x02;
                        buffer[5] = 0xEA;
                        break;
                    case GAINX100:
                        // x1
                        buffer[4] = 0x03;
                        buffer[5] = 0xE9;
                        break;

                    case GAINX200:
                        buffer[4] = 0x04;
                        buffer[5] = 0xE8;
                        break;
                }
                port.Write(buffer, 0, 6);
            }

        }

        public static void enableECGwave(bool enable) {
            if (isPortOpen)
            {
                Byte[] buffer = new Byte[6];
                buffer[0] = 0x55;
                buffer[1] = 0xAA;
                buffer[2] = 0x04;
                buffer[3] = 0xFB;
                if (enable == true)
                {
                    buffer[4] = 0x01;
                    buffer[5] = 0xFF;
                }
                else
                {
                    buffer[4] = 0x00;
                    buffer[5] = 0x00;
                }
                port.Write(buffer, 0, 6);
            }
        }

        public static void enableSPO2wave(bool enable) {
            if (isPortOpen)
            {
                Byte[] buffer = new Byte[6];
                buffer[0] = 0x55;
                buffer[1] = 0xAA;
                buffer[2] = 0x04;
                buffer[3] = 0xFE;
                if (enable == true)
                {
                    buffer[4] = 0x01;
                    buffer[5] = 0xFC;
                }
                else
                {
                    buffer[4] = 0x00;
                    buffer[5] = 0xFD;
                }
                port.Write(buffer, 0, 6);
            }
        }
    
        public static void enableRESPwave(bool enable) {
            if (isPortOpen)
            {
                Byte[] buffer = new Byte[6];
                buffer[0] = 0x55;
                buffer[1] = 0xAA;
                buffer[2] = 0x04;
                buffer[3] = 0xFF;
                if (enable == true)
                {
                    buffer[4] = 0x01;
                    buffer[5] = 0xFB;
                }
                else
                {
                    buffer[4] = 0x00;
                    buffer[5] = 0xFC;
                }
                port.Write(buffer, 0, 6);
            }
        }    

    }

}