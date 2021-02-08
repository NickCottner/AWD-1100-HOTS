
namespace EX3_3
{
    partial class FormDifferentExceptions
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
            this.labelNumber1 = new System.Windows.Forms.Label();
            this.textBoxNumber1 = new System.Windows.Forms.TextBox();
            this.labelNumber2 = new System.Windows.Forms.Label();
            this.textBoxNumber2 = new System.Windows.Forms.TextBox();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumber1
            // 
            this.labelNumber1.AutoSize = true;
            this.labelNumber1.Location = new System.Drawing.Point(29, 22);
            this.labelNumber1.Name = "labelNumber1";
            this.labelNumber1.Size = new System.Drawing.Size(124, 25);
            this.labelNumber1.TabIndex = 0;
            this.labelNumber1.Text = "Numero Uno: ";
            // 
            // textBoxNumber1
            // 
            this.textBoxNumber1.Location = new System.Drawing.Point(29, 50);
            this.textBoxNumber1.Name = "textBoxNumber1";
            this.textBoxNumber1.Size = new System.Drawing.Size(124, 31);
            this.textBoxNumber1.TabIndex = 0;
            // 
            // labelNumber2
            // 
            this.labelNumber2.AutoSize = true;
            this.labelNumber2.Location = new System.Drawing.Point(519, 22);
            this.labelNumber2.Name = "labelNumber2";
            this.labelNumber2.Size = new System.Drawing.Size(123, 25);
            this.labelNumber2.TabIndex = 2;
            this.labelNumber2.Text = "Numero Dos: ";
            // 
            // textBoxNumber2
            // 
            this.textBoxNumber2.Location = new System.Drawing.Point(519, 50);
            this.textBoxNumber2.Name = "textBoxNumber2";
            this.textBoxNumber2.Size = new System.Drawing.Size(123, 31);
            this.textBoxNumber2.TabIndex = 1;
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(279, 105);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(112, 57);
            this.buttonMultiply.TabIndex = 2;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(279, 208);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(112, 58);
            this.buttonDivide.TabIndex = 3;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAnswer.Location = new System.Drawing.Point(279, 393);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(142, 32);
            this.labelAnswer.TabIndex = 7;
            this.labelAnswer.Text = "labelAnswer";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(279, 297);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 65);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // FormDifferentExceptions
            // 
            this.AcceptButton = this.buttonMultiply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.textBoxNumber2);
            this.Controls.Add(this.labelNumber2);
            this.Controls.Add(this.textBoxNumber1);
            this.Controls.Add(this.labelNumber1);
            this.Name = "FormDifferentExceptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Different Type of Exceptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber1;
        private System.Windows.Forms.TextBox textBoxNumber1;
        private System.Windows.Forms.Label labelNumber2;
        private System.Windows.Forms.TextBox textBoxNumber2;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Button buttonClear;
    }
}

