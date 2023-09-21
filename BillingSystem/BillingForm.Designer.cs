namespace BillingSystem
{
    partial class BillingForm
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.QuantityComboBox = new System.Windows.Forms.ComboBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ProductsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridTable = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBillLabel = new System.Windows.Forms.Label();
            this.FinishButton = new System.Windows.Forms.Button();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(880, 65);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // QuantityComboBox
            // 
            this.QuantityComboBox.FormattingEnabled = true;
            this.QuantityComboBox.Location = new System.Drawing.Point(692, 64);
            this.QuantityComboBox.Name = "QuantityComboBox";
            this.QuantityComboBox.Size = new System.Drawing.Size(144, 24);
            this.QuantityComboBox.TabIndex = 10;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(469, 66);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(124, 22);
            this.PriceTextBox.TabIndex = 9;
            // 
            // ProductsComboBox
            // 
            this.ProductsComboBox.FormattingEnabled = true;
            this.ProductsComboBox.Items.AddRange(new object[] {
            "Tea",
            "Coffee",
            "Biscuits",
            "Chips",
            "Bread Butter",
            "Vegetable Sandwich ",
            "Idli",
            "Dosa",
            "Masala Dosa"});
            this.ProductsComboBox.Location = new System.Drawing.Point(179, 64);
            this.ProductsComboBox.Name = "ProductsComboBox";
            this.ProductsComboBox.Size = new System.Drawing.Size(214, 24);
            this.ProductsComboBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantity";
            // 
            // DataGridTable
            // 
            this.DataGridTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ProductPrice,
            this.ProductQuantity,
            this.ProductTotalAmount});
            this.DataGridTable.Location = new System.Drawing.Point(83, 137);
            this.DataGridTable.Name = "DataGridTable";
            this.DataGridTable.RowHeadersWidth = 51;
            this.DataGridTable.RowTemplate.Height = 24;
            this.DataGridTable.Size = new System.Drawing.Size(872, 376);
            this.DataGridTable.TabIndex = 14;
            this.DataGridTable.SelectionChanged += new System.EventHandler(this.DataGridTable_SelectionChanged);
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.HeaderText = "Quantity";
            this.ProductQuantity.MinimumWidth = 6;
            this.ProductQuantity.Name = "ProductQuantity";
            // 
            // ProductTotalAmount
            // 
            this.ProductTotalAmount.HeaderText = "Product Total Amount";
            this.ProductTotalAmount.MinimumWidth = 6;
            this.ProductTotalAmount.Name = "ProductTotalAmount";
            // 
            // TotalBillLabel
            // 
            this.TotalBillLabel.AutoSize = true;
            this.TotalBillLabel.Location = new System.Drawing.Point(83, 577);
            this.TotalBillLabel.Name = "TotalBillLabel";
            this.TotalBillLabel.Size = new System.Drawing.Size(81, 16);
            this.TotalBillLabel.TabIndex = 15;
            this.TotalBillLabel.Text = "Count Total: ";
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(879, 575);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 23);
            this.FinishButton.TabIndex = 17;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(80, 25);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(110, 16);
            this.CustomerNameLabel.TabIndex = 18;
            this.CustomerNameLabel.Text = "Customer Name: ";
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 633);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.TotalBillLabel);
            this.Controls.Add(this.DataGridTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.QuantityComboBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.ProductsComboBox);
            this.Controls.Add(this.label1);
            this.Name = "BillingForm";
            this.Text = "BillingForm";
            this.Load += new System.EventHandler(this.BillingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox QuantityComboBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.ComboBox ProductsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridTable;
        private new System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTotalAmount;
        private System.Windows.Forms.Label TotalBillLabel;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Label CustomerNameLabel;
    }
}