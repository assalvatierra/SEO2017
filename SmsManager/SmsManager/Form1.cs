using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Collections.Specialized;

namespace SmsManager
{
    public partial class Form1 : Form
    {
        public SMSFactory SMS = new ConcreteSMSFactory();
        public ISMSSender LabSys;

        public FormOverview OverviewView = new FormOverview();
        public FormInbox InboxView = new FormInbox();
        public FormSettings Settingsview = new FormSettings();
        public FormNewNotif NewNotifView = new FormNewNotif();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Connection.url = "http://localhost:63556/SmsService.asmx/";

            LabSys = SMS.GetSystem("Laboratory");

            OverviewView.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            OverviewView.TopLevel = false;
            OverviewView.AutoScroll = true;
            panel1.Controls.Add(OverviewView);
            OverviewView.Show();

            InboxView.Hide();

        }
        
       
        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void OverviewFlatButton_Click(object sender, EventArgs e)
        {
            OverviewView.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            OverviewView.TopLevel = false;
            OverviewView.AutoScroll = true;
            panel1.Controls.Add(OverviewView);
            OverviewView.Show();

            InboxView.Hide();
            Settingsview.Hide();
            NewNotifView.Hide();
        }

        private void LogsFlatButton_Click(object sender, EventArgs e)
        {
            InboxView.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            InboxView.TopLevel = false;
            InboxView.AutoScroll = true;
            panel1.Controls.Add(InboxView);
            InboxView.Show();

            OverviewView.Hide();
            Settingsview.Hide();
            NewNotifView.Hide();
        }

        private void SettingsFlatButton2_Click(object sender, EventArgs e)
        {
            Settingsview.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Settingsview.TopLevel = false;
            Settingsview.AutoScroll = true;
            panel1.Controls.Add(Settingsview);
            Settingsview.Show();

            InboxView.Hide();
            OverviewView.Hide();
            NewNotifView.Hide();
        }

        private void newNotifFlatButton_Click(object sender, EventArgs e)
        {
            NewNotifView.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            NewNotifView.TopLevel = false;
            NewNotifView.AutoScroll = true;
            panel1.Controls.Add(NewNotifView);
            NewNotifView.Show();

            OverviewView.Hide();
            InboxView.Hide();
            Settingsview.Hide();
        }

        private void UpdateButton_Click_1(object sender, EventArgs e)
        {
            //if (FormWindowState.Minimized == this.WindowState)
            //{

                notifyIcon1.Visible = true;
               // notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            //}

            //else if (FormWindowState.Normal == this.WindowState)
            //{
            //    notifyIcon1.Visible = false;
            //}
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }
    }//end of class
}
