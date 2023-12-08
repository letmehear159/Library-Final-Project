using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Final_Project
{
    internal class Utils
    {

        /// <summary>
        /// Check if this form is already opened?
        /// </summary>
        /// <param name="formName"></param> :Name of the form we want to know did it show
        /// <returns></returns> True: Opened, False: Hasn't opened
        public static bool isOpen(string formName)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();

            var isOpen = OpenForms.Any(q => q.Name == formName);
            return isOpen;
        }
        /// <summary>
        /// Turn the password to another text for security
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns> A new password to store it in database
        public static string EncodingPassword(string password)
        {
            SHA256 sHA = SHA256.Create();
            //Convert the input string to a byte array and compute the hash
            byte[] data = sHA.ComputeHash(Encoding.UTF8.GetBytes(password));
            //Create a new Stringbuilder to collect the bytes
            //and create a string 
            StringBuilder sBuilder = new StringBuilder();
            //Loop through each byte of the hashed data
            //and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));

            }
            string hashed_password = sBuilder.ToString();
            return hashed_password;
        }
        public static bool CheckAccountExisted(string userName, LibraryEntities _db)
        {
            var isExisted = _db.Users.Any(q => q.Account == userName);
            return isExisted;
        }
    }
}
