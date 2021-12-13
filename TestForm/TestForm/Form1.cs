using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        private List<Group> school = new List<Group>();
        public Form1()
        {
            InitializeComponent();

            Student s1 = new Student("Khayal", "Salimov");
            Student s2 = new Student("Sadiq", "Ilyasli");
            Student s3 = new Student("Rasim", "Aliyev");
            Student s4 = new Student("Nurlan", "Hasanli");

            Group group1 = new Group("A101");
            Group group2 = new Group("B255");

            school.Add(group1);
            school.Add(group2);
            
            group1.GroupAddStudent(s1);
            group1.GroupAddStudent(s2);
            group2.GroupAddStudent(s3);
            group2.GroupAddStudent(s4);

            cmbGroup.Items.AddRange(school.ToArray());
            cmbGroup.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();

            if (name == "" || surname == "")
            {
                MessageBox.Show("Doldur", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student student = new Student(name,surname);
            Group selectGroup = (Group)cmbGroup.SelectedItem;
            selectGroup.GroupAddStudent(student);

            dgv.DataSource = null;
            dgv.DataSource = selectGroup.GetAllStudent();

            txtName.Text = "";
            txtSurname.Text = "";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete(school,cmbGroup,dgv);
            delete.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
