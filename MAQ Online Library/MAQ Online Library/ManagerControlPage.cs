using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAQ_Online_Library
{
    public partial class ManagerControlPage : Form
    {
        public ManagerControlPage()
        {
            InitializeComponent();
        }

        private void ManagerControlPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mAQDataBaseDataSet1.BorrowerTable' table. You can move, or remove it, as needed.
            this.borrowerTableTableAdapter.Fill(this.mAQDataBaseDataSet1.BorrowerTable);
            // TODO: This line of code loads data into the 'mAQDataBaseDataSet1.BorrowerTable' table. You can move, or remove it, as needed.
            this.borrowerTableTableAdapter.Fill(this.mAQDataBaseDataSet1.BorrowerTable);

        }
        
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (idTextBox.Text != "")
                {
                    string idN = idTextBox.Text; //to save primary key we will search for in the list
                    MAQDataBaseDataSet1.BorrowerTableRow rw;
                    rw = mAQDataBaseDataSet1.BorrowerTable.FindById(int.Parse(idN));
                    //int parse cuz Id initatlized as int 
                    //to find the primary key in the list
                    mAQDataBaseDataSet1.BorrowerTable.Rows.Remove(rw);
                    //remove the row that have the same primary key 
                }
                else
                {
                    MessageBox.Show("Please enter Id Number to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Librarian Table
                MAQDataBaseDataSet1.BorrowerTableRow rw;
                rw = mAQDataBaseDataSet1.BorrowerTable.NewBorrowerTableRow();
                rw.Id = int.Parse(idTextBox.Text);
                rw.LibrarianName = librarianTextBox.Text;
                rw.Password = passwordTextBox.Text;
                rw.Email = emailTextBox.Text;
                rw.Phone_Number = int.Parse(phoneNumberTextBox.Text);

                mAQDataBaseDataSet1.BorrowerTable.Rows.Add(rw);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                int phoneNumber;
                string librarianName, password, email;
                if (librarianTextBox.Text != "")
                {
                    librarianName = librarianTextBox.Text;
                    if (passwordTextBox.Text != "")
                    {
                        password = passwordTextBox.Text;
                        if (emailTextBox.Text != "")
                        {
                            email = emailTextBox.Text;
                            if (int.TryParse(phoneNumberTextBox.Text, out phoneNumber))
                            {

                                borrowerTableTableAdapter.Insert(librarianName, password, email, phoneNumber);
                                borrowerTableTableAdapter.Fill(mAQDataBaseDataSet1.BorrowerTable);

                            }
                            else
                            {
                                MessageBox.Show("Please enter Laibrarian phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter Laibrarian email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter Laibrarian password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Librarian Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void saveButton_Click(object sender, EventArgs e){
            try
            {
                borrowerTableBindingSource.EndEdit();
                borrowerTableTableAdapter.Update(mAQDataBaseDataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                borrowerTableBindingSource.MoveNext();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            try
            {
                borrowerTableBindingSource.MovePrevious();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            try
            {
                borrowerTableBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            try
            {
                borrowerTableBindingSource.MoveFirst();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
