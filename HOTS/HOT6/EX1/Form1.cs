using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class FormPasswordCracker : Form
    {
        public FormPasswordCracker()
        {
            InitializeComponent();
        }
        const int NUMOFHASH = 10;
        const string F = "FAIL";

        List<Password> passwords = new List<Password>()
        {
            new Password("123456", "e10adc3949ba59abbe56e057f20f883e"),
            new Password("123456789", "25f9e794323b453885f5181f1b624d0b"),
            new Password("qwerty" , "d8578edf8458ce06fbc5bb76a58c5ca4"),
            new Password("111111", "96e79218965eb72c92a549dd5a330112"),
            new Password("password", "5f4dcc3b5aa765d61d8327deb882cf99"),
            new Password("qwertyuiop" , "6eea9b7ef19179a06954edd0f6c05ceb"),
            new Password("123321", "c8837b23ff8aaa8a2dde915473ee0991"),
            new Password("google", "c822c1b63853ed273b89687ac505f9fa"),
            new Password("P@ssword", "161ebd7d45089b3446ee4e0d86dbcf92"),
            new Password("Tr0ub4dor&3", "4ece57a61323b52ccffdbef021956754")
        };



        private void buttonCrack_Click(object sender, EventArgs e)
        {
            int position = searchForHash();

            if ((position >= 0) && (position <= (NUMOFHASH - 1)))
            {
                CrackPassword(position);
            }
            else
            {
                showFail();
            }
            
        }
        public int searchForHash()
        {
            string searchHash = textBoxMD5Hash.Text;

            for (int lcv = 0; lcv < NUMOFHASH; ++lcv)
            {
                if (passwords[lcv].GetHash().ToLower() == searchHash.ToLower())
                {
                    return lcv;
                }
            }
            return -1;
        }
        public void CrackPassword(int r)
        {
            labelPasswordResult.Text = passwords[r].GetRaw();
        }
        public void showFail()
        {
            labelPasswordResult.Text = F;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }
        public void clearAllFields()
        {
            textBoxMD5Hash.Text = "";
            labelPasswordResult.Text = "";
            textBoxMD5Hash.Focus();
        }
    }
}
