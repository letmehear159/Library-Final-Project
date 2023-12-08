namespace Library_Final_Project
{
    partial class SearchBook
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
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnConfirmBookReturned = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvBorrowingBook = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserBorrow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvBorrowingBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(574, 373);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(150, 41);
            this.btnResetPassword.TabIndex = 27;
            this.btnResetPassword.Text = "Show/Hide in Library";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(574, 316);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(150, 40);
            this.btnEditBook.TabIndex = 26;
            this.btnEditBook.Text = "Edit Book";
            this.btnEditBook.UseVisualStyleBackColor = true;
            // 
            // btnConfirmBookReturned
            // 
            this.btnConfirmBookReturned.Location = new System.Drawing.Point(574, 227);
            this.btnConfirmBookReturned.Name = "btnConfirmBookReturned";
            this.btnConfirmBookReturned.Size = new System.Drawing.Size(150, 42);
            this.btnConfirmBookReturned.TabIndex = 25;
            this.btnConfirmBookReturned.Text = "Confirm Add";
            this.btnConfirmBookReturned.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Borrowing Book";
            // 
            // gvBorrowingBook
            // 
            this.gvBorrowingBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBorrowingBook.Location = new System.Drawing.Point(47, 144);
            this.gvBorrowingBook.Name = "gvBorrowingBook";
            this.gvBorrowingBook.Size = new System.Drawing.Size(479, 269);
            this.gvBorrowingBook.TabIndex = 23;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(574, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 33);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(192, 45);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(334, 20);
            this.tbSearch.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Search";
            // 
            // tbUserBorrow
            // 
            this.tbUserBorrow.Location = new System.Drawing.Point(574, 178);
            this.tbUserBorrow.Name = "tbUserBorrow";
            this.tbUserBorrow.Size = new System.Drawing.Size(179, 20);
            this.tbUserBorrow.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(571, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(571, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "User Borrow";
            // 
            // SearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUserBorrow);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnEditBook);
            this.Controls.Add(this.btnConfirmBookReturned);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvBorrowingBook);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label2);
            this.Name = "SearchBook";
            this.Text = "SearchBook";
            this.Load += new System.EventHandler(this.SearchBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBorrowingBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnConfirmBookReturned;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvBorrowingBook;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserBorrow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}