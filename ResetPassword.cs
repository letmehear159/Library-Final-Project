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
    public partial class ResetPassword : Form
    {
        public ForgotPassword _forgot;
        private string username;
        private readonly LibraryEntities _db = new LibraryEntities();
        public ResetPassword()
        {
            InitializeComponent();
        }
        public ResetPassword(ForgotPassword forgot, string user)
        {
            InitializeComponent();
            _forgot = forgot;
            username = user;
        }

        private void ResetPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            _forgot.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var hometown = tbHometown.Text;
            var favourSong = tbFavouriteSong.Text;
            var name = tbUsername.Text;
            //Get the value from text box
            var pi = _db.PersonalInfors.FirstOrDefault(q => q.Account == username);
            //Get the information from the username to check the answer of the user
            if (pi.HomeTown == hometown && favourSong == pi.FavouriteSong && name == pi.Name)
            {
                var _user = _db.Users.FirstOrDefault(q => q.Account == username);
                _user.Password = Utils.EncodingPassword("25892589");
                _db.SaveChanges();
                MessageBox.Show($"Reset password successfully!\r\n{_user.Account}'s new password is 25892589.");
                Close();
            }
        }
    }
}
