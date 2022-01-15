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
    public partial class SearchUser : Form
    {
        public SearchUser()
        {
            InitializeComponent();
        }

        private void SearchUser_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=SALIMOV\SQLEXPRESS;Initial Catalog=UserR;Integrated Security=True");

            SqlCommand command = new SqlCommand("Select * from Register", connect);
            SqlDataAdapter data = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            data.Fill(table);
            dtGrid.DataSource = table;

        }
    }
}
