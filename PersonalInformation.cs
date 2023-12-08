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
    public partial class PersonalInformation : Form
    {
        private readonly LibraryEntities _db;
        public User _user=new User();
        public int _role;
        public PersonalInformation()
        {
            InitializeComponent();
            _db = new LibraryEntities();
        }
        public PersonalInformation(User user, CreateNewAccount cre, int role)
        {
            InitializeComponent();
            _db = new LibraryEntities();
            _user = user;
            _role = role;
        }

        private void PersonalInformation_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _user.Account + "Personal Information";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var birthDate = dtBirthDate.Value;
                var name = tbUsername.Text;
                var hometown = tbHometown.Text;
                var favouriteSong = tbFavouriteSong.Text;
                string gender = "";
                foreach (var control in grGender.Controls)
                {
                    if (control is RadioButton)
                    {
                        RadioButton radioButton = (RadioButton)control;
                        if (radioButton.Checked)
                        {
                            gender = radioButton.Text;
                        }
                    }
                }
                PersonalInfor pi = new PersonalInfor();
                pi.BirthDate = birthDate;
                pi.Name = name;
                pi.Gender = gender;
                pi.Account = _user.Account;
                pi.HomeTown = hometown;
                pi.FavouriteSong = favouriteSong;

                UserRole userRole = new UserRole();
                userRole.Username = _user.Account;
                userRole.RoleID = _role;

                if (!string.IsNullOrEmpty(gender))
                {
                    _db.Users.Add(_user);
                    _db.SaveChanges();
                    _db.PersonalInfors.Add(pi);
                    _db.UserRoles.Add(userRole);
                    _db.SaveChanges();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
