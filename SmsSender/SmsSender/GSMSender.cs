using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace SmsSender
{
    class GSMSender
    {

        private const string SERIAL_PORT_NAME = "COM11";

        public SerialPort _modemConnection;
        public GSMSender()
        {
            _modemConnection = new SerialPort(SERIAL_PORT_NAME)
            {
                // 19200 baud, most modems will accept everything
                // from 9600 up to 115200
                BaudRate = 19200,
                // 99% of the time the port connection will be
                //8 Data bits
                DataBits = 8,
                // NO partiy
                Parity = Parity.None,
                // and 1 stop bit. Check your modem manual if
                // this doesn't work
                StopBits = StopBits.One
            };

        }

        public void SendSms(string destination, string text)
        {
            _modemConnection.Open();
            // Turn off echo, we don't need it for this
            _modemConnection.WriteLine("ATE0");
            var response = _modemConnection.ReadExisting();

            // Set text mode
            _modemConnection.WriteLine("AT+CMGF=1");
            response = _modemConnection.ReadExisting();

            // Send the SMS
            _modemConnection.WriteLine(String.Format
               ("AT+CMGS=\"{0}\"", destination));
            response = _modemConnection.ReadExisting();

            _modemConnection.Write(text);
            _modemConnection.Write(new byte[] { 26 }, 0, 1);

            response = _modemConnection.ReadExisting();

            if (response.Contains("ERROR"))
            {
                Console.WriteLine("SMS Failed to send");
            }
            else
            {
                Console.WriteLine("SMS Sent");
                Console.WriteLine("Response: {0}", response);
            }


            _modemConnection.Close();
        }




    }
}
