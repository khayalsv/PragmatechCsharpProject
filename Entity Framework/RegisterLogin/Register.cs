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
    public partial class Register : Form
    {
        private readonly DBEntities db;
        public Register()
        {
            InitializeComponent();
            db = new DBEntities();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUname.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string repeat = txtRepeat.Text.Trim();

            if (!(isValid(username,email,password,repeat)))
            {
                MessageBox.Show("Error!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool emailInDB = db.Users.Any(x => x.Email == email);
            if (emailInDB)
            {
                MessageBox.Show("Email Is Already !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = new User()
            {
                Username = username,
                Email = email,
                Password = password,
            };
            db.Users.Add(user);
            db.SaveChanges();

            MessageBox.Show("Success");
        }

        private bool isValid(string username, string email, string password, string repeat)
        {
            if (username == "" || email == "" || password == "" || repeat == "")
            {
                MessageBox.Show("Fill all input !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(email.Contains("@")))
            {
                MessageBox.Show("Email Is not valid !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (password !=repeat)
            {
                MessageBox.Show("Please repaet password correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


    }
}
