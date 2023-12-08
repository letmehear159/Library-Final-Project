﻿using System;
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
    public partial class CreateNewAccount : Form
    {
        private readonly LibraryEntities _db;
        public CreateNewAccount()
        {
            InitializeComponent();
            _db = new LibraryEntities();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var userName = tbUsername.Text;
                var password = tbPassword.Text;
                var confirmPassword = tbConfirmPassword.Text;
                var role = (int)cbRole.SelectedValue;
                //Save all values in the form to variables
                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
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
            //Update the value in the dropdown list box from the database in Role Table then display it
            var roles = _db.Roles.Select(q => new { ID = q.ID, Name = q.RoleName, ShortcutName = q.RoleNameShorcut }).ToList();
            cbRole.DisplayMember = "Name";
            cbRole.ValueMember = "ID";
            cbRole.DataSource = roles;
        }

    }
}
