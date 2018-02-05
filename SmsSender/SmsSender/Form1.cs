using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SmsSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SMSCOMMS SMSEngine = new SMSCOMMS("COM18");
            SMSEngine.Open();
            SMSEngine.SendSMS("09193812657", "Message from c# - " + System.DateTime.Now.ToString("MMM-dd-yyyy hh:mm:ss"));
            SMSEngine.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GSMSender gsm1 = new GSMSender();

            gsm1.SendSms("09193812657", "Message from c# - " + System.DateTime.Now.ToString("MMM-dd-yyyy hh:mm:ss"));

        }
    }
}
