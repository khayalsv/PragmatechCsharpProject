using Library.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Sale : Form
    {
        private readonly LibraryEntities db;
        public Sale()
        {
            InitializeComponent();
            db = new LibraryEntities();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            Clear();
            DataViewList();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim().ToLower();
            int amount = Convert.ToInt32(txtAmount.Text.Trim());

           

            Book book = db.Books.FirstOrDefault(x => x.Name.ToLower() == name);
            if (book == null)
            {
                Book bookDB = new Book
                {
                    Name = name,
                    Amount = amount

                };
                db.Books.Add(bookDB);
            }
            else
            {
                book.Amount = amount;

            }

            DataViewBucket();

            db.SaveChanges();
            Refresh();
            Clear();
            MessageBox.Show("Success");
            
        }





        public void Clear()
        {
            txtName.Text = "";
            txtAmount.Value = 0;
            btnDelete.Enabled = false;
        }

        public void DataViewList()
        {
            dtGridList.DataSource = db.Books.ToList<Book>();
        }

        public void DataViewBucket()
        {
            string name = txtName.Text.Trim().ToLower();
            dtGridBucket.DataSource = db.Books.Where(m => m.Name == name).Select(m => new
            {
                m.Name,
                m.Price,
                m.Amount,

            }).ToList();
        }

        private void dtGridList_DoubleClick(object sender, EventArgs e)
        {

        }

        public void Refresh()
        {
            dtGridBucket.DataSource = db.Books.Select(x => new
            {
                x.Name,
                x.Price,
                x.Amount
            }).ToList();
        }
    }
}
