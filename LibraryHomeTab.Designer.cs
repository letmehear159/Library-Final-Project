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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tpSearchUser = new System.Windows.Forms.TabPage();
            this.btnResetUserPassword = new System.Windows.Forms.Button();
            this.btnActDeactiveUser = new System.Windows.Forms.Button();
            this.btnConfirmBookReturn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gvBorrowingBook = new System.Windows.Forms.DataGridView();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tpManageUser = new System.Windows.Forms.TabPage();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnActDeactUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvUserList = new System.Windows.Forms.DataGridView();
            this.tpSearchBook = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbManageBook = new System.Windows.Forms.GroupBox();
            this.btnConfirmBookReturned = new System.Windows.Forms.Button();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUserBorrow = new System.Windows.Forms.TextBox();
            this.btnConfirmBookAdd = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnShowHideBook = new System.Windows.Forms.Button();
            this.btnViewBooksInfor = new System.Windows.Forms.Button();
            this.cbSearchOption = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gvBookListSearch = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tcMenu = new System.Windows.Forms.TabControl();
            this.tpMenu = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.btnViewBookInfor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gvBookListMenu = new System.Windows.Forms.DataGridView();
            this.tpMyList = new System.Windows.Forms.TabPage();
            this.btnUnfavourite = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gvFavouriteList = new System.Windows.Forms.DataGridView();
            this.gvBorrowingList = new System.Windows.Forms.DataGridView();
            this.tsStatusLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.tsStatusLoginFinal = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRefreshFavourlist = new System.Windows.Forms.Button();
            this.tpSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBorrowingBook)).BeginInit();
            this.tpManageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).BeginInit();
            this.tpSearchBook.SuspendLayout();
            this.gbManageBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBookListSearch)).BeginInit();
            this.tcMenu.SuspendLayout();
            this.tpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBookListMenu)).BeginInit();
            this.tpMyList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFavouriteList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBorrowingList)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpSearchUser
            // 
            this.tpSearchUser.Controls.Add(this.btnResetUserPassword);
            this.tpSearchUser.Controls.Add(this.btnActDeactiveUser);
            this.tpSearchUser.Controls.Add(this.btnConfirmBookReturn);
            this.tpSearchUser.Controls.Add(this.label7);
            this.tpSearchUser.Controls.Add(this.gvBorrowingBook);
            this.tpSearchUser.Controls.Add(this.btnSearchUser);
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
            // btnResetUserPassword
            // 
            this.btnResetUserPassword.Location = new System.Drawing.Point(789, 404);
            this.btnResetUserPassword.Name = "btnResetUserPassword";
            this.btnResetUserPassword.Size = new System.Drawing.Size(150, 69);
            this.btnResetUserPassword.TabIndex = 27;
            this.btnResetUserPassword.Text = "Reset User Password";
            this.btnResetUserPassword.UseVisualStyleBackColor = true;
            this.btnResetUserPassword.Click += new System.EventHandler(this.btnResetUserPassword_Click);
            // 
            // btnActDeactiveUser
            // 
            this.btnActDeactiveUser.Location = new System.Drawing.Point(789, 298);
            this.btnActDeactiveUser.Name = "btnActDeactiveUser";
            this.btnActDeactiveUser.Size = new System.Drawing.Size(150, 69);
            this.btnActDeactiveUser.TabIndex = 26;
            this.btnActDeactiveUser.Text = "Active/Deactive User";
            this.btnActDeactiveUser.UseVisualStyleBackColor = true;
            this.btnActDeactiveUser.Click += new System.EventHandler(this.btnActDeactiveUser_Click);
            // 
            // btnConfirmBookReturn
            // 
            this.btnConfirmBookReturn.Location = new System.Drawing.Point(789, 204);
            this.btnConfirmBookReturn.Name = "btnConfirmBookReturn";
            this.btnConfirmBookReturn.Size = new System.Drawing.Size(150, 69);
            this.btnConfirmBookReturn.TabIndex = 25;
            this.btnConfirmBookReturn.Text = "Confirm Book Returned";
            this.btnConfirmBookReturn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Borrowing Book";
            // 
            // gvBorrowingBook
            // 
            this.gvBorrowingBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBorrowingBook.Location = new System.Drawing.Point(8, 153);
            this.gvBorrowingBook.Name = "gvBorrowingBook";
            this.gvBorrowingBook.Size = new System.Drawing.Size(670, 324);
            this.gvBorrowingBook.TabIndex = 23;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(686, 77);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(114, 33);
            this.btnSearchUser.TabIndex = 22;
            this.btnSearchUser.Text = "Search ";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
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
            this.label8.Location = new System.Drawing.Point(106, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Search By Username";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tpManageUser
            // 
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
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(732, 304);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(154, 69);
            this.btnResetPassword.TabIndex = 17;
            this.btnResetPassword.Text = "Reset User Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnActDeactUser
            // 
            this.btnActDeactUser.Location = new System.Drawing.Point(732, 202);
            this.btnActDeactUser.Name = "btnActDeactUser";
            this.btnActDeactUser.Size = new System.Drawing.Size(150, 69);
            this.btnActDeactUser.TabIndex = 16;
            this.btnActDeactUser.Text = "Active/Deactive User";
            this.btnActDeactUser.UseVisualStyleBackColor = true;
            this.btnActDeactUser.Click += new System.EventHandler(this.btnActDeactUser_Click);
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
            // tpSearchBook
            // 
            this.tpSearchBook.Controls.Add(this.btnRefresh);
            this.tpSearchBook.Controls.Add(this.gbManageBook);
            this.tpSearchBook.Controls.Add(this.btnViewBooksInfor);
            this.tpSearchBook.Controls.Add(this.cbSearchOption);
            this.tpSearchBook.Controls.Add(this.label5);
            this.tpSearchBook.Controls.Add(this.label6);
            this.tpSearchBook.Controls.Add(this.gvBookListSearch);
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
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(819, 448);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(135, 69);
            this.btnRefresh.TabIndex = 44;
            this.btnRefresh.Text = "Refresh Search";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gbManageBook
            // 
            this.gbManageBook.Controls.Add(this.btnConfirmBookReturned);
            this.gbManageBook.Controls.Add(this.btnAddNewBook);
            this.gbManageBook.Controls.Add(this.label4);
            this.gbManageBook.Controls.Add(this.tbUserBorrow);
            this.gbManageBook.Controls.Add(this.btnConfirmBookAdd);
            this.gbManageBook.Controls.Add(this.btnEditBook);
            this.gbManageBook.Controls.Add(this.btnShowHideBook);
            this.gbManageBook.Location = new System.Drawing.Point(614, 128);
            this.gbManageBook.Name = "gbManageBook";
            this.gbManageBook.Size = new System.Drawing.Size(340, 316);
            this.gbManageBook.TabIndex = 44;
            this.gbManageBook.TabStop = false;
            this.gbManageBook.Text = "Manage Book";
            // 
            // btnConfirmBookReturned
            // 
            this.btnConfirmBookReturned.Location = new System.Drawing.Point(183, 120);
            this.btnConfirmBookReturned.Name = "btnConfirmBookReturned";
            this.btnConfirmBookReturned.Size = new System.Drawing.Size(150, 52);
            this.btnConfirmBookReturned.TabIndex = 43;
            this.btnConfirmBookReturned.Text = "Confirmly Returned";
            this.btnConfirmBookReturned.UseVisualStyleBackColor = true;
            this.btnConfirmBookReturned.Click += new System.EventHandler(this.btnConfirmBookReturned_Click);
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Location = new System.Drawing.Point(183, 246);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(150, 54);
            this.btnAddNewBook.TabIndex = 42;
            this.btnAddNewBook.Text = "Add New Book";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Add User Borrow/Confirm Book Returned";
            // 
            // tbUserBorrow
            // 
            this.tbUserBorrow.Location = new System.Drawing.Point(27, 70);
            this.tbUserBorrow.Name = "tbUserBorrow";
            this.tbUserBorrow.Size = new System.Drawing.Size(306, 27);
            this.tbUserBorrow.TabIndex = 39;
            // 
            // btnConfirmBookAdd
            // 
            this.btnConfirmBookAdd.Location = new System.Drawing.Point(27, 120);
            this.btnConfirmBookAdd.Name = "btnConfirmBookAdd";
            this.btnConfirmBookAdd.Size = new System.Drawing.Size(150, 42);
            this.btnConfirmBookAdd.TabIndex = 36;
            this.btnConfirmBookAdd.Text = "Confirmly Add";
            this.btnConfirmBookAdd.UseVisualStyleBackColor = true;
            this.btnConfirmBookAdd.Click += new System.EventHandler(this.btnConfirmBookAdd_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(27, 188);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(150, 40);
            this.btnEditBook.TabIndex = 37;
            this.btnEditBook.Text = "Edit Book";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnShowHideBook
            // 
            this.btnShowHideBook.Location = new System.Drawing.Point(27, 246);
            this.btnShowHideBook.Name = "btnShowHideBook";
            this.btnShowHideBook.Size = new System.Drawing.Size(150, 54);
            this.btnShowHideBook.TabIndex = 38;
            this.btnShowHideBook.Text = "Hide in Library";
            this.btnShowHideBook.UseVisualStyleBackColor = true;
            this.btnShowHideBook.Click += new System.EventHandler(this.btnShowHideBook_Click);
            // 
            // btnViewBooksInfor
            // 
            this.btnViewBooksInfor.Location = new System.Drawing.Point(614, 450);
            this.btnViewBooksInfor.Name = "btnViewBooksInfor";
            this.btnViewBooksInfor.Size = new System.Drawing.Size(184, 69);
            this.btnViewBooksInfor.TabIndex = 43;
            this.btnViewBooksInfor.Text = "View Book\'s Information";
            this.btnViewBooksInfor.UseVisualStyleBackColor = true;
            this.btnViewBooksInfor.Click += new System.EventHandler(this.btnViewBooksInfor_Click);
            // 
            // cbSearchOption
            // 
            this.cbSearchOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchOption.FormattingEnabled = true;
            this.cbSearchOption.Items.AddRange(new object[] {
            "Search By Book\'s Title",
            "Search By Author",
            "Search By Content",
            "Search Overdue Book"});
            this.cbSearchOption.Location = new System.Drawing.Point(57, 22);
            this.cbSearchOption.Name = "cbSearchOption";
            this.cbSearchOption.Size = new System.Drawing.Size(211, 28);
            this.cbSearchOption.TabIndex = 42;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Book List";
            // 
            // gvBookListSearch
            // 
            this.gvBookListSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBookListSearch.Location = new System.Drawing.Point(12, 83);
            this.gvBookListSearch.Name = "gvBookListSearch";
            this.gvBookListSearch.Size = new System.Drawing.Size(596, 431);
            this.gvBookListSearch.TabIndex = 34;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(656, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 33);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(274, 22);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(334, 27);
            this.tbSearch.TabIndex = 32;
            // 
            // tcMenu
            // 
            this.tcMenu.Controls.Add(this.tpMenu);
            this.tcMenu.Controls.Add(this.tpSearchBook);
            this.tcMenu.Controls.Add(this.tpManageUser);
            this.tcMenu.Controls.Add(this.tpSearchUser);
            this.tcMenu.Controls.Add(this.tpMyList);
            this.tcMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMenu.Location = new System.Drawing.Point(0, -1);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(969, 553);
            this.tcMenu.TabIndex = 0;
            // 
            // tpMenu
            // 
            this.tpMenu.Controls.Add(this.label9);
            this.tpMenu.Controls.Add(this.btnViewBookInfor);
            this.tpMenu.Controls.Add(this.label2);
            this.tpMenu.Controls.Add(this.gvBookListMenu);
            this.tpMenu.Location = new System.Drawing.Point(4, 29);
            this.tpMenu.Name = "tpMenu";
            this.tpMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tpMenu.Size = new System.Drawing.Size(961, 520);
            this.tpMenu.TabIndex = 0;
            this.tpMenu.Text = "Menu";
            this.tpMenu.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 22);
            this.label9.TabIndex = 36;
            this.label9.Text = "Book List";
            // 
            // btnViewBookInfor
            // 
            this.btnViewBookInfor.Location = new System.Drawing.Point(770, 390);
            this.btnViewBookInfor.Name = "btnViewBookInfor";
            this.btnViewBookInfor.Size = new System.Drawing.Size(184, 69);
            this.btnViewBookInfor.TabIndex = 11;
            this.btnViewBookInfor.Text = "View Book\'s Information";
            this.btnViewBookInfor.UseVisualStyleBackColor = true;
            this.btnViewBookInfor.Click += new System.EventHandler(this.btnViewBookInfor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 9;
            // 
            // gvBookListMenu
            // 
            this.gvBookListMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBookListMenu.Location = new System.Drawing.Point(19, 79);
            this.gvBookListMenu.Name = "gvBookListMenu";
            this.gvBookListMenu.Size = new System.Drawing.Size(745, 380);
            this.gvBookListMenu.TabIndex = 8;
            // 
            // tpMyList
            // 
            this.tpMyList.Controls.Add(this.btnRefreshFavourlist);
            this.tpMyList.Controls.Add(this.btnUnfavourite);
            this.tpMyList.Controls.Add(this.label3);
            this.tpMyList.Controls.Add(this.label10);
            this.tpMyList.Controls.Add(this.gvFavouriteList);
            this.tpMyList.Controls.Add(this.gvBorrowingList);
            this.tpMyList.Location = new System.Drawing.Point(4, 29);
            this.tpMyList.Name = "tpMyList";
            this.tpMyList.Padding = new System.Windows.Forms.Padding(3);
            this.tpMyList.Size = new System.Drawing.Size(961, 520);
            this.tpMyList.TabIndex = 5;
            this.tpMyList.Text = "My List";
            this.tpMyList.UseVisualStyleBackColor = true;
            // 
            // btnUnfavourite
            // 
            this.btnUnfavourite.Location = new System.Drawing.Point(747, 393);
            this.btnUnfavourite.Name = "btnUnfavourite";
            this.btnUnfavourite.Size = new System.Drawing.Size(184, 69);
            this.btnUnfavourite.TabIndex = 14;
            this.btnUnfavourite.Text = "Unfavourite";
            this.btnUnfavourite.UseVisualStyleBackColor = true;
            this.btnUnfavourite.Click += new System.EventHandler(this.btnUnfavourite_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(475, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Favourite List";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Borrowing List";
            // 
            // gvFavouriteList
            // 
            this.gvFavouriteList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFavouriteList.Location = new System.Drawing.Point(475, 64);
            this.gvFavouriteList.Name = "gvFavouriteList";
            this.gvFavouriteList.Size = new System.Drawing.Size(479, 289);
            this.gvFavouriteList.TabIndex = 11;
            // 
            // gvBorrowingList
            // 
            this.gvBorrowingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBorrowingList.Location = new System.Drawing.Point(32, 64);
            this.gvBorrowingList.Name = "gvBorrowingList";
            this.gvBorrowingList.Size = new System.Drawing.Size(437, 289);
            this.gvBorrowingList.TabIndex = 10;
            // 
            // tsStatusLogin
            // 
            this.tsStatusLogin.Name = "tsStatusLogin";
            this.tsStatusLogin.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLoginFinal});
            this.statusStrip2.Location = new System.Drawing.Point(0, 556);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(970, 22);
            this.statusStrip2.TabIndex = 38;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // tsStatusLoginFinal
            // 
            this.tsStatusLoginFinal.Name = "tsStatusLoginFinal";
            this.tsStatusLoginFinal.Size = new System.Drawing.Size(118, 17);
            this.tsStatusLoginFinal.Text = "toolStripStatusLabel1";
            // 
            // btnRefreshFavourlist
            // 
            this.btnRefreshFavourlist.Location = new System.Drawing.Point(515, 393);
            this.btnRefreshFavourlist.Name = "btnRefreshFavourlist";
            this.btnRefreshFavourlist.Size = new System.Drawing.Size(184, 69);
            this.btnRefreshFavourlist.TabIndex = 15;
            this.btnRefreshFavourlist.Text = "Refresh Favourite List";
            this.btnRefreshFavourlist.UseVisualStyleBackColor = true;
            this.btnRefreshFavourlist.Click += new System.EventHandler(this.btnRefreshFavourlist_Click);
            // 
            // LibraryHomeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 578);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.tcMenu);
            this.Name = "LibraryHomeTab";
            this.Text = "TestTab";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LibraryHomeTab_FormClosing);
            this.Load += new System.EventHandler(this.LibraryHomeTab_Load);
            this.tpSearchUser.ResumeLayout(false);
            this.tpSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBorrowingBook)).EndInit();
            this.tpManageUser.ResumeLayout(false);
            this.tpManageUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).EndInit();
            this.tpSearchBook.ResumeLayout(false);
            this.tpSearchBook.PerformLayout();
            this.gbManageBook.ResumeLayout(false);
            this.gbManageBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBookListSearch)).EndInit();
            this.tcMenu.ResumeLayout(false);
            this.tpMenu.ResumeLayout(false);
            this.tpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBookListMenu)).EndInit();
            this.tpMyList.ResumeLayout(false);
            this.tpMyList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFavouriteList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBorrowingList)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tpSearchUser;
        private System.Windows.Forms.Button btnResetUserPassword;
        private System.Windows.Forms.Button btnActDeactiveUser;
        private System.Windows.Forms.Button btnConfirmBookReturn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gvBorrowingBook;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tpManageUser;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnActDeactUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvUserList;
        private System.Windows.Forms.TabPage tpSearchBook;
        private System.Windows.Forms.GroupBox gbManageBook;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUserBorrow;
        private System.Windows.Forms.Button btnConfirmBookAdd;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnShowHideBook;
        private System.Windows.Forms.Button btnViewBooksInfor;
        private System.Windows.Forms.ComboBox cbSearchOption;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gvBookListSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TabControl tcMenu;
        private System.Windows.Forms.TabPage tpMenu;
        private System.Windows.Forms.Button btnViewBookInfor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvBookListMenu;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLogin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLoginFinal;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnConfirmBookReturned;
        private System.Windows.Forms.TabPage tpMyList;
        private System.Windows.Forms.Button btnUnfavourite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView gvFavouriteList;
        private System.Windows.Forms.DataGridView gvBorrowingList;
        private System.Windows.Forms.Button btnRefreshFavourlist;
    }
}