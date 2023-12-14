using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
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
            try
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
                Utils.PopulateBorrowingBookGrid(_db, gvBorrowingList, _user);
                Utils.PopulateFavouriteList(_db, gvFavouriteList, _user);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

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
            try
            {
                //Get the isbn of selected book
                var isbn = (int)gvBookListSearch.SelectedRows[0].Cells["ISBN"].Value;
                // Get book from database by book's isbn
                var book = _db.Books.FirstOrDefault(q => q.ISBN == isbn);
                var bookInfor = new BookInformation(book, _user, true);
                bookInfor.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnShowHideBook_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnViewBooksInfor_Click(object sender, EventArgs e)
        {
            try
            {
                //Get the isbn of selected book
                var isbn = (int)gvBookListSearch.SelectedRows[0].Cells["ISBN"].Value;
                // Get book from database by book's isbn
                var book = _db.Books.FirstOrDefault(q => q.ISBN == isbn);
                var bookInfor = new BookInformation(book, _user, false);
                bookInfor.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
                //Get the user in the textbox from User database
                var overdueBook = (from dueBook in userBorrow.TransactionHistories
                                   where dueBook.DateReturn < DateTime.Now && dueBook.IsReturned == false
                                   select dueBook).ToList();
                var didBorrow = _db.TransactionHistories.Any(q => q.ISBN == isbn && q.IsReturned == false && q.Account == userBorrow.Account);
                //Get the overdue books of this user
                if (userBorrow == null) //if user doesnt exist
                {
                    MessageBox.Show("Invalid user, this user doesn't exist in our data.");
                }
                else if (overdueBook.Count > 0) //If he/she has overdue books
                {
                    MessageBox.Show($"\"{borrower}\" has overdue books, tell him/her to return before borrowing new book.");
                }
                else if (book.Quantity <= 0) //if book is out of stock
                {
                    MessageBox.Show($"\"{book.Title}\" is currently out of stock. Unable to borrow.");
                }
                else if (didBorrow == true)
                {
                    MessageBox.Show($"\"{book.Title}\" is borrowing by this user. Cannot borrow more");
                }
                else
                {
                    book.Quantity -= 1;
                    //decrease the book quantity
                    _db.SaveChanges();
                    //save change.
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
                //get the user from the textbox in user database
                var borrowingBook = (from notReturnedBook in _db.TransactionHistories
                                     where notReturnedBook.IsReturned == false && notReturnedBook.ISBN == book.ISBN && notReturnedBook.Account == borrower
                                     select notReturnedBook).FirstOrDefault();
                //Get the book he/ she is borrowing and now wants to return
                if (borrowingBook == null)
                {
                    MessageBox.Show($"\"{userBorrow.Account}\" hasn't borrowed \"{book.Title}\" before.");
                }
                else if (userBorrow == null) { MessageBox.Show("Invalid user, this user doesn't exist in our data."); }
                else
                {
                    var returnBook = (from notReturnedBook in _db.TransactionHistories
                                      where notReturnedBook.IsReturned == false && notReturnedBook.ISBN == book.ISBN && notReturnedBook.Account == borrower
                                      select notReturnedBook).FirstOrDefault();
                    returnBook.IsReturned = true;
                    //set the transaction history of this user to this book is true
                    book.Quantity += 1;
                    //increase book quantity in library
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
            try
            {
                var account = (string)gvUserList.SelectedRows[0].Cells["Account"].Value;
                var user = _db.Users.FirstOrDefault(q => q.Account == account);
                user.IsActive = user.IsActive == true ? false : true;
                _db.SaveChanges();
                MessageBox.Show($"\"{account}\"'s status successfully changes.");
                Utils.PopulateUserGrid(_db, gvUserList);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            var account = (string)gvUserList.SelectedRows[0].Cells["Account"].Value;
            var resetPass = new SetNewPassword(account);
            resetPass.Show();

        }


        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            try
            {
                string account = tbUsername.Text.Trim();
                var user = _db.Users.FirstOrDefault(q => q.Account == account);
                //Get the user from User database
                if (user == null)  //If wrong account
                {
                    MessageBox.Show("Invalid user, it doesn't Exist.");
                }
                else
                {
                    Utils.PopulateBorrowingBookGrid(_db, gvBorrowingBook, user);
                    MessageBox.Show("Search Completed");
                    //Get the borrowing book list of this user 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnActDeactiveUser_Click(object sender, EventArgs e)
        {
            try
            {
                string account = tbUsername.Text.Trim();
                var user = _db.Users.FirstOrDefault(q => q.Account == account);
                //Get the user from database
                user.IsActive = user.IsActive == true ? false : true;
                //If the user is active then change to unactive 
                _db.SaveChanges();
                //Save change in database
                MessageBox.Show($"\"{account}\"'s status successfully changes.");
                //inform successfully change
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnResetUserPassword_Click(object sender, EventArgs e)
        {
            string account = tbUsername.Text.Trim();
            var resetPass = new SetNewPassword(account);
            resetPass.Show();
        }

        private void btnUnfavourite_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvFavouriteList.SelectedRows[0].Cells["id"].Value;
                var book = _user.FavouriteBooks.FirstOrDefault(q => q.id == id);
                //get the choosen book in database favouritelist
                string bookName = book.Book.Title;
                if (book != null) //if the database favouritelist has this book
                {
                    _db.FavouriteBooks.Remove(book);
                    _db.SaveChanges();
                    MessageBox.Show($"\"{bookName}\" Is Removed From Your Favourite List.");
                    //Remove and savechange

                }
                else
                {
                    MessageBox.Show("Sorry but we can find this book is our data.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshFavourlist_Click(object sender, EventArgs e)
        {
            try
            {
                _user = _db.Users.FirstOrDefault(q => q.Account == _user.Account);
                Utils.PopulateFavouriteList(_db, gvFavouriteList, _user);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnRefreshMenu_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.PopulateBookGrid(_db, gvBookListMenu);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmBookReturn_Click(object sender, EventArgs e)
        {
            try
            {
                var isbn = (int)gvBorrowingBook.SelectedRows[0].Cells["ISBN"].Value;
                var book = _db.Books.FirstOrDefault(q => q.ISBN == isbn);
                string borrower = tbUsername.Text;
                var userBorrow = (from user in _db.Users
                                  where user.Account == borrower
                                  select user).FirstOrDefault();
                //get the user from the textbox in user database
                //TransactionHistory borrowingBook = (from notReturnedBook in _db.TransactionHistories
                //                                    where notReturnedBook.IsReturned == false && notReturnedBook.ISBN == book.ISBN && notReturnedBook.Account == borrower
                //                                    select notReturnedBook).FirstOrDefault();
                var borrowingBook = _db.TransactionHistories.FirstOrDefault(q => q.IsReturned == false && q.ISBN == isbn && q.Account == borrower);
                var check = _db.TransactionHistories.FirstOrDefault(q => q.IsReturned == false && q.ISBN == isbn && q.Account == borrower);
                //Get the book he/ she is borrowing and now wants to return
                if (borrowingBook == null)
                {
                    MessageBox.Show($"\"{userBorrow.Account}\" hasn't borrowed \"{book.Title}\" before.");
                }
                else if (userBorrow == null) { MessageBox.Show("Invalid user, this user doesn't exist in our data."); }
                else
                {

                    //returnBook.IsReturned = true;
                    //set the transaction history of this user to this book is true
                    borrowingBook.Book.Quantity += 1;
                    _db.TransactionHistories.Remove(borrowingBook);
                    if (check.DateBorrow != borrowingBook.DateBorrow)
                    {
                        MessageBox.Show("Not equal day");
                    }

                    //increase book quantity in library
                    _db.SaveChanges();
                    MessageBox.Show($"\"{userBorrow.Account}\" has returned \"{book.Title}\" succesfully");
                    Utils.PopulateBorrowingBookGrid(_db, gvBorrowingBook, userBorrow);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshBorrowingBook_Click(object sender, EventArgs e)
        {
            try
            {

                string borrower = tbUsername.Text.Trim();
                var userBorrow = (from user in _db.Users
                                  where user.Account == borrower
                                  select user).FirstOrDefault();
                Utils.PopulateBorrowingBookGrid(_db, gvBorrowingBook, userBorrow);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
