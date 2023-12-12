namespace Library_Final_Project
{
    partial class BookInformation
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pbBookImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBorrowUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbContenSummary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnViewComment = new System.Windows.Forms.Button();
            this.btnAddToFavourList = new System.Windows.Forms.Button();
            this.lblCurrentBorrow = new System.Windows.Forms.Label();
            this.btnAddToLibrary = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pbBookImage
            // 
            this.pbBookImage.InitialImage = null;
            this.pbBookImage.Location = new System.Drawing.Point(28, 12);
            this.pbBookImage.Name = "pbBookImage";
            this.pbBookImage.Size = new System.Drawing.Size(348, 292);
            this.pbBookImage.TabIndex = 1;
            this.pbBookImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(482, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Status";
            // 
            // lblBorrowUser
            // 
            this.lblBorrowUser.AutoSize = true;
            this.lblBorrowUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowUser.Location = new System.Drawing.Point(857, 101);
            this.lblBorrowUser.Name = "lblBorrowUser";
            this.lblBorrowUser.Size = new System.Drawing.Size(51, 20);
            this.lblBorrowUser.TabIndex = 6;
            this.lblBorrowUser.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Book\'s Title";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.73913F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.26087F));
            this.tableLayoutPanel1.Controls.Add(this.tbCategory, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbStatus, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbISBN, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbAuthor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(391, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 233);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(194, 187);
            this.tbCategory.Multiline = true;
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(262, 43);
            this.tbCategory.TabIndex = 19;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(194, 141);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(131, 20);
            this.tbStatus.TabIndex = 19;
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(194, 95);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(131, 20);
            this.tbISBN.TabIndex = 19;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(194, 49);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(262, 20);
            this.tbAuthor.TabIndex = 18;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(194, 3);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(262, 20);
            this.tbTitle.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Category";
            // 
            // tbContenSummary
            // 
            this.tbContenSummary.Location = new System.Drawing.Point(28, 336);
            this.tbContenSummary.Multiline = true;
            this.tbContenSummary.Name = "tbContenSummary";
            this.tbContenSummary.Size = new System.Drawing.Size(704, 219);
            this.tbContenSummary.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Content Summary";
            // 
            // btnViewComment
            // 
            this.btnViewComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewComment.Location = new System.Drawing.Point(738, 336);
            this.btnViewComment.Name = "btnViewComment";
            this.btnViewComment.Size = new System.Drawing.Size(129, 52);
            this.btnViewComment.TabIndex = 15;
            this.btnViewComment.Text = "View Comment";
            this.btnViewComment.UseVisualStyleBackColor = true;
            this.btnViewComment.Click += new System.EventHandler(this.btnViewComment_Click);
            // 
            // btnAddToFavourList
            // 
            this.btnAddToFavourList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddToFavourList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToFavourList.Location = new System.Drawing.Point(894, 336);
            this.btnAddToFavourList.Name = "btnAddToFavourList";
            this.btnAddToFavourList.Size = new System.Drawing.Size(129, 52);
            this.btnAddToFavourList.TabIndex = 16;
            this.btnAddToFavourList.Text = "Add To Favourite List";
            this.btnAddToFavourList.UseVisualStyleBackColor = false;
            this.btnAddToFavourList.Click += new System.EventHandler(this.btnAddToFavourList_Click);
            // 
            // lblCurrentBorrow
            // 
            this.lblCurrentBorrow.AutoSize = true;
            this.lblCurrentBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBorrow.Location = new System.Drawing.Point(852, 71);
            this.lblCurrentBorrow.Name = "lblCurrentBorrow";
            this.lblCurrentBorrow.Size = new System.Drawing.Size(171, 20);
            this.lblCurrentBorrow.TabIndex = 17;
            this.lblCurrentBorrow.Text = "Currently Borrowing:";
            // 
            // btnAddToLibrary
            // 
            this.btnAddToLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToLibrary.Location = new System.Drawing.Point(894, 437);
            this.btnAddToLibrary.Name = "btnAddToLibrary";
            this.btnAddToLibrary.Size = new System.Drawing.Size(129, 84);
            this.btnAddToLibrary.TabIndex = 18;
            this.btnAddToLibrary.Text = "Add Book To Library";
            this.btnAddToLibrary.UseVisualStyleBackColor = true;
            this.btnAddToLibrary.Click += new System.EventHandler(this.btnAddToLibrary_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(738, 437);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(129, 84);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit Book\'s Change";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // BookInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 588);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAddToLibrary);
            this.Controls.Add(this.lblCurrentBorrow);
            this.Controls.Add(this.btnAddToFavourList);
            this.Controls.Add(this.btnViewComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbContenSummary);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbBookImage);
            this.Controls.Add(this.lblBorrowUser);
            this.Name = "BookInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookInformation";
            this.Load += new System.EventHandler(this.BookInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pbBookImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBorrowUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbContenSummary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewComment;
        private System.Windows.Forms.Button btnAddToFavourList;
        private System.Windows.Forms.Label lblCurrentBorrow;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Button btnAddToLibrary;
        private System.Windows.Forms.Button btnSubmit;
    }
}