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
            private static double low_temperatura = 34;
            private static double high_temperatura = 39;
            private static int low_HR = 40;
            private static int high_HR = 150;
            private static int low_RR = 3;
            private static int high_RR = 15;
            private static int low_Spo2 = 95;
            public static Boolean flag_alarma = true;
            private static System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            public static Stream audio_HR = Properties.Resources.audio_HR;
            private static Stream audio_RR = Properties.Resources.audio_RR;
            private static Stream audio_NIBP = Properties.Resources.audio_NIBP;
            private static Stream audio_spo2 = Properties.Resources.audio_spo2;
            private static Stream audio_temp = Properties.Resources.audio_temp;
            public static int counter1;
            public static int counter_color;
            public static Boolean flag_color = true;

            public static Boolean flag_RR_enable = false;
            public static Boolean flag_HR_enable = false;
            public static Boolean flag_SpO2_enable = false;
            public static Boolean flag_TEMP_enable = false;

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
        public static int get_low_Spo2()
        {
            return low_Spo2;
        }

        // setters
        public static void set_low_HR(System.Windows.Forms.TextBox text)
        {
            low_HR = Convert.ToInt32(text.Text);
        }
        public static void set_high_HR(System.Windows.Forms.TextBox text)
        {
            high_HR = Convert.ToInt32(text.Text);
            
        }
        public static void set_low_RR(System.Windows.Forms.TextBox text)
        {
            low_RR = Convert.ToInt32(text.Text);
        }
        public static void set_high_RR(System.Windows.Forms.TextBox text)
        {
            high_RR = Convert.ToInt32(text.Text);
        }
        public static void set_low_Spo2(System.Windows.Forms.TextBox text)
        {
            low_Spo2 = Convert.ToInt32(text.Text);
        }
        public static void set_high_temperatura(System.Windows.Forms.TextBox text)
        {
            high_temperatura = Convert.ToDouble(text.Text);
        }
        public static void set_low_temperatura(System.Windows.Forms.TextBox text)
        {
            low_temperatura = Convert.ToDouble(text.Text);
        }


        public static void toma_de_decisiones(int currentHR, int currentRR, double currentTemperatura,
                                                int currentSpo2,
                                                System.Windows.Forms.TextBox text_HR,
                                                System.Windows.Forms.TextBox text_RR, 
                                                System.Windows.Forms.TextBox text_spo2, 
                                                System.Windows.Forms.TextBox text_temp)
        {
            //low_HR
            if (currentHR < low_HR && flag_HR_enable) 
            {
                if (flag_alarma == true)
                { 
                    sonarAlarma(audio_HR);
                }
                if (flag_color == true)
                {
                    text_HR.BackColor = System.Drawing.Color.Red;
                    flag_color = false;
                }
                else
                {
                    text_HR.BackColor = System.Drawing.Color.Yellow;
                    flag_color = true;
                }
                
            }
            else
            {
                text_HR.BackColor = System.Drawing.Color.White;
            }

            //high_HR
            if (currentHR > high_HR && flag_HR_enable)
            {
                if (flag_alarma == true)
                {
                    sonarAlarma(audio_HR);
                }
                text_HR.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                text_HR.BackColor = System.Drawing.Color.White;
            }

            //low_RR
            if (currentRR < low_RR && flag_RR_enable)
            {
                if (flag_alarma == true)
                {
                    sonarAlarma(audio_RR);
                }
                text_RR.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                text_RR.BackColor = System.Drawing.Color.White;
            }

            //high_RR
            if (currentRR > high_RR && flag_RR_enable)
            {
                if (flag_alarma == true)
                {
                    sonarAlarma(audio_RR);
                }
                text_RR.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                text_RR.BackColor = System.Drawing.Color.White;
            }

           //low_SpO2
            if (currentSpo2 < low_Spo2 && flag_SpO2_enable)
            {
                if (flag_alarma == true)
                {
                    sonarAlarma(audio_spo2);
                }
                text_spo2.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                text_spo2.BackColor = System.Drawing.Color.White;
            }

            //low_temperatura
            if (currentTemperatura < low_temperatura && flag_TEMP_enable)
            {
                if (flag_alarma == true)
                {
                    sonarAlarma(audio_temp);
                }
                text_temp.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                text_temp.BackColor = System.Drawing.Color.White;
            }
            //high_temperatura
            if (currentTemperatura > high_temperatura && flag_TEMP_enable)
            {
                if (flag_alarma == true)
                {
                    sonarAlarma(audio_temp);
                }
                text_temp.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                text_temp.BackColor = System.Drawing.Color.White;
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
