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
    public partial class FormSettings : Form
    {

        private ISMSSender LabSys;
        private SMSFactory SMS = new ConcreteSMSFactory();

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedValue = 0;
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {

            LabSys = SMS.GetSystem("Laboratory");
            Connection.url = comboBox1.SelectedItem.ToString();
            Console.WriteLine(comboBox1.SelectedItem.ToString());
            Console.WriteLine(Connection.url.ToString());
            Console.WriteLine(LabSys.GetListing());
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
