
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

        private static int ECG_Wave_Amplitud;

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
        private static int TEMPval;
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
        const double TIMEpackage = 0.1;

        static int[] ECG_WAVEdat = new int[(int)(TIMEpackage * ECG_WAVEfreq)];
        static int[] ECG_PARAMdat = new int[TIME * ECG_PARAMfreq];
        static int[] NIBP_PARAMdat = new int[TIME * NIBP_PARAMfreq];
        static int[] SPO2_PARAMdat = new int[TIME * SPO2_PARAMfreq];
        static int[] TEMPdat = new int[TIME * TEMPfreq];
        static int[] SPO2_WAVEdat = new int[(int)(TIMEpackage * SPO2_WAVEfreq)];
        static int[] RESP_WAVEdat = new int[(int)(TIMEpackage * RESP_WAVEfreq)];

        static int indexECG = 0;
        static int indexSPO2 = 0;
        static int indexRESP = 0;

        static bool flagPaquete = false;
        public static bool isPortOpen = false;
        static int package_length;
        static bool reading = false;
        private static SerialPort port;

        // Incia la comunicación con el puerto serie que se elige 
        public static void init(String portName)
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

                    //string indata = port.ReadExisting();
                    //Console.WriteLine("Data Received");
                    //Console.Write(indata);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Se debe asignar el nombre del puerto que se desea leer", "Error");
            }

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
            else
            {
                Console.WriteLine("Procesando paquetes. Bytes acumulados = " + byteCount);
            }
            
        }


        //// Funcion para identificar entrada -> 55 aa
        //private static bool initpaquete()
        //{
        //    if (port.ReadByte() == 85)
        //    {
        //        if (port.ReadByte() == 170)
        //        {
        //            flagPaquete = true;
        //        }
        //        else
        //        {
        //            flagPaquete = false;
        //        }
        //    }
        //    else
        //    {
        //        flagPaquete = false;
        //    }
        //    return flagPaquete;
        //}


        //// Funcion para identificar tipo de paquete -> devuelve byte de tipo

        //private static int tipopaquete()
        //{
        //    package_length = port.ReadByte();
        //    return package_length;
        //}



        //// Para devolver valores(tipo) -> switch

        //static int ECG_WAVEindex = 0;

        //private static void armarpaquete()
        //{


        //    while (initpaquete())
        //    {

        //        int tiposenal = tipopaquete();

        //        switch (tiposenal)
        //        {
        //            case ECG_WAVE:

        //                ECG_WAVEdat[ECG_WAVEindex] = port.ReadByte();
        //                ECG_WAVEindex++;

        //                if (ECG_WAVEindex > 250)
        //                {
        //                    ECG_WAVEindex = 0;
        //                }

        //                break;


        //            case ECG_PARAM:
        //                break;
        //            case NIBP_PARAM:
        //                break;
        //            case SPO2_PARAM:
        //                break;
        //            case TEMP:
        //                break;

        //            case SOFT_VERSION:

        //                break;
        //            case HARD_VERSION:
        //                break;
        //            case SPO2_WAVE:
        //                break;
        //            case RESP_WAVE:
        //                break;

        //        }
        //    }

        //}

        private static int armarPaquetes(int BytesToRead)
        {
            int package_length;
            int checksum;

 
            reading = true;
            int bytesRead = 0;

            while (bytesRead < BytesToRead) {

                bytesRead++;
                if (port.ReadByte() == 85)
                {              //verifica primer byte de header asd
                    bytesRead++;
                    if (port.ReadByte() == 170)
                    {                //verifica segundo
                        bytesRead++;
                        package_length = port.ReadByte();
                        int[] data = new int[package_length];
                        bytesRead++;
                        int tiposenal = port.ReadByte();

                        for(int i = 0; i<package_length-3; i++){
                            bytesRead++;
                            data[i] = port.ReadByte();                           
                        }

                        switch (tiposenal)
                        {
                        case ECG_WAVE:
                            ECG_Wave_Amplitud = data[0];
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
                            TEMPval = TEMP1_Integral + TEMP1_Decimal / 10;
                            Data.updateTemperatura(TEMPval);
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
                        bytesRead++;
                        checksum = port.ReadByte();
                        // Si esta todo bien hay que derivar el dato que se leyo
                    }
                }
            }

            reading = false;
            return 0;
        }


    }
}



//    port.ReadByte()

//    private static void aq(){

//        if (){

//        switch(varAd){
//            case 1:
//                data.updatetemperatura(100);
//                break;
//            case 2:
//                addecgdata(valor);
//                if (full)
//                    data.updateecg();
//                break;
//            default:
//                break;


//        }
//    }
//}

