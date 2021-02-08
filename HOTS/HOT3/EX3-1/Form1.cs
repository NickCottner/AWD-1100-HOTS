using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Create a program for ordering T-Shirts.
 *  - Users must enter a numeric quantity.
 *  - Users can enter an optional discount code.
 *  - Shirts are normally $13.75 each. Sales tas is 8%.
 *  - If the discount code is valid, apply the discount percentage shown below.
 *  - If the discount code is missing or not valid, do not apply a discount.
 *  
 */
namespace EX3_1
{
    public partial class FormShirtSizes : Form
    {
        public FormShirtSizes()
        {
            InitializeComponent();
        }
        decimal price = 13.75m;
        const decimal SALES_TAX = 0.08m;
        const double MINSHIRTS = 1.0;
        const double MAXSHIRTS = 50.0;
        const int discountCode1 = 8264;
        const int discountCode2 = 5679;
        const int discountCode3 = 6483;
        double quantity = 0.0;
        int discountCode = 0;
        decimal subtotal = 0.0m;
        decimal salesTax = 0.0m;
        decimal total = 0.0m;
        decimal discountPercentage = 0.0m;

        private void btnOrder_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;
            keepGoing = validateIsNumeric(textBoxQuantity.Text);

            if (keepGoing)
            {
                quantity = Convert.ToDouble(textBoxQuantity.Text);
                if ((quantity < MINSHIRTS) || (quantity > MAXSHIRTS))
                {
                    MessageBox.Show("Out of range quantity of shirts inputted. " + " Please reenter a quantity within range.", "OUT OF RANGE QUANTITY INPUTTED! ",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else
                {
                    keepGoing = validateIsNumeric(textBoxQuantity.Text);

                }
            }
            else
            {
                MessageBox.Show("Non-Numeric Value Inputted." + "Please reenter a numeric value.",
                               "NON-NUMERIC VALUE INPUTTED!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            
            if (keepGoing)
            {
                CheckDiscountCode();
                showInvoice();
            }
                

            

            

        }
        private bool validateIsNumeric(string input)
        {
            double test = 0;

            return double.TryParse(input, out test);
        }

        private void textBoxDiscountCode_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void CheckDiscountCode()
        {
            discountCode = Convert.ToInt32(textBoxDiscountCode.Text);
            if (discountCode1)
            {

            }
        }
    
    
    
    
    
    
    
    
    }   
}
