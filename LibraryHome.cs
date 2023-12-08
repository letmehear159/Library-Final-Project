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
    public partial class LibraryHome : Form
    {
        private readonly LibraryEntities _db = new LibraryEntities();
        public User _user;
        public Login _login;
        public LibraryHome(User user, Login login)
        {
            InitializeComponent();
            _user = user;
            _login = login;
        }

        private void LibrarayHome_Load(object sender, EventArgs e)
        {
            tsbLogin.Text = "Login as Admin";
        }

        private void heeloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LibraryHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }
    }
}
