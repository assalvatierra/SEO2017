using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmsManager.Controls;

namespace SmsManager
{
    public partial class FormOverview : Form
    {
        private ISMSSender LabSys;
        private SMSFactory SMS = new ConcreteSMSFactory();

        public FormOverview()
        {
            InitializeComponent();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {

            string messageStatus = "Sent";
            string recipient = "";
            string message = "";
            string notificationID = "";
            string sentDate = DateTime.Now.ToString();
            Console.WriteLine("SEND BUTTON");
            //insert at timer method

            //check db for new message list

            //get list of new messages
            LabSys = SMS.GetSystem("Laboratory");
            DataTable MessageList = LabSys.GetUnsentItems();
            dataGridView2.DataSource = MessageList;

            //convert datasource to list
            List<DataRow> Messagelist = MessageList.AsEnumerable().ToList();

            foreach (DataRow row in MessageList.Rows)
            {
                //Console.WriteLine(row["id"]);
                //Console.WriteLine(row["RecType"]);
                //Console.WriteLine(row["Recipient"]);
                //Console.WriteLine(row["Message"]);
                //Console.WriteLine(row["DTSending"]);
                //Console.WriteLine(row["RefId"]);
                //Console.WriteLine(row["RefTable"]);

                notificationID = row["id"].ToString();
                recipient = row["Recipient"].ToString();
                message = row["Message"].ToString();

                //messageStatus = LabSys.SendSMS(recipient, message); //uncomment to enable sending
               
                //inset new activity log
                LabSys.SetActivityLog(notificationID, messageStatus, "none");
                
               // break;
            }
        }

        int count=0;
        int top = 0;
        int left = 0;
        private void refreshbutton_Click(object sender, EventArgs e)
        {
            //get list of new messages
            string messageStatus = "";
            LabSys = SMS.GetSystem("Laboratory");
            DataTable MessageList = LabSys.GetDetails("0");
            //dataGridView1.DataSource = MessageList;

            //convert datasource to list
            List<DataRow> Messagelist = MessageList.AsEnumerable().ToList();

            foreach (DataRow row in MessageList.Rows)
            {

                string notificationID = row["id"].ToString();
                string RecType   = row["RecType"].ToString();
                string recipient = row["Recipient"].ToString();
                string DTSending = row["DTSending"].ToString();
                string message   = row["Message"].ToString();
                dataGridView1.Rows.Add(DTSending,RecType,recipient,message);
                
            }


        }

        public int time = 0;
        public int timeLimit = 1000;
        private void smstimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(time);

            string messageStatus = "Sent";
            string recipient = "";
            string message = "";
            string notificationID = "";
            string sendingDate = "";

            DateTime date1;
            string sentDate = DateTime.Now.ToString();

            //get list of new messages
            LabSys = SMS.GetSystem("Laboratory");
            DataTable MessageList = LabSys.GetUnsentItems();
            dataGridView2.DataSource = MessageList;

            try
            {

                //convert datasource to list
                List<DataRow> Messagelist = MessageList.AsEnumerable().ToList();

                foreach (DataRow row in MessageList.Rows)
                {
                    notificationID = row["id"].ToString();
                    recipient = row["Recipient"].ToString();
                    message = row["Message"].ToString();
                    sendingDate = row["DTSending"].ToString();

                    //get date and time today
                    date1 = Convert.ToDateTime(sendingDate);

                    if (date1 <= DateTime.Now)
                    {
                        Console.WriteLine(date1 + " - DATE TIME LESS THAN TODAY");
                        //messageStatus = LabSys.SendSMS(recipient, message); //uncomment to enable sending
                        //inset new activity log
                        LabSys.SetActivityLog(notificationID, messageStatus, "none");
                    }
                    else if(date1 > DateTime.Now)
                    {
                        Console.WriteLine(date1 + " - DATE TIME GREATER THAN TODAY");
                    }
                
                
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("SMS Manager cannot connect to the server.");
            }
            
            time++;
        }

        private void FormOverview_Load(object sender, EventArgs e)
        {
            smstimer.Enabled = false; //enable timer
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (smstimer.Enabled == true)
            {
                smstimer.Enabled = false; //disable timer
            }
            else
            {
                smstimer.Enabled = true; //enable timer
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
