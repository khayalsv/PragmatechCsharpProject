using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogReg
{
    public partial class Login : Form
    {
        private readonly DBEntities db;
        public Login()
        {
            InitializeComponent();
            db = new DBEntities();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (email == "" || password == "") 
            {
                MessageBox.Show("Fill all input");
            }

            User user = db.Users.FirstOrDefault(x => x.Email==email);
            user = db.Users.FirstOrDefault(x => x.Password == password);
            if (user == null)
            {
                MessageBox.Show("Pls register");
                return;
            }
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
    }
}
