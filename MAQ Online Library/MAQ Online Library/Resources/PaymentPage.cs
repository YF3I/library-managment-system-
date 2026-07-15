using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAQ_Online_Library.Resources
{
    public partial class PaymentPage : Form
    {
        public PaymentPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cardnum, exp, cvv;
            string cardname;

            try
            {
                if (textBox1.Text != "")
                {

                    if (int.TryParse(textBox1.Text, out cardnum)) ;


                    if (textBox2.Text != "")
                    {

                        if (int.TryParse(textBox2.Text, out exp)) ;


                        if (textBox3.Text != "")
                        {

                            if (int.TryParse(textBox3.Text, out cvv)) ;

                            if (textBox4.Text != "")
                            {
                                cardname = textBox4.Text;
                                MessageBox.Show(" Payment Successd ", "secususful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("please enter Card Name ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            MessageBox.Show("please enter the CVV ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("please enter the expirition date ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

                else
                {
                    MessageBox.Show("please enter the card number ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
