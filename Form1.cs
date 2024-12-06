using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngouriMath;
using AngouriMath.Extensions;

namespace teszt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void buttonnum1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void buttonnum0_Click(object sender, EventArgs e)
        { 
            textBox1.Text += 0;
        }

        private void buttonnum2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void buttonnum3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void buttonnum4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void buttonnum5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void buttonnum6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void buttonnum7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void buttonnum8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void buttonnum9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void buttonper_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void buttonszor_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }
        private void buttonans_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString((decimal)textBox1.Text.EvalNumerical());
        }
    }
}
