using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            AdminProductsForm adminProductsForm = new AdminProductsForm();
            adminProductsForm.Show();
        }
    }
}
