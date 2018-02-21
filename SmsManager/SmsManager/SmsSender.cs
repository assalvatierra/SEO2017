using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsManager
{

    //INTERFACE
    public interface ISMSSender
    {
        //SMS Sender Methods
        DataTable GetListing();
        DataTable GetUnsentItems();
        DataTable GetDetails(string notificationID);

        string SendSMS(string Recipient, string Message);
        void SendAdminNotif(SmsSender adminList);

        void ServerUpdate(string NotificationID, string sentdatetime);
        void SetActivityLog(string NotificationID, string status, string remarks);
        void setNewNotification(string type, string recipient, string message, string dtSending);
        void SetRefreshTime(int timeSec);

    }

    //product
    public abstract class SmsSender
    {
        public int id { get; set; }
        public string receipient { get; set; }
        public string RcptName { get; set; }
        public string MsgBody { get; set; }
        public string Description { get; set; }
        public string status { get; set; }
        public bool isAdmin { get; set; }
    }


    //CREATOR ABTRACT CLASS
    public abstract class SMSFactory
    {
        public abstract ISMSSender GetSystem(string System);
    }

    //CONCRETE CREATOR 
    public class ConcreteSMSFactory : SMSFactory
    {
        public override ISMSSender GetSystem(string System)
        {
            switch (System)
            {
                case "Laboratory":
                    return new LabSys();
                //add new system here
                default:
                    throw new NotImplementedException(string.Format("Invalid System input. System cannot be created."));
            }
        }
    }


    //CONCRETE PRODUCT
    //SMS Sender Methods
    public class LabSys : ISMSSender
    {
        JsonHandler webData = new JsonHandler();
        //get sending list from the database using JSON 
        public DataTable GetListing() {

            Console.WriteLine("GET LISTING");
            return webData.Getcontent("http://localhost:63556/SmsService.asmx/getList");
            
        }

        //get sending details, message 
        public DataTable GetDetails(string notificationID) {

            Console.WriteLine("GET DETAILS");
            return webData.Getcontent("http://localhost:63556/SmsService.asmx/getDetails");
            
        }


        //get sending details, message 
        public DataTable GetUnsentItems()
        {

            return webData.Getcontent("http://localhost:63556/SmsService.asmx/getUnsentItems");
            

        }

        //send sms 
        public string SendSMS(string Recipient, string Message) {
            GSM GSMBot = new GSM();
            string messageStatus = "";
            Recipient = "639279016517"; //format (63 + number ex. 639279016517)
            Message = "c# text test :" + DateTime.Today.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();

            Console.WriteLine("CONNECTING TO COM10");
            if (GSMBot.PortConnect("COM14"))
            {
                Console.WriteLine("COM10 CONNECTED. SENDING MESSAGE");
                if(GSMBot.GSMSend(Recipient, Message))
                {
                    //insert serverupdate here
                    Console.WriteLine("MESSAGE SENT");              //sending success
                    messageStatus = "Sent";
                }
                else
                {
                    Console.WriteLine("MESSAGE SENDING FAILED");    //sending failed
                    messageStatus = "Failed";
                }
            }
            else
            {
                Console.WriteLine("Error connecting to Broadband COM10");
                messageStatus = "COM error";
            }
            GSMBot.closeConnection();
            return messageStatus;
        }

        //update admin through notification through text
        public void SendAdminNotif(SmsSender adminList) {


        }

        //update notifications
        public void ServerUpdate(string notificationID, string sentdatetime)
        {
           
            string url = "http://localhost:63556/SmsService.asmx/updateItemStatus";

            var data = new NameValueCollection();
            data["NotificationID"] = notificationID.ToString();
            data["DtSending"] = DateTime.Now.ToString();

            Console.WriteLine("DATETIME: "+DateTime.Now.ToString());
            string responseInString = webData.sendMsgData(url, data);

            Console.WriteLine("notifications update " + responseInString);
        }

        //update notifications
        public void SetActivityLog(string notificationID, string status, string remarks)
        {
            
            string url = "http://localhost:63556/SmsService.asmx/updateLog";

            var data = new NameValueCollection();
            data["NotificationID"] = notificationID.ToString();
            data["DtSending"] = DateTime.Now.ToString();
            data["Status"] = status;
            data["Remarks"] = remarks;
            //string responseInString = webData.sendPOSTData(url, "1", "2/16/2018", "sent", "none");
            string responseInString = webData.sendMsgData(url, data);

            Console.WriteLine("logs update " + responseInString );

        }

        public void setNewNotification(string type, string recipient, string message,string dtSending)
        {
            string url = "http://localhost:63556/SmsService.asmx/addNotification";

            var data = new NameValueCollection();
            data["recType"] = type;
            data["dtSending"] = dtSending;
            data["message"] = message;
            data["recipient"] = recipient;
            //string responseInString = webData.sendPOSTData(url, "1", "2/16/2018", "sent", "none");
            string responseInString = webData.sendMsgData(url, data);

            Console.WriteLine("logs update " + responseInString);
        }


        public void SetRefreshTime(int timeSec)
        {

        }

    }


}
