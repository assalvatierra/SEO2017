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
    public partial class FormInbox : Form
    {
        private ISMSSender LabSys;
        private SMSFactory SMS = new ConcreteSMSFactory();

        public FormInbox()
        {
            InitializeComponent();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
             
            //get list of new messages
            LabSys = SMS.GetSystem("Laboratory");
            DataTable MessageList = LabSys.GetListing();
            dataGridView1.DataSource = MessageList;
        }
    }
}
