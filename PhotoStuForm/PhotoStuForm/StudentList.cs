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
    public partial class StudentList : Form
    {
        private List<Student> _room;
        public StudentList(List<Student> room)
        {
            InitializeComponent();
            _room = room;
            cmbSearch.Items.AddRange(room.ToArray());
            AddList();
            
        }

        private void AddList()
        {
            listBox.Items.Clear();
            foreach (var item in _room)
            {
                listBox.Items.Add(item.ToString());
            }
        }


        private void cmbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student selectStu = cmbSearch.SelectedItem as Student;
            if (selectStu == null)
            {        
                AddList();
            }
            else
            {
                listBox.Items.Clear();
                foreach (var item in _room)
                {
                    if (selectStu.Name == item.Name)
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

        private void StudentList_Load(object sender, EventArgs e)
        {
            cmbSearch.Items.Insert(0, "All");
            
        }
    }
}
