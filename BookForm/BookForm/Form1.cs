using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookForm
{
    public partial class Form1 : Form
    {
        private List<Book> _books;
        private List<Genre> _genres;
        private object cmb_Genre;

        public Form1()
        {
            InitializeComponent();
            _books = new List<Book>();
            _genres = new List<Genre>
            {
                new Genre{Name="Dedective"},
                new Genre{Name="Roman"},
                new Genre{Name="Love"},
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_Filter
        }
    }
}
