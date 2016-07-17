using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECONOMITOR2
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            // Se inicia el timer si se logro abrir el puerto
            WelcomeTimer.Tick += new EventHandler(Welcome_Tick);  // Everytime timer ticks, timer_Tick will be called
            WelcomeTimer.Interval = (3000);                     // Timer will tick evert second
            WelcomeTimer.Enabled = true;                       // Enable the timer
            WelcomeTimer.Start();                              // Start the timer
        }

        private void Welcome_Tick(object sender, EventArgs e)
        {
            WelcomeTimer.Stop();
            Close();
        }
    }
}
