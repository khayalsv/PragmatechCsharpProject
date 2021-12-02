using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        private List<Student> students;
        public Form1()
        {
            students = new List<Student>();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fname = txtName.Text.Trim();
            string fsurname = txtSurname.Text.Trim();
            string femail = txtEmail.Text.Trim();

            try
            {
                Student student = new Student
                {
                    name = fname,
                    surname = fsurname,
                    email = femail
                };
                students.Add(student);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pls fill valid values for student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FillStudentList();
        }
        private void FillStudentList()
        {
            listStudent.Items.Clear();
            foreach (var item in students)
            {
                listStudent.Items.Add(item.fullname+" "+item.email);

            }
        }
    }
}
