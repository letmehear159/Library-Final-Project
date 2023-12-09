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
            var role = _user.UserRoles.FirstOrDefault().Role.RoleNameShorcut;
            tsStatusLogin.Text = $"Logged as {role}";
            Utils.PopulateUserGrid(_db, gvUserList);
        }

        private void gbManageBook_Enter(object sender, EventArgs e)
        {

        }
    }
}
