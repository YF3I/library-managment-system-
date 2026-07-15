namespace MAQ_Online_Library
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.librarianRadioButton = new System.Windows.Forms.RadioButton();
            this.borrowerRadioButton = new System.Windows.Forms.RadioButton();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginAsManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.signUpUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.signUpPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.confirmpasswordTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mAQDataBaseDataSet1 = new MAQ_Online_Library.MAQDataBaseDataSet1();
            this.borrowerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableTableAdapter = new MAQ_Online_Library.MAQDataBaseDataSet1TableAdapters.UserTableTableAdapter();
            this.borrowerTableTableAdapter = new MAQ_Online_Library.MAQDataBaseDataSet1TableAdapters.BorrowerTableTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAQDataBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to MAQ Online Library";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(72, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(65, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(65, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Type :";
            // 
            // librarianRadioButton
            // 
            this.librarianRadioButton.AutoSize = true;
            this.librarianRadioButton.Location = new System.Drawing.Point(158, 163);
            this.librarianRadioButton.Name = "librarianRadioButton";
            this.librarianRadioButton.Size = new System.Drawing.Size(80, 20);
            this.librarianRadioButton.TabIndex = 7;
            this.librarianRadioButton.TabStop = true;
            this.librarianRadioButton.Text = "Librarian";
            this.librarianRadioButton.UseVisualStyleBackColor = true;
            // 
            // borrowerRadioButton
            // 
            this.borrowerRadioButton.AutoSize = true;
            this.borrowerRadioButton.Location = new System.Drawing.Point(244, 163);
            this.borrowerRadioButton.Name = "borrowerRadioButton";
            this.borrowerRadioButton.Size = new System.Drawing.Size(82, 20);
            this.borrowerRadioButton.TabIndex = 8;
            this.borrowerRadioButton.TabStop = true;
            this.borrowerRadioButton.Text = "Borrower";
            this.borrowerRadioButton.UseVisualStyleBackColor = true;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(152, 82);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(148, 22);
            this.userNameTextBox.TabIndex = 9;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(152, 124);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(148, 22);
            this.passwordTextBox.TabIndex = 10;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(140, 196);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(84, 24);
            this.loginButton.TabIndex = 11;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginAsManagerToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1203, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginAsManagerToolStripMenuItem
            // 
            this.loginAsManagerToolStripMenuItem.Name = "loginAsManagerToolStripMenuItem";
            this.loginAsManagerToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.loginAsManagerToolStripMenuItem.Text = "Login as &Manager";
            this.loginAsManagerToolStripMenuItem.Click += new System.EventHandler(this.loginAsManagerToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.aboutUsToolStripMenuItem.Text = "&About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(159, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 31);
            this.label7.TabIndex = 15;
            this.label7.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.librarianRadioButton);
            this.panel1.Controls.Add(this.borrowerRadioButton);
            this.panel1.Controls.Add(this.userNameTextBox);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Location = new System.Drawing.Point(55, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 336);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(75, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Username :";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(158, 117);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(148, 22);
            this.phoneNumberTextBox.TabIndex = 20;
            // 
            // signUpUsernameTextBox
            // 
            this.signUpUsernameTextBox.Location = new System.Drawing.Point(158, 156);
            this.signUpUsernameTextBox.Name = "signUpUsernameTextBox";
            this.signUpUsernameTextBox.Size = new System.Drawing.Size(148, 22);
            this.signUpUsernameTextBox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(41, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Phone Number :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.Location = new System.Drawing.Point(75, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Password :";
            // 
            // signUpPasswordTextBox
            // 
            this.signUpPasswordTextBox.Location = new System.Drawing.Point(158, 191);
            this.signUpPasswordTextBox.Name = "signUpPasswordTextBox";
            this.signUpPasswordTextBox.Size = new System.Drawing.Size(148, 22);
            this.signUpPasswordTextBox.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(152, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sign Up";
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(158, 268);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(79, 25);
            this.signUpButton.TabIndex = 27;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(23, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Confirm Password :";
            // 
            // confirmpasswordTextBox
            // 
            this.confirmpasswordTextBox.Location = new System.Drawing.Point(158, 228);
            this.confirmpasswordTextBox.Name = "confirmpasswordTextBox";
            this.confirmpasswordTextBox.Size = new System.Drawing.Size(148, 22);
            this.confirmpasswordTextBox.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.emailTextBox);
            this.panel2.Controls.Add(this.confirmpasswordTextBox);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.signUpButton);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.signUpPasswordTextBox);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.signUpUsernameTextBox);
            this.panel2.Controls.Add(this.phoneNumberTextBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(759, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 336);
            this.panel2.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(102, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Email :";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(158, 77);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(148, 22);
            this.emailTextBox.TabIndex = 31;
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "UserTable";
            this.userTableBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.mAQDataBaseDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // mAQDataBaseDataSet1
            // 
            this.mAQDataBaseDataSet1.DataSetName = "MAQDataBaseDataSet1";
            this.mAQDataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borrowerTableBindingSource
            // 
            this.borrowerTableBindingSource.DataMember = "BorrowerTable";
            this.borrowerTableBindingSource.DataSource = this.bindingSource1;
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // borrowerTableTableAdapter
            // 
            this.borrowerTableTableAdapter.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = global::MAQ_Online_Library.Properties.Resources.th__1_;
            this.ClientSize = new System.Drawing.Size(1203, 567);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login&Registeration";
            this.Load += new System.EventHandler(this.Login_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAQDataBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton librarianRadioButton;
        private System.Windows.Forms.RadioButton borrowerRadioButton;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginAsManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox signUpUsernameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox signUpPasswordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox confirmpasswordTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MAQDataBaseDataSet1 mAQDataBaseDataSet1;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private MAQDataBaseDataSet1TableAdapters.UserTableTableAdapter userTableTableAdapter;
        private System.Windows.Forms.BindingSource borrowerTableBindingSource;
        private MAQDataBaseDataSet1TableAdapters.BorrowerTableTableAdapter borrowerTableTableAdapter;
    }
}

