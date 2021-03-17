
namespace EX2
{
    partial class FormNetworkScanner
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
            this.labelIPAddress = new System.Windows.Forms.Label();
            this.textBoxIPAddress = new System.Windows.Forms.TextBox();
            this.buttonScan = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxCompInfo = new System.Windows.Forms.GroupBox();
            this.labelComputerName = new System.Windows.Forms.Label();
            this.labelTheIpAddress = new System.Windows.Forms.Label();
            this.groupBoxServices = new System.Windows.Forms.GroupBox();
            this.labelServices = new System.Windows.Forms.Label();
            this.groupBoxCompInfo.SuspendLayout();
            this.groupBoxServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIPAddress
            // 
            this.labelIPAddress.AutoSize = true;
            this.labelIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIPAddress.Location = new System.Drawing.Point(13, 13);
            this.labelIPAddress.Name = "labelIPAddress";
            this.labelIPAddress.Size = new System.Drawing.Size(97, 20);
            this.labelIPAddress.TabIndex = 0;
            this.labelIPAddress.Text = "IP Address";
            // 
            // textBoxIPAddress
            // 
            this.textBoxIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIPAddress.Location = new System.Drawing.Point(17, 48);
            this.textBoxIPAddress.Name = "textBoxIPAddress";
            this.textBoxIPAddress.Size = new System.Drawing.Size(295, 26);
            this.textBoxIPAddress.TabIndex = 1;
            // 
            // buttonScan
            // 
            this.buttonScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScan.Location = new System.Drawing.Point(350, 16);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(75, 58);
            this.buttonScan.TabIndex = 2;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(468, 16);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 58);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBoxCompInfo
            // 
            this.groupBoxCompInfo.Controls.Add(this.labelTheIpAddress);
            this.groupBoxCompInfo.Controls.Add(this.labelComputerName);
            this.groupBoxCompInfo.Location = new System.Drawing.Point(17, 98);
            this.groupBoxCompInfo.Name = "groupBoxCompInfo";
            this.groupBoxCompInfo.Size = new System.Drawing.Size(295, 105);
            this.groupBoxCompInfo.TabIndex = 4;
            this.groupBoxCompInfo.TabStop = false;
            this.groupBoxCompInfo.Text = "Computer Info";
            // 
            // labelComputerName
            // 
            this.labelComputerName.AutoSize = true;
            this.labelComputerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerName.Location = new System.Drawing.Point(7, 26);
            this.labelComputerName.Name = "labelComputerName";
            this.labelComputerName.Size = new System.Drawing.Size(70, 25);
            this.labelComputerName.TabIndex = 0;
            this.labelComputerName.Text = "label1";
            // 
            // labelTheIpAddress
            // 
            this.labelTheIpAddress.AutoSize = true;
            this.labelTheIpAddress.Location = new System.Drawing.Point(12, 65);
            this.labelTheIpAddress.Name = "labelTheIpAddress";
            this.labelTheIpAddress.Size = new System.Drawing.Size(51, 20);
            this.labelTheIpAddress.TabIndex = 1;
            this.labelTheIpAddress.Text = "label2";
            // 
            // groupBoxServices
            // 
            this.groupBoxServices.Controls.Add(this.labelServices);
            this.groupBoxServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxServices.Location = new System.Drawing.Point(17, 240);
            this.groupBoxServices.Name = "groupBoxServices";
            this.groupBoxServices.Size = new System.Drawing.Size(295, 300);
            this.groupBoxServices.TabIndex = 5;
            this.groupBoxServices.TabStop = false;
            this.groupBoxServices.Text = "Services";
            // 
            // labelServices
            // 
            this.labelServices.AutoSize = true;
            this.labelServices.Location = new System.Drawing.Point(16, 45);
            this.labelServices.Name = "labelServices";
            this.labelServices.Size = new System.Drawing.Size(57, 20);
            this.labelServices.TabIndex = 0;
            this.labelServices.Text = "label1";
            // 
            // FormNetworkScanner
            // 
            this.AcceptButton = this.buttonScan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.groupBoxServices);
            this.Controls.Add(this.groupBoxCompInfo);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.textBoxIPAddress);
            this.Controls.Add(this.labelIPAddress);
            this.Name = "FormNetworkScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Scanner";
            this.groupBoxCompInfo.ResumeLayout(false);
            this.groupBoxCompInfo.PerformLayout();
            this.groupBoxServices.ResumeLayout(false);
            this.groupBoxServices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIPAddress;
        private System.Windows.Forms.TextBox textBoxIPAddress;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBoxCompInfo;
        private System.Windows.Forms.Label labelTheIpAddress;
        private System.Windows.Forms.Label labelComputerName;
        private System.Windows.Forms.GroupBox groupBoxServices;
        private System.Windows.Forms.Label labelServices;
    }
}

