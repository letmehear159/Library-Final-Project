using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Final_Project
{
    internal class Utils
    {

        /// <summary>
        /// Check if this form is already opened?
        /// </summary>
        /// <param name="formName"></param> :Name of the form we want to know did it show
        /// <returns></returns> True: Opened, False: Hasn't opened
        public static bool isOpen(string formName)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();

            var isOpen = OpenForms.Any(q => q.Name == formName);
            return isOpen;
        }
        /// <summary>
        /// Turn the password to another text for security
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns> A new password to store it in database
        public static string EncodingPassword(string password)
        {
            SHA256 sHA = SHA256.Create();
            //Convert the input string to a byte array and compute the hash
            byte[] data = sHA.ComputeHash(Encoding.UTF8.GetBytes(password));
            //Create a new Stringbuilder to collect the bytes
            //and create a string 
            StringBuilder sBuilder = new StringBuilder();
            //Loop through each byte of the hashed data
            //and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));

            }
            string hashed_password = sBuilder.ToString();
            return hashed_password;
        }
        /// <summary>
        /// Check if this account existed
        /// </summary>
        /// <returns></returns> True if existed or false if not
        public static bool CheckAccountExisted(string userName, LibraryEntities _db)
        {
            var isExisted = _db.Users.Any(q => q.Account == userName);
            return isExisted;
        }
        public static void PopulateBookGrid(LibraryEntities _db, DataGridView data)
        {
            var books = (
                from book in _db.Books
                where book.Show == true
                select new
                {
                    ISBN = book.ISBN,
                    Title = book.Title,
                    Author = book.Author,
                    Category = book.Category,
                    Quantity = book.Quantity,
                    Status = book.Quantity > 0 ? "Available" : "Unavailable"
                }).ToList();
            //Create a list book from a linq from database
            data.DataSource = books;
            //Update the data of book list to datagridview 
            data.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //Resize the width of column
            data.Columns[0].Visible = false;
            //Hide the ISBN coloumn, we need it for edit but not indicating
        }
        public static void PopulateUserGrid(LibraryEntities _db, DataGridView data)
        {
            //Tạo database sách rồi select sách để truyên source vào grid 
            var users = (
                from user in _db.Users
                select new
                {
                    Account = user.Account,
                    Name = user.PersonalInfor.Name,
                    Gender = user.PersonalInfor.Gender,
                    BirthDate = user.PersonalInfor.BirthDate,
                    IsActive = user.IsActive
                }).ToList();
            //Create a list User from a linq from database
            data.DataSource = users;
            //Update the data of User list to datagridview 
            data.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            data.Columns[3].Width = 110;
            //Resize the width of column
        }
        /// <summary>
        /// Get the role of the using user
        /// </summary>
        /// <param name="_db"></param> Database
        /// <param name="user"></param>: Using user
        /// <returns></returns>: String of Shorcut Role Name
        public static string GetRoleOfUser(LibraryEntities _db, User user)
        {
            string role = user.UserRoles.FirstOrDefault().Role.RoleNameShorcut;
            return role;
        }

        /// <summary>
        /// Get the comment list of selected book and pass the data to display grid
        /// </summary>
        /// <param name="data"></param>: The comment grid view
        /// <param name="book"></param>: Selected Book
        public static void PopulateCommentGrid(LibraryEntities _db, DataGridView data, Book book)
        {
            var comments = (
                from comment in _db.Comments
                where comment.ISBN == book.ISBN
                select new
                {
                    Account = comment.Account,
                    Content = comment.CommentaryContent,
                    Date = comment.Date
                }
                ).ToList();
            data.DataSource = comments;
            data.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            data.Columns[1].Width = 250;
            data.Columns[2].Width = 150;
        }

        public static void PopulateBorrowingBookGrid(LibraryEntities _db, DataGridView data, User user)
        {
            var borrowingBooks = (from book in user.TransactionHistories
                                  where book.Account == user.Account && book.IsReturned == false
                                  select new
                                  {
                                      BookName = book.Book.Title,
                                      Author = book.Book.Author,
                                      Category = book.Book.Category,
                                  }).ToList();
            data.DataSource = borrowingBooks;
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public static void PopulateFavouriteList(LibraryEntities _db, DataGridView data, User user)
        {
            var favouriteBooks = (from book in user.FavouriteBooks
                                  select new
                                  {
                                      id = book.id,
                                      BookName = book.Book.Title,
                                      Author = book.Book.Author,
                                      Category = book.Book.Category,

                                  }).ToList();
            data.DataSource = favouriteBooks;
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            data.Columns[0].Visible = false;
        }
    }

}

