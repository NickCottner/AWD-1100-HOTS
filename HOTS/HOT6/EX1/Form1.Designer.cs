
namespace EX1
{
    partial class FormPasswordCracker
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
            this.labelMD5Hash = new System.Windows.Forms.Label();
            this.textBoxMD5Hash = new System.Windows.Forms.TextBox();
            this.buttonCrack = new System.Windows.Forms.Button();
            this.labelPasswordResult = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMD5Hash
            // 
            this.labelMD5Hash.AutoSize = true;
            this.labelMD5Hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMD5Hash.Location = new System.Drawing.Point(27, 13);
            this.labelMD5Hash.Name = "labelMD5Hash";
            this.labelMD5Hash.Size = new System.Drawing.Size(93, 20);
            this.labelMD5Hash.TabIndex = 3;
            this.labelMD5Hash.Text = "MD5 Hash";
            // 
            // textBoxMD5Hash
            // 
            this.textBoxMD5Hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMD5Hash.Location = new System.Drawing.Point(31, 48);
            this.textBoxMD5Hash.Name = "textBoxMD5Hash";
            this.textBoxMD5Hash.Size = new System.Drawing.Size(381, 26);
            this.textBoxMD5Hash.TabIndex = 0;
            // 
            // buttonCrack
            // 
            this.buttonCrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrack.Location = new System.Drawing.Point(444, 33);
            this.buttonCrack.Name = "buttonCrack";
            this.buttonCrack.Size = new System.Drawing.Size(75, 41);
            this.buttonCrack.TabIndex = 1;
            this.buttonCrack.Text = "Crack";
            this.buttonCrack.UseVisualStyleBackColor = true;
            this.buttonCrack.Click += new System.EventHandler(this.buttonCrack_Click);
            // 
            // labelPasswordResult
            // 
            this.labelPasswordResult.BackColor = System.Drawing.Color.Red;
            this.labelPasswordResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordResult.Location = new System.Drawing.Point(31, 101);
            this.labelPasswordResult.Name = "labelPasswordResult";
            this.labelPasswordResult.Size = new System.Drawing.Size(155, 23);
            this.labelPasswordResult.TabIndex = 2;
            this.labelPasswordResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(544, 33);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 41);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormPasswordCracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 161);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelPasswordResult);
            this.Controls.Add(this.buttonCrack);
            this.Controls.Add(this.textBoxMD5Hash);
            this.Controls.Add(this.labelMD5Hash);
            this.Name = "FormPasswordCracker";
            this.Text = "Password Cracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMD5Hash;
        private System.Windows.Forms.TextBox textBoxMD5Hash;
        private System.Windows.Forms.Button buttonCrack;
        private System.Windows.Forms.Label labelPasswordResult;
        private System.Windows.Forms.Button buttonClear;
    }
}

