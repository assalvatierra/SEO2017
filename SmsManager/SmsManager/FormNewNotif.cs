using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmsManager
{
    public partial class FormNewNotif : Form
    {
        private ISMSSender LabSys;
        private SMSFactory SMS = new ConcreteSMSFactory();

        public FormNewNotif()
        {
            InitializeComponent();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            string recipient = RecipientTextBox.Text.ToString();
            string message =MessagetextBox.Text.ToString();
            string dateSending = Datepicker.Value.ToShortDateString() ;
            string timesending = timeTextBox1.Text.ToString();
            string dtSending = dateSending+" "+timesending;
            string type = typeDropdown.selectedValue.ToString() ;

            //get list of new messages
            LabSys = SMS.GetSystem("Laboratory");
            LabSys.setNewNotification(type,recipient,message,dtSending);
            Console.WriteLine("new notification added");

        }
    }
}
