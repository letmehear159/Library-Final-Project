namespace Library_Final_Project
{
    partial class LibraryHomeTab
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
            this.tcMenu = new System.Windows.Forms.TabControl();
            this.tpMenu = new System.Windows.Forms.TabPage();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnViewBookInfor = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbBookList = new System.Windows.Forms.DataGridView();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.tpManageUser = new System.Windows.Forms.TabPage();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnActDeactUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvUserList = new System.Windows.Forms.DataGridView();
            this.tpManageBook = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatusLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcMenu.SuspendLayout();
            this.tpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbBookList)).BeginInit();
            this.tpManageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMenu
            // 
            this.tcMenu.Controls.Add(this.tpMenu);
            this.tcMenu.Controls.Add(this.tpSearch);
            this.tcMenu.Controls.Add(this.tpManageUser);
            this.tcMenu.Controls.Add(this.tpManageBook);
            this.tcMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMenu.Location = new System.Drawing.Point(0, -1);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(969, 553);
            this.tcMenu.TabIndex = 0;
            // 
            // tpMenu
            // 
            this.tpMenu.Controls.Add(this.statusStrip1);
            this.tpMenu.Controls.Add(this.btnEditBook);
            this.tpMenu.Controls.Add(this.btnViewBookInfor);
            this.tpMenu.Controls.Add(this.btnDeleteBook);
            this.tpMenu.Controls.Add(this.label2);
            this.tpMenu.Controls.Add(this.gbBookList);
            this.tpMenu.Location = new System.Drawing.Point(4, 29);
            this.tpMenu.Name = "tpMenu";
            this.tpMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tpMenu.Size = new System.Drawing.Size(961, 520);
            this.tpMenu.TabIndex = 0;
            this.tpMenu.Text = "Menu";
            this.tpMenu.UseVisualStyleBackColor = true;
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(770, 177);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(184, 69);
            this.btnEditBook.TabIndex = 12;
            this.btnEditBook.Text = "Edit Book";
            this.btnEditBook.UseVisualStyleBackColor = true;
            // 
            // btnViewBookInfor
            // 
            this.btnViewBookInfor.Location = new System.Drawing.Point(770, 390);
            this.btnViewBookInfor.Name = "btnViewBookInfor";
            this.btnViewBookInfor.Size = new System.Drawing.Size(184, 69);
            this.btnViewBookInfor.TabIndex = 11;
            this.btnViewBookInfor.Text = "View Book\'s Information";
            this.btnViewBookInfor.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(770, 286);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(184, 69);
            this.btnDeleteBook.TabIndex = 10;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Book List";
            // 
            // gbBookList
            // 
            this.gbBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gbBookList.Location = new System.Drawing.Point(19, 79);
            this.gbBookList.Name = "gbBookList";
            this.gbBookList.Size = new System.Drawing.Size(745, 380);
            this.gbBookList.TabIndex = 8;
            // 
            // tpSearch
            // 
            this.tpSearch.Location = new System.Drawing.Point(4, 29);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearch.Size = new System.Drawing.Size(961, 520);
            this.tpSearch.TabIndex = 1;
            this.tpSearch.Text = "Search";
            this.tpSearch.UseVisualStyleBackColor = true;
            // 
            // tpManageUser
            // 
            this.tpManageUser.Controls.Add(this.btnSearchUser);
            this.tpManageUser.Controls.Add(this.btnResetPassword);
            this.tpManageUser.Controls.Add(this.btnActDeactUser);
            this.tpManageUser.Controls.Add(this.label1);
            this.tpManageUser.Controls.Add(this.gvUserList);
            this.tpManageUser.Location = new System.Drawing.Point(4, 29);
            this.tpManageUser.Name = "tpManageUser";
            this.tpManageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageUser.Size = new System.Drawing.Size(961, 520);
            this.tpManageUser.TabIndex = 2;
            this.tpManageUser.Text = "Manage User";
            this.tpManageUser.UseVisualStyleBackColor = true;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(732, 104);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(154, 69);
            this.btnSearchUser.TabIndex = 18;
            this.btnSearchUser.Text = "Search User";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(732, 304);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(154, 69);
            this.btnResetPassword.TabIndex = 17;
            this.btnResetPassword.Text = "Reset User Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            // 
            // btnActDeactUser
            // 
            this.btnActDeactUser.Location = new System.Drawing.Point(732, 202);
            this.btnActDeactUser.Name = "btnActDeactUser";
            this.btnActDeactUser.Size = new System.Drawing.Size(150, 69);
            this.btnActDeactUser.TabIndex = 16;
            this.btnActDeactUser.Text = "Active/Deactive User";
            this.btnActDeactUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "User List";
            // 
            // gvUserList
            // 
            this.gvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUserList.Location = new System.Drawing.Point(14, 104);
            this.gvUserList.Name = "gvUserList";
            this.gvUserList.Size = new System.Drawing.Size(634, 330);
            this.gvUserList.TabIndex = 14;
            // 
            // tpManageBook
            // 
            this.tpManageBook.Location = new System.Drawing.Point(4, 29);
            this.tpManageBook.Name = "tpManageBook";
            this.tpManageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageBook.Size = new System.Drawing.Size(961, 520);
            this.tpManageBook.TabIndex = 3;
            this.tpManageBook.Text = "Manage Book";
            this.tpManageBook.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLogin});
            this.statusStrip1.Location = new System.Drawing.Point(3, 495);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(955, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatusLogin
            // 
            this.tsStatusLogin.Name = "tsStatusLogin";
            this.tsStatusLogin.Size = new System.Drawing.Size(0, 17);
            // 
            // LibraryHomeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 555);
            this.Controls.Add(this.tcMenu);
            this.Name = "LibraryHomeTab";
            this.Text = "TestTab";
            this.Load += new System.EventHandler(this.LibraryHomeTab_Load);
            this.tcMenu.ResumeLayout(false);
            this.tpMenu.ResumeLayout(false);
            this.tpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbBookList)).EndInit();
            this.tpManageUser.ResumeLayout(false);
            this.tpManageUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMenu;
        private System.Windows.Forms.TabPage tpMenu;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.TabPage tpManageUser;
        private System.Windows.Forms.TabPage tpManageBook;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnActDeactUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvUserList;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnViewBookInfor;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gbBookList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLogin;
    }
}