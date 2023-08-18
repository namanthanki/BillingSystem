using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class WelcomeForm : Form
    {
        bool validateNameErrorFlag = false;
        bool validateContactErrorFlag = false;

        bool isValidName(string name)
        {
            foreach (char c in name)
            {
                if(!char.IsLetter(c))
                {
                    return false;
                }
            }

            return true;
        }

        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            int timeHour = Convert.ToInt32(DateTime.Now.Hour.ToString());
            string message = String.Empty;
            if(timeHour >= 4 && timeHour < 12)
            {
                subHeaderLabel.Text += "Breakfast";
            } else if(timeHour >= 12 && timeHour < 16)
            {
                subHeaderLabel.Text += "Lunch";
            } else if(timeHour >= 16 && timeHour < 19)
            {
                subHeaderLabel.Text += "Snacks";
            } else
            {
                subHeaderLabel.Text += "Dinner";
            }
        }
        private void nameInputBox_Leave(object sender, EventArgs e)
        {
            string customerName = nameInputBox.Text.Trim();

            if(!isValidName(customerName))
            {
                nameInputBox.Clear();
                validateNameErrorFlag = true;
                nameInputBox.Text = "Please Enter Alphabets Only!";
                nameInputBox.ForeColor = Color.Red;
            } else
            {
                validateNameErrorFlag = false;
            }
        }
        private void nameInputBox_Enter(object sender, EventArgs e)
        {
            if(validateNameErrorFlag)
            {
                nameInputBox.Clear();
                nameInputBox.ForeColor = Color.Black;
            }
        }

        private void contactInputBox_Leave(object sender, EventArgs e)
        {
            string contactNumber = contactInputBox.Text;
            Regex regex = new Regex(@"^(\+91){0,1}[7-9]\d{9}$");
            if (contactInputBox.Text != String.Empty && !regex.IsMatch(contactNumber))
            {
                contactInputBox.Clear();
                validateContactErrorFlag = true;
                contactInputBox.Text = "Please Enter Valid Contact Number!";
                contactInputBox.ForeColor = Color.Red;
            } else
            {
                validateContactErrorFlag = false;
            }
        }
        private void contactInputBox_Enter(object sender, EventArgs e)
        {
            if(validateContactErrorFlag)
            {
                contactInputBox.Clear();
                contactInputBox.ForeColor = Color.Black;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showMenuBtn_Click(object sender, EventArgs e)
        {
            bool condition = String.IsNullOrWhiteSpace(nameInputBox.Text) || String.IsNullOrWhiteSpace(contactInputBox.Text);
            if(condition)
            {
                validateNameErrorFlag = true;
                validateContactErrorFlag = true;

                nameInputBox.Text = "This Field is Required!";
                nameInputBox.ForeColor = Color.Red;

                contactInputBox.Text = "This Field is Required!";
                contactInputBox.ForeColor = Color.Red;
            } else
            {
                //Todo
            }
        }
    }
}
