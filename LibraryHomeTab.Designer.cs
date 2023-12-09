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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatusLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnViewBookInfor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbBookList = new System.Windows.Forms.DataGridView();
            this.tpSearchBook = new System.Windows.Forms.TabPage();
            this.tpManageUser = new System.Windows.Forms.TabPage();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnActDeactUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvUserList = new System.Windows.Forms.DataGridView();
            this.tpManageBook = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnShowHideBook = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.tpSearchUser = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUserBorrow = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnConfirmBookReturned = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gvBookList = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gvBorrowingBook = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.gbManageBook = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.tcMenu.SuspendLayout();
            this.tpMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbBookList)).BeginInit();
            this.tpSearchBook.SuspendLayout();
            this.tpManageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).BeginInit();
            this.tpManageBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBorrowingBook)).BeginInit();
            this.gbManageBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMenu
            // 
            this.tcMenu.Controls.Add(this.tpMenu);
            this.tcMenu.Controls.Add(this.tpSearchBook);
            this.tcMenu.Controls.Add(this.tpManageUser);
            this.tcMenu.Controls.Add(this.tpManageBook);
            this.tcMenu.Controls.Add(this.tpSearchUser);
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
            this.tpMenu.Controls.Add(this.btnViewBookInfor);
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
            // btnViewBookInfor
            // 
            this.btnViewBookInfor.Location = new System.Drawing.Point(770, 390);
            this.btnViewBookInfor.Name = "btnViewBookInfor";
            this.btnViewBookInfor.Size = new System.Drawing.Size(184, 69);
            this.btnViewBookInfor.TabIndex = 11;
            this.btnViewBookInfor.Text = "View Book\'s Information";
            this.btnViewBookInfor.UseVisualStyleBackColor = true;
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
            // tpSearchBook
            // 
            this.tpSearchBook.Controls.Add(this.gbManageBook);
            this.tpSearchBook.Controls.Add(this.button7);
            this.tpSearchBook.Controls.Add(this.comboBox1);
            this.tpSearchBook.Controls.Add(this.label5);
            this.tpSearchBook.Controls.Add(this.label6);
            this.tpSearchBook.Controls.Add(this.gvBookList);
            this.tpSearchBook.Controls.Add(this.btnSearch);
            this.tpSearchBook.Controls.Add(this.tbSearch);
            this.tpSearchBook.Location = new System.Drawing.Point(4, 29);
            this.tpSearchBook.Name = "tpSearchBook";
            this.tpSearchBook.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearchBook.Size = new System.Drawing.Size(961, 520);
            this.tpSearchBook.TabIndex = 1;
            this.tpSearchBook.Text = "Search Book";
            this.tpSearchBook.UseVisualStyleBackColor = true;
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
            this.gvUserList.Location = new System.Drawing.Point(14, 104);
            this.gvUserList.Name = "gvUserList";
            this.gvUserList.Size = new System.Drawing.Size(634, 330);
            this.gvUserList.TabIndex = 14;
            // 
            // tpManageBook
            // 
            this.tpManageBook.Controls.Add(this.btnAddBook);
            this.tpManageBook.Controls.Add(this.btnEditBook);
            this.tpManageBook.Controls.Add(this.btnShowHideBook);
            this.tpManageBook.Controls.Add(this.label3);
            this.tpManageBook.Controls.Add(this.dataGridView1);
            this.tpManageBook.Location = new System.Drawing.Point(4, 29);
            this.tpManageBook.Name = "tpManageBook";
            this.tpManageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageBook.Size = new System.Drawing.Size(961, 520);
            this.tpManageBook.TabIndex = 3;
            this.tpManageBook.Text = "Manage Book";
            this.tpManageBook.UseVisualStyleBackColor = true;
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(771, 297);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(184, 69);
            this.btnEditBook.TabIndex = 16;
            this.btnEditBook.Text = "Edit Book";
            this.btnEditBook.UseVisualStyleBackColor = true;
            // 
            // btnShowHideBook
            // 
            this.btnShowHideBook.Location = new System.Drawing.Point(771, 394);
            this.btnShowHideBook.Name = "btnShowHideBook";
            this.btnShowHideBook.Size = new System.Drawing.Size(184, 69);
            this.btnShowHideBook.TabIndex = 15;
            this.btnShowHideBook.Text = "Show/Hide Book";
            this.btnShowHideBook.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Book List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 380);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(774, 200);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(184, 69);
            this.btnAddBook.TabIndex = 17;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // tpSearchUser
            // 
            this.tpSearchUser.Controls.Add(this.button3);
            this.tpSearchUser.Controls.Add(this.button4);
            this.tpSearchUser.Controls.Add(this.button5);
            this.tpSearchUser.Controls.Add(this.label7);
            this.tpSearchUser.Controls.Add(this.gvBorrowingBook);
            this.tpSearchUser.Controls.Add(this.button6);
            this.tpSearchUser.Controls.Add(this.tbUsername);
            this.tpSearchUser.Controls.Add(this.label8);
            this.tpSearchUser.Location = new System.Drawing.Point(4, 29);
            this.tpSearchUser.Name = "tpSearchUser";
            this.tpSearchUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearchUser.Size = new System.Drawing.Size(961, 520);
            this.tpSearchUser.TabIndex = 4;
            this.tpSearchUser.Text = "Search User";
            this.tpSearchUser.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Add User Borrow";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 40;
            // 
            // tbUserBorrow
            // 
            this.tbUserBorrow.Location = new System.Drawing.Point(27, 47);
            this.tbUserBorrow.Name = "tbUserBorrow";
            this.tbUserBorrow.Size = new System.Drawing.Size(222, 27);
            this.tbUserBorrow.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 41);
            this.button1.TabIndex = 38;
            this.button1.Text = "Show/Hide in Library";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 37;
            this.button2.Text = "Edit Book";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnConfirmBookReturned
            // 
            this.btnConfirmBookReturned.Location = new System.Drawing.Point(27, 95);
            this.btnConfirmBookReturned.Name = "btnConfirmBookReturned";
            this.btnConfirmBookReturned.Size = new System.Drawing.Size(150, 42);
            this.btnConfirmBookReturned.TabIndex = 36;
            this.btnConfirmBookReturned.Text = "Confirmly Add";
            this.btnConfirmBookReturned.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Book List";
            // 
            // gvBookList
            // 
            this.gvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBookList.Location = new System.Drawing.Point(12, 157);
            this.gvBookList.Name = "gvBookList";
            this.gvBookList.Size = new System.Drawing.Size(596, 293);
            this.gvBookList.TabIndex = 34;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(656, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 33);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(274, 79);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(334, 27);
            this.tbSearch.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Search By Book\'s Title",
            "Search By Author",
            "Search By Content",
            "Search Overdue Book"});
            this.comboBox1.Location = new System.Drawing.Point(125, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 28);
            this.comboBox1.TabIndex = 42;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(685, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 69);
            this.button3.TabIndex = 27;
            this.button3.Text = "Reset User Password";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(685, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 69);
            this.button4.TabIndex = 26;
            this.button4.Text = "Active/Deactive User";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(685, 179);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 69);
            this.button5.TabIndex = 25;
            this.button5.Text = "Confirm Book Returned";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(126, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Borrowing Book";
            // 
            // gvBorrowingBook
            // 
            this.gvBorrowingBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBorrowingBook.Location = new System.Drawing.Point(129, 179);
            this.gvBorrowingBook.Name = "gvBorrowingBook";
            this.gvBorrowingBook.Size = new System.Drawing.Size(479, 269);
            this.gvBorrowingBook.TabIndex = 23;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(685, 72);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 33);
            this.button6.TabIndex = 22;
            this.button6.Text = "Search ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(274, 80);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(334, 27);
            this.tbUsername.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(126, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Search By Username";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(706, 448);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(184, 69);
            this.button7.TabIndex = 43;
            this.button7.Text = "View Book\'s Information";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // gbManageBook
            // 
            this.gbManageBook.Controls.Add(this.button8);
            this.gbManageBook.Controls.Add(this.label4);
            this.gbManageBook.Controls.Add(this.tbUserBorrow);
            this.gbManageBook.Controls.Add(this.btnConfirmBookReturned);
            this.gbManageBook.Controls.Add(this.button2);
            this.gbManageBook.Controls.Add(this.button1);
            this.gbManageBook.Location = new System.Drawing.Point(614, 157);
            this.gbManageBook.Name = "gbManageBook";
            this.gbManageBook.Size = new System.Drawing.Size(340, 287);
            this.gbManageBook.TabIndex = 44;
            this.gbManageBook.TabStop = false;
            this.gbManageBook.Text = "Manage Book";
            this.gbManageBook.Enter += new System.EventHandler(this.gbManageBook_Enter);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(206, 95);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(128, 67);
            this.button8.TabIndex = 42;
            this.button8.Text = "Add New Book";
            this.button8.UseVisualStyleBackColor = true;
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbBookList)).EndInit();
            this.tpSearchBook.ResumeLayout(false);
            this.tpSearchBook.PerformLayout();
            this.tpManageUser.ResumeLayout(false);
            this.tpManageUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).EndInit();
            this.tpManageBook.ResumeLayout(false);
            this.tpManageBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpSearchUser.ResumeLayout(false);
            this.tpSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBorrowingBook)).EndInit();
            this.gbManageBook.ResumeLayout(false);
            this.gbManageBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMenu;
        private System.Windows.Forms.TabPage tpMenu;
        private System.Windows.Forms.TabPage tpSearchBook;
        private System.Windows.Forms.TabPage tpManageUser;
        private System.Windows.Forms.TabPage tpManageBook;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnActDeactUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvUserList;
        private System.Windows.Forms.Button btnViewBookInfor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gbBookList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnShowHideBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TabPage tpSearchUser;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUserBorrow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnConfirmBookReturned;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gvBookList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gvBorrowingBook;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox gbManageBook;
        private System.Windows.Forms.Button button8;
    }
}