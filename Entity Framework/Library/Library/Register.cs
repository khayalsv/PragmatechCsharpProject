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
    public partial class Register : Form
    {
        private readonly LibraryEntities db;
        public Register()
        {
            InitializeComponent();
            db = new LibraryEntities();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUname.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string repeat = txtRepeat.Text.Trim();

            if (!(isValid(username, email, password, repeat)))
            {
                MessageBox.Show("Error1");
                return;
            }

            bool emailInDB = db.Users.Any(x => x.Email == email);
            if (emailInDB)
            {
                MessageBox.Show("Email is Already!");
                return;
            }

            User user = new User()
            {
                Username = username,
                Email = email,
                Password = password
            };
            db.Users.Add(user);
            db.SaveChanges();

            MessageBox.Show("Success");
        }

        private bool isValid(string username,string email,string password,string repeat)
        {
            if (username == "" || email == "" || password ==""|| repeat == "")
            {
                MessageBox.Show("Fill all input");
                return false;
            }

            if (!(email.Contains("@")))
            {
                MessageBox.Show("Email is not valid");
                return false;
            }

            if (password != repeat)
            {
                MessageBox.Show("Please repeat password correctly!");
                return false;
            }
            return true;
        }
    }
}
