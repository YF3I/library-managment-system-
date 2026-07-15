using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAQ_Online_Library
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'managerDataBaseDataSet.ManagerrTable' table. You can move, or remove it, as needed.
            this.managerrTableTableAdapter.Fill(this.managerDataBaseDataSet.ManagerrTable);

        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginnButton_Click(object sender, EventArgs e)
        {
            try
            {
                ManagerControlPage managerControlPage = new ManagerControlPage();
                string username, password;
                if (userNameTextBox.Text != "")
                {
                    username = userNameTextBox.Text;
                    if (passwordTextBox.Text != "")
                    {
                        password = passwordTextBox.Text;

                        string response = managerrTableTableAdapter.ManagerLogin(username, password).ToString();
                        if (response != "")
                        {
                            managerControlPage.Show();
                        }
                        else
                        {
                            MessageBox.Show("Correct your data boss !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            userNameTextBox.Text = "";
                            passwordTextBox.Text = "";
                            userNameTextBox.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please enter your password boss !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        passwordTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your username boss !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    userNameTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
