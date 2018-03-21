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
            sendbutton.Hide();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            UpdateAndSentMessages();
        }

        int count=0;
        int top = 0;
        int left = 0;

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            //get list of new messages
            LabSys = SMS.GetSystem("Laboratory");
            DataTable MessageList = LabSys.GetDetails();
            //dataGridView1.DataSource = MessageList;

            sendbutton.Hide();

            //clear table
            dataGridView1.Rows.Clear();

            //convert datasource to list
            List<DataRow> Messagelist = MessageList.AsEnumerable().ToList();

            foreach (DataRow row in MessageList.Rows)
            {

                string notificationID = row["id"].ToString();
                string RecType = row["RecType"].ToString();
                //string recipient = row["Recipient"].ToString();
                string DTSending = row["DTSending"].ToString();
                string message = row["Message"].ToString();

                dataGridView1.Rows.Add(notificationID, DTSending, RecType, message);

            }
            
        }

        #region "AutoSend Timer"
        public int time = 0;
        public int timeLimit = 1000;

        private void UpdateAndSentMessages()
        {

            string messageStatus = "Sent";
            string recipient = "";
            string message = "";
            string notificationRecipientID = "";
            string sendingDate = "";
            string notificationID = "";

            DateTime date1;
            string sentDate = DateTime.Now.ToString();

            //clear table
            dataGridView2.Rows.Clear();

            //get list of new messages
            LabSys = SMS.GetSystem("Laboratory");
            DataTable MessageList = LabSys.GetUnsentItems();
            //dataGridView2.DataSource = MessageList;

            try
            {

                //convert datasource to list
                List<DataRow> Messagelist = MessageList.AsEnumerable().ToList();

                foreach (DataRow row in MessageList.Rows)
                {
                    notificationRecipientID = row["Id"].ToString();
                    notificationID = row["Id"].ToString();
                    recipient = row["ContactInfo"].ToString();
                    message = row["Message"].ToString();
                    sendingDate = row["DTSending"].ToString();

                    dataGridView2.Rows.Add(sendingDate, notificationID,  recipient, message);


                    //get date and time today
                    date1 = Convert.ToDateTime(sendingDate);

                    if (date1 <= DateTime.Now)
                    {
                        Console.WriteLine(date1 + " - DATE TIME LESS THAN TODAY - ACTION SEND AND LOG");
                        // messageStatus = LabSys.SendSMS(recipient, message); //uncomment to enable sending
                        //inset new activity log
                        //LabSys.updateActivityLog(notificationRecipientID, messageStatus, "none");
                        // update activity log
                    }
                    else if (date1 > DateTime.Now)
                    {
                        Console.WriteLine(date1 + " - DATE TIME GREATER THAN TODAY - ACTION IGNORE");
                    }

                }


                DataTable FailedList = LabSys.FailedItems();

                List<DataRow> Failedlist = FailedList.AsEnumerable().ToList();
                Console.WriteLine("GETTING FAILED LISTS");
                foreach (DataRow row in FailedList.Rows)
                {
                    notificationRecipientID = row["Id"].ToString();
                    notificationID = row["NotificationId"].ToString();
                    recipient = row["ContactInfo"].ToString();
                    message = row["Message"].ToString();
                    sendingDate = row["DTSending"].ToString();

                    dataGridView2.Rows.Add(sendingDate, notificationID, recipient, message);
                    Console.WriteLine(notificationRecipientID);

                    //check multiple entries on recipientID
                    //DataTable FailedListID = LabSys.GetLogByRecipientIdList_Failed(int.Parse(notificationRecipientID));

                    ////get date and time today
                    //date1 = Convert.ToDateTime(sendingDate);

                    //if (date1 <= DateTime.Now)
                    //{
                    //    Console.WriteLine(date1 + " - DATE TIME LESS THAN TODAY - ACTION SEND AND LOG");
                    //    messageStatus = LabSys.SendSMS(recipient, message); //uncomment to enable sending
                    //    //inset new activity log
                    //   LabSys.updateActivityLog(notificationRecipientID, messageStatus, "none");

                    //}
                    //else if (date1 > DateTime.Now)
                    //{
                    //    Console.WriteLine(date1 + " - DATE TIME GREATER THAN TODAY - ACTION IGNORE");
                    //}

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("SMS Manager cannot connect to the server. " + ex.ToString());
            }
        }

        private void smstimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(time);

            UpdateAndSentMessages();

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
        #endregion

        #region "datagrid cell select and display at info panel"
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            sendbutton.Hide();
            //get list of new messages
            LabSys = SMS.GetSystem("Laboratory");

            //select item in the table
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;
            //int notificationId = int.Parse(dataGridView1.Rows[rowindex].Cells[0].ToString());

            // DataTable RecipientsList = LabSys.GetRecipientsList(1);
            //Console.WriteLine(RecipientsList);
            //column index guide 
            // 0 = id
            // 1 = date
            // 2 = type
            // 3 = content

            DetailsDateSending.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            DetailsRecipients.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            DetailsContent.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            sendbutton.Hide();
            //get list of new messages
            LabSys = SMS.GetSystem("Laboratory");

            //select item in the table
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;
            //int notificationId = int.Parse(dataGridView1.Rows[rowindex].Cells[0].ToString());

            // DataTable RecipientsList = LabSys.GetRecipientsList(1);
            //Console.WriteLine(RecipientsList);
            //column index guide 
            // 0 = id
            // 1 = date
            // 2 = recipient number
            // 3 = content

            DetailsDateSending.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            DetailsRecipients.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            DetailsContent.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            sendbutton.Show();
            //get list of new messages
            LabSys = SMS.GetSystem("Laboratory");

            //select item in the table
            int rowindex = dataGridView2.CurrentCell.RowIndex;
            int columnindex = dataGridView2.CurrentCell.ColumnIndex;

            //column index guide 
            // 0 = id
            // 1 = date
            // 2 = type
            // 3 = content

            DetailsDateSending.Text = dataGridView2.Rows[rowindex].Cells[0].Value.ToString();
            DetailsRecipients.Text = dataGridView2.Rows[rowindex].Cells[2].Value.ToString();
            DetailsContent.Text = dataGridView2.Rows[rowindex].Cells[3].Value.ToString();
        }

        #endregion

        #region no action
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

    }
}
