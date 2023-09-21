using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class BillingForm : Form
    {
        string contact;

        public BillingForm(string contact)
        {
            InitializeComponent();
            this.contact = contact;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int totalBillAmount = 0;
            bool Found = false;
            if (DataGridTable.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DataGridTable.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == ProductsComboBox.Text &&
                        Convert.ToString(row.Cells[1].Value) == PriceTextBox.Text)
                    {
                        row.Cells[2].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[2].Value));
                        Found = true;
                    }
                }

                if (!Found)
                {
                    DataGridTable.Rows.Add(ProductsComboBox.Text, PriceTextBox.Text, QuantityComboBox.Text);
                }
            }
            else
            {
                DataGridTable.Rows.Add(ProductsComboBox.Text, PriceTextBox.Text, QuantityComboBox.Text);
            }

            foreach (DataGridViewRow row in DataGridTable.Rows)
            {
                int productTotal = (Convert.ToInt32(row.Cells[DataGridTable.Columns["ProductPrice"].Index].Value) * Convert.ToInt32(row.Cells[DataGridTable.Columns["ProductQuantity"].Index].Value));
                row.Cells[DataGridTable.Columns["ProductTotalAmount"].Index].Value = productTotal;
                totalBillAmount += productTotal;
            }

            TotalBillLabel.Text = "Count Total: ";
            TotalBillLabel.Text += totalBillAmount.ToString();
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\naman\source\repos\BillingSystem\BillingSystem\BillingSystem.mdf;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            string query = 
                "SELECT name FROM CUSTOMER " 
                + "WHERE contact = @contact";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@contact", this.contact);

            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                string customerName = reader["name"].ToString();
                CustomerNameLabel.Text += customerName;
            }

            sqlConnection.Close();
        }

        private void DataGridTable_SelectionChanged(object sender, EventArgs e)
        {
            int totalBillAmount = 0;

            foreach (DataGridViewRow row in DataGridTable.Rows)
            {
                int productTotal = (Convert.ToInt32(row.Cells[DataGridTable.Columns["ProductPrice"].Index].Value) * Convert.ToInt32(row.Cells[DataGridTable.Columns["ProductQuantity"].Index].Value));
                row.Cells[DataGridTable.Columns["ProductTotalAmount"].Index].Value = productTotal;
                totalBillAmount += productTotal;
            }

            TotalBillLabel.Text = "Count Total: ";
            TotalBillLabel.Text += totalBillAmount.ToString();
        }
    }
}
