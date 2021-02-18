using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class FormAddressBook : Form
    {
        public FormAddressBook()
        {
            InitializeComponent();
        }
        const int LEN = 8;
        const string ANF = "ADDRESS NOT FOUND";

        string[] firstName = { "Markel", "Luiza", "Byrony", "Giraldo", "Lowri" };

        string[] lastName = { "Diggory", "Gunnar", "Hester", "Addy", "Hari" };

        string[] phoneNumber = { "555-8390", "555-4618", "555-4440", "555-1687", "555-7763" };

        int index = -1;

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool keepGoing = doesAddressExist();

            if (keepGoing)
            {
                showResults();
            }
            else
            {
                labelTheFirstName.Text = ANF;
                labelTheLastName.Text = ANF;
                labelthePhoneNumber.Text = ANF;
            }
        }
        private bool doesAddressExist()
        {
            index = -1;

            bool retVal = false;
            string item = "";

            if(textBoxSearch.Text.Trim() == "")
            {
                MessageBox.Show("No First or Last Name Entered", "NO FIRST OR LAST NAME ENTERED",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSearch.Focus();
            }
            else
            {
                item = textBoxSearch.Text.ToLower();
                for (int lcv = 0; lcv < firstName.Length; ++lcv)
                {
                    if(firstName[lcv].ToLower().Contains(item))
                    {
                        retVal = true;
                        index = lcv;
                        break;
                    }
                    else if(lastName[lcv].ToLower().Contains(item))
                    {
                        retVal = true;
                        index = lcv;
                        break;
                    }
                    else
                    {
                        retVal = false;
                        index = -1;
                    }
                }
            }
            return retVal;
        }
        private void showResults()
        {
            labelTheFirstName.Text = firstName[index];
            labelTheLastName.Text = lastName[index];
            labelthePhoneNumber.Text = phoneNumber[index];
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAndSetFocus();
        }
        private void clearAndSetFocus()
        {
            textBoxSearch.Text = "";
            labelTheFirstName.Text = "";
            labelTheLastName.Text = "";
            labelthePhoneNumber.Text = "";
            textBoxSearch.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            applicationExit();
        }
        private void applicationExit()
        {
            if (MessageBox.Show("Do You Really Want To Exit?", "EXIT PROGRAM?",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                              == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
