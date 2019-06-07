using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mnage
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ad_fm = new Form1();
            ad_fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 ad_fm = new Form1();
            ad_fm.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            data dta = new data();
            dta.Show();
            this.Hide(); 
         }

        private void button4_Click(object sender, EventArgs e)
        {
            staff stf = new staff();
            stf.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 fm_up = new Form3();
            fm_up.Show();
            this.Hide();
        }
    }
}
