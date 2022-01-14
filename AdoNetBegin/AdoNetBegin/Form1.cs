using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetBegin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connstring = ConfigurationManager.ConnectionStrings["uniqueName"].ConnectionString;

            using (SqlConnection sqlconnection = new SqlConnection(connstring))
            {
                string command = "Select * from Student";

                using (SqlCommand sqlcommand=new SqlCommand(command,sqlconnection))
                {
                    sqlconnection.Open();

                    using (SqlDataReader sqlDataReader=sqlcommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            listBox1.Items.Add(sqlDataReader[1]);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connstring = ConfigurationManager.ConnectionStrings["uniqueName"].ConnectionString;

            using (SqlConnection sqlconnection = new SqlConnection(connstring))
            {
                string command = "Select * from Student where Fullname='Xeyal'";

                using (SqlCommand sqlcommand = new SqlCommand(command, sqlconnection))
                {
                    sqlconnection.Open();

                    using (SqlDataReader sqlDataReader = sqlcommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            listBox2.Items.Add(sqlDataReader[1]);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstring = ConfigurationManager.ConnectionStrings["uniqueName"].ConnectionString;

            using (SqlConnection sqlconnection = new SqlConnection(connstring))
            {
                string command = "delete from Student where Id=6 ";

                using (SqlCommand sqlcommand = new SqlCommand(command, sqlconnection))
                {
                    sqlconnection.Open();

                    using (SqlDataReader sqlDataReader = sqlcommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            listBox1.Items.Add(sqlDataReader[1]);
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string connstring = ConfigurationManager.ConnectionStrings["uniqueName"].ConnectionString;

            using (SqlConnection sqlconnection = new SqlConnection(connstring))
            {
                string command = "insert into dbo.Student (Fullname,Qrup,Birthdate,Grade) values ('Eli', '333T6', '1995-10-12', 'senior')";

                using (SqlCommand sqlcommand = new SqlCommand(command, sqlconnection))
                {
                    sqlconnection.Open();

                    using (SqlDataReader sqlDataReader = sqlcommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            listBox1.Items.Add(sqlDataReader[1]);
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connstring = ConfigurationManager.ConnectionStrings["uniqueName"].ConnectionString;

            using (SqlConnection sqlconnection = new SqlConnection(connstring))
            {
                string command = "update Student set Fullname='Veli' where Id=7";

                using (SqlCommand sqlcommand = new SqlCommand(command, sqlconnection))
                {
                    sqlconnection.Open();

                    using (SqlDataReader sqlDataReader = sqlcommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            listBox2.Items.Add(sqlDataReader[1]);
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
