using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF_IDF;

namespace Library_Final_Project
{
    public partial class LibraryHomeTab : Form
    {
        private User _user;
        private readonly LibraryEntities _db = new LibraryEntities();
        private Login _login;
        public LibraryHomeTab(User user, Login login)
        {
            InitializeComponent();
            _user = user;
            _login = login;
        }
        public LibraryHomeTab()
        {
            InitializeComponent();

        }

        private void LibraryHomeTab_Load(object sender, EventArgs e)
        {
            //If the user logged in is a user(Borrower) then hide the admin's operation 
            if (Utils.GetRoleOfUser(_db, _user) == "User")
            {
                gbManageBook.Visible = false;
                tcMenu.TabPages.Remove(tpManageUser);
                tcMenu.TabPages.Remove(tpSearchUser);
            }
            else
            {
                Utils.PopulateUserGrid(_db, gvUserList);
                //Update the data of user from database to gvUserList to display

            }
            Utils.PopulateBookGrid(_db, gvBookListMenu);
            //Update the data of book from database to gvBookListMenu to display

            Utils.PopulateBookGrid(_db, gvBookListSearch);
            //Update the data of book from database to gvBookListSearch to display
            gvBookListSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            var role = _user.UserRoles.FirstOrDefault().Role.RoleNameShorcut;
            tsStatusLoginFinal.Text = $"Logged as {role}";

        }
        /// <summary>
        /// View choosen book's information
        /// </summary>
        private void btnViewBookInfor_Click(object sender, EventArgs e)
        {
            try
            {
                var isbn = (int)gvBookListMenu.SelectedRows[0].Cells["ISBN"].Value;
                //Get the isbn of selected book

                var book = _db.Books.FirstOrDefault(q => q.ISBN == isbn);
                //Get this book's data from the database

                if (book != null)   //If we view or edit book 
                {
                    BookInformation bookInformation = new BookInformation(book, _user, false);
                    bookInformation.Show();
                    //Show the book_information winform
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void LibraryHomeTab_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                string searchContent = tbSearch.Text;
                // The keywords inputed from user
                string searchOption = cbSearchOption.Text;
                //The search option
                switch (searchOption)
                {
                    case "Search By Content":
                        List<int> searchResult = StringHandle.CompleteTF_IDF(_db, searchContent);
                        //List of ISBN descending book which has content similar to keywords
                        if (searchResult.Count > 0)
                        {
                            List<object> allBooksContent = new List<object>();
                            foreach (int isbn in searchResult)
                            {

                                var booksContent = (from book in _db.Books
                                                    where book.ISBN == isbn
                                                    select new
                                                    {
                                                        book.ISBN,
                                                        Title = book.Title,
                                                        Author = book.Author,
                                                        Category = book.Category,
                                                        Quantity = book.Quantity,
                                                        Status = book.Quantity > 0 ? "Available" : "Unavailable"
                                                    }).ToList();

                                allBooksContent.AddRange(booksContent);
                            }
                            gvBookListSearch.DataSource = allBooksContent;
                            //Update the data to booklist grid view
                        }
                        else
                        {
                            MessageBox.Show("Sorry, we couldn't find approriate books for you.");
                        }
                        break;
                        //case "Search By Book's Title":
                        //    var booksTitle = (from book in _db.Books
                        //                      where StringHandle.DeletePunctuation(searchContent) == StringHandle.DeletePunctuation(book.Title)
                        //                      select new
                        //                      {
                        //                          book.ISBN,
                        //                          Title = book.Title,
                        //                          Author = book.Author,
                        //                          Category = book.Category,
                        //                          Quantity = book.Quantity,
                        //                          Status = book.Quantity > 0 ? "Available" : "Unavailable"
                        //                      }
                        //                 ).ToList();
                        //    gvBookListSearch.DataSource = booksTitle;
                        //    break;
                        //case "Search By Author":
                        //    var booksAuthor = (from book in _db.Books
                        //                       where StringHandle.DeletePunctuation(searchContent) == StringHandle.DeletePunctuation(book.Author)
                        //                       select new
                        //                       {
                        //                           book.ISBN,
                        //                           Title = book.Title,
                        //                           Author = book.Author,
                        //                           Category = book.Category,
                        //                           Quantity = book.Quantity,
                        //                           Status = book.Quantity > 0 ? "Available" : "Unavailable"
                        //                       }
                        //                      ).ToList();
                        //    gvBookListSearch.DataSource = booksAuthor;
                        //    break;
                        //case "Search Overdue Book":
                        //    var booksOverdue = (from book in _db.TransactionHistories
                        //                        where book.DateReturn < DateTime.Now && book.IsReturned == false
                        //                        select new
                        //                        {
                        //                            ISBN = book.ISBN,
                        //                            Title = book.BookName,
                        //                            Borrower = book.Account,
                        //                            DateReturn = book.DateReturn,
                        //                        }).ToList();
                        //    gvBookListSearch.DataSource = booksOverdue;
                        //    break;
                }
                MessageBox.Show("Search completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            var bookInfor = new BookInformation(_user);
            bookInfor.Show();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            //Get the isbn of selected book
            var isbn = (int)gvBookListSearch.SelectedRows[0].Cells["ISBN"].Value;
            // Get book from database by book's isbn
            var book = _db.Books.FirstOrDefault(q => q.ISBN == isbn);
            var bookInfor = new BookInformation(book, _user, true);
            bookInfor.Show();
        }

        private void btnShowHideBook_Click(object sender, EventArgs e)
        {
            //Get the isbn of selected book
            var isbn = (int)gvBookListSearch.SelectedRows[0].Cells["ISBN"].Value;
            // Get book from database by book's isbn
            var book = _db.Books.FirstOrDefault(q => q.ISBN == isbn);
            book.Show = book.Show == true ? false : true;
            _db.SaveChanges();
            MessageBox.Show($"{book.Title}'s successfully hiden.");
            Utils.PopulateBookGrid(_db, gvBookListSearch);
        }

        private void btnViewBooksInfor_Click(object sender, EventArgs e)
        {
            //Get the isbn of selected book
            var isbn = (int)gvBookListSearch.SelectedRows[0].Cells["ISBN"].Value;
            // Get book from database by book's isbn
            var book = _db.Books.FirstOrDefault(q => q.ISBN == isbn);
            var bookInfor = new BookInformation(book, _user, false);
            bookInfor.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Utils.PopulateBookGrid(_db, gvBookListSearch);
        }
    }
}
