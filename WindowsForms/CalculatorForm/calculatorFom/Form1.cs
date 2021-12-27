using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorFom
{
    public partial class Form1 : Form
    {
        public double first { get; private set; }
        public double second { get; private set; }

        public string method { get; private set; }
        public double result { get; private set; }
        public Form1()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//1
        {
            if (box.Text == "0" && box.Text != null)
            {
                box.Text = "1";
            }
            else
            {
                box.Text = box.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)//2
        {
            if (box.Text == "0" && box.Text != null)
            {
                box.Text = "2";
            }
            else
            {
                box.Text = box.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)//3
        {
            box.Text = box.Text + "3";
        }

        private void button10_Click(object sender, EventArgs e) //++++++++++++++++
        {
            first = Convert.ToDouble(box.Text);
            box.Text = "0";
            method = "+";
        }

        private void button11_Click(object sender, EventArgs e) //----------------
        {
            first = Convert.ToDouble(box.Text);
            box.Text = "0";
            method = "-";


        }

        private void button12_Click(object sender, EventArgs e) //==================
        {
            
            second = Convert.ToDouble(box.Text);


            if (method == "+")
            {
                result = (first + second);
                box.Text = Convert.ToString(result);             
            }

            if (method == "-")
            {
                result = (first - second);
                box.Text = Convert.ToString(result);
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

  
    }
}
