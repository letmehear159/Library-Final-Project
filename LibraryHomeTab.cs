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
            //var role = _user.UserRoles.FirstOrDefault().Role.RoleNameShorcut;
            //tsStatusLogin.Text = $"Logged as {role}";
            Utils.PopulateUserGrid(_db, gvUserList);
            //Update the data of user from database to gvUserList to display

            Utils.PopulateBookGrid(_db, gvBookListMenu);
            //Update the data of book from database to gvUserList to display

        }
        /// <summary>
        /// View choosen book's information
        /// </summary>
        private void btnViewBookInfor_Click(object sender, EventArgs e)
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

        private void LibraryHomeTab_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }
    }
}
