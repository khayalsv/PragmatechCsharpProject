using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RegisterForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=SALIMOV\SQLEXPRESS;Initial Catalog=UserR;Integrated Security=True");
            SqlCommand command = new SqlCommand(@"INSERT INTO [dbo].[Register]
           ([username]
           ,[email]
           ,[password]
           ,[phone]
           ,[gender])
     VALUES
           ('" + txtUname.Text + "', '" + txtEmail.Text + "', '" + txtPass.Text + "', '" + txtPhone.Text + "','" + cmbGender.SelectedItem.ToString() + "')", connect);
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Success");
            txtUname.Clear();
            txtEmail.Clear();
            txtPass.Clear();
            txtPhone.Clear();
            cmbGender.ResetText();
        }


        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchUser users = new SearchUser();
            users.ShowDialog();
        }
    }
}
