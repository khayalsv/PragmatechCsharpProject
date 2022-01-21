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
    public partial class AdminLogin : Form
    {
        private readonly LibraryEntities db;
        public AdminLogin()
        {
            InitializeComponent();
            db = new LibraryEntities();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUname.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "") 
            {
                MessageBox.Show("Fill all input");
            }

            Admin admin = db.Admins.FirstOrDefault(x => x.AdminMail == username);
            admin= db.Admins.FirstOrDefault(x => x.AdminPassword == password);
            if (admin==null)
            {
                MessageBox.Show("Not found");
                return;
            }
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
