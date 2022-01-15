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

namespace CRUD
{
    public partial class UserTable : Form
    {
        public UserTable()
        {
            InitializeComponent();
        }

        private void UserTable_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SALIMOV\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from UserTable", con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            data.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SALIMOV\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update UserTable set username=@username where id=@id", con);
          
            cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));
            cmd.Parameters.AddWithValue("@username", txtUname.Text);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Success");

            txtID.Clear();
            txtUname.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SALIMOV\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from UserTable", con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            data.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SALIMOV\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete UserTable where id=@id", con);

            cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Success");
        }
    }
}