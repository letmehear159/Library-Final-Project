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
        public static bool CheckAccountExisted(string userName, LibraryEntities _db)
        {
            var isExisted = _db.Users.Any(q => q.Account == userName);
            return isExisted;
        }
        public static void PopulateBookGrid(LibraryEntities _db, DataGridView data)
        {
            //Tạo database sách rồi select sách để truyên source vào grid 
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
                }).ToList();
            data.DataSource = books;
            data.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            data.Columns[0].Visible = false;
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
            data.DataSource = users;
            data.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            data.Columns[3].Width = 110;
        }
    }
}
