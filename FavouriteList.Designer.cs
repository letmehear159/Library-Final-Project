namespace Library_Final_Project
{
    partial class FavouriteList
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
            this.gvBorrowingList = new System.Windows.Forms.DataGridView();
            this.gvFavouriteList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUnfavourite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvBorrowingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFavouriteList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvBorrowingList
            // 
            this.gvBorrowingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBorrowingList.Location = new System.Drawing.Point(54, 92);
            this.gvBorrowingList.Name = "gvBorrowingList";
            this.gvBorrowingList.Size = new System.Drawing.Size(420, 269);
            this.gvBorrowingList.TabIndex = 1;
            // 
            // gvFavouriteList
            // 
            this.gvFavouriteList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFavouriteList.Location = new System.Drawing.Point(534, 92);
            this.gvFavouriteList.Name = "gvFavouriteList";
            this.gvFavouriteList.Size = new System.Drawing.Size(420, 269);
            this.gvFavouriteList.TabIndex = 2;
            this.gvFavouriteList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Borrowing List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Favourite List";
            // 
            // btnUnfavourite
            // 
            this.btnUnfavourite.Location = new System.Drawing.Point(646, 395);
            this.btnUnfavourite.Name = "btnUnfavourite";
            this.btnUnfavourite.Size = new System.Drawing.Size(184, 69);
            this.btnUnfavourite.TabIndex = 9;
            this.btnUnfavourite.Text = "Unfavourite";
            this.btnUnfavourite.UseVisualStyleBackColor = true;
            // 
            // FavouriteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 515);
            this.Controls.Add(this.btnUnfavourite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gvFavouriteList);
            this.Controls.Add(this.gvBorrowingList);
            this.Name = "FavouriteList";
            this.Text = "FavouriteList";
            ((System.ComponentModel.ISupportInitialize)(this.gvBorrowingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFavouriteList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvBorrowingList;
        private System.Windows.Forms.DataGridView gvFavouriteList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUnfavourite;
    }
}