using System;
using System.Windows.Forms;

namespace MAQ_Online_Library.Resources
{
    public partial class Borrowerrr : Form
    {
        public Borrowerrr()
        {
            InitializeComponent();
        }
        const decimal RENT = 3 , Pelanty = 0.5m , HARDCOPY = 10.0m , DOWNLOADING = 4.5M , FLASH = 1.0m;
        decimal total=0;
        private void dramabutton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fiction books tell stories!" +
               " They can be anything from mysteries that keep you guessing to fantastical adventures in far-off lands." +
               " They're for enjoyment and exploring different worlds.", "Fiction Book Diffinition", MessageBoxButtons.OK);
        }
        private void BookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (BookListBox.SelectedIndex != -1)


                {

                    if (BookListBox.SelectedIndex == 0)
                    {
                        academicsGroupBox1.Visible = true;
                        FictiongroupBox1.Visible = false;
                        NonFictionGroupBox1.Visible = false;
                        poetryGgroupBox1.Visible = false;
                        DramaGroupBox1.Visible = false;
                        LiteraturegroupBox1.Visible = false;
                    }
                    else if (BookListBox.SelectedIndex == 1)
                    {
                        academicsGroupBox1.Visible = false;
                        FictiongroupBox1.Visible = true;
                        NonFictionGroupBox1.Visible = false;
                        poetryGgroupBox1.Visible = false;
                        DramaGroupBox1.Visible = false;
                        LiteraturegroupBox1.Visible = false;
                    }
                    else if (BookListBox.SelectedIndex == 2)
                    {
                        academicsGroupBox1.Visible = false;
                        FictiongroupBox1.Visible = false;
                        NonFictionGroupBox1.Visible = true;
                        poetryGgroupBox1.Visible = false;
                        DramaGroupBox1.Visible = false;
                        LiteraturegroupBox1.Visible = false;
                    }
                    else if (BookListBox.SelectedIndex == 3)
                    {
                        academicsGroupBox1.Visible = false;
                        FictiongroupBox1.Visible = false;
                        NonFictionGroupBox1.Visible = false;
                        poetryGgroupBox1.Visible = true;
                        DramaGroupBox1.Visible = false;
                        LiteraturegroupBox1.Visible = false;
                    }
                    else if (BookListBox.SelectedIndex == 4)
                    {
                        academicsGroupBox1.Visible = false;
                        FictiongroupBox1.Visible = false;
                        NonFictionGroupBox1.Visible = false;
                        poetryGgroupBox1.Visible = false;
                        DramaGroupBox1.Visible = true;
                        LiteraturegroupBox1.Visible = false;
                    }
                    else if (BookListBox.SelectedIndex == 5)
                    {
                        academicsGroupBox1.Visible = false;
                        FictiongroupBox1.Visible = false;
                        NonFictionGroupBox1.Visible = false;
                        poetryGgroupBox1.Visible = false;
                        DramaGroupBox1.Visible = false;
                        LiteraturegroupBox1.Visible = true;
                    }
                    else { MessageBox.Show("select again "); }




                }
                else { MessageBox.Show("please select a catagory ", "Remainder", MessageBoxButtons.OK); }
            }
            catch (Exception ex) { MessageBox.Show("please choose a catagory ", "Remainder", MessageBoxButtons.OK); }
        }

        private void And_Tango_Makes_Three_2005_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(And_Tango_Makes_Three_2005.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void down_2017_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(down_2017.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void nausea_1938_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(nausea_1938.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void san_sombrero_2008_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(san_sombrero_2008.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void tales_from_the_secret_annex_1960_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(tales_from_the_secret_annex_1960.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void the_navagitor_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(the_navagitor.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Poetry books are collections of poems, written to evoke emotions and ideas through creative use of language. Imagine a treasure chest filled with words that paint pictures, sing, and surprise you.", "Poetry Book Diffinition", MessageBoxButtons.OK);

        }

        private void crank_2004_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(crank_2004.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void fallout_2010_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(fallout_2010.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void Me_2019_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(Me_2019.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void milk_and_honey_2001_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(milk_and_honey_2001.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void the_cross_over_2014_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(the_cross_over_2014.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void the_prophet_1923_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(the_prophet_1923.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void Literaturebutton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Literature books are works of fiction or non-fiction considered to have artistic merit and lasting importance. They explore themes, use language in creative ways, and offer insights into the human condition. Think novels like Pride and Prejudice or poems like Ode to a Nightingale.", "Literature Book Diffinition", MessageBoxButtons.OK);
        }

        private void asymmetry_2018_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(asymmetry_2018.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void HHhH_2010_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(HHhH_2010.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void lila_2014_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(lila_2014.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void m_Train_2015_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(m_Train_2015.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void the_goldfinch_2013_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(the_goldfinch_2013.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void the_secret_history_1992_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(the_secret_history_1992.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Non - fiction books explore the real world! They present true stories, factual information, and fresh perspectives on everything from history and science to self - improvement and current events.Think of them as journeys of discovery, packed with knowledge and engaging writing.", "Non-Fiction Book Diffinition", MessageBoxButtons.OK);
        }

        private void t13_hours_2014_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(t13_hours_2014.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void fear_trump_in_the_white_house_2018_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(fear_trump_in_the_white_house_2018.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void into_the_wild_1990_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(into_the_wild_1990.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void stasliand_2003_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(stasliand_2003.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void three_women_2001_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(three_women_2001.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void underground_1997_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(underground_1997.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Drama books tell intense stories through characters, either in plays meant to be performed or analyzed for deeper meaning.", "Drama Book Diffinition", MessageBoxButtons.OK);
        }

        private void after_2014_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(after_2014.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }

        }

        private void dear_john_2006_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(dear_john_2006.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void switched_2010_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(switched_2010.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void the_island_2005_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(the_island_2005.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {

                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void the_last_song_2008_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(the_last_song_2008.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void the_longest_ride_2012_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(the_longest_ride_2012.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void BriefButtonAcademics_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Academic books are scholarly dives into specific subjects, written formally for researchers and students to analyze and understand a field in detail.", "Academic Book Diffinition", MessageBoxButtons.OK);
        }

        private void the_nature_of_middle_earth_2021_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(the_nature_of_middle_earth_2021.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void a_history_of_the_arab_peoples_1991_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(a_history_of_the_arab_peoples_1991.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void reading_angel_the_tv_spin_2005_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(reading_angel_the_tv_spin_2005.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void the_godwulf_manuscript_1973_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(the_godwulf_manuscript_1973.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void the_silent_world_1977_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(the_silent_world_1977.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }

        private void the_tumip_princess_2015_Click(object sender, EventArgs e)
        {
            AddedBooklistBox1.Items.Add(the_tumip_princess_2015.Name.ToString());
            if (AddedBooklistBox1.Items.Count == 0) { AddedBooklistBox1.Visible = false; }
            else if (AddedBooklistBox1.Items.Count > 0)
            {
                AddedBooklistBox1.Visible = true;

            }
            if (AddedBooklistBox1.Items.Count > 0)
            {
                FormatgroupBox1.Visible = true;
            }
        }
        PaymentPage ali = new PaymentPage();
        private void checkButton2_Click(object sender, EventArgs e)
        {
            
            try {
                
                if (RentButton.Checked || HardCopyRadioButton2.Checked ||
                    downloadingjournalsradioButton3.Checked || FlashradioButton4.Checked)
                {

                    if (RentButton.Checked) {

                        total = AddedBooklistBox1.Items.Count + (AddedBooklistBox1.Items.Count * RENT);
                    }


                    else if (HardCopyRadioButton2.Checked) {
                        total = AddedBooklistBox1.Items.Count + (AddedBooklistBox1.Items.Count * HARDCOPY);
                    }else if (downloadingjournalsradioButton3.Checked) {
                        total = AddedBooklistBox1.Items.Count + (AddedBooklistBox1.Items.Count * DOWNLOADING);
                    }else  if(FlashradioButton4.Checked) {
                        total = AddedBooklistBox1.Items.Count + (AddedBooklistBox1.Items.Count * FLASH);
                    }
                    ali.OutPutlabelTotal.Text = total.ToString("c");
                    for (int i = 0; i < AddedBooklistBox1.Items.Count; i++) 
                    
                    {       
                        string item = AddedBooklistBox1.Items[i].ToString();
                        ali.IssuedBookSlistBox1.Items.Add(item);


                    }



                    ali.ShowDialog();
                }
                else { MessageBox.Show("please select onr of the Purchase Service ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            
            
            
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }



            
           
        }

        private void HardCovercheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (HardCovercheckBox1.Checked || EBookcheckBox2.Checked)
                { PurchasingGroupBox1.Visible = true; }
                if (!HardCovercheckBox1.Checked && !EBookcheckBox2.Checked) { PurchasingGroupBox1.Visible = false; }
                if (HardCovercheckBox1.Checked) { RentButton.Enabled = true; FlashradioButton4.Enabled = false; }
                else { RentButton.Enabled = false; FlashradioButton4.Enabled = true; downloadingjournalsradioButton3.Enabled = true; }
            }
            catch (Exception ex) { MessageBox.Show("error","remainder", MessageBoxButtons.OK); }
        }

        private void Borrowerrr_Load(object sender, EventArgs e)
        {

        }

        private void FormatgroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void EBookcheckBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (HardCovercheckBox1.Checked || EBookcheckBox2.Checked) { PurchasingGroupBox1.Visible = true; }
            if (!HardCovercheckBox1.Checked && !EBookcheckBox2.Checked) { PurchasingGroupBox1.Visible = false; }

            if (EBookcheckBox2.Checked) { RentButton.Enabled = false; HardCopyRadioButton2.Enabled = false; }
            else { RentButton.Enabled = true;HardCopyRadioButton2.Enabled = true; }
        }

        private void LiteraturegroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void HardCopyRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RentButton.Checked || FlashradioButton4.Checked || HardCopyRadioButton2.Checked || downloadingjournalsradioButton3.Checked) { checkButton2.Visible = true; }
            if (!RentButton.Checked && !FlashradioButton4.Checked && !HardCopyRadioButton2.Checked && !downloadingjournalsradioButton3.Checked) { checkButton2.Visible = false; }
        }

        private void RentButton_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("After 6 Days Delaying You Will Charged By 500FILS Over the Total Amount", "Remainder", MessageBoxButtons.OK);
            if (RentButton.Checked || FlashradioButton4.Checked || HardCopyRadioButton2.Checked || downloadingjournalsradioButton3.Checked) { checkButton2.Visible = true; }
            if (!RentButton.Checked && !FlashradioButton4.Checked && !HardCopyRadioButton2.Checked && !downloadingjournalsradioButton3.Checked) { checkButton2.Visible = false; }
        }

        private void downloadingjournalsradioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (RentButton.Checked || FlashradioButton4.Checked || HardCopyRadioButton2.Checked || downloadingjournalsradioButton3.Checked) { checkButton2.Visible = true; }
            if (!RentButton.Checked && !FlashradioButton4.Checked && !HardCopyRadioButton2.Checked && !downloadingjournalsradioButton3.Checked) { checkButton2.Visible = false; }
        }

        private void FlashradioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (RentButton.Checked || FlashradioButton4.Checked || HardCopyRadioButton2.Checked || downloadingjournalsradioButton3.Checked) { checkButton2.Visible = true; }
            if (!RentButton.Checked && !FlashradioButton4.Checked && !HardCopyRadioButton2.Checked && !downloadingjournalsradioButton3.Checked) { checkButton2.Visible = false; }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form login = new Form();
            login.ShowDialog();
        }
    }
}
