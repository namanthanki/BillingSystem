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
    public partial class AdminProductsForm : Form
    {
        public AdminProductsForm()
        {
            InitializeComponent();
        }

        private void ShowDataGridView()
        {
            DGV.Rows.Clear();

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\naman\source\repos\BillingSystem\BillingSystem\BillingSystem.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string query = "SELECT * FROM PRODUCT";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string id = reader.GetFieldValue<int>(0).ToString();
                    string name = reader.GetFieldValue<string>(1);
                    string price = reader.GetFieldValue<int>(2).ToString();
  
                    string[] row = { id, name, price };

                    DGV.Rows.Add(row);
                }
            }

            conn.Close();
        }

        private void FillProductNames()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\naman\source\repos\BillingSystem\BillingSystem\BillingSystem.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string query = "SELECT name FROM PRODUCT";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            List<string> itemsList = new List<string>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string name = reader.GetString(0).ToString();
                    itemsList.Add(name);
                }
            }

            ProductNameComboBox.DataSource = itemsList;

            conn.Close();
        }

        private void AdminProductsForm_Load(object sender, EventArgs e)
        {
            FillProductNames();
            ShowDataGridView();
        }

        private void ProductNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\naman\source\repos\BillingSystem\BillingSystem\BillingSystem.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string query = "SELECT price FROM PRODUCT WHERE name = @name";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@name", ProductNameComboBox.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                PriceTextBox.Text = reader.GetFieldValue<int>(0).ToString();
            }

            conn.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\naman\source\repos\BillingSystem\BillingSystem\BillingSystem.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string searchProductQuery = "SELECT name FROM PRODUCT WHERE name = @name";
            SqlCommand searchCommand = new SqlCommand(searchProductQuery, conn);

            searchCommand.Parameters.AddWithValue("@name", ProductNameComboBox.Text);

            SqlDataReader reader = searchCommand.ExecuteReader();

            if(!reader.HasRows)
            {
                reader.Close();

                string query = "INSERT INTO PRODUCT(name, price) VALUES(@name, @price)";
                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@name", ProductNameComboBox.Text);
                command.Parameters.AddWithValue("@price", Convert.ToInt32(PriceTextBox.Text));

                command.ExecuteNonQuery();
    
                MessageBox.Show("Added Successfully.");
            } else
            {
                MessageBox.Show("Already Exists!");
            }

            conn.Close();

            ShowDataGridView();
        }

        bool CheckForNameConflict(SqlConnection connection, string name, int id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandText = "SELECT COUNT(*) FROM Product WHERE Name = @name AND Id <> @id";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@id", id);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\naman\source\repos\BillingSystem\BillingSystem\BillingSystem.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string searchProductQuery = "SELECT * FROM PRODUCT WHERE name = @name";
            SqlCommand searchCommand = new SqlCommand(searchProductQuery, conn);

            searchCommand.Parameters.AddWithValue("@name", ProductNameComboBox.Text);

            bool isNewName = CheckForNameConflict(conn, ProductNameComboBox.Text, Convert.ToInt32(DGV.SelectedCells[0].Value));

            if (!isNewName)
            {
                string query = "UPDATE PRODUCT SET name = @name, price = @price WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@id", DGV.SelectedCells[0].Value);
                command.Parameters.AddWithValue("@name", ProductNameComboBox.Text);
                command.Parameters.AddWithValue("@price", PriceTextBox.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Updated Successfully.");
            } else
            {
                MessageBox.Show("Already Exists!.");
            }

            conn.Close();

            ShowDataGridView();
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateButton.Enabled = true;
            DeleteButton.Enabled = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\naman\source\repos\BillingSystem\BillingSystem\BillingSystem.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string query = "DELETE FROM PRODUCT WHERE id = @id";
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@id", Convert.ToInt64(DGV.SelectedCells[0].Value));

            command.ExecuteNonQuery();

            MessageBox.Show("Deleted Successfully.");

            conn.Close();

            ShowDataGridView();
        }
    }
}
