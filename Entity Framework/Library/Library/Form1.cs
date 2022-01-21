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
            Clear();
            DataView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim().ToLower();
            double price =Convert.ToDouble(txtPrice.Text.Trim());
            int amount = Convert.ToInt32(txtAmount.Text.Trim());

            Book book = db.Books.FirstOrDefault(x => x.Name.ToLower() == name);
            if (book == null)
            {
                Book bookDB = new Book
                {
                    Name = name,
                    Price = price,
                    Amount = amount

                };
                db.Books.Add(bookDB);
            }
            else
            {               
                book.Price = price;
                book.Amount += amount;
            }
 
            db.SaveChanges();
            Clear();
            DataView();
            MessageBox.Show("Success");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete?","EF Crud Operation",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                if (book !=null)
                {
                    var entry = db.Entry(book);
                    if (entry.State == EntityState.Deleted)
                        db.Books.Attach(book);

                    db.Books.Remove(book);
                    db.SaveChanges();
                    DataView();
                    Clear();
                    MessageBox.Show("Deleted");
                }
               
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }


        private void dtGrid_DoubleClick(object sender, EventArgs e)
        {
            if (dtGrid.CurrentRow.Index != -1)
            {
                book.ID = Convert.ToInt32(dtGrid.CurrentRow.Cells["ID"].Value);
                book = db.Books.Where(x => x.ID == book.ID).FirstOrDefault();
                txtName.Text = book.Name;
                txtPrice.Text = book.Price.ToString();
                txtAmount.Text = book.Amount.ToString();

                btnDelete.Enabled = true;
                btnSave.Text = "Update";
            }        
        }

        //Method
        public void Clear()
        {
            txtName.Text = "";
            txtPrice.Value = 0;
            txtAmount.Value = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }

        public void DataView()
        {
            dtGrid.DataSource = db.Books.ToList<Book>();
        }
    }
}
  