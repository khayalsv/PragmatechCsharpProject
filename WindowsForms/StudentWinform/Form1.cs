using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWinform
{
    public partial class Form1 : Form
    {
        private List<Group> groups = new List<Group>();
        public Form1()
        {
            InitializeComponent();
            Student s1 = new Student("Sadiq", "Ilyasli");
            Student s2 = new Student("Xeyal", "Selimov");
            Student s3 = new Student("Nurlan", "Hesenli");
            Student s4 = new Student("Rasim", "Eliyev");

            Group group1 = new Group("208a1");
            Group group2 = new Group("434a3");

            group1.AddStudent(s1);
            group1.AddStudent(s2);
            group2.AddStudent(s3);
            group2.AddStudent(s4);

            groups.Add(group1);
            groups.Add(group2);

            cmbGroup.Items.AddRange(groups.ToArray());
            cmbGroup.SelectedIndex =0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();

            if (name=="" || surname=="")
            {
                MessageBox.Show("Doldur", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Student student = new Student(name, surname);
            Group selectGroup = (Group)cmbGroup.SelectedItem;
            selectGroup.AddStudent(student);
            dgv.DataSource = null;
            dgv.DataSource = selectGroup.GetAllStudent();

            txtName.Text = "";
            txtSurname.Text = "";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete(groups,cmbGroup,dgv);
            delete.ShowDialog();
        }

        private void uptadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update update = new Update(groups, cmbGroup, dgv);
            update.ShowDialog();
        }
    }
}
