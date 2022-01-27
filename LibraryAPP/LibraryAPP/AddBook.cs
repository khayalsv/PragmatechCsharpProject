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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPrice.Text != "")
            {



                SqlConnection con = new SqlConnection(@"Data Source=salimov\sqlexpress;Initial Catalog=LibAPP;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into NewBook values (@name,@author,@type,@price,@amount,@date)", con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@author", txtAuthor.Text);
                cmd.Parameters.AddWithValue("@type", txtType.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@amount", txtAmount.Text);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Success");
                Clear();

            }
            else
            {
                MessageBox.Show("Fill input");
            }
        }

        void Clear()
        {
            txtName.Text = "";
            txtAuthor.Text = "";
            txtType.Text = "";
            txtPrice.Text = "";
            txtAmount.Text = "";
            dateTimePicker1.Text = "";
        }
    }
}
