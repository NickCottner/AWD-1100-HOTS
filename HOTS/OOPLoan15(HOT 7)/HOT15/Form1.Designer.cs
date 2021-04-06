
namespace HOT15
{
    partial class FormBankLoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxCLCreateLoan = new System.Windows.Forms.GroupBox();
            this.groupBoxRadioButtons = new System.Windows.Forms.GroupBox();
            this.radioButtonLongTermLoan = new System.Windows.Forms.RadioButton();
            this.radioButtonShortTermLoan = new System.Windows.Forms.RadioButton();
            this.buttonCLClear = new System.Windows.Forms.Button();
            this.buttonCLCreateLoan = new System.Windows.Forms.Button();
            this.textBoxCLAmount = new System.Windows.Forms.TextBox();
            this.textBoxCLName = new System.Windows.Forms.TextBox();
            this.labelCLType = new System.Windows.Forms.Label();
            this.labelCLAmount = new System.Windows.Forms.Label();
            this.labelCLName = new System.Windows.Forms.Label();
            this.groupBoxMLManageLoan = new System.Windows.Forms.GroupBox();
            this.buttonMLExit = new System.Windows.Forms.Button();
            this.buttonMLMakePayment = new System.Windows.Forms.Button();
            this.labelMLLastInterest = new System.Windows.Forms.Label();
            this.labelMLLastPayment = new System.Windows.Forms.Label();
            this.labelMLLoanAmountDecimal = new System.Windows.Forms.Label();
            this.labelMLLoanAmountStr = new System.Windows.Forms.Label();
            this.labelMLName = new System.Windows.Forms.Label();
            this.groupBoxCLCreateLoan.SuspendLayout();
            this.groupBoxRadioButtons.SuspendLayout();
            this.groupBoxMLManageLoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCLCreateLoan
            // 
            this.groupBoxCLCreateLoan.BackColor = System.Drawing.Color.DarkGreen;
            this.groupBoxCLCreateLoan.Controls.Add(this.groupBoxRadioButtons);
            this.groupBoxCLCreateLoan.Controls.Add(this.buttonCLClear);
            this.groupBoxCLCreateLoan.Controls.Add(this.buttonCLCreateLoan);
            this.groupBoxCLCreateLoan.Controls.Add(this.textBoxCLAmount);
            this.groupBoxCLCreateLoan.Controls.Add(this.textBoxCLName);
            this.groupBoxCLCreateLoan.Controls.Add(this.labelCLType);
            this.groupBoxCLCreateLoan.Controls.Add(this.labelCLAmount);
            this.groupBoxCLCreateLoan.Controls.Add(this.labelCLName);
            this.groupBoxCLCreateLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCLCreateLoan.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCLCreateLoan.Name = "groupBoxCLCreateLoan";
            this.groupBoxCLCreateLoan.Size = new System.Drawing.Size(775, 249);
            this.groupBoxCLCreateLoan.TabIndex = 0;
            this.groupBoxCLCreateLoan.TabStop = false;
            this.groupBoxCLCreateLoan.Text = "CreateLoan";
            // 
            // groupBoxRadioButtons
            // 
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonLongTermLoan);
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonShortTermLoan);
            this.groupBoxRadioButtons.Location = new System.Drawing.Point(123, 139);
            this.groupBoxRadioButtons.Name = "groupBoxRadioButtons";
            this.groupBoxRadioButtons.Size = new System.Drawing.Size(270, 88);
            this.groupBoxRadioButtons.TabIndex = 9;
            this.groupBoxRadioButtons.TabStop = false;
            // 
            // radioButtonLongTermLoan
            // 
            this.radioButtonLongTermLoan.AutoSize = true;
            this.radioButtonLongTermLoan.Location = new System.Drawing.Point(7, 58);
            this.radioButtonLongTermLoan.Name = "radioButtonLongTermLoan";
            this.radioButtonLongTermLoan.Size = new System.Drawing.Size(164, 24);
            this.radioButtonLongTermLoan.TabIndex = 1;
            this.radioButtonLongTermLoan.TabStop = true;
            this.radioButtonLongTermLoan.Text = "Long Term Loan";
            this.radioButtonLongTermLoan.UseVisualStyleBackColor = true;
            // 
            // radioButtonShortTermLoan
            // 
            this.radioButtonShortTermLoan.AutoSize = true;
            this.radioButtonShortTermLoan.Location = new System.Drawing.Point(7, 17);
            this.radioButtonShortTermLoan.Name = "radioButtonShortTermLoan";
            this.radioButtonShortTermLoan.Size = new System.Drawing.Size(168, 24);
            this.radioButtonShortTermLoan.TabIndex = 0;
            this.radioButtonShortTermLoan.TabStop = true;
            this.radioButtonShortTermLoan.Text = "Short Term Loan";
            this.radioButtonShortTermLoan.UseVisualStyleBackColor = true;
            // 
            // buttonCLClear
            // 
            this.buttonCLClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCLClear.Location = new System.Drawing.Point(519, 69);
            this.buttonCLClear.Name = "buttonCLClear";
            this.buttonCLClear.Size = new System.Drawing.Size(221, 30);
            this.buttonCLClear.TabIndex = 5;
            this.buttonCLClear.Text = "Clear";
            this.buttonCLClear.UseVisualStyleBackColor = true;
            this.buttonCLClear.Click += new System.EventHandler(this.buttonCLClear_Click);
            // 
            // buttonCLCreateLoan
            // 
            this.buttonCLCreateLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCLCreateLoan.Location = new System.Drawing.Point(519, 32);
            this.buttonCLCreateLoan.Name = "buttonCLCreateLoan";
            this.buttonCLCreateLoan.Size = new System.Drawing.Size(221, 31);
            this.buttonCLCreateLoan.TabIndex = 4;
            this.buttonCLCreateLoan.Text = "Create Loan";
            this.buttonCLCreateLoan.UseVisualStyleBackColor = true;
            this.buttonCLCreateLoan.Click += new System.EventHandler(this.buttonCLCreateLoan_Click);
            // 
            // textBoxCLAmount
            // 
            this.textBoxCLAmount.Location = new System.Drawing.Point(123, 69);
            this.textBoxCLAmount.Name = "textBoxCLAmount";
            this.textBoxCLAmount.Size = new System.Drawing.Size(368, 26);
            this.textBoxCLAmount.TabIndex = 1;
            // 
            // textBoxCLName
            // 
            this.textBoxCLName.Location = new System.Drawing.Point(123, 32);
            this.textBoxCLName.Name = "textBoxCLName";
            this.textBoxCLName.Size = new System.Drawing.Size(368, 26);
            this.textBoxCLName.TabIndex = 0;
            // 
            // labelCLType
            // 
            this.labelCLType.AutoSize = true;
            this.labelCLType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCLType.Location = new System.Drawing.Point(48, 139);
            this.labelCLType.Name = "labelCLType";
            this.labelCLType.Size = new System.Drawing.Size(68, 25);
            this.labelCLType.TabIndex = 8;
            this.labelCLType.Text = "Type:";
            // 
            // labelCLAmount
            // 
            this.labelCLAmount.AutoSize = true;
            this.labelCLAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCLAmount.Location = new System.Drawing.Point(23, 68);
            this.labelCLAmount.Name = "labelCLAmount";
            this.labelCLAmount.Size = new System.Drawing.Size(93, 25);
            this.labelCLAmount.TabIndex = 7;
            this.labelCLAmount.Text = "Amount:";
            // 
            // labelCLName
            // 
            this.labelCLName.AutoSize = true;
            this.labelCLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCLName.Location = new System.Drawing.Point(41, 32);
            this.labelCLName.Name = "labelCLName";
            this.labelCLName.Size = new System.Drawing.Size(75, 25);
            this.labelCLName.TabIndex = 6;
            this.labelCLName.Text = "Name:";
            // 
            // groupBoxMLManageLoan
            // 
            this.groupBoxMLManageLoan.BackColor = System.Drawing.Color.DarkGreen;
            this.groupBoxMLManageLoan.Controls.Add(this.buttonMLExit);
            this.groupBoxMLManageLoan.Controls.Add(this.buttonMLMakePayment);
            this.groupBoxMLManageLoan.Controls.Add(this.labelMLLastInterest);
            this.groupBoxMLManageLoan.Controls.Add(this.labelMLLastPayment);
            this.groupBoxMLManageLoan.Controls.Add(this.labelMLLoanAmountDecimal);
            this.groupBoxMLManageLoan.Controls.Add(this.labelMLLoanAmountStr);
            this.groupBoxMLManageLoan.Controls.Add(this.labelMLName);
            this.groupBoxMLManageLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMLManageLoan.Location = new System.Drawing.Point(13, 282);
            this.groupBoxMLManageLoan.Name = "groupBoxMLManageLoan";
            this.groupBoxMLManageLoan.Size = new System.Drawing.Size(775, 273);
            this.groupBoxMLManageLoan.TabIndex = 1;
            this.groupBoxMLManageLoan.TabStop = false;
            this.groupBoxMLManageLoan.Text = "ManageLoan";
            // 
            // buttonMLExit
            // 
            this.buttonMLExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMLExit.Location = new System.Drawing.Point(519, 77);
            this.buttonMLExit.Name = "buttonMLExit";
            this.buttonMLExit.Size = new System.Drawing.Size(221, 31);
            this.buttonMLExit.TabIndex = 6;
            this.buttonMLExit.Text = "Exit";
            this.buttonMLExit.UseVisualStyleBackColor = true;
            this.buttonMLExit.Click += new System.EventHandler(this.buttonMLExit_Click);
            // 
            // buttonMLMakePayment
            // 
            this.buttonMLMakePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMLMakePayment.Location = new System.Drawing.Point(519, 25);
            this.buttonMLMakePayment.Name = "buttonMLMakePayment";
            this.buttonMLMakePayment.Size = new System.Drawing.Size(221, 32);
            this.buttonMLMakePayment.TabIndex = 5;
            this.buttonMLMakePayment.Text = "Make Payment";
            this.buttonMLMakePayment.UseVisualStyleBackColor = true;
            // 
            // labelMLLastInterest
            // 
            this.labelMLLastInterest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelMLLastInterest.Location = new System.Drawing.Point(24, 198);
            this.labelMLLastInterest.Name = "labelMLLastInterest";
            this.labelMLLastInterest.Size = new System.Drawing.Size(467, 31);
            this.labelMLLastInterest.TabIndex = 4;
            this.labelMLLastInterest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMLLastPayment
            // 
            this.labelMLLastPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelMLLastPayment.Location = new System.Drawing.Point(28, 137);
            this.labelMLLastPayment.Name = "labelMLLastPayment";
            this.labelMLLastPayment.Size = new System.Drawing.Size(463, 31);
            this.labelMLLastPayment.TabIndex = 3;
            this.labelMLLastPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMLLoanAmountDecimal
            // 
            this.labelMLLoanAmountDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelMLLoanAmountDecimal.Location = new System.Drawing.Point(310, 77);
            this.labelMLLoanAmountDecimal.Name = "labelMLLoanAmountDecimal";
            this.labelMLLoanAmountDecimal.Size = new System.Drawing.Size(181, 31);
            this.labelMLLoanAmountDecimal.TabIndex = 2;
            this.labelMLLoanAmountDecimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMLLoanAmountStr
            // 
            this.labelMLLoanAmountStr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelMLLoanAmountStr.Location = new System.Drawing.Point(28, 77);
            this.labelMLLoanAmountStr.Name = "labelMLLoanAmountStr";
            this.labelMLLoanAmountStr.Size = new System.Drawing.Size(259, 31);
            this.labelMLLoanAmountStr.TabIndex = 1;
            this.labelMLLoanAmountStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMLName
            // 
            this.labelMLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelMLName.Location = new System.Drawing.Point(28, 26);
            this.labelMLName.Name = "labelMLName";
            this.labelMLName.Size = new System.Drawing.Size(463, 31);
            this.labelMLName.TabIndex = 0;
            this.labelMLName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBankLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.groupBoxMLManageLoan);
            this.Controls.Add(this.groupBoxCLCreateLoan);
            this.Name = "FormBankLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Loan";
            this.Load += new System.EventHandler(this.FormBankLoan_Load);
            this.groupBoxCLCreateLoan.ResumeLayout(false);
            this.groupBoxCLCreateLoan.PerformLayout();
            this.groupBoxRadioButtons.ResumeLayout(false);
            this.groupBoxRadioButtons.PerformLayout();
            this.groupBoxMLManageLoan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCLCreateLoan;
        private System.Windows.Forms.Button buttonCLClear;
        private System.Windows.Forms.Button buttonCLCreateLoan;
        private System.Windows.Forms.TextBox textBoxCLAmount;
        private System.Windows.Forms.TextBox textBoxCLName;
        private System.Windows.Forms.Label labelCLType;
        private System.Windows.Forms.Label labelCLAmount;
        private System.Windows.Forms.Label labelCLName;
        private System.Windows.Forms.GroupBox groupBoxMLManageLoan;
        private System.Windows.Forms.Button buttonMLExit;
        private System.Windows.Forms.Button buttonMLMakePayment;
        private System.Windows.Forms.Label labelMLLastInterest;
        private System.Windows.Forms.Label labelMLLastPayment;
        private System.Windows.Forms.Label labelMLLoanAmountDecimal;
        private System.Windows.Forms.Label labelMLLoanAmountStr;
        private System.Windows.Forms.Label labelMLName;
        private System.Windows.Forms.GroupBox groupBoxRadioButtons;
        private System.Windows.Forms.RadioButton radioButtonLongTermLoan;
        private System.Windows.Forms.RadioButton radioButtonShortTermLoan;
    }
}

