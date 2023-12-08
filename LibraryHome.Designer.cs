namespace Library_Final_Project
{
    partial class LibraryHome
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsbLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnViewBookInfor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.YourselfTools = new System.Windows.Forms.ToolStripMenuItem();
            this.myFavouriteBookListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByBooksNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.searchByAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchOverdueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLogin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 507);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1059, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsbLogin
            // 
            this.tsbLogin.Name = "tsbLogin";
            this.tsbLogin.Size = new System.Drawing.Size(118, 17);
            this.tsbLogin.Text = "toolStripStatusLabel1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 380);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book List";
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(793, 308);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(184, 69);
            this.btnDeleteBook.TabIndex = 4;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            // 
            // btnViewBookInfor
            // 
            this.btnViewBookInfor.Location = new System.Drawing.Point(793, 412);
            this.btnViewBookInfor.Name = "btnViewBookInfor";
            this.btnViewBookInfor.Size = new System.Drawing.Size(184, 69);
            this.btnViewBookInfor.TabIndex = 5;
            this.btnViewBookInfor.Text = "View Book\'s Information";
            this.btnViewBookInfor.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.YourselfTools,
            this.searchBookToolStripMenuItem,
            this.manageBookToolStripMenuItem,
            this.manageUserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // YourselfTools
            // 
            this.YourselfTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myFavouriteBookListToolStripMenuItem,
            this.borrowingListToolStripMenuItem});
            this.YourselfTools.Name = "YourselfTools";
            this.YourselfTools.Size = new System.Drawing.Size(62, 20);
            this.YourselfTools.Text = "YourSelf";
            this.YourselfTools.Click += new System.EventHandler(this.heeloToolStripMenuItem_Click);
            // 
            // myFavouriteBookListToolStripMenuItem
            // 
            this.myFavouriteBookListToolStripMenuItem.Name = "myFavouriteBookListToolStripMenuItem";
            this.myFavouriteBookListToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.myFavouriteBookListToolStripMenuItem.Text = "My Favourite Book List";
            // 
            // borrowingListToolStripMenuItem
            // 
            this.borrowingListToolStripMenuItem.Name = "borrowingListToolStripMenuItem";
            this.borrowingListToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.borrowingListToolStripMenuItem.Text = "Borrowing List";
            // 
            // searchBookToolStripMenuItem
            // 
            this.searchBookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByBooksNameToolStripMenuItem,
            this.searchByContentToolStripMenuItem,
            this.searchByAuthorToolStripMenuItem,
            this.searchOverdueBookToolStripMenuItem});
            this.searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            this.searchBookToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.searchBookToolStripMenuItem.Text = "Search Book";
            // 
            // searchByBooksNameToolStripMenuItem
            // 
            this.searchByBooksNameToolStripMenuItem.Name = "searchByBooksNameToolStripMenuItem";
            this.searchByBooksNameToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.searchByBooksNameToolStripMenuItem.Text = "Search By Book\'s Name";
            // 
            // searchByContentToolStripMenuItem
            // 
            this.searchByContentToolStripMenuItem.Name = "searchByContentToolStripMenuItem";
            this.searchByContentToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.searchByContentToolStripMenuItem.Text = "Search by content";
            // 
            // manageBookToolStripMenuItem
            // 
            this.manageBookToolStripMenuItem.Name = "manageBookToolStripMenuItem";
            this.manageBookToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.manageBookToolStripMenuItem.Text = "Manage Book";
            // 
            // manageUserToolStripMenuItem
            // 
            this.manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            this.manageUserToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.manageUserToolStripMenuItem.Text = "Manage User";
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(793, 199);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(184, 69);
            this.btnEditBook.TabIndex = 7;
            this.btnEditBook.Text = "Edit Book";
            this.btnEditBook.UseVisualStyleBackColor = true;
            // 
            // searchByAuthorToolStripMenuItem
            // 
            this.searchByAuthorToolStripMenuItem.Name = "searchByAuthorToolStripMenuItem";
            this.searchByAuthorToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.searchByAuthorToolStripMenuItem.Text = "Search By Author";
            // 
            // searchOverdueBookToolStripMenuItem
            // 
            this.searchOverdueBookToolStripMenuItem.Name = "searchOverdueBookToolStripMenuItem";
            this.searchOverdueBookToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.searchOverdueBookToolStripMenuItem.Text = "Search overdueBook";
            // 
            // LibraryHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 529);
            this.Controls.Add(this.btnEditBook);
            this.Controls.Add(this.btnViewBookInfor);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LibraryHome";
            this.Text = "Library Home";
            this.Load += new System.EventHandler(this.LibrarayHome_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsbLogin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnViewBookInfor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByBooksNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBookToolStripMenuItem;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.ToolStripMenuItem YourselfTools;
        private System.Windows.Forms.ToolStripMenuItem myFavouriteBookListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowingListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchOverdueBookToolStripMenuItem;
    }
}