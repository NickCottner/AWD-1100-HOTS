
namespace Ex1
{
    partial class FormAddressBook
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelFNorLN = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxSearchResults = new System.Windows.Forms.GroupBox();
            this.labelthePhoneNumber = new System.Windows.Forms.Label();
            this.labelTheLastName = new System.Windows.Forms.Label();
            this.labelTheFirstName = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.groupBoxSearchResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(24, 74);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(207, 31);
            this.textBoxSearch.TabIndex = 0;
            // 
            // labelFNorLN
            // 
            this.labelFNorLN.AutoSize = true;
            this.labelFNorLN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFNorLN.Location = new System.Drawing.Point(24, 29);
            this.labelFNorLN.Name = "labelFNorLN";
            this.labelFNorLN.Size = new System.Drawing.Size(220, 25);
            this.labelFNorLN.TabIndex = 1;
            this.labelFNorLN.Text = "First Name or Last Name";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(298, 29);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(112, 34);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(298, 70);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 34);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(452, 55);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 34);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxSearchResults
            // 
            this.groupBoxSearchResults.BackColor = System.Drawing.Color.Crimson;
            this.groupBoxSearchResults.Controls.Add(this.labelthePhoneNumber);
            this.groupBoxSearchResults.Controls.Add(this.labelTheLastName);
            this.groupBoxSearchResults.Controls.Add(this.labelTheFirstName);
            this.groupBoxSearchResults.Controls.Add(this.labelPhoneNumber);
            this.groupBoxSearchResults.Controls.Add(this.labelLastName);
            this.groupBoxSearchResults.Controls.Add(this.labelFirstName);
            this.groupBoxSearchResults.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchResults.Location = new System.Drawing.Point(24, 161);
            this.groupBoxSearchResults.Name = "groupBoxSearchResults";
            this.groupBoxSearchResults.Size = new System.Drawing.Size(454, 277);
            this.groupBoxSearchResults.TabIndex = 3;
            this.groupBoxSearchResults.TabStop = false;
            this.groupBoxSearchResults.Text = "Search Results";
            // 
            // labelthePhoneNumber
            // 
            this.labelthePhoneNumber.BackColor = System.Drawing.Color.Maroon;
            this.labelthePhoneNumber.ForeColor = System.Drawing.Color.White;
            this.labelthePhoneNumber.Location = new System.Drawing.Point(115, 162);
            this.labelthePhoneNumber.Name = "labelthePhoneNumber";
            this.labelthePhoneNumber.Size = new System.Drawing.Size(271, 38);
            this.labelthePhoneNumber.TabIndex = 5;
            // 
            // labelTheLastName
            // 
            this.labelTheLastName.BackColor = System.Drawing.Color.Maroon;
            this.labelTheLastName.ForeColor = System.Drawing.Color.White;
            this.labelTheLastName.Location = new System.Drawing.Point(115, 95);
            this.labelTheLastName.Name = "labelTheLastName";
            this.labelTheLastName.Size = new System.Drawing.Size(271, 38);
            this.labelTheLastName.TabIndex = 4;
            // 
            // labelTheFirstName
            // 
            this.labelTheFirstName.BackColor = System.Drawing.Color.Maroon;
            this.labelTheFirstName.ForeColor = System.Drawing.Color.White;
            this.labelTheFirstName.Location = new System.Drawing.Point(115, 31);
            this.labelTheFirstName.Name = "labelTheFirstName";
            this.labelTheFirstName.Size = new System.Drawing.Size(271, 38);
            this.labelTheFirstName.TabIndex = 3;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(9, 162);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(92, 25);
            this.labelPhoneNumber.TabIndex = 2;
            this.labelPhoneNumber.Text = "Phone # :";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(9, 95);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(106, 25);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(7, 31);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(108, 25);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
            // 
            // FormAddressBook
            // 
            this.AcceptButton = this.buttonSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxSearchResults);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelFNorLN);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "FormAddressBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address Book";
            this.groupBoxSearchResults.ResumeLayout(false);
            this.groupBoxSearchResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelFNorLN;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxSearchResults;
        private System.Windows.Forms.Label labelthePhoneNumber;
        private System.Windows.Forms.Label labelTheLastName;
        private System.Windows.Forms.Label labelTheFirstName;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
    }
}

