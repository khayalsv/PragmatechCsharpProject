using Library.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        private readonly LibraryEntities db;
        Book book = new Book();
        public Form1()
        {
            InitializeComponent();
            db = new LibraryEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataView();
            Clear();
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim().ToLower();
            double price = Convert.ToDouble(txtPrice.Text.Trim());
            int amount = Convert.ToInt32(txtAmount.Text.Trim());


            if (name=="")
            {
                MessageBox.Show("Please filled");
                return;
            }

            Book book = db.Books.FirstOrDefault(x => x.Name.ToLower() == name);

            if (book==null)  //Insert
            {
                Book bookDB = new Book()
                {
                    Name = name,
                    Price = price,
                    Amount = amount
                };
                db.Books.Add(bookDB);
            }
            else //Update
            {
                book.Amount += amount;
                book.Price = price;
            }

            db.SaveChanges();
            MessageBox.Show("Success");
            DataView();
            Clear();

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim().ToLower();
            Book book = db.Books.FirstOrDefault(x => x.Name.ToLower() == name);

            if (book!=null)
            {
                db.Books.Remove(book);
                db.SaveChanges();
                DataView();
                Clear();
                MessageBox.Show("Deleted");
                return;
            }
            MessageBox.Show("This book not exist");
        }

        private void dtGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dtGrid.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            Book book = db.Books.FirstOrDefault(x => x.Name == name);

            txtName.Text = name;
            txtPrice.Value = decimal.Parse(book.Price.ToString());
            txtAmount.Value = book.Amount;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void DataView()
        {
            //string name = txtName.Text.Trim().ToLower();
            //dtGrid.DataSource = db.Books.Where(m => m.Name == name).Select(m => new
            //{
            //    m.Name,
            //    m.Price,
            //    m.Amount

            //}).ToList();

            dtGrid.DataSource = db.Books.ToList<Book>();

        }

        public void Clear()
        {
            txtName.Text = "";
            txtPrice.Value = 0;
            txtAmount.Value = 0;
        }
    }
}
  