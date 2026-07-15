using MAQ_Online_Library.MAQDataBaseDataSet1TableAdapters;
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
    public partial class Librarian : Form
    {
        public Librarian()
        {
            InitializeComponent();
        }

        private void Librarian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksInfoDataSet.BooksTable' table. You can move, or remove it, as needed.
            this.booksTableTableAdapter.Fill(this.booksInfoDataSet.BooksTable);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                booksTableTableAdapter.SearchByName(booksInfoDataSet.BooksTable, searchTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            int bookQuantity;
            string bookName,bookCategory,bookAutherName;
            decimal bookPrice;
            try
            {
                    if (bookNameTextBox.Text != "")
                    {
                        bookName = bookNameTextBox.Text;
                        if (categoryTextBox.Text != "")
                        {
                            bookCategory = categoryTextBox.Text;
                            if (autherNameTextBox.Text != "")
                            {
                                bookAutherName = autherNameTextBox.Text;
                                if (decimal.TryParse(priceTextBox.Text, out bookPrice))
                                {
                                    if (int.TryParse(quantityTextBox.Text, out bookQuantity))
                                    {
                                    
                                    booksTableTableAdapter.Insert(bookName,bookCategory,bookAutherName,bookPrice,bookQuantity);
                                    booksTableTableAdapter.Fill(booksInfoDataSet.BooksTable);

                                    }
                                    else
                                    {
                                        MessageBox.Show("Please enter Book Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please enter Book Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter Book Auther Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter Book Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter Book Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string bookNumber = bookNumberTextBox.Text;
                //to save primary key we will search for in the list
                BooksInfoDataSet.BooksTableRow rw;
                rw = booksInfoDataSet.BooksTable.FindByBook_Number(int.Parse(bookNumber));
                //to find the primary key in the list
                booksInfoDataSet.BooksTable.Rows.Remove(rw);
                //remove the row that have the same primary key

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
