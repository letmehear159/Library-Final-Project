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
    public partial class Login : Form
    {
        private readonly LibraryEntities _db = new LibraryEntities();
        CreateNewAccount _cre;
        PersonalInformation _per;
        public Login()
        {
            InitializeComponent();
        }
        public Login(CreateNewAccount cre)
        {
            InitializeComponent();
            _cre = cre;
        }
        public Login(PersonalInformation per)
        {
            InitializeComponent();
            _per = per;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_cre != null)
                _cre.Close();
            if (_per != null)
                _per.Close();
            //If this form is closed then hiding forms are also closed
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var userName = tbUsername.Text;
                var password = tbPassword.Text;
                var isUserNameValid = _db.Users.Any(q => q.Account == userName);
                //Get the username and password from the text box
                //Check is this user existed in database
                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                {
                    //if the user forget to type username or password
                    MessageBox.Show("You Can Not Let The Value Empty.");
                }

                else if (!isUserNameValid)
                {
                    //if the user type wrong username
                    MessageBox.Show($"{userName} Does Not Exist, Maybe Your Typing Wrong Username.");
                }
                else
                {
                    var _user = _db.Users.FirstOrDefault(q => q.Account == userName);
                    //Select the user data from the database to compare the password input
                    if (Utils.EncodingPassword(password) != _user.Password)
                    {
                        //Change the password input by hashcode then compare to hashcode password in database
                        //If it is unmatched
                        MessageBox.Show($"Wrong Password!!!");
                    }
                    else if (_user.IsActive == false)
                    {
                        MessageBox.Show("Sorry But Your Account Has Been Deactivated By The Librarian, Contact Them To Reopen It.");
                    }
                    else
                    {
                        //If login successfully
                        var libraryHome = new LibraryHomeTab(_user, this);
                        libraryHome.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void linkLblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var createNewAcc = new CreateNewAccount(this);
            createNewAcc.Show();
            this.Hide();
        }

        private void menuSInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Library Application Is Builded By: \r\n" +
                "-22110085 Nguyễn Trường\r\n" +
                "-22110032 Lê Gia Huy");
        }

        private void menuSContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nguyễn Trường's Email: Nguyentruongpro19@gmail.com");
        }

        private void toolSForgot_Click(object sender, EventArgs e)
        {
            if (!Utils.isOpen("ForgotPassword"))
            {
                var forgotPassword = new ForgotPassword();
                forgotPassword.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
