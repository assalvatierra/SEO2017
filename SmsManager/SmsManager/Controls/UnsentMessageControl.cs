using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmsManager.Controls
{
    public partial class UnsentMessageControl : UserControl
    {
        public string notificationID = "0";
        public UnsentMessageControl()
        {
            InitializeComponent();
        }

        public void setInfo(string id,string recipient,string message,string datetime)
        {
            notificationID = id;
            recipientlabel.Text = recipient;
            Messagelabel.Text = message;
            DateTimelabel.Text = datetime;
        }

        public string getnotificationID()
        {
            return notificationID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //perform sending
            //update notificaiton logs
            //remove this item
        }

        private void UnsentMessageControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSkyBlue;
        }

        private void UnsentMessageControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

        }

        private void UnsentMessageControl_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSkyBlue;

        }

        private void UnsentMessageControl_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSkyBlue;

        }
    }
}
