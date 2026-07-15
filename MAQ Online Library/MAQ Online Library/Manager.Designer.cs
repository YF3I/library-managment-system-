namespace MAQ_Online_Library
{
    partial class Manager
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
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.managerDataBaseDataSet = new MAQ_Online_Library.ManagerDataBaseDataSet();
            this.managerrTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerrTableTableAdapter = new MAQ_Online_Library.ManagerDataBaseDataSetTableAdapters.ManagerrTableTableAdapter();
            this.loginnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerrTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Boss !";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(198, 99);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(162, 22);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(198, 149);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(162, 22);
            this.passwordTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.managerDataBaseDataSet;
            this.bindingSource1.Position = 0;
            // 
            // managerDataBaseDataSet
            // 
            this.managerDataBaseDataSet.DataSetName = "ManagerDataBaseDataSet";
            this.managerDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerrTableBindingSource
            // 
            this.managerrTableBindingSource.DataMember = "ManagerrTable";
            this.managerrTableBindingSource.DataSource = this.bindingSource1;
            // 
            // managerrTableTableAdapter
            // 
            this.managerrTableTableAdapter.ClearBeforeFill = true;
            // 
            // loginnButton
            // 
            this.loginnButton.Location = new System.Drawing.Point(213, 189);
            this.loginnButton.Name = "loginnButton";
            this.loginnButton.Size = new System.Drawing.Size(75, 28);
            this.loginnButton.TabIndex = 5;
            this.loginnButton.Text = "Login";
            this.loginnButton.UseVisualStyleBackColor = true;
            this.loginnButton.Click += new System.EventHandler(this.loginnButton_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(493, 308);
            this.Controls.Add(this.loginnButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerrTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ManagerDataBaseDataSet managerDataBaseDataSet;
        private System.Windows.Forms.BindingSource managerrTableBindingSource;
        private ManagerDataBaseDataSetTableAdapters.ManagerrTableTableAdapter managerrTableTableAdapter;
        private System.Windows.Forms.Button loginnButton;
    }
}