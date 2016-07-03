
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;



namespace ECONOMITOR2
{


    //static const int ECG_WAVE = 1;
    //static const int ECG_PARAM = 2;
    //static const int NIBP_PARAM = 3;
    //static const int SPO2_PARAM = 4;
    //static const int TEMP = 5;
    //static const int SOFT_VERSION = 252;
    //static const int HARD_VERSION = 253;
    //static const int SPO2_WAVE = 254;
    //static const int RESP_WAVE = 255;

    //static const int ECG_WAVEfreq = 250;
    //static const int ECG_PARAMfreq = 1;
    //static const int NIBP_PARAMfreq = 2;
    //static const int SPO2_PARAMfreq = 1;
    //static const int TEMPfreq = 1;
    //static const int SPO2_WAVEfreq = 50;
    //static const int RESP_WAVEfreq = 50;


    public class Acqsign
    {

        private int tipo_de_variable;

        private static int varAd = 1;
        private static SerialPort port;

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
        public static void close()
        {
            try
            {
                port.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
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

