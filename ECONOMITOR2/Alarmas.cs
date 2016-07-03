using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECONOMITOR2
{
    class Alarmas
    {
        public static void Alarma_ECG()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Users\Sebastian\Documents\HomeroDOH.mp3");
            player.Play();
            Console.Write("Hello, World!");
        }

       
    }
    
}
