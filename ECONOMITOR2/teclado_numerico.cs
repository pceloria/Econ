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
    public partial class teclado_numerico : Form
    {
        String oldAlarm;
        String newAlarm;
        TextBox currentTB;
        int maxLength = 5;

        public teclado_numerico(TextBox currentTB)
        {
            InitializeComponent();
            this.currentTB = currentTB;
            oldAlarm = this.currentTB.Text;
            newAlarm = "";

            int parentCenterX = currentTB.Parent.Location.X + currentTB.Parent.Width / 2;
            int centerY = currentTB.Location.Y + currentTB.Parent.Location.Y - Height / 2;
            int offsetX = currentTB.Parent.Width / 2 - currentTB.Location.X;
            if (currentTB.Location.X < currentTB.Parent.Width / 2)
                Location = new Point(parentCenterX - offsetX + currentTB.Width,
                                     centerY);
            else
                Location = new Point(parentCenterX - Width - offsetX,
                                     centerY);
        }

        private void numberClick(object sender, EventArgs e)
        {
            if (newAlarm.Length < maxLength)
            {
                newAlarm += ((Button)sender).Text;
                currentTB.Text = newAlarm;
            }
                
        }

        private void dotClick(object sender, EventArgs e)
        {
            if (newAlarm.Length < maxLength)
            {
                if (!(System.Text.RegularExpressions.Regex.IsMatch(newAlarm, "(\\.)")))
                {
                    newAlarm += ((Button)sender).Text;
                    currentTB.Text = newAlarm;
                }
                
            }
        }

        private void deleteClick(object sender, EventArgs e)
        {
            if (newAlarm.Length > 0)
            {
                newAlarm = newAlarm.Substring(0, newAlarm.Length - 1);
                currentTB.Text = newAlarm;
            }
                
        }

        private void enterClick(object sender, EventArgs e)
        {

            this.Close();
        }

        private void discardClick(object sender, EventArgs e)
        {
            currentTB.Text = oldAlarm;
            this.Close();
        }
    }
}
