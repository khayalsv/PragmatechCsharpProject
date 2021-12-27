using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace photoTEST
{
    public partial class SelectList : Form
    {
        private List<Student> _room;
        public SelectList(List<Student> room)
        {
            InitializeComponent();
            _room = room;
            cmbSearch.Items.AddRange(room.ToArray());
            Add();
        }

        private void Add()
        {
            listBox.Items.Clear();
            foreach (var item in _room)
            {
                listBox.Items.Add(item.ToString());
            }
        }

        private void cmbSearch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Student selectStu = cmbSearch.SelectedItem as Student;
            if (selectStu==null)
            {
                Add();
            }
            else
            {
                listBox.Items.Clear();
                foreach (var item in _room)
                {
                    if (selectStu.Name==item.Name)
                    {

                        listBox.Items.Add(selectStu);

                        cmbName.Items.Add(selectStu.Name);
                        cmbName.SelectedIndex = 0;

                        cmbSurname.Items.Add(selectStu.Surname);
                        cmbSurname.SelectedIndex = 0;

                        cmbEmail.Items.Add(selectStu.Email);
                        cmbEmail.SelectedIndex = 0;
                    }
                }
            }
        }

        private void SelectList_Load(object sender, EventArgs e)
        {
            cmbSearch.Items.Insert(0, "All");
        }
    }
}
