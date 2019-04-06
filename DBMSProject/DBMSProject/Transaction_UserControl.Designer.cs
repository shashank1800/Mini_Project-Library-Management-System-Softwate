namespace DBMSProject
{
    partial class Transaction_UserControl
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
            this.pLACEORDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rETURNBOOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.Accno_textbox = new System.Windows.Forms.TextBox();
            this.Borrower_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Borrower_id = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(120)))), ((int)(((byte)(164)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pLACEORDERToolStripMenuItem,
            this.rETURNBOOKToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // pLACEORDERToolStripMenuItem
            // 
            this.pLACEORDERToolStripMenuItem.AutoSize = false;
            this.pLACEORDERToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(233)))), ((int)(((byte)(182)))));
            this.pLACEORDERToolStripMenuItem.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.pLACEORDERToolStripMenuItem.Name = "pLACEORDERToolStripMenuItem";
            this.pLACEORDERToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.pLACEORDERToolStripMenuItem.Text = "Issue Book";
            this.pLACEORDERToolStripMenuItem.Click += new System.EventHandler(this.pLACEORDERToolStripMenuItem_Click);
            // 
            // rETURNBOOKToolStripMenuItem
            // 
            this.rETURNBOOKToolStripMenuItem.AutoSize = false;
            this.rETURNBOOKToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(233)))), ((int)(((byte)(182)))));
            this.rETURNBOOKToolStripMenuItem.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.rETURNBOOKToolStripMenuItem.Name = "rETURNBOOKToolStripMenuItem";
            this.rETURNBOOKToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.rETURNBOOKToolStripMenuItem.Text = "Return Book";
            this.rETURNBOOKToolStripMenuItem.Click += new System.EventHandler(this.rETURNBOOKToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(233)))), ((int)(((byte)(182)))));
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 30);
            this.toolStripMenuItem1.Text = "Transactions";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(231)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(252, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "Issue Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Accno_textbox
            // 
            this.Accno_textbox.Location = new System.Drawing.Point(302, 150);
            this.Accno_textbox.Name = "Accno_textbox";
            this.Accno_textbox.Size = new System.Drawing.Size(142, 20);
            this.Accno_textbox.TabIndex = 18;
            this.Accno_textbox.Visible = false;
            this.Accno_textbox.TextChanged += new System.EventHandler(this.Accno_textbox_TextChanged);
            // 
            // Borrower_textbox
            // 
            this.Borrower_textbox.Location = new System.Drawing.Point(303, 100);
            this.Borrower_textbox.Name = "Borrower_textbox";
            this.Borrower_textbox.Size = new System.Drawing.Size(142, 20);
            this.Borrower_textbox.TabIndex = 17;
            this.Borrower_textbox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Accession No";
            this.label1.Visible = false;
            // 
            // Borrower_id
            // 
            this.Borrower_id.AutoSize = true;
            this.Borrower_id.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrower_id.Location = new System.Drawing.Point(188, 99);
            this.Borrower_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Borrower_id.Name = "Borrower_id";
            this.Borrower_id.Size = new System.Drawing.Size(109, 20);
            this.Borrower_id.TabIndex = 15;
            this.Borrower_id.Text = "Borrower\'s ID ";
            this.Borrower_id.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(231)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(252, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 37);
            this.button2.TabIndex = 20;
            this.button2.Text = "Return Book";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView.Location = new System.Drawing.Point(54, 93);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(534, 288);
            this.dataGridView.TabIndex = 78;
            this.dataGridView.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 100;
            this.comboBox1.DropDownWidth = 100;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "Any time",
            "Past 24 hours",
            "Past week",
            "Past month",
            "Past 6 months"});
            this.comboBox1.Location = new System.Drawing.Point(267, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 25);
            this.comboBox1.TabIndex = 79;
            this.comboBox1.TabStop = false;
            this.comboBox1.Text = "Any time";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Transaction_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Accno_textbox);
            this.Controls.Add(this.Borrower_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Borrower_id);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button1);
            this.Name = "Transaction_UserControl";
            this.Size = new System.Drawing.Size(650, 416);
            this.Load += new System.EventHandler(this.Transaction_UserControl_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pLACEORDERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rETURNBOOKToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Accno_textbox;
        private System.Windows.Forms.TextBox Borrower_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Borrower_id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
