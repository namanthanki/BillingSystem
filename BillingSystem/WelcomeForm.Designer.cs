namespace BillingSystem
{
    partial class WelcomeForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.nameInputBox = new System.Windows.Forms.TextBox();
            this.nameInputLabel = new System.Windows.Forms.Label();
            this.contactInputLabel = new System.Windows.Forms.Label();
            this.contactInputBox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.showMenuBtn = new System.Windows.Forms.Button();
            this.subHeaderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(1, 23);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(780, 38);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Hello! Welcome to our Restaurant";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameInputBox
            // 
            this.nameInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInputBox.Location = new System.Drawing.Point(47, 221);
            this.nameInputBox.Name = "nameInputBox";
            this.nameInputBox.Size = new System.Drawing.Size(703, 34);
            this.nameInputBox.TabIndex = 1;
            this.nameInputBox.Enter += new System.EventHandler(this.nameInputBox_Enter);
            this.nameInputBox.Leave += new System.EventHandler(this.nameInputBox_Leave);
            // 
            // nameInputLabel
            // 
            this.nameInputLabel.AutoSize = true;
            this.nameInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInputLabel.Location = new System.Drawing.Point(42, 170);
            this.nameInputLabel.Name = "nameInputLabel";
            this.nameInputLabel.Size = new System.Drawing.Size(231, 29);
            this.nameInputLabel.TabIndex = 2;
            this.nameInputLabel.Text = "What is Your Name?";
            // 
            // contactInputLabel
            // 
            this.contactInputLabel.AutoSize = true;
            this.contactInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInputLabel.Location = new System.Drawing.Point(42, 319);
            this.contactInputLabel.Name = "contactInputLabel";
            this.contactInputLabel.Size = new System.Drawing.Size(462, 29);
            this.contactInputLabel.TabIndex = 3;
            this.contactInputLabel.Text = "Please Let us Know Your Contact Number";
            // 
            // contactInputBox
            // 
            this.contactInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInputBox.Location = new System.Drawing.Point(47, 370);
            this.contactInputBox.Name = "contactInputBox";
            this.contactInputBox.Size = new System.Drawing.Size(703, 34);
            this.contactInputBox.TabIndex = 4;
            this.contactInputBox.Enter += new System.EventHandler(this.contactInputBox_Enter);
            this.contactInputBox.Leave += new System.EventHandler(this.contactInputBox_Leave);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(47, 469);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(91, 33);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // showMenuBtn
            // 
            this.showMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showMenuBtn.Location = new System.Drawing.Point(500, 469);
            this.showMenuBtn.Name = "showMenuBtn";
            this.showMenuBtn.Size = new System.Drawing.Size(250, 33);
            this.showMenuBtn.TabIndex = 6;
            this.showMenuBtn.Text = "Take me to Food Menu";
            this.showMenuBtn.UseCompatibleTextRendering = true;
            this.showMenuBtn.UseVisualStyleBackColor = true;
            this.showMenuBtn.Click += new System.EventHandler(this.showMenuBtn_Click);
            // 
            // subHeaderLabel
            // 
            this.subHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subHeaderLabel.Location = new System.Drawing.Point(0, 78);
            this.subHeaderLabel.Name = "subHeaderLabel";
            this.subHeaderLabel.Size = new System.Drawing.Size(780, 38);
            this.subHeaderLabel.TabIndex = 7;
            this.subHeaderLabel.Text = "It\'s Good Time to Eat Some ";
            this.subHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.subHeaderLabel.UseCompatibleTextRendering = true;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.subHeaderLabel);
            this.Controls.Add(this.showMenuBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.contactInputBox);
            this.Controls.Add(this.contactInputLabel);
            this.Controls.Add(this.nameInputLabel);
            this.Controls.Add(this.nameInputBox);
            this.Controls.Add(this.welcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TextBox nameInputBox;
        private System.Windows.Forms.Label nameInputLabel;
        private System.Windows.Forms.Label contactInputLabel;
        private System.Windows.Forms.TextBox contactInputBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button showMenuBtn;
        private System.Windows.Forms.Label subHeaderLabel;
    }
}

