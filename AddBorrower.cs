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
    public partial class AddBorrower : Form
    {
        private readonly LibraryEntities _db = new LibraryEntities();
        private int _bookISBN;
        private string _borrowerAccount;
        public AddBorrower(int bookISBN, string borrowerAccount)
        {
            InitializeComponent();
            _bookISBN = bookISBN;
            _borrowerAccount = borrowerAccount;
        }

        private void AddBorrower_Load(object sender, EventArgs e)
        {
            var book = _db.Books.FirstOrDefault(q => q.ISBN == _bookISBN);
            lblBookTitle.Text = book.Title;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var dateBorrow = dtDateBorrow.Value;
                var dateReturn = dtDateReturn.Value;
                var book = _db.Books.FirstOrDefault(q => q.ISBN == _bookISBN);
                if (dateBorrow > dateReturn)
                {
                    MessageBox.Show("Error date borrow and date return.");
                }
                else
                {
                    var transaction = new TransactionHistory();
                    transaction.ISBN = _bookISBN;
                    transaction.DateBorrow = dateBorrow;
                    transaction.DateReturn = dateReturn;
                    transaction.Account = _borrowerAccount;
                    transaction.IsReturned = false;
                    transaction.BookName = book.Title;
                    _db.TransactionHistories.Add(transaction);
                    _db.SaveChanges();
                    MessageBox.Show($"{book.Title} borrowed by {_borrowerAccount} is successfully recorded.");
                    this.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
