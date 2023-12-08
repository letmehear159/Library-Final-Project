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
    public partial class ForgotPassword : Form
    {
        private readonly LibraryEntities _db = new LibraryEntities();
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnFindUsername_Click(object sender, EventArgs e)
        {
            var userName = tbUsername.Text;
            if (!Utils.CheckAccountExisted(userName, _db))
            {
                //If the user type wrong username
                MessageBox.Show("This username doesnt exist!!!");
            }
            else
            {
                var _user = _db.Users.FirstOrDefault(q => q.Account == userName);
                //We need to ensure this is correct user so we need to confimr the answer from the user 
                MessageBox.Show("To assure that it's you , We need to you to fill out our question");
                var resetPass = new ResetPassword(this, _user);
                resetPass.Show();
                this.Hide();

            }
        }
    }
}
