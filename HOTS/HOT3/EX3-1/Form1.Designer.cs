
namespace EX3_1
{
    partial class FormShirtSizes
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
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelDiscountCode = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxDiscountCode = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.labelCheckDiscountCode = new System.Windows.Forms.Label();
            this.textBoxOrderSummary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(13, 29);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(80, 25);
            this.labelQuantity.TabIndex = 3;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelDiscountCode
            // 
            this.labelDiscountCode.AutoSize = true;
            this.labelDiscountCode.Location = new System.Drawing.Point(13, 118);
            this.labelDiscountCode.Name = "labelDiscountCode";
            this.labelDiscountCode.Size = new System.Drawing.Size(129, 25);
            this.labelDiscountCode.TabIndex = 4;
            this.labelDiscountCode.Text = "Discount Code";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(148, 29);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(150, 31);
            this.textBoxQuantity.TabIndex = 0;
            // 
            // textBoxDiscountCode
            // 
            this.textBoxDiscountCode.Location = new System.Drawing.Point(148, 112);
            this.textBoxDiscountCode.Name = "textBoxDiscountCode";
            this.textBoxDiscountCode.Size = new System.Drawing.Size(150, 31);
            this.textBoxDiscountCode.TabIndex = 1;
            this.textBoxDiscountCode.TextChanged += new System.EventHandler(this.textBoxDiscountCode_TextChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(357, 67);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(112, 34);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // labelCheckDiscountCode
            // 
            this.labelCheckDiscountCode.AutoSize = true;
            this.labelCheckDiscountCode.BackColor = System.Drawing.Color.Transparent;
            this.labelCheckDiscountCode.ForeColor = System.Drawing.Color.Red;
            this.labelCheckDiscountCode.Location = new System.Drawing.Point(148, 178);
            this.labelCheckDiscountCode.Name = "labelCheckDiscountCode";
            this.labelCheckDiscountCode.Size = new System.Drawing.Size(59, 25);
            this.labelCheckDiscountCode.TabIndex = 5;
            this.labelCheckDiscountCode.Text = "label1";
            // 
            // textBoxOrderSummary
            // 
            this.textBoxOrderSummary.Location = new System.Drawing.Point(13, 266);
            this.textBoxOrderSummary.Multiline = true;
            this.textBoxOrderSummary.Name = "textBoxOrderSummary";
            this.textBoxOrderSummary.ReadOnly = true;
            this.textBoxOrderSummary.Size = new System.Drawing.Size(303, 116);
            this.textBoxOrderSummary.TabIndex = 6;
            // 
            // FormShirtSizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxOrderSummary);
            this.Controls.Add(this.labelCheckDiscountCode);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.textBoxDiscountCode);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelDiscountCode);
            this.Controls.Add(this.labelQuantity);
            this.Name = "FormShirtSizes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crazy Crank\'s T-Shirt Factory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelDiscountCode;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxDiscountCode;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label labelCheckDiscountCode;
        private System.Windows.Forms.TextBox textBoxOrderSummary;
    }
}

