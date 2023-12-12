using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Final_Project
{
    public partial class CreateNewAccount : Form
    {
        private readonly LibraryEntities _db;
        Login _login;
        User _user;
        public CreateNewAccount()
        {
            InitializeComponent();
            _db = new LibraryEntities();
        }
        public CreateNewAccount(Login login)
        {
            InitializeComponent();
            _db = new LibraryEntities();
            _login = login;
        }
        public CreateNewAccount(User admin = null)
        {
            InitializeComponent();
            _db = new LibraryEntities();
            _user = admin;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var userName = tbUsername.Text;
                var password = tbPassword.Text;
                var confirmPassword = tbConfirmPassword.Text;
                var role = (int)cbRole.SelectedValue;
                if (role == 1 && _user == null)
                {
                    //If this operation is from a user but not an admin then stop to create this account
                    MessageBox.Show("You don't have authentication to create and account as administrator.");
                }
                else if (Utils.CheckAccountExisted(userName, _db))
                {
                    //If this userName was in database then tell user to choose again
                    MessageBox.Show("This account has existed, please choose again.");

                }
                //Save all values in the form to variables
                else if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                {
                    //If one of three input is empty
                    MessageBox.Show("Please fill the empty information.");
                }
                else
                {
                    if (confirmPassword != password)
                        //Password doesnt match;
                        MessageBox.Show("Retyped Password doesn't match, Please try again.");
                    else
                    {
                        User user = new User();
                        user.Account = userName;
                        user.Password = Utils.EncodingPassword(password);
                        user.IsActive = true;
                        //Update all the value in to a New User 
                        MessageBox.Show("Just one more step to completely create your account, Please help us about your information.");
                        //Inform user to go to next step
                        PersonalInformation pi = new PersonalInformation(user, this, role);
                        pi.Show();
                        //Show the PersonalInformation Fomr
                        this.Hide();
                        //Hide currently Form
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        private void CreateNewAccount_Load(object sender, EventArgs e)
        {
            try
            {
                //Update the value in the dropdown list box from the database in Role Table then display it
                var roles = _db.Roles.Select(q => new { ID = q.ID, Name = q.RoleName, ShortcutName = q.RoleNameShorcut }).ToList();
                cbRole.DisplayMember = "Name";
                cbRole.ValueMember = "ID";
                cbRole.DataSource = roles;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }


        private void linkLblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
            //Hide the current form and open new login form
        }

        private void CreateNewAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }
    }
}
