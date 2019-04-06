namespace DBMSProject
{
    partial class Books_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Department_TextBox = new System.Windows.Forms.TextBox();
            this.Department_ComboBox = new System.Windows.Forms.Label();
            this.Accno_textBox = new System.Windows.Forms.TextBox();
            this.Publisher_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Author_textBox = new System.Windows.Forms.TextBox();
            this.Isbn_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.addBook = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(120)))), ((int)(((byte)(164)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.deleteBookToolStripMenuItem,
            this.updateBookToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.AutoSize = false;
            this.addBookToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(233)))), ((int)(((byte)(182)))));
            this.addBookToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.addBookToolStripMenuItem.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.addBookToolStripMenuItem.Text = "Add Book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // deleteBookToolStripMenuItem
            // 
            this.deleteBookToolStripMenuItem.AutoSize = false;
            this.deleteBookToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(233)))), ((int)(((byte)(182)))));
            this.deleteBookToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.deleteBookToolStripMenuItem.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            this.deleteBookToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.deleteBookToolStripMenuItem.Text = "Delete Book";
            this.deleteBookToolStripMenuItem.Click += new System.EventHandler(this.deleteBookToolStripMenuItem_Click);
            // 
            // updateBookToolStripMenuItem
            // 
            this.updateBookToolStripMenuItem.AutoSize = false;
            this.updateBookToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(233)))), ((int)(((byte)(182)))));
            this.updateBookToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.updateBookToolStripMenuItem.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.updateBookToolStripMenuItem.Name = "updateBookToolStripMenuItem";
            this.updateBookToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.updateBookToolStripMenuItem.Text = "Update Book";
            this.updateBookToolStripMenuItem.Click += new System.EventHandler(this.updateBookToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(233)))), ((int)(((byte)(182)))));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 30);
            this.toolStripMenuItem1.Text = "Search Book";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.White;
            this.button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(287, 159);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 30);
            this.button.TabIndex = 60;
            this.button.Text = "Submit";
            this.button.UseVisualStyleBackColor = false;
            this.button.Visible = false;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(231)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(288, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 76;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Department_TextBox
            // 
            this.Department_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Department_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department_TextBox.Location = new System.Drawing.Point(510, 284);
            this.Department_TextBox.Name = "Department_TextBox";
            this.Department_TextBox.Size = new System.Drawing.Size(120, 27);
            this.Department_TextBox.TabIndex = 75;
            this.Department_TextBox.Visible = false;
            // 
            // Department_ComboBox
            // 
            this.Department_ComboBox.AutoSize = true;
            this.Department_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department_ComboBox.ForeColor = System.Drawing.Color.Black;
            this.Department_ComboBox.Location = new System.Drawing.Point(396, 293);
            this.Department_ComboBox.Name = "Department_ComboBox";
            this.Department_ComboBox.Size = new System.Drawing.Size(88, 16);
            this.Department_ComboBox.TabIndex = 73;
            this.Department_ComboBox.Text = "Department";
            this.Department_ComboBox.Visible = false;
            // 
            // Accno_textBox
            // 
            this.Accno_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Accno_textBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accno_textBox.Location = new System.Drawing.Point(510, 152);
            this.Accno_textBox.Name = "Accno_textBox";
            this.Accno_textBox.Size = new System.Drawing.Size(120, 27);
            this.Accno_textBox.TabIndex = 72;
            this.Accno_textBox.Visible = false;
            // 
            // Publisher_textBox
            // 
            this.Publisher_textBox.BackColor = System.Drawing.Color.White;
            this.Publisher_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Publisher_textBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publisher_textBox.Location = new System.Drawing.Point(510, 218);
            this.Publisher_textBox.Name = "Publisher_textBox";
            this.Publisher_textBox.Size = new System.Drawing.Size(120, 27);
            this.Publisher_textBox.TabIndex = 74;
            this.Publisher_textBox.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(396, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 71;
            this.label5.Text = "Publisher";
            this.label5.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(396, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Accession No.";
            this.label2.Visible = false;
            // 
            // Author_textBox
            // 
            this.Author_textBox.BackColor = System.Drawing.Color.White;
            this.Author_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Author_textBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author_textBox.Location = new System.Drawing.Point(142, 289);
            this.Author_textBox.Name = "Author_textBox";
            this.Author_textBox.Size = new System.Drawing.Size(120, 27);
            this.Author_textBox.TabIndex = 66;
            this.Author_textBox.Visible = false;
            // 
            // Isbn_textBox
            // 
            this.Isbn_textBox.BackColor = System.Drawing.Color.White;
            this.Isbn_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Isbn_textBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Isbn_textBox.Location = new System.Drawing.Point(142, 222);
            this.Isbn_textBox.Name = "Isbn_textBox";
            this.Isbn_textBox.Size = new System.Drawing.Size(120, 27);
            this.Isbn_textBox.TabIndex = 65;
            this.Isbn_textBox.Visible = false;
            // 
            // Name_textBox
            // 
            this.Name_textBox.BackColor = System.Drawing.Color.White;
            this.Name_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_textBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_textBox.Location = new System.Drawing.Point(142, 155);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(120, 27);
            this.Name_textBox.TabIndex = 64;
            this.Name_textBox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(47, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 63;
            this.label7.Text = "ISBN ";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(47, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 62;
            this.label6.Text = "Author";
            this.label6.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(47, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Book Name";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(231)))));
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(288, 219);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 30);
            this.Delete.TabIndex = 69;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Visible = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click_2);
            // 
            // addBook
            // 
            this.addBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(231)))));
            this.addBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBook.Location = new System.Drawing.Point(288, 348);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(75, 30);
            this.addBook.TabIndex = 67;
            this.addBook.Text = "Save";
            this.addBook.UseVisualStyleBackColor = false;
            this.addBook.Visible = false;
            this.addBook.Click += new System.EventHandler(this.addBook_Click_2);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(231)))));
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(288, 348);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 30);
            this.Update.TabIndex = 68;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Visible = false;
            this.Update.Click += new System.EventHandler(this.Update_Click_2);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView.Location = new System.Drawing.Point(10, 87);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(630, 320);
            this.dataGridView.TabIndex = 77;
            this.dataGridView.Visible = false;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(231)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(288, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 78;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Books_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Department_TextBox);
            this.Controls.Add(this.Department_ComboBox);
            this.Controls.Add(this.Accno_textBox);
            this.Controls.Add(this.Publisher_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Author_textBox);
            this.Controls.Add(this.Isbn_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Update);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Books_UserControl";
            this.Size = new System.Drawing.Size(650, 416);
            this.Load += new System.EventHandler(this.Books_UserControl_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBookToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Department_TextBox;
        private System.Windows.Forms.Label Department_ComboBox;
        private System.Windows.Forms.TextBox Accno_textBox;
        private System.Windows.Forms.TextBox Publisher_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Author_textBox;
        private System.Windows.Forms.TextBox Isbn_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button3;
    }
}
