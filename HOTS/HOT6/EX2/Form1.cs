using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class FormNetworkScanner : Form
    {
        public FormNetworkScanner()
        {
            InitializeComponent();
        }
        const int MAXLEN = 9;
        const string RTO = "REQUEST TIMED OUT";
        const string NOSERVICES = "NONE";
        List<Computer> computers = new List<Computer>()
        {

        };

        private void buttonScan_Click(object sender, EventArgs e)
        {
            int position = scanIpAddress();

            if ((position >= 0) && (position <= (MAXLEN - 1)))
            {
                scanIpAddress(position);
            }
            else
            {
                showComputer();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }
        private void clearAllFields()
        {
            textBoxIPAddress.Text = "";
            labelComputerName.Text = "";
            labelIPAddress.Text = "";
            labelServices.Text = "";
            textBoxIPAddress.Focus();
        }
    }
}
