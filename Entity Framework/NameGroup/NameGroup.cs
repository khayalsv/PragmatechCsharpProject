using EntityBegin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityBegin
{
    public partial class Form1 : Form
    {
        private readonly AkademiyaEntities db;
        public Form1()
        {
            InitializeComponent();
            db = new AkademiyaEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbGroup.DataSource = db.Groups.Select(x => x.Name).ToList(); //db-den groupu comboboxa cekir
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e) 
        {
            string group = cmbGroup.Text;
            if (!string.IsNullOrEmpty(group)) //comboboxda ad ferqli olarsa cxarmaz studenti tapmaz
            {
                Group groupresult = db.Groups.FirstOrDefault(x => x.Name == group); //gelen soz groupda tapilarse
                if (groupresult.Students.Count==0)
                {
                    MessageBox.Show("Null");
                }
                cmbStudent.DataSource = groupresult.Students.Select(x => x.Name).ToList();
            }
        }

        
    
    }
}
