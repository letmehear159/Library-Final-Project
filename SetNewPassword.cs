using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Final_Project
{
    public partial class SetNewPassword : Form
    {
        private readonly LibraryEntities _db = new LibraryEntities();
        private string _account;
        private ResetPassword _resetPassword;
        public SetNewPassword(string account, ResetPassword resetPassword = null)
        {
            InitializeComponent();
            _account = account;
            _resetPassword = resetPassword;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy database từ record 
                var _user = _db.Users.FirstOrDefault(q => q.Account == _account);
                //Tìm giá trị trong typeofcar có giá trị bằng với id 
                if (tbNewpassword.Text == tbConfirmPassword.Text)
                {
                    var genericPassword = tbNewpassword.Text;
                    var hashed_password = Utils.EncodingPassword(genericPassword);
                    _user.Password = hashed_password;
                    _db.SaveChanges();
                    MessageBox.Show($"{_user.Account}'s password is changed");
                    Close();
                }
                else
                {
                    MessageBox.Show("Your Confirm Password Didn't Match!!!");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void SetNewPassword_Load(object sender, EventArgs e)
        {
            if (_resetPassword != null)
            {
                _resetPassword.Close();
            }
        }
    }
}
