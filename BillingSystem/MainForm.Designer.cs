namespace BillingSystem
{
    partial class MainForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.adminBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.subheaderLabel = new System.Windows.Forms.Label();
            this.customerInfoLabel = new System.Windows.Forms.Label();
            this.adminInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(3, 29);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(780, 80);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Billing System";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminBtn
            // 
            this.adminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.Location = new System.Drawing.Point(300, 316);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(180, 50);
            this.adminBtn.TabIndex = 1;
            this.adminBtn.Text = "Admin Panel";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBtn.Location = new System.Drawing.Point(300, 248);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(180, 50);
            this.customerBtn.TabIndex = 2;
            this.customerBtn.Text = "Customer";
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // subheaderLabel
            // 
            this.subheaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subheaderLabel.Location = new System.Drawing.Point(1, 148);
            this.subheaderLabel.Name = "subheaderLabel";
            this.subheaderLabel.Size = new System.Drawing.Size(780, 50);
            this.subheaderLabel.TabIndex = 3;
            this.subheaderLabel.Text = "Welcome! Please Choose Your Role\r\n\r\n\r\n";
            this.subheaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerInfoLabel
            // 
            this.customerInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInfoLabel.Location = new System.Drawing.Point(1, 427);
            this.customerInfoLabel.Name = "customerInfoLabel";
            this.customerInfoLabel.Size = new System.Drawing.Size(780, 50);
            this.customerInfoLabel.TabIndex = 4;
            this.customerInfoLabel.Text = "Customer Button Will Take You to Food Ordering Window";
            this.customerInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminInfoLabel
            // 
            this.adminInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminInfoLabel.Location = new System.Drawing.Point(1, 477);
            this.adminInfoLabel.Name = "adminInfoLabel";
            this.adminInfoLabel.Size = new System.Drawing.Size(780, 50);
            this.adminInfoLabel.TabIndex = 5;
            this.adminInfoLabel.Text = "Admin Panel is for Restaurant Only!";
            this.adminInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.adminInfoLabel);
            this.Controls.Add(this.customerInfoLabel);
            this.Controls.Add(this.subheaderLabel);
            this.Controls.Add(this.customerBtn);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.headerLabel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Label subheaderLabel;
        private System.Windows.Forms.Label customerInfoLabel;
        private System.Windows.Forms.Label adminInfoLabel;
    }
}