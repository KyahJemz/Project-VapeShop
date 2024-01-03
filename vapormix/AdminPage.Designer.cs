namespace vapormix
{
    partial class AdminPage
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
            this.btn_Accounts = new System.Windows.Forms.Button();
            this.btn_Transactions = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.itemsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Transactions = new System.Windows.Forms.Panel();
            this.TransactionsTable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_Accounts = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_SaveChanges = new System.Windows.Forms.Button();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.AccountTable = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.pnl_Transactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsTable)).BeginInit();
            this.pnl_Accounts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Accounts
            // 
            this.btn_Accounts.BackColor = System.Drawing.Color.Transparent;
            this.btn_Accounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Accounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Accounts.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Accounts.FlatAppearance.BorderSize = 0;
            this.btn_Accounts.Location = new System.Drawing.Point(17, 75);
            this.btn_Accounts.Name = "btn_Accounts";
            this.btn_Accounts.Size = new System.Drawing.Size(144, 23);
            this.btn_Accounts.TabIndex = 7;
            this.btn_Accounts.Text = "Accounts";
            this.btn_Accounts.UseVisualStyleBackColor = false;
            this.btn_Accounts.Click += new System.EventHandler(this.btn_Accounts_Click);
            // 
            // btn_Transactions
            // 
            this.btn_Transactions.BackColor = System.Drawing.Color.Transparent;
            this.btn_Transactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Transactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Transactions.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Transactions.FlatAppearance.BorderSize = 0;
            this.btn_Transactions.Location = new System.Drawing.Point(167, 75);
            this.btn_Transactions.Name = "btn_Transactions";
            this.btn_Transactions.Size = new System.Drawing.Size(144, 23);
            this.btn_Transactions.TabIndex = 5;
            this.btn_Transactions.Text = "Transactions";
            this.btn_Transactions.UseVisualStyleBackColor = false;
            this.btn_Transactions.Click += new System.EventHandler(this.btn_Transactions_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.Location = new System.Drawing.Point(582, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(144, 23);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // itemsListView
            // 
            this.itemsListView.BackColor = System.Drawing.Color.Black;
            this.itemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.itemsListView.ForeColor = System.Drawing.Color.White;
            this.itemsListView.HideSelection = false;
            this.itemsListView.Location = new System.Drawing.Point(495, 14);
            this.itemsListView.Name = "itemsListView";
            this.itemsListView.Size = new System.Drawing.Size(198, 295);
            this.itemsListView.TabIndex = 10;
            this.itemsListView.UseCompatibleStateImageBehavior = false;
            this.itemsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Items";
            this.columnHeader1.Width = 194;
            // 
            // pnl_Transactions
            // 
            this.pnl_Transactions.BackColor = System.Drawing.Color.Black;
            this.pnl_Transactions.Controls.Add(this.TransactionsTable);
            this.pnl_Transactions.Controls.Add(this.button1);
            this.pnl_Transactions.Controls.Add(this.itemsListView);
            this.pnl_Transactions.Location = new System.Drawing.Point(20, 104);
            this.pnl_Transactions.Name = "pnl_Transactions";
            this.pnl_Transactions.Size = new System.Drawing.Size(704, 347);
            this.pnl_Transactions.TabIndex = 13;
            // 
            // TransactionsTable
            // 
            this.TransactionsTable.AllowUserToAddRows = false;
            this.TransactionsTable.AllowUserToDeleteRows = false;
            this.TransactionsTable.AllowUserToResizeRows = false;
            this.TransactionsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TransactionsTable.BackgroundColor = System.Drawing.Color.Black;
            this.TransactionsTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TransactionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionsTable.Location = new System.Drawing.Point(19, 14);
            this.TransactionsTable.MultiSelect = false;
            this.TransactionsTable.Name = "TransactionsTable";
            this.TransactionsTable.ReadOnly = true;
            this.TransactionsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransactionsTable.Size = new System.Drawing.Size(470, 295);
            this.TransactionsTable.TabIndex = 15;
            this.TransactionsTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TransactionsTable_CellMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_Accounts
            // 
            this.pnl_Accounts.BackColor = System.Drawing.Color.Black;
            this.pnl_Accounts.Controls.Add(this.groupBox1);
            this.pnl_Accounts.Controls.Add(this.AccountTable);
            this.pnl_Accounts.Location = new System.Drawing.Point(20, 104);
            this.pnl_Accounts.Name = "pnl_Accounts";
            this.pnl_Accounts.Size = new System.Drawing.Size(704, 347);
            this.pnl_Accounts.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_SaveChanges);
            this.groupBox1.Controls.Add(this.txt_Username);
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(556, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 187);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Username :";
            // 
            // btn_Delete
            // 
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Location = new System.Drawing.Point(6, 156);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(125, 23);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_SaveChanges
            // 
            this.btn_SaveChanges.ForeColor = System.Drawing.Color.Black;
            this.btn_SaveChanges.Location = new System.Drawing.Point(6, 127);
            this.btn_SaveChanges.Name = "btn_SaveChanges";
            this.btn_SaveChanges.Size = new System.Drawing.Size(125, 23);
            this.btn_SaveChanges.TabIndex = 23;
            this.btn_SaveChanges.Text = "Save Changes";
            this.btn_SaveChanges.UseVisualStyleBackColor = true;
            this.btn_SaveChanges.Click += new System.EventHandler(this.btn_SaveChanges_Click);
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(9, 38);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(122, 20);
            this.txt_Username.TabIndex = 21;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(9, 86);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(122, 20);
            this.txt_Password.TabIndex = 20;
            // 
            // AccountTable
            // 
            this.AccountTable.AllowUserToAddRows = false;
            this.AccountTable.AllowUserToDeleteRows = false;
            this.AccountTable.AllowUserToResizeColumns = false;
            this.AccountTable.AllowUserToResizeRows = false;
            this.AccountTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AccountTable.BackgroundColor = System.Drawing.Color.Black;
            this.AccountTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountTable.Location = new System.Drawing.Point(20, 22);
            this.AccountTable.MultiSelect = false;
            this.AccountTable.Name = "AccountTable";
            this.AccountTable.ReadOnly = true;
            this.AccountTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AccountTable.Size = new System.Drawing.Size(530, 306);
            this.AccountTable.TabIndex = 19;
            this.AccountTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountTable_CellDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Juice ITC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(267, 45);
            this.label9.TabIndex = 18;
            this.label9.Text = "Vape and Juice Shop";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(738, 465);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Transactions);
            this.Controls.Add(this.btn_Accounts);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pnl_Transactions);
            this.Controls.Add(this.pnl_Accounts);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.pnl_Transactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsTable)).EndInit();
            this.pnl_Accounts.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Accounts;
        private System.Windows.Forms.Button btn_Transactions;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.ListView itemsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel pnl_Transactions;
        private System.Windows.Forms.Panel pnl_Accounts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_SaveChanges;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.DataGridView AccountTable;
        private System.Windows.Forms.DataGridView TransactionsTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
    }
}