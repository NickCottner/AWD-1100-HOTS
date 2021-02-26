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
    public partial class FormCD : Form
    {
        public FormCD()
        {
            InitializeComponent();
        }

        const int OLEN = 4;
        const int SLEN = 7;
        const int CMLEN = 4;


        string[] images = {"C:\\Users\\Nick Cottner\\OneDrive\\Desktop\\HOTS\\HOTS\\HOT5\\Card Designer\\EX1\\Images\\Insert Image.jfif",
                           "C:\\Users\\Nick Cottner\\OneDrive\\Desktop\\HOTS\\HOTS\\HOT5\\Card Designer\\EX1\\Images\\Leaf Thank You.jpg",
                           "C:\\Users\\Nick Cottner\\OneDrive\\Desktop\\HOTS\\HOTS\\HOT5\\Card Designer\\EX1\\Images\\Tree.jpg",
                           "C:\\Users\\Nick Cottner\\OneDrive\\Desktop\\HOTS\\HOTS\\HOT5\\Card Designer\\EX1\\Images\\Christmas.jpg",
                           "C:\\Users\\Nick Cottner\\OneDrive\\Desktop\\HOTS\\HOTS\\HOT5\\Card Designer\\EX1\\Images\\Easter.jpg",
                           "C:\\Users\\Nick Cottner\\OneDrive\\Desktop\\HOTS\\HOTS\\HOT5\\Card Designer\\EX1\\Images\\First Birthday.jpg",
                           "C:\\Users\\Nick Cottner\\OneDrive\\Desktop\\HOTS\\HOTS\\HOT5\\Card Designer\\EX1\\Images\\21st Birthday.jpg"};

        string[] occasion = { "Choose an Occasion", "Thank you", "Holiday", "Birthday" };

        string[] style = {"Choose a Style","Leaf ($1.25)","Tree ($1.50)", "Chirstmas ($1.00)",
                          "Easter ($1.05)", "1st Birthday ($.50)", "21st Birthday ($1.75)"};

        double[] costOfCard = { 0, 1.25, 1.50, 1.00, 1.05, .5, 1.75 };

        string[] customMessage = {"", "Please Accept this Thank You Card.",
                                  "Please Accept this Holiday Card.",
                                  "Please Accept this Happy Birthday Card." };
        double cost = 0;
        double totalCost = 0;


        private void FormCD_Activated(object sender, EventArgs e)
        {

            for (int lcv = 0; lcv < OLEN; ++lcv)
            {

                comboBoxOccasion.Items.Add(occasion[lcv]);
                comboBoxOccasion.SelectedIndex = 0;

            }
            for (int lcv = 0; lcv < SLEN; ++lcv)
            {
                comboBoxStyle.Items.Add(style[lcv]);
                comboBoxStyle.SelectedIndex = 0;
            }
            
        }
        private bool CheckboxMethod()
        {
            
            if (checkBoxEnv.Checked == true)
            {
                cost = 0.25;
            }
            if (checkBoxStamp.Checked == true)
            {
                cost = 0.50;
            }
            if (checkBoxCM.Checked == true)
            {
                cost = 0.30;
                labelCM.Visible = true;
            }
            return true;
            
        }
        private void comboBoxOccasion_Enter(object sender, EventArgs e)
        {
            comboBoxOccasion.BackColor = Color.LightGreen;
        }

        private void comboBoxStyle_Enter(object sender, EventArgs e)
        {
            comboBoxStyle.BackColor = Color.LightGreen;
        }

        private void checkBoxEnv_Enter(object sender, EventArgs e)
        {
            checkBoxEnv.BackColor = Color.LightGreen;
        }

        private void checkBoxStamp_Enter(object sender, EventArgs e)
        {
            checkBoxStamp.BackColor = Color.LightGreen;
        }

        private void checkBoxCM_Enter(object sender, EventArgs e)
        {
            checkBoxCM.BackColor = Color.LightGreen;
        }

        private void labelCM_Enter(object sender, EventArgs e)
        {
            labelCM.BackColor = Color.LightGreen;
        }

        private void labelTC_Enter(object sender, EventArgs e)
        {
            labelTC.BackColor = Color.LightGreen;
        }
        private void comboBoxOccasion_Leave(object sender, EventArgs e)
        {
            comboBoxOccasion.BackColor = Color.White;
        }

        private void comboBoxStyle_Leave(object sender, EventArgs e)
        {
            comboBoxStyle.BackColor = Color.White;
        }

        private void checkBoxEnv_Leave(object sender, EventArgs e)
        {
            checkBoxEnv.BackColor = Color.Transparent;
        }

        private void checkBoxStamp_Leave(object sender, EventArgs e)
        {
            checkBoxStamp.BackColor = Color.Transparent;
        }

        private void checkBoxCM_Leave(object sender, EventArgs e)
        {
            checkBoxCM.BackColor = Color.Transparent;
        }

        private void labelCM_Leave(object sender, EventArgs e)
        {
            labelCM.BackColor = Color.Red;
        }

        private void labelTC_Leave(object sender, EventArgs e)
        {
            labelTC.BackColor = Color.Red;
        }

        private void comboBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckboxMethod();
            int index = comboBoxStyle.SelectedIndex;
            pictureBoxStyle.Image = Image.FromFile(images[index]);

            totalCost += costOfCard[index] + cost;

            labelTC.Text = "Cost: " + totalCost;
            labelCM.Text = customMessage[index];
            
        }
    }
}
