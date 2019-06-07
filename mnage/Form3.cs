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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            record rd_std = new record();
            rd_std.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            recordstaff rd_stff = new recordstaff();
            rd_stff.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Main mn = new Main();
            mn.Show();
        }
    }
}
