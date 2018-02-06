﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using GsmComm.PduConverter;
using GsmComm.PduConverter.SmartMessaging;
using GsmComm.GsmCommunication;
using GsmComm.Interfaces;
using GsmComm.Server;
using System.Globalization;

namespace GSMModem
{
    public partial class Form1 : Form
    {
        private GsmCommMain comm;
        private delegate void SetTextCallback(string text);
        private SmsServer smsServer;
        public Form1()
        {
            InitializeComponent();
        }
        TextBox txtMessage = new TextBox();
        TextBox txtDonorName = new TextBox();
        TextBox txtNumber = new TextBox();
        TextBox txtDonorId = new TextBox();
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            Operation code = new Operation();
            try
            {
                //SqlConnection con = Main.GetDBConnection();
                //DataTable consultanttable = new DataTable();
                //string sqlConsultant = @"SELECT  Don_Donor_ID,Don_Donor_Name,left(Don_Mobile_Phone,4)+ right(Don_Mobile_Phone,7) 
                //FROM  psh.dbo.Donor_Profile WHERE (Don_SMS1 IS NULL) or (Don_SMS1='notsend') and Don_Donor_ID ='CF-00001-12'";

                //SqlDataAdapter Consultantdataadapter = new SqlDataAdapter(sqlConsultant, con);
                //Consultantdataadapter.Fill(consultanttable); +639279016517

                //foreach (DataRow myrow in consultanttable.Rows) +639193812657
                //{
                //abel no.: +639193812657
                //joy no.: +639279016517
                    txtDonorId.Text = "000";
                    txtDonorName.Text = "000";
                    txtNumber.Text = "+639193812657";
                    Cursor.Current = Cursors.WaitCursor;
                    txtMessage.Text = "c# test message to " + txtNumber.Text + " at " + System.DateTime.Now.ToString();
                    try
                    {
                        SmsSubmitPdu pdu;
                        byte dcs = (byte)DataCodingScheme.GeneralCoding.Alpha7BitDefault;
                        pdu = new SmsSubmitPdu(txtMessage.Text, Convert.ToString(txtNumber.Text), dcs);
                        int times = 1;
                        for (int i = 0; i < times; i++)
                        {
                            comm.SendMessage(pdu);
                    }
                    MessageBox.Show("SMS sent");
                }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Modem is not available" + ex.ToString());
                       // code.Execute("update psh.dbo.donor_profile set don_sms2='notsend' where don_donor_id ='" + txtDonorId.Text + "'");
                    }
                //}
            }
            catch
            {
                MessageBox.Show("SMS not send");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCOM.Items.Add("COM1");
            cmbCOM.Items.Add("COM2");
            cmbCOM.Items.Add("COM3");
            cmbCOM.Items.Add("COM4");
            cmbCOM.Items.Add("COM5");
            cmbCOM.Items.Add("COM6");
            cmbCOM.Items.Add("COM14");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cmbCOM.Text == "")
            {
                MessageBox.Show("Invalid Port Name");
                return;
            }
             comm = new GsmCommMain(cmbCOM.Text , 19200, 1000);
            Cursor.Current = Cursors.Default;
            bool retry;
            do
            {   retry = false;
                try
                {   Cursor.Current = Cursors.WaitCursor;
                    comm.Open();
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Modem Connected Sucessfully");
                }
                catch (Exception ex)
                {   Cursor.Current = Cursors.Default;
                    if (MessageBox.Show(this, "GSM Modem is not available" + ex.ToString(), "Check",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                        retry = true;
                    else
                   { return;}
               }
            }
            while (retry);

        }

        private void lblPending_Click(object sender, EventArgs e)
        {

        }
    }
    }

