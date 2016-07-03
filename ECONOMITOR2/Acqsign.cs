
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;



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

        const int ECG_WAVEfreq = 250;
        const int ECG_PARAMfreq = 1;
        const int NIBP_PARAMfreq = 2;
        const int SPO2_PARAMfreq = 1;
        const int TEMPfreq = 1;
        const int SPO2_WAVEfreq = 50;
        const int RESP_WAVEfreq = 50;

        const int TIME = 1;

        static int[] ECG_WAVEdat = new int[TIME * ECG_WAVEfreq];
        static int[] ECG_PARAMdat = new int[TIME *ECG_PARAMfreq];
        static int[] NIBP_PARAMdat = new int[TIME *NIBP_PARAMfreq];
        static int[] SPO2_PARAMdat = new int[TIME *SPO2_PARAMfreq];
        static int[] TEMPdat = new int[TIME *TEMPfreq];
        static int[] SPO2_WAVEdat = new int[TIME *SPO2_WAVEfreq];
        static int[] RESP_WAVEdat = new int[TIME *RESP_WAVEfreq];

        static bool flagPaquete = false;

        static int package_length;

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


        // Lee la cantidad de bytes que se le indique
        private static int[] manyacq(int cant)
        {
            int[] arreglo = new int[cant];

            for (int i = 0; i < cant; i++)
            {
                arreglo[i] = port.ReadByte();
            }
            return arreglo;
        }


        // Funcion para identificar entrada -> 55 aa
        private static bool initpaquete() {
            if (port.ReadByte() == 85)
            {
                if (port.ReadByte() == 170)
                {
                    flagPaquete = true;
                }
                else {
                    flagPaquete = false;
                }
            }
            else {
                flagPaquete = false;
            }
            return flagPaquete;
        }


        // Funcion para identificar tipo de paquete -> devuelve byte de tipo

        private static int tipopaquete() {
            package_length = port.ReadByte();
            return package_length;
        }



        // Para devolver valores(tipo) -> switch
        
        static int ECG_WAVEindex = 0;
        
        private static void armarpaquete(){
            

            while (initpaquete())
            {

                int tiposenal = tipopaquete();

                switch (tiposenal)
                {
                    case ECG_WAVE:
                        
                        ECG_WAVEdat[ECG_WAVEindex] = port.ReadByte();
                        ECG_WAVEindex++;

                        if (ECG_WAVEindex > 250) { 
                            ECG_WAVEindex = 0;
                        }

                        break;


                    case ECG_PARAM:
                        break;
                    case NIBP_PARAM:
                        break;
                    case SPO2_PARAM:
                        break;
                    case TEMP:
                        break;

                    case SOFT_VERSION:

                        break;
                    case HARD_VERSION:
                        break;
                    case SPO2_WAVE:
                        break;
                    case RESP_WAVE:
                        break;

                }
            }
            
            }

    //private static int armarpaquete(){
    //        int package_length;
    //        int checksum;

    //        int ECG_WAVEsig;

    //        while (port.ReadByte() != 85){              //verifica primer byte de header
    //            ;
    //        }

    //        if (port.ReadByte() == 170){                //verifica segundo
                	
    //            package_length = port.ReadByte();				 
    //            int[] vector = new int[package_length];

    //            int tiposenal = port.ReadByte();

    //            switch (tiposenal){
							 
    //                case ECG_WAVE:
						                  
    //                    ECG_WAVEsig = port.ReadByte();                                       
    //                    return ECG_WAVEsig;   
                        						
    //                case ECG_PARAM:
    //                    return 0;
                      
						
    //                case NIBP_PARAM:
    //                    return 0;
					
    //                case SPO2_PARAM:
    //                    return 0;
                        
    //                case TEMP:
    //                    return 0;
                    
    //                case SOFT_VERSION:
    //                    return 0;
                      
    //                case HARD_VERSION:
    //                    return 0;
                      
    //                case SPO2_WAVE:
    //                    return 0;
                      
    //                case RESP_WAVE:
    //                    return 0; 
                      
    //                default:
    //                    return 0;
						 								                        
    //            }
                
    //            //checksum = port.ReadByte();

    //        }
    //        return 0;
           
          
    //     }


        //public static int[] tedoyECG(int longitud) {

        //    for (int i = 0; i < longitud; i++) {
        //        ECG_WAVEdat[i] = armarpaquete();
        //    }
        //    return ECG_WAVEdat;

        
        //}
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

