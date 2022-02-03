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
    public partial class Update : Form
    {
        private ComboBox _cmb;
        private DataGridView _dgv;
        public Update(List<Group> groups,ComboBox cmb,DataGridView dgv)
        {
            InitializeComponent();
            _cmb = cmb;
            _dgv = dgv;
            cmbGroupUptade.Items.AddRange(groups.ToArray());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Group selectGroup = cmbGroupUptade.SelectedItem as Group;
                Student selectStudent = cmbStudentUptade.SelectedItem as Student;

                string name = txtName.Text;
                string surname = txtSurname.Text;
                selectStudent.UpdateStudent(name, surname);

                if (selectGroup == (Group)_cmb.SelectedItem)
                {
                    _dgv.DataSource = null;
                    _dgv.DataSource = selectGroup.GetAllStudent();
                }
                cmbGroupUptade.Text = "";
                cmbStudentUptade.Text = "";
                MessageBox.Show("Uptade");
            }
        }


        private void cmbGroupDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group selected_group = cmbGroupUptade.SelectedItem as Group;
            cmbStudentUptade.Items.Clear();
            cmbStudentUptade.Text = "";
            cmbStudentUptade.Items.AddRange(selected_group.GetAllStudent().ToArray());
        }
    }
}
