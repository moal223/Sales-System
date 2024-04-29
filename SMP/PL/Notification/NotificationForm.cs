using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMP.PL.Notification
{
    public partial class NotificationForm : Form
    {

        public NotificationForm(string message, Color color)
        {
            InitializeComponent();
            this.labelTitle.Text = message;
            this.labelTitle.BackColor = color;
            this.timerNotification.Interval = Properties.Settings.Default.HideNotifiInterval;
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void timerNotification_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
