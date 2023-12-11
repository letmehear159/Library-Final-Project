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
                        List<int> searchResultContent = StringHandle.SearchByContentSummary(_db, searchContent);
                        //List of ISBN descending book which has content similar to keywords
                        if (searchResultContent.Count > 0)
                        {
                            List<object> allBooksContent = new List<object>();
                            foreach (int isbn in searchResultContent)
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
                            MessageBox.Show("Search completed.");

                        }
                        else
                        {
                            MessageBox.Show("Sorry, we couldn't find approriate books for you.");
                        }
                        break;
                    case "Search By Book's Title":
                        List<int> searchResultTitle = StringHandle.SearchByTitle(_db, searchContent);
                        //List of ISBN descending book which has content similar to keywords
                        if (searchResultTitle.Count > 0)
                        {
                            List<object> allBooksContent = new List<object>();
                            foreach (int isbn in searchResultTitle)
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
                            MessageBox.Show("Search completed.");

                        }
                        else
                        {
                            MessageBox.Show("Sorry, we couldn't find approriate books for you.");
                        }
                        break;

                    case "Search By Author":
                        string standardSearchContent = StringHandle.DeletePunctuation(searchContent);
                        var booksTitle = (from book in _db.Books
                                          select new
                                          {
                                              book.ISBN,
                                              Title = book.Title,
                                              Author = book.Author,
                                              Category = book.Category,
                                              Quantity = book.Quantity,
                                              Status = book.Quantity > 0 ? "Available" : "Unavailable"
                                          }
             ).ToList()
             .Where(book => standardSearchContent == StringHandle.DeletePunctuation(book.Author))
             .ToList();
                        if (booksTitle.Count > 0)
                        {
                            gvBookListSearch.DataSource = booksTitle;
                            //Update the data to booklist grid view
                            MessageBox.Show("Search completed.");
                        }
                        else
                        {
                            MessageBox.Show("Sorry, we couldn't find approriate books for you.");
                        }
                        break;
                    case "Search Overdue Book":
                        var booksOverdue = (from book in _db.TransactionHistories
                                            where book.DateReturn < DateTime.Now && book.IsReturned == false
                                            select new
                                            {
                                                ISBN = book.ISBN,
                                                Title = book.BookName,
                                                Borrower = book.Account,
                                                DateReturn = book.DateReturn,
                                                Quantity = book.Book.Quantity,
                                                Status = book.Book.Quantity > 0 ? "Available" : "Unavailable"
                                            }).ToList();
                        if (booksOverdue.Count > 0)
                        {
                            gvBookListSearch.DataSource = booksOverdue;
                            //Update the data to booklist grid view
                            MessageBox.Show("Search completed.");
                        }
                        else
                        {
                            MessageBox.Show("Sorry, we couldn't find approriate books for you.");
                        }
                        break;
                }
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
            MessageBox.Show($"\"{book.Title}\"'s successfully hiden.");
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

        private void btnConfirmBookAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Get the isbn of selected book
                var isbn = (int)gvBookListSearch.SelectedRows[0].Cells["ISBN"].Value;
                var book = _db.Books.FirstOrDefault(q => q.ISBN == isbn);
                string borrower = tbUserBorrow.Text;
                var userBorrow = (from user in _db.Users
                                  where user.Account == borrower
                                  select user).FirstOrDefault();

                var overdueBook = (from dueBook in userBorrow.TransactionHistories
                                   where dueBook.DateReturn < DateTime.Now && dueBook.IsReturned == false
                                   select dueBook).ToList();
                if (userBorrow == null)
                {
                    MessageBox.Show("Invalid user, this user doesn't exist in our data.");
                }
                else if (overdueBook.Count > 0)
                {
                    MessageBox.Show($"\"{borrower}\" has overdue books, tell him/her to return before borrowing new book.");
                }
                else if (book.Quantity <= 0)
                {
                    MessageBox.Show($"\"{book.Title}\" is currently out of stock. Unable to borrow.");
                }
                else
                {
                    book.Quantity -= 1;
                    _db.SaveChanges();
                    var addBorrower = new AddBorrower(isbn, borrower);
                    addBorrower.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnConfirmBookReturned_Click(object sender, EventArgs e)
        {
            try
            {
                var isbn = (int)gvBookListSearch.SelectedRows[0].Cells["ISBN"].Value;
                var book = _db.Books.FirstOrDefault(q => q.ISBN == isbn);
                string borrower = tbUserBorrow.Text;
                var userBorrow = (from user in _db.Users
                                  where user.Account == borrower
                                  select user).FirstOrDefault();
                var borrowingBook = (from notReturnedBook in userBorrow.TransactionHistories
                                     where notReturnedBook.IsReturned == false && notReturnedBook.ISBN == book.ISBN
                                     select notReturnedBook).FirstOrDefault();
                if (borrowingBook == null)
                {
                    MessageBox.Show($"\"{userBorrow}\" hasn't borrowed \"{book.Title}\" before.");
                }
                else if (userBorrow == null) { MessageBox.Show("Invalid user, this user doesn't exist in our data."); }
                else
                {
                    var returnBook = (from notReturnedBook in userBorrow.TransactionHistories
                                      where notReturnedBook.IsReturned == false && notReturnedBook.ISBN == book.ISBN
                                      select notReturnedBook).FirstOrDefault();
                    returnBook.IsReturned = true;
                    _db.SaveChanges();
                    MessageBox.Show($"\"{userBorrow.Account}\" has returned \"{book.Title}\" succesfully");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnActDeactUser_Click(object sender, EventArgs e)
        {
            var account = (string)gvUserList.SelectedRows[0].Cells["Account"].Value;
            var user = _db.Users.FirstOrDefault(q => q.Account == account);
            user.IsActive = user.IsActive == true ? false : true;
            _db.SaveChanges();
            MessageBox.Show($"\"{account}\"'s status successfully changes.");
            Utils.PopulateUserGrid(_db, gvUserList);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            var account = (string)gvUserList.SelectedRows[0].Cells["Account"].Value;
            var resetPass = new SetNewPassword(account);
            resetPass.Show();

        }

        private void btnSearchUserLink_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            string account = tbUsername.Text.Trim();
            var user = _db.Users.FirstOrDefault(q => q.Account == account);
            if (user == null)
            {
                MessageBox.Show("Invalid user, it doesn't Exist.");
            }
            else
            {
                var borrowingBooks = (from book in user.TransactionHistories
                                      where book.Account == account && book.IsReturned == false
                                      select book).ToList();
                gvBorrowingBook.DataSource = borrowingBooks;
                gvBorrowingBook.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                MessageBox.Show("Search Completed");
            }
        }

        private void btnActDeactiveUser_Click(object sender, EventArgs e)
        {
            string account = tbUsername.Text.Trim();
            var user = _db.Users.FirstOrDefault(q => q.Account == account);
            user.IsActive = user.IsActive == true ? false : true;
            _db.SaveChanges();
            MessageBox.Show($"\"{account}\"'s status successfully changes.");
        }

        private void btnResetUserPassword_Click(object sender, EventArgs e)
        {
            string account = tbUsername.Text.Trim();
            var resetPass = new SetNewPassword(account);
            resetPass.Show();
        }
    }
}
