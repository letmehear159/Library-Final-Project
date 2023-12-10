using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Final_Project
{
    public partial class CommentList : Form
    {
        private readonly LibraryEntities _db = new LibraryEntities();
        private User _user;
        private Book _book;
        public CommentList(User user, Book book)
        {
            InitializeComponent();
            _user = user;
            _book = book;
        }
        /// <summary>
        /// Add the user comment to the commentList in database
        /// </summary>
        private void btnLeaveComment_Click(object sender, EventArgs e)
        {
            try
            {
                var userComment = tbComment.Text;
                var comment = new Comment();
                comment.ISBN = _book.ISBN;
                comment.CommentaryContent = userComment;
                comment.Date = DateTime.Now;
                comment.Account = _user.Account;
                //Create a new instance of comment then pass the data from the textbox to it

                _db.Comments.Add(comment);
                _db.SaveChanges();
                //Add this comment to list

                MessageBox.Show("We received your comment about this book.\r\n" +
                    "Thanks for your attribution.");
                //Inform the user 
                Utils.PopulateCommentGrid(_db, gvCommentList, _book);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void CommentList_Load(object sender, EventArgs e)
        {
            try
            {
                lblBookName.Text = _book.Title;
                Utils.PopulateCommentGrid(_db, gvCommentList, _book);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }


        }
    }
}
