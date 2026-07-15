using MAQ_Online_Library.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAQ_Online_Library
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mAQDataBaseDataSet1.BorrowerTable' table. You can move, or remove it, as needed.
            this.borrowerTableTableAdapter.Fill(this.mAQDataBaseDataSet1.BorrowerTable);
            // TODO: This line of code loads data into the 'mAQDataBaseDataSet1.UserTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.Fill(this.mAQDataBaseDataSet1.UserTable);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Borrowerrr go = new Borrowerrr();
                Librarian lb = new Librarian();
                if (userNameTextBox.Text != "")
                {
                    string enteredUsername = userNameTextBox.Text;
                    if (passwordTextBox.Text != "")
                    {
                        string enterdpassword = passwordTextBox.Text;
                        string response = userTableTableAdapter.Login(enteredUsername, enterdpassword).ToString();
                        string laibrarianresponse = borrowerTableTableAdapter.LibrarianLogin(enteredUsername,enterdpassword).ToString();
                        if (response != "")
                        {
                            if (borrowerRadioButton.Checked || librarianRadioButton.Checked)
                            {
                                if (borrowerRadioButton.Checked)
                                {
                                  go.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("Choose right user type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Choose user type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else if (laibrarianresponse != "")
                        {
                            if (borrowerRadioButton.Checked || librarianRadioButton.Checked)
                            {
                                if (librarianRadioButton.Checked)
                            {
                                lb.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Choose right user type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                            else
                            {
                                MessageBox.Show("Choose user type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            }
                            
                        else
                        {
                            MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            userNameTextBox.Focus();
                            userNameTextBox.Text = "";
                            passwordTextBox.Text = "";
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please type your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        passwordTextBox.Text = "";
                        passwordTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please type your username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    userNameTextBox.Text = "";
                    userNameTextBox.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string email, singUpUsername, singUpPassword, confirmPass;
            int phoneNumber;
            try
            {
                if (emailTextBox.Text != "")
                {
                    email = emailTextBox.Text;
                    if (int.TryParse(phoneNumberTextBox.Text, out phoneNumber))
                    {
                        if (signUpUsernameTextBox.Text != "")
                        {
                            singUpUsername = signUpUsernameTextBox.Text;
                            if (signUpPasswordTextBox.Text != "")
                            {
                                singUpPassword = signUpPasswordTextBox.Text;
                                if (confirmpasswordTextBox.Text != "")
                                {
                                    confirmPass = confirmpasswordTextBox.Text;
                                    if (singUpPassword != confirmPass)
                                    {
                                        MessageBox.Show("Sorry your confirm password is not matching the first password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        confirmpasswordTextBox.Text = "";
                                        confirmpasswordTextBox.Focus();
                                        return;
                                    }

                                    MessageBox.Show("You signed up sucessfuly");
                                    
                                        userTableTableAdapter.Insert(singUpUsername, singUpPassword, phoneNumber, email);
                                        userTableTableAdapter.Fill(mAQDataBaseDataSet1.UserTable);

                                        emailTextBox.Text = "";
                                        signUpPasswordTextBox.Text = "";
                                        signUpUsernameTextBox.Text = "";
                                        confirmpasswordTextBox.Text = "";
                                        phoneNumberTextBox.Text = "";
                                    signUpUsernameTextBox.Text = "";

                                }
                                else
                                {
                                    MessageBox.Show("please enter your password confiramtion.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                    confirmpasswordTextBox.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("please enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                signUpPasswordTextBox.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("please enter your Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            signUpUsernameTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("please enter your Phone Number. (your phone number shoud be numaric value!)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        phoneNumberTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("please enter your email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emailTextBox.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void loginAsManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Manager manager = new Manager();
                manager.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AboutUs aboutUs = new AboutUs();
            aboutUs.ShowDialog();
        }
    }
}
