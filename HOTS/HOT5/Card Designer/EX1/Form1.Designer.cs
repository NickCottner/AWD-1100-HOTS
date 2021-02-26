
namespace EX1
{
    partial class FormCD
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
            this.labelOccasion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOccasion = new System.Windows.Forms.ComboBox();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.checkBoxEnv = new System.Windows.Forms.CheckBox();
            this.checkBoxStamp = new System.Windows.Forms.CheckBox();
            this.checkBoxCM = new System.Windows.Forms.CheckBox();
            this.labelCM = new System.Windows.Forms.Label();
            this.labelTC = new System.Windows.Forms.Label();
            this.pictureBoxStyle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStyle)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOccasion
            // 
            this.labelOccasion.AutoSize = true;
            this.labelOccasion.Location = new System.Drawing.Point(13, 13);
            this.labelOccasion.Name = "labelOccasion";
            this.labelOccasion.Size = new System.Drawing.Size(84, 25);
            this.labelOccasion.TabIndex = 0;
            this.labelOccasion.Text = "Occasion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Style";
            // 
            // comboBoxOccasion
            // 
            this.comboBoxOccasion.FormattingEnabled = true;
            this.comboBoxOccasion.Location = new System.Drawing.Point(104, 13);
            this.comboBoxOccasion.Name = "comboBoxOccasion";
            this.comboBoxOccasion.Size = new System.Drawing.Size(182, 33);
            this.comboBoxOccasion.TabIndex = 0;
            this.comboBoxOccasion.Enter += new System.EventHandler(this.comboBoxOccasion_Enter);
            this.comboBoxOccasion.Leave += new System.EventHandler(this.comboBoxOccasion_Leave);
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Location = new System.Drawing.Point(104, 70);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(182, 33);
            this.comboBoxStyle.TabIndex = 1;
            this.comboBoxStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxStyle_SelectedIndexChanged);
            this.comboBoxStyle.Enter += new System.EventHandler(this.comboBoxStyle_Enter);
            this.comboBoxStyle.Leave += new System.EventHandler(this.comboBoxStyle_Leave);
            // 
            // checkBoxEnv
            // 
            this.checkBoxEnv.AutoSize = true;
            this.checkBoxEnv.Location = new System.Drawing.Point(13, 119);
            this.checkBoxEnv.Name = "checkBoxEnv";
            this.checkBoxEnv.Size = new System.Drawing.Size(169, 29);
            this.checkBoxEnv.TabIndex = 2;
            this.checkBoxEnv.Text = "Envelope ($0.25)";
            this.checkBoxEnv.UseVisualStyleBackColor = true;
            this.checkBoxEnv.Enter += new System.EventHandler(this.checkBoxEnv_Enter);
            this.checkBoxEnv.Leave += new System.EventHandler(this.checkBoxEnv_Leave);
            // 
            // checkBoxStamp
            // 
            this.checkBoxStamp.AutoSize = true;
            this.checkBoxStamp.Location = new System.Drawing.Point(12, 154);
            this.checkBoxStamp.Name = "checkBoxStamp";
            this.checkBoxStamp.Size = new System.Drawing.Size(148, 29);
            this.checkBoxStamp.TabIndex = 3;
            this.checkBoxStamp.Text = "Stamp ($0.50)";
            this.checkBoxStamp.UseVisualStyleBackColor = true;
            this.checkBoxStamp.Enter += new System.EventHandler(this.checkBoxStamp_Enter);
            this.checkBoxStamp.Leave += new System.EventHandler(this.checkBoxStamp_Leave);
            // 
            // checkBoxCM
            // 
            this.checkBoxCM.AutoSize = true;
            this.checkBoxCM.Location = new System.Drawing.Point(12, 189);
            this.checkBoxCM.Name = "checkBoxCM";
            this.checkBoxCM.Size = new System.Drawing.Size(234, 29);
            this.checkBoxCM.TabIndex = 4;
            this.checkBoxCM.Text = "Custom Message ($0.30)";
            this.checkBoxCM.UseVisualStyleBackColor = true;
            this.checkBoxCM.Enter += new System.EventHandler(this.checkBoxCM_Enter);
            this.checkBoxCM.Leave += new System.EventHandler(this.checkBoxCM_Leave);
            // 
            // labelCM
            // 
            this.labelCM.BackColor = System.Drawing.Color.Red;
            this.labelCM.Location = new System.Drawing.Point(13, 221);
            this.labelCM.Name = "labelCM";
            this.labelCM.Size = new System.Drawing.Size(320, 165);
            this.labelCM.TabIndex = 5;
            this.labelCM.Enter += new System.EventHandler(this.labelCM_Enter);
            this.labelCM.Leave += new System.EventHandler(this.labelCM_Leave);
            // 
            // labelTC
            // 
            this.labelTC.BackColor = System.Drawing.Color.Red;
            this.labelTC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTC.Location = new System.Drawing.Point(12, 400);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(234, 38);
            this.labelTC.TabIndex = 7;
            this.labelTC.Enter += new System.EventHandler(this.labelTC_Enter);
            this.labelTC.Leave += new System.EventHandler(this.labelTC_Leave);
            // 
            // pictureBoxStyle
            // 
            this.pictureBoxStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxStyle.Location = new System.Drawing.Point(363, 13);
            this.pictureBoxStyle.Name = "pictureBoxStyle";
            this.pictureBoxStyle.Size = new System.Drawing.Size(590, 425);
            this.pictureBoxStyle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStyle.TabIndex = 8;
            this.pictureBoxStyle.TabStop = false;
            // 
            // FormCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.pictureBoxStyle);
            this.Controls.Add(this.labelTC);
            this.Controls.Add(this.labelCM);
            this.Controls.Add(this.checkBoxCM);
            this.Controls.Add(this.checkBoxStamp);
            this.Controls.Add(this.checkBoxEnv);
            this.Controls.Add(this.comboBoxStyle);
            this.Controls.Add(this.comboBoxOccasion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOccasion);
            this.Name = "FormCD";
            this.Text = "Card Designer";
            this.Activated += new System.EventHandler(this.FormCD_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStyle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOccasion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOccasion;
        private System.Windows.Forms.ComboBox comboBoxStyle;
        private System.Windows.Forms.CheckBox checkBoxEnv;
        private System.Windows.Forms.CheckBox checkBoxStamp;
        private System.Windows.Forms.CheckBox checkBoxCM;
        private System.Windows.Forms.Label labelCM;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.PictureBox pictureBoxStyle;
    }
}

