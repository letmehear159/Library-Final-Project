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
        public User _user = new User();
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
            //Get the value from parameter 
        }

        private void PersonalInformation_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _user.Account + "'s Personal Information";
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
                //Pass the data from the textbox to variables
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
                    //Loop in the group box, if a radio button is checked, get that radio button's value
                }
                PersonalInfor pi = new PersonalInfor();
                pi.BirthDate = birthDate;
                pi.Name = name;
                pi.Gender = gender;
                pi.Account = _user.Account;
                pi.HomeTown = hometown;
                pi.FavouriteSong = favouriteSong;
                //Create a new Personal Info and pass the value from the textbox to pi's attributes

                UserRole userRole = new UserRole();
                userRole.Username = _user.Account;
                userRole.RoleID = _role;
                //Create a new UserRole then pass value of the username role in the prev CreateNewAccount

                if (!string.IsNullOrEmpty(gender))  //Because gender could run without value from radio button, make sure it got value from radio button
                {
                    _db.Users.Add(_user);
                    _db.SaveChanges();
                    //Add a user with Account and password , IsActive= true to User table in database

                    _db.PersonalInfors.Add(pi);
                    _db.UserRoles.Add(userRole);
                    _db.SaveChanges();
                    //Add Personal Information and role of that user we have just added to database

                    MessageBox.Show($"{_user.Account} is created successfully!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
