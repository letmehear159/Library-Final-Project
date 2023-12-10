namespace Library_Final_Project
{
    partial class CommentList
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
            this.gvCommentList = new System.Windows.Forms.DataGridView();
            this.btnLeaveComment = new System.Windows.Forms.Button();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvCommentList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvCommentList
            // 
            this.gvCommentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCommentList.Location = new System.Drawing.Point(12, 92);
            this.gvCommentList.Name = "gvCommentList";
            this.gvCommentList.Size = new System.Drawing.Size(479, 269);
            this.gvCommentList.TabIndex = 0;
            // 
            // btnLeaveComment
            // 
            this.btnLeaveComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveComment.Location = new System.Drawing.Point(664, 309);
            this.btnLeaveComment.Name = "btnLeaveComment";
            this.btnLeaveComment.Size = new System.Drawing.Size(129, 52);
            this.btnLeaveComment.TabIndex = 16;
            this.btnLeaveComment.Text = "Leave Comment";
            this.btnLeaveComment.UseVisualStyleBackColor = true;
            this.btnLeaveComment.Click += new System.EventHandler(this.btnLeaveComment_Click);
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(497, 140);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(296, 151);
            this.tbComment.TabIndex = 15;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(284, 25);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(156, 31);
            this.lblBookName.TabIndex = 17;
            this.lblBookName.Text = "BookName";
            // 
            // CommentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.btnLeaveComment);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.gvCommentList);
            this.Name = "CommentList";
            this.Text = "Comment List";
            this.Load += new System.EventHandler(this.CommentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCommentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvCommentList;
        private System.Windows.Forms.Button btnLeaveComment;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label lblBookName;
    }
}