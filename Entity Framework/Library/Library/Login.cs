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
    public partial class Login : Form
    {
        private readonly LibraryEntities db;
        public Login()
        {
            InitializeComponent();
            db = new LibraryEntities();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (email == "" || password == "") 
            {
                MessageBox.Show("Fill All Input");
                return;
            }

            User user = db.Users.FirstOrDefault(x => x.Email == email);
            user = db.Users.FirstOrDefault(x => x.Password == password);
            if (user==null)
            {
                MessageBox.Show("Pls register");
                return;
            }
            Sale sale = new Sale();
            sale.ShowDialog();
        }
    }
}
