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
                MessageBox.Show("Information is matched, you can set your new password now.");
                var setPassword = new SetNewPassword(username, this);
                setPassword.Show();
                Close();
            }
        }
    }
}
