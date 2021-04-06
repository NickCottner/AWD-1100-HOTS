using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOT15
{
    public partial class FormBankLoan : Form 
    {
        const double STLPAYMENT = 450;
        const double LTLPAYMENT = 200;
        const double STLINTERESTRATE = .10;
        const double LTLINTERESTRATE = .05;

        
        double amount = 0;
        string typeStr = " ";
        
        
        RadioButton radioButtonTypeStr;
        

        public FormBankLoan()
        {
            InitializeComponent();

            radioButtonShortTermLoan.CheckedChanged += new EventHandler(type_Check_Changed);
            radioButtonLongTermLoan.CheckedChanged += new EventHandler(type_Check_Changed);
        }
        
        private void type_Check_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonTypeStr = (RadioButton)sender;

                typeStr = radioButtonTypeStr.Name.Substring(11);

                switch(typeStr)
                {
                    case " Short Term Loan ":
                        groupBoxRadioButtons.Enabled = true;
                        radioButtonShortTermLoan.Checked = true;
                        break;
                    case " LongTermLoan ":
                        groupBoxRadioButtons.Enabled = true;
                        radioButtonLongTermLoan.Checked = true;
                        break;
                }
            }
            
        }
        
        private void buttonCLCreateLoan_Click(object sender, EventArgs e)
        {
            bool keepgoing = validateName();
            if(keepgoing)
            {
                keepgoing = validateAmount();
            }
            else
            {
                return;
            }
            if (keepgoing)
            {
                validateRadioButtonsChecked();
            }
            else
            {
                return;
            }
            if (keepgoing)
            {
                updateLoanInformation();
            }
            else
            {
                return;
            }
            if (keepgoing)
            {
                calculateLoanPayment();
            }
            else
            {
                return;
            }
            buttonMLMakePayment.Enabled = true;
            
        }
        private bool validateName()
        {
            if (textBoxCLName.Text.Trim() == "")
            {
                showMessage("Name Cannot Be Blank.\nPlease Enter A Name. ", "NO NAME INPUTTED!");
                textBoxCLName.Focus();
                return false;
            }
            return true;
            
        }
        
        private bool validateAmount()
        {
            if (textBoxCLAmount.Text.Trim() == "")
            {
                showMessage("Amount Cannot Be Blank.\nPlease Enter An Amount. ", " NO AMOUNT INPUTTED!");
                textBoxCLAmount.Focus();
                return false;
            }
           
            try
            {
                amount = Convert.ToDouble(textBoxCLAmount.Text);
                if (amount <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return true;
            }
            catch (FormatException fe)
            {
                showMessage("Amount Is Not Numeric.\nPlease Enter A Numeric Amount. " + fe.Message, "ILLEGAL AMOUNT INPUTTED!");
                textBoxCLAmount.Text = " ";
                textBoxCLAmount.Focus();
                return false;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                showMessage("Amount Inputted Was <= 0.\nPlease Enter An Amount > 0. " + aoore.Message,
                            "NEGATIVE AMOUNT INPUTTED!");
                textBoxCLAmount.Text = "";
                textBoxCLAmount.Focus();
                return false;
            }
        }
        private bool validateRadioButtonsChecked()
        {
            if (radioButtonTypeStr.Checked == false)
            {
                showMessage("Type of Loan Must Be Checked.\nPlease Select a Loan.", "TYPE OF LOAN ISN'T SELECTED");
                radioButtonShortTermLoan.Focus();
                
            }
            return true;
        }
        private bool updateLoanInformation()
        {
            labelMLName.Text = textBoxCLName.Text;
            labelMLLoanAmountStr.Text = typeStr + " of";
            labelMLLoanAmountDecimal.Text = amount.ToString("c");
            return true;
            
        }
       
        private void buttonMLMakePayment_Click(object sender, EventArgs e)
        {
            calculateLoanPayment();    
        }
        private void calculateLoanPayment()
        {
            if (radioButtonShortTermLoan.Checked == true)
            {
                labelMLLastPayment.Text = "After the last payment the loan is down to " + (amount - STLPAYMENT).ToString("c");
                labelMLLastInterest.Text = "After the last interest accumulation, the loan is now " + 
                                            ((amount - STLPAYMENT).ToString("c") + STLINTERESTRATE.ToString("c"));
                
            }
            if (radioButtonLongTermLoan.Checked == true)
            {
                labelMLLastPayment.Text = "After the last payment the loan is down to " + (amount - LTLPAYMENT).ToString("c");
                labelMLLastInterest.Text = "After the last interest accumulation, the loan is now " + 
                                            ((amount - LTLPAYMENT).ToString("c") + LTLINTERESTRATE.ToString("c"));
                

            }
            
        }
       
       

        private void buttonCLClear_Click(object sender, EventArgs e)
        {
            textBoxCLName.Text = " ";
            textBoxCLAmount.Text = " ";
            labelMLLastInterest.Text = " ";
            labelMLLastPayment.Text = " ";
            labelMLLoanAmountStr.Text = " ";
            labelMLLoanAmountDecimal.Text = " ";
            labelMLName.Text = " ";
            textBoxCLName.Focus();
        } 
        private void showMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonMLExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want To Exit?", "EXIT NOW?",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void FormBankLoan_Load(object sender, EventArgs e)
        {
            buttonCLCreateLoan.Enabled = true;
            buttonMLMakePayment.Enabled = false;
            textBoxCLName.Text = "";
            textBoxCLAmount.Text = "";
            labelMLName.Text = "";
            labelMLLoanAmountStr.Text = " ";
            labelMLLoanAmountDecimal.Text = " ";
            labelMLLastInterest.Text = " ";
            labelMLLastPayment.Text = " ";

        }
    }
}
