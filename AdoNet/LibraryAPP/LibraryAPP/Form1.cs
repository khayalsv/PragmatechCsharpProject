using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text=="Password")
            {
                txtPassword.Clear();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=salimov\sqlexpress;Initial Catalog=LibAPP;Integrated Security=True");
  
            SqlCommand cmd = new SqlCommand("Select * from Login where Email='"+txtEmail.Text+"' and Password='"+txtPassword.Text+"' ",con);
           
            SqlDataAdapter data = new SqlDataAdapter(cmd);
           
            DataSet ds = new DataSet();
            data.Fill(ds);

            if (ds.Tables[0].Rows.Count !=0)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong");
            }
            
        }
    }
}
