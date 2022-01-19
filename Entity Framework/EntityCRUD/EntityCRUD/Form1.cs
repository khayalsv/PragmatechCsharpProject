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

namespace EntityCRUD
{
    public partial class Form1 : Form
    {
        private readonly DBEntities db;
        Customer model = new Customer();

        public Form1()
        {
            InitializeComponent();
            db = new DBEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            DataView();
        }


        void Clear()
        {
            txtFname.Text = txtLname.Text = txtCity.Text = txtAddress.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            model.CustomerID = 0;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.FirstName = txtFname.Text.Trim();
            model.LastName = txtLname.Text.Trim();
            model.City = txtCity.Text.Trim();
            model.Address = txtAddress.Text.Trim();


            if (model.CustomerID == 0) //insert
                db.Customers.Add(model);
            else //update
                db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();

           

            Clear();
            DataView();
            MessageBox.Show("Submit Successfuly");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void DataView()
        {
            dtGrid.AutoGenerateColumns = false; //2ci viewni gizledir
            dtGrid.DataSource = db.Customers.ToList<Customer>();
        }

        private void dtGrid_DoubleClick(object sender, EventArgs e)//////////UPDATE
        {
            if (dtGrid.CurrentRow.Index !=-1)
            {
                model.CustomerID = Convert.ToInt32(dtGrid.CurrentRow.Cells["CustomerID"].Value);
                model = db.Customers.Where(x => x.CustomerID == model.CustomerID).FirstOrDefault();
                txtFname.Text = model.FirstName;
                txtLname.Text = model.LastName;
                txtCity.Text = model.City;
                txtAddress.Text = model.Address;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure to Delete?","EF Crud Operation",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                var entry = db.Entry(model);
                if (entry.State == EntityState.Deleted)
                    db.Customers.Attach(model);

                db.Customers.Remove(model);
                db.SaveChanges();
                DataView();
                Clear();
                MessageBox.Show("Deleted");
                
            }
        }
    }
}
