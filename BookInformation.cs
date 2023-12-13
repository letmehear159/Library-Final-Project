using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Final_Project
{
    public partial class BookInformation : Form
    {
        private readonly LibraryEntities _db = new LibraryEntities();
        private Book _book;
        private User _user;
        private bool _isEdit;
        /// <summary>
        /// Get the book , using user , and edit or just view
        /// </summary>
        public BookInformation(Book book, User user, bool isEdit)
        {
            InitializeComponent();
            _book = book;
            _isEdit = isEdit;
            _user = user;
        }
        public BookInformation(User user)
        {
            InitializeComponent();
            _user = user;
        }
        /// <summary>
        /// Pass the value from the choosen book to the textbox for edit or view information
        /// </summary>
        public void PopulateBookInformation()
        {
            try
            {
                tbTitle.Text = _book.Title;
                tbAuthor.Text = _book.Author;
                tbCategory.Text = _book.Category;
                tbContenSummary.Text = _book.ContentSummary.ContentBook;
                tbISBN.Text = _book.ISBN.ToString();
                if (_book.Quantity == 0)    //If book is out of stock
                {
                    tbStatus.Text = "Unavailable";
                }
                else
                {
                    tbStatus.Text = "Available";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        /// <summary>
        /// Set all the text box in bookinfor winform is read_only
        /// </summary>
        public void StaticBookInformation()
        {
            tbStatus.ReadOnly = true;
            tbTitle.ReadOnly = true;
            tbCategory.ReadOnly = true;
            tbContenSummary.ReadOnly = true;
            tbISBN.ReadOnly = true;
            tbAuthor.ReadOnly = true;
        }

        private void BookInformation_Load(object sender, EventArgs e)
        {

            try
            {
                string role = Utils.GetRoleOfUser(_db, _user);
                //Get the shorcut role name of this user
                if (role.Equals("User"))  //If this is a borrower than hide admin's operation
                {
                    btnAddToLibrary.Visible = false;
                    lblBorrowUser.Visible = false;
                    lblBorrowUser.Visible = false;
                    btnSubmit.Visible = false;
                }
                if (_book != null)      //If we are viewing or editting book information
                {
                    btnAddToLibrary.Visible = false;
                    PopulateBookInformation();
                    if (!_isEdit)
                    {
                        StaticBookInformation();
                    }
                    string path = "D:\\Visual Studio\\WindownForm\\Library Final Project\\BookImage\\";
                    string imageBookName = "";
                    switch (_book.ISBN)
                    {
                        case 1: //Hỏa phụng Liêu Nguyên
                            imageBookName = "HPLN.JPG";
                            break;
                        case 2: //Đại quản gia là ma hoàng
                            imageBookName = "DQG.JPG";
                            break;
                        case 3: //Cậu bé thần giáo
                            imageBookName = "CBTG.JPG";
                            break;
                        case 4:
                            imageBookName = "NKTL.JPG";
                            break;
                        case 5:
                            imageBookName = "Kingdom.JPG";
                            break;
                        default:
                            imageBookName = "CatDog.JPG";
                            break;
                    }
                    string imagePath = path + imageBookName;
                    Utils.ImageSizeHandle(imagePath, pbBookImage);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Save data of this book from the text box to database
        /// </summary>
        /// <param name="book"></param>: The book need changing data
        /// 
        public void SaveBookChangeToDatabase(Book book)
        {
            try
            {
                book.ISBN = int.Parse(tbISBN.Text);
                book.Author = tbAuthor.Text;
                book.Title = tbTitle.Text;
                book.Category = tbCategory.Text;
                string status = tbStatus.Text;
                status = status.Trim();
                status = status.ToLower();
                if (status == "available")
                {
                    book.Status = true;
                }
                else
                {
                    book.Status = false;
                }
                //Pass the data to book database 

                int oldISBN = _book.ISBN;
                //Find the old isbn to get this book from the database

                var contentSummary = _db.ContentSummaries.FirstOrDefault(q => q.ISBN == oldISBN);
                contentSummary.ContentBook = tbContenSummary.Text;
                //Get the content summary of this book and pass the new comment summary

                _db.SaveChanges();
                //Save change in database
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }
        /// <summary>
        /// Apply the edit/Change of book
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var isbn = _book.ISBN;
                var book = _db.Books.FirstOrDefault(q => q.ISBN == isbn);
                //Get the book from book table database
                SaveBookChangeToDatabase(book);
                //Save change
                MessageBox.Show("Successfuly saved book's changes.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        /// <summary>
        /// Add new book to library
        /// </summary>
        private void btnAddToLibrary_Click(object sender, EventArgs e)
        {
            try
            {
                var book = new Book();
                //Create a new instance of book

                book.Status = true;
                book.Author = tbAuthor.Text;
                book.Title = tbTitle.Text;
                book.Category = tbCategory.Text;
                book.Show = true;

                //Pass the data to new book
                if (string.IsNullOrEmpty(tbISBN.Text))
                {
                    _db.Books.Add(book);
                    _db.SaveChanges();
                    var justAddedBook = _db.Books.Where(q => q.Title == tbTitle.Text).ToList().LastOrDefault();
                    var contentSummary = new ContentSummary();
                    contentSummary.ContentBook = tbContenSummary.Text;
                    contentSummary.ISBN = justAddedBook.ISBN;
                    _db.ContentSummaries.Add(contentSummary);
                    _db.SaveChanges();
                }
                else
                {
                    book.ISBN = int.Parse(tbISBN.Text);
                    _db.Books.Add(book);
                    _db.SaveChanges();
                    var contentSummary = new ContentSummary();
                    contentSummary.ContentBook = tbContenSummary.Text;
                    contentSummary.ISBN = book.ISBN;
                    _db.ContentSummaries.Add(contentSummary);
                    _db.SaveChanges();
                }
                //Add this book to the database

                MessageBox.Show("Book added successfully to your library.");
                //Inform the user.
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnAddToFavourList_Click(object sender, EventArgs e)
        {
            try
            {
                bool alreadyFavourite = _db.FavouriteBooks.Any(q => q.ISBN == _book.ISBN && q.Account == _user.Account);
                if (alreadyFavourite)
                {
                    MessageBox.Show("You Have Already Favourited This Book Before.");
                }
                else
                {
                    var favourBook = new FavouriteBook();
                    favourBook.Account = _user.Account;
                    favourBook.ISBN = _book.ISBN;
                    //Create a new instance of favourite book then pass the data to it

                    _db.FavouriteBooks.Add(favourBook);
                    _db.SaveChanges();
                    //Add this favourite book to favouriteBooks in database then save changes.

                    MessageBox.Show("Book added successfully to your favourite list.");
                    //Inform the user.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        //public string BorrowerListThisBook()
        //{

        //}


        /// <summary>
        /// Display the comment list of this winform and user can add his/her comment
        /// </summary>
        private void btnViewComment_Click(object sender, EventArgs e)
        {
            if (!Utils.isOpen("CommentList"))   //If this form hasnt been openning then it can display if yes stop this operation to open new form
            {
                var commentList = new CommentList(_user, _book);
                commentList.Show();
            }

        }
    }
}
