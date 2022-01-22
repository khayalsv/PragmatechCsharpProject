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
            DataViewList();
            DataViewBucket();
            Clear();

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim().ToLower();
            int amount = Convert.ToInt32(txtAmount.Text.Trim());


            if (name == "")
            {
                MessageBox.Show("Please filled");
                return;
            }

            Book book = db.Books.FirstOrDefault(x => x.Name.ToLower() == name);

            if (book == null)  //Insert
            {
                Book bookDB = new Book()
                {
                    Name = name,
                    Amount = amount
                };
                db.Books.Add(bookDB);
            }
            else //Update
            {
                book.Amount = amount;
            }

            db.SaveChanges();
            MessageBox.Show("Success");
            DataViewBucket();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
        public void DataViewList()
        {
            string name = txtName.Text.Trim().ToLower();
            dtGridList.DataSource = db.Books.Where(m => m.Name == name).Select(m => new
            {
                m.Name,
                m.Price,
                m.Amount

            }).ToList();

            dtGridList.DataSource = db.Books.ToList<Book>();

        }

        public void DataViewBucket()
        {
            string name = txtName.Text.Trim().ToLower();
            dtGridBucket.DataSource = db.Books.Where(m => m.Name == name).Select(m => new
            {
                m.Name,
                m.Price,
                m.Amount

            }).ToList();

            //dtGridBucket.DataSource = db.Sales.ToList<Model.Sale>();

        }

        public void Clear()
        {
            txtName.Text = "";
            txtAmount.Value = 0;
        }
    }
}
