
namespace EX3_2
{
    partial class FormTestScores
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEnterScore = new System.Windows.Forms.Label();
            this.textBoxEnterScore = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelNumOfScores = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelLowScore = new System.Windows.Forms.Label();
            this.labelHighScore = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEnterScore
            // 
            this.labelEnterScore.AutoSize = true;
            this.labelEnterScore.Location = new System.Drawing.Point(65, 46);
            this.labelEnterScore.Name = "labelEnterScore";
            this.labelEnterScore.Size = new System.Drawing.Size(205, 25);
            this.labelEnterScore.TabIndex = 0;
            this.labelEnterScore.Text = "Please enter a test score:";
            // 
            // textBoxEnterScore
            // 
            this.textBoxEnterScore.Location = new System.Drawing.Point(65, 88);
            this.textBoxEnterScore.Name = "textBoxEnterScore";
            this.textBoxEnterScore.Size = new System.Drawing.Size(205, 31);
            this.textBoxEnterScore.TabIndex = 0;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(65, 147);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(112, 34);
            this.buttonEnter.TabIndex = 1;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // labelNumOfScores
            // 
            this.labelNumOfScores.AutoSize = true;
            this.labelNumOfScores.Location = new System.Drawing.Point(65, 217);
            this.labelNumOfScores.Name = "labelNumOfScores";
            this.labelNumOfScores.Size = new System.Drawing.Size(0, 25);
            this.labelNumOfScores.TabIndex = 2;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(65, 242);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(0, 25);
            this.labelSum.TabIndex = 3;
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(65, 267);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(0, 25);
            this.labelAverage.TabIndex = 4;
            // 
            // labelLowScore
            // 
            this.labelLowScore.AutoSize = true;
            this.labelLowScore.Location = new System.Drawing.Point(65, 292);
            this.labelLowScore.Name = "labelLowScore";
            this.labelLowScore.Size = new System.Drawing.Size(0, 25);
            this.labelLowScore.TabIndex = 5;
            // 
            // labelHighScore
            // 
            this.labelHighScore.AutoSize = true;
            this.labelHighScore.Location = new System.Drawing.Point(65, 317);
            this.labelHighScore.Name = "labelHighScore";
            this.labelHighScore.Size = new System.Drawing.Size(0, 25);
            this.labelHighScore.TabIndex = 6;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(219, 147);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 34);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormTestScores
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelHighScore);
            this.Controls.Add(this.labelLowScore);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelNumOfScores);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxEnterScore);
            this.Controls.Add(this.labelEnterScore);
            this.Name = "FormTestScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnterScore;
        private System.Windows.Forms.TextBox textBoxEnterScore;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelNumOfScores;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelLowScore;
        private System.Windows.Forms.Label labelHighScore;
        private System.Windows.Forms.Button buttonClear;
    }
}

