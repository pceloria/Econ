using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;


namespace ECONOMITOR2
{
    class Alarmas
    {

            // inicializo los vectores a graficar
            private static double low_temperatura = 36;
            private static double high_temperatura = 39;
            private static int low_HR = 50;
            private static int high_HR = 200;
            private static int low_RR = 30;
            private static int high_RR = 90;
            private static int low_Spo2 = 95;
            private static int low_NIBP = 70;
            private static int high_NIBP = 140;
            public static Boolean flag_alarma = true;
            private static System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            public static Stream audio_HR = Properties.Resources.audio_HR;
            private static Stream audio_RR = Properties.Resources.audio_RR;
            private static Stream audio_NIBP = Properties.Resources.audio_NIBP;
            private static Stream audio_spo2 = Properties.Resources.audio_spo2;
            private static Stream audio_temp = Properties.Resources.audio_temp;
            public static int counter1;

        //getters
        public static double get_low_temperatura()
        {
            return low_temperatura;
        }

        public static double get_high_temperatura()
        {
            return high_temperatura;
        }

        public static int get_low_HR()
        {
            return low_HR;
        }

        public static int get_high_HR()
        {
            return high_HR;
        }

        public static int get_low_RR()
        {
            return low_RR;
        }

        public static int get_high_RR()
        {
            return high_RR;
        }

        public static int get_low_NIBP()
        {
            return low_NIBP;
        }

        public static int get_high_NIBP()
        {
            return high_NIBP;
        }
        public static int get_low_Spo2()
        {
            return low_Spo2;
        }

        // setters
        public static void set_low_HR(System.Windows.Forms.TextBox text)
        {
            if (text.Text != "")
            {
                low_HR = Convert.ToInt32(text.Text);
            }
        }

        public static void set_high_HR(System.Windows.Forms.TextBox text)
        {
            if (text.Text != "") { 
                high_HR = Convert.ToInt32(text.Text);
            }
            else
            {
                high_HR = 500;
            }
        }

        public static void set_low_RR(System.Windows.Forms.TextBox text)
        {
            if (text.Text != "")
            {
                low_RR = Convert.ToInt32(text.Text);
            }
        }

        public static void set_high_RR(System.Windows.Forms.TextBox text)
        {
            if (text.Text != "")
            {
                high_RR = Convert.ToInt32(text.Text);
            }
            else
            {
                high_RR = 600;
            }
        }

        public static void set_low_Spo2(System.Windows.Forms.TextBox text)
        {
            if (text.Text != "")
            {
                low_Spo2 = Convert.ToInt32(text.Text);
            }
        }

        public static void set_low_NIBP(System.Windows.Forms.TextBox text)
        {
            if (text.Text != "")
            {
                low_NIBP = Convert.ToInt32(text.Text);
            }
        }

        public static void set_high_NIBP(System.Windows.Forms.TextBox text)
        {
            if (text.Text != "")
            {
                high_NIBP = Convert.ToInt32(text.Text);
            }
            else
            {
                high_NIBP = 600;
            }
        }

        public static void set_high_temperatura(System.Windows.Forms.TextBox text)
        {
            if (text.Text != "")
            {
                high_temperatura = Convert.ToDouble(text.Text);
            }
            else
            {
                high_temperatura = 600;
            }
        }

        public static void set_low_temperatura(System.Windows.Forms.TextBox text)
        {
            if (text.Text != "")
            {
                low_temperatura = Convert.ToDouble(text.Text);
            }
        }

        public static void toma_de_decisiones(int currentHR, int currentRR, double currentTemperatura, 
            int currentDiastolica, int currentSistolica, int currentSpo2, System.Windows.Forms.TextBox text_low_HR,
            System.Windows.Forms.TextBox text_high_HR, System.Windows.Forms.TextBox text_low_RR, System.Windows.Forms.TextBox text_high_RR,
            System.Windows.Forms.TextBox text_low_spo2, System.Windows.Forms.TextBox text_low_temp, System.Windows.Forms.TextBox text_high_temp,
            System.Windows.Forms.TextBox text_low_NIBP, System.Windows.Forms.TextBox text_high_NIBP)
        {
            if (currentHR < low_HR)
            {
                if (flag_alarma == true)
                { 
                sonarAlarma(audio_HR);
                }
                text_low_HR.BackColor = System.Drawing.Color.Red;

                //Boolean color = true;
                //if (color == true)
                //{ 
                //    text_low_HR.BackColor = System.Drawing.Color.Red;
                //    color = false;
                //}
                //if (color == false)
                //{
                //    text_low_HR.BackColor = System.Drawing.Color.HotPink;
                //    color = true;
                //}
            }
            else
            {
                text_low_HR.BackColor = System.Drawing.Color.White;
            }

            if (currentHR > high_HR)
            {
                if (flag_alarma == true)
                {
                    sonarAlarma(audio_HR);
                }
                text_high_HR.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                text_high_HR.BackColor = System.Drawing.Color.White;
            }

            if (currentRR < low_RR)
            {
                if (flag_alarma == true)
                {
                    sonarAlarma(audio_RR);
                }
                text_low_RR.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                text_low_RR.BackColor = System.Drawing.Color.White;
            }

            if (currentRR > high_RR)
            {
                if (flag_alarma == true)
                {
                    sonarAlarma(audio_RR);
                }
                text_high_RR.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                text_high_RR.BackColor = System.Drawing.Color.White;
            }

            if (currentDiastolica < low_NIBP)
            {
                if (flag_alarma == true)
                {
                    sonarAlarma(audio_NIBP);
                }
                text_low_NIBP.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                text_low_NIBP.BackColor = System.Drawing.Color.White;
            }

            if (currentSistolica > high_NIBP)
            {
                if (flag_alarma == true)
                {
                    sonarAlarma(audio_NIBP);
                }
                text_high_NIBP.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                text_high_NIBP.BackColor = System.Drawing.Color.White;
            }

            if (currentSpo2 < low_Spo2)
            {
                if (flag_alarma == true)
                {
                    sonarAlarma(audio_spo2);
                }
                text_low_spo2.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                text_low_spo2.BackColor = System.Drawing.Color.White;
            }

            if (currentTemperatura < low_temperatura)
            {
                if (flag_alarma == true)
                {
                    sonarAlarma(audio_temp);
                }
                text_low_temp.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                text_low_temp.BackColor = System.Drawing.Color.White;
            }

            if (currentTemperatura > high_temperatura)
            {
                if (flag_alarma == true)
                {
                    sonarAlarma(audio_temp);
                }
                text_high_temp.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                text_high_temp.BackColor = System.Drawing.Color.White;
            }


        }

        public static void sonarAlarma(Stream str)
        {
           
            str.Position = 0;     // Manually rewind stream 
            player.Stream = null;    // Then we have to set stream to null 
            player.Stream = str;  // And set it again, to force it to be loaded again... 
            player.Play();          // Yes! We can play the sound! 

        }

        public static void silenciarAlarma()
        {
            flag_alarma = false;
            player.Stop();
            counter1 = 0;
        }
    }

}
