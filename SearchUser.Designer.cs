namespace Library_Final_Project
{
    partial class SearchUser
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gvBorrowingBook = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmBookReturned = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnActDeactUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvBorrowingBook)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(213, 40);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(334, 20);
            this.tbUsername.TabIndex = 10;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search By Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(624, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 33);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // gvBorrowingBook
            // 
            this.gvBorrowingBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBorrowingBook.Location = new System.Drawing.Point(68, 139);
            this.gvBorrowingBook.Name = "gvBorrowingBook";
            this.gvBorrowingBook.Size = new System.Drawing.Size(479, 269);
            this.gvBorrowingBook.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Borrowing Book";
            // 
            // btnConfirmBookReturned
            // 
            this.btnConfirmBookReturned.Location = new System.Drawing.Point(624, 139);
            this.btnConfirmBookReturned.Name = "btnConfirmBookReturned";
            this.btnConfirmBookReturned.Size = new System.Drawing.Size(150, 69);
            this.btnConfirmBookReturned.TabIndex = 17;
            this.btnConfirmBookReturned.Text = "Confirm Book Returned";
            this.btnConfirmBookReturned.UseVisualStyleBackColor = true;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(624, 339);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(150, 69);
            this.btnResetPassword.TabIndex = 19;
            this.btnResetPassword.Text = "Reset User Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            // 
            // btnActDeactUser
            // 
            this.btnActDeactUser.Location = new System.Drawing.Point(624, 233);
            this.btnActDeactUser.Name = "btnActDeactUser";
            this.btnActDeactUser.Size = new System.Drawing.Size(150, 69);
            this.btnActDeactUser.TabIndex = 18;
            this.btnActDeactUser.Text = "Active/Deactive User";
            this.btnActDeactUser.UseVisualStyleBackColor = true;
            // 
            // SearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnActDeactUser);
            this.Controls.Add(this.btnConfirmBookReturned);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvBorrowingBook);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label2);
            this.Name = "SearchUser";
            this.Text = "SearchUser";
            ((System.ComponentModel.ISupportInitialize)(this.gvBorrowingBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView gvBorrowingBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmBookReturned;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnActDeactUser;
    }
}