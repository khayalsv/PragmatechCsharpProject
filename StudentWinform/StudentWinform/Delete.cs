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
    public partial class Delete : Form
    {
        private ComboBox _cmb;
        private DataGridView _dgv;
       
        public Delete(List<Group> groups,ComboBox cmb,DataGridView dgv)
        {
            InitializeComponent();
            _cmb = cmb;
            _dgv = dgv;
            cmbGroupDelete.Items.AddRange(groups.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result==DialogResult.Yes)
            {
                Group selectGroup = cmbGroupDelete.SelectedItem as Group;
                Student selectStudent = cmbStudentDelete.SelectedItem as Student;
                selectGroup.DeleteStudent(selectStudent);
                if (selectGroup==(Group)_cmb.SelectedItem)
                {
                    _dgv.DataSource = null;
                    _dgv.DataSource = selectGroup.GetAllStudent();
                }
                cmbGroupDelete.Text = "";
                cmbStudentDelete.Text = "";
                MessageBox.Show("Deleted");
            }
        }

        private void cmbGroupDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group selected_group = cmbGroupDelete.SelectedItem as Group;
            cmbStudentDelete.Items.Clear();
            cmbStudentDelete.Text = "";
            cmbStudentDelete.Items.AddRange(selected_group.GetAllStudent().ToArray());
        }
    }
}
