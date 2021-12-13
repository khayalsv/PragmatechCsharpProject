using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoStuForm
{
    public partial class Form1 : Form
    {
        private List<Student> room;

        public Form1()
        {
            room = new List<Student>();
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string email = txtEmail.Text.Trim();

            try
            {
                Student student = new Student
                {
                    Name = name,
                    Surname = surname,
                    Email=email
                };
                room.Add(student);
                MessageBox.Show("Elave olundu","Success",MessageBoxButtons.OK);
            }
            catch (Exception)
            {   
                MessageBox.Show("Yeniden yaz", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            txtName.Text = "";
            txtSurname.Text = "";
            txtEmail.Text = "";
        

        }


        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentList list = new StudentList(room);
            list.ShowDialog();
        }
    }
}
