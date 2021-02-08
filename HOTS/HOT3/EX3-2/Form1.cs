using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX3_2
{
    public partial class FormTestScores : Form
    {
        public FormTestScores()
        {
            InitializeComponent();
        }
        const double MINSCORE = 0.0;
        const double MAXSCORE = 100.0;
        int testScore = 0;
        int numberOfScores = 0;
        double sum = 0.0;
        double avg = 0.0;
        double lowScore = 101.0;
        double highScore = -1.0;

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;
            keepGoing = AddScore();
            if (keepGoing)
            {
                calculateScore();
                updateScores();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxEnterScore.Text = "";
            textBoxEnterScore.Focus();
        }
        private bool AddScore()
        {
            try
            {
                if (textBoxEnterScore.Text.Trim() == "")
                {
                    throw new ArgumentException();
                }
                foreach (char c in textBoxEnterScore.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        throw new ArgumentException();
                    }
                    testScore = Convert.ToInt32(textBoxEnterScore.Text);
                    if ((testScore < MINSCORE) || (testScore > MAXSCORE))
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                }
                return true;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show("Inputted Test Score Is Out Of Range (< 1 or > 100).\n" +
                                aoore.Message, "OUT OF RANGE TEST SCORE INPUTTED!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEnterScore.Text = "";
                textBoxEnterScore.Focus();
                return false;
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show("Inputted Test Score Is Non-Numeric.\n" +
                                ae.Message, "NON-NUMERIC TEST SCORE INPUTTED!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEnterScore.Text = "";
                textBoxEnterScore.Focus();
                return false;
            }
        }
        private void calculateScore()
        {
            sum += testScore;
            labelSum.Text = "Sum of Scores: " + sum.ToString("f2");
            ++numberOfScores;
            labelNumOfScores.Text = "Number of Scores: " + numberOfScores.ToString();
            avg = sum / numberOfScores;
            labelAverage.Text = "Average Score: " + avg.ToString("f2");
        }
        private void updateScores()
        {
            if(testScore < lowScore)
            {
                lowScore = testScore;
                labelLowScore.Text = "Lowest Test Score: " + lowScore.ToString("f2");
            }
            if (testScore > highScore)
            {
                highScore = testScore;
                labelHighScore.Text = "Highest Test Score: " + highScore.ToString("f2");
                    
            }
        }
    }
}
