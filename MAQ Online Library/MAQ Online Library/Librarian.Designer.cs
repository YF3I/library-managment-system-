namespace MAQ_Online_Library
{
    partial class Librarian
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
            this.insertButton = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksInfoDataSet = new MAQ_Online_Library.BooksInfoDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAutherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableTableAdapter = new MAQ_Online_Library.BooksInfoDataSetTableAdapters.BooksTableTableAdapter();
            this.bookNumberTextBox = new System.Windows.Forms.TextBox();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.autherNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksTableBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.insertButton.Location = new System.Drawing.Point(319, 392);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(111, 35);
            this.insertButton.TabIndex = 0;
            this.insertButton.Text = "Insert Book";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Delete.Location = new System.Drawing.Point(319, 471);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(111, 34);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete Book";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.backButton.Location = new System.Drawing.Point(1064, 474);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(95, 34);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.booksInfoDataSet;
            this.bindingSource1.Position = 0;
            // 
            // booksInfoDataSet
            // 
            this.booksInfoDataSet.DataSetName = "BooksInfoDataSet";
            this.booksInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookNumberDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.bookCategoryDataGridViewTextBoxColumn,
            this.bookAutherNameDataGridViewTextBoxColumn,
            this.bookPriceDataGridViewTextBoxColumn,
            this.bookQuantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.booksTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1108, 291);
            this.dataGridView1.TabIndex = 3;
            // 
            // bookNumberDataGridViewTextBoxColumn
            // 
            this.bookNumberDataGridViewTextBoxColumn.DataPropertyName = "Book Number";
            this.bookNumberDataGridViewTextBoxColumn.HeaderText = "Book Number";
            this.bookNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNumberDataGridViewTextBoxColumn.Name = "bookNumberDataGridViewTextBoxColumn";
            this.bookNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book Name";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book Name";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookCategoryDataGridViewTextBoxColumn
            // 
            this.bookCategoryDataGridViewTextBoxColumn.DataPropertyName = "Book Category";
            this.bookCategoryDataGridViewTextBoxColumn.HeaderText = "Book Category";
            this.bookCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookCategoryDataGridViewTextBoxColumn.Name = "bookCategoryDataGridViewTextBoxColumn";
            this.bookCategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookAutherNameDataGridViewTextBoxColumn
            // 
            this.bookAutherNameDataGridViewTextBoxColumn.DataPropertyName = "Book Auther Name";
            this.bookAutherNameDataGridViewTextBoxColumn.HeaderText = "Book Auther Name";
            this.bookAutherNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookAutherNameDataGridViewTextBoxColumn.Name = "bookAutherNameDataGridViewTextBoxColumn";
            this.bookAutherNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookPriceDataGridViewTextBoxColumn
            // 
            this.bookPriceDataGridViewTextBoxColumn.DataPropertyName = "Book Price";
            this.bookPriceDataGridViewTextBoxColumn.HeaderText = "Book Price";
            this.bookPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookPriceDataGridViewTextBoxColumn.Name = "bookPriceDataGridViewTextBoxColumn";
            this.bookPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookQuantityDataGridViewTextBoxColumn
            // 
            this.bookQuantityDataGridViewTextBoxColumn.DataPropertyName = "Book Quantity";
            this.bookQuantityDataGridViewTextBoxColumn.HeaderText = "Book Quantity";
            this.bookQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookQuantityDataGridViewTextBoxColumn.Name = "bookQuantityDataGridViewTextBoxColumn";
            this.bookQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // booksTableBindingSource
            // 
            this.booksTableBindingSource.DataMember = "BooksTable";
            this.booksTableBindingSource.DataSource = this.booksInfoDataSet;
            // 
            // booksTableTableAdapter
            // 
            this.booksTableTableAdapter.ClearBeforeFill = true;
            // 
            // bookNumberTextBox
            // 
            this.bookNumberTextBox.Location = new System.Drawing.Point(180, 377);
            this.bookNumberTextBox.Name = "bookNumberTextBox";
            this.bookNumberTextBox.Size = new System.Drawing.Size(121, 22);
            this.bookNumberTextBox.TabIndex = 1;
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(630, 377);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.bookNameTextBox.TabIndex = 2;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(1038, 377);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(121, 22);
            this.categoryTextBox.TabIndex = 3;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(630, 421);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(121, 22);
            this.quantityTextBox.TabIndex = 5;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(1038, 421);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(121, 22);
            this.priceTextBox.TabIndex = 6;
            // 
            // autherNameTextBox
            // 
            this.autherNameTextBox.Location = new System.Drawing.Point(180, 421);
            this.autherNameTextBox.Name = "autherNameTextBox";
            this.autherNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.autherNameTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(51, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Book Number :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Location = new System.Drawing.Point(501, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Book Name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Location = new System.Drawing.Point(912, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Book Category :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Location = new System.Drawing.Point(48, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Book Authre Name :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Location = new System.Drawing.Point(909, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Book Price :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Location = new System.Drawing.Point(498, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Book Quantity :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(447, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(298, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Books Information Table";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.searchButton.Location = new System.Drawing.Point(343, 22);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(111, 34);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(216, 28);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(121, 22);
            this.searchTextBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label8.Location = new System.Drawing.Point(40, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 22);
            this.label8.TabIndex = 19;
            this.label8.Text = "Search By Book Name:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Location = new System.Drawing.Point(428, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 84);
            this.panel1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label9.Location = new System.Drawing.Point(168, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 46);
            this.label9.TabIndex = 21;
            this.label9.Text = "Hint : Delete By Book Number";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Librarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MAQ_Online_Library.Properties.Resources.th;
            this.ClientSize = new System.Drawing.Size(1192, 572);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.autherNameTextBox);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.bookNameTextBox);
            this.Controls.Add(this.bookNumberTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.insertButton);
            this.Name = "Librarian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librarian";
            this.Load += new System.EventHandler(this.Librarian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksTableBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BooksInfoDataSet booksInfoDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource booksTableBindingSource;
        private BooksInfoDataSetTableAdapters.BooksTableTableAdapter booksTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAutherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox bookNumberTextBox;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox autherNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
    }
}