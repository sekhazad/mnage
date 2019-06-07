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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Main mn = new Main();
            mn.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main mns = new Main();
            mns.Show();                                                                                                            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentRegister str_sd = new studentRegister();
            str_sd.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            staffReg str_stf = new staffReg();
            str_stf.Show();
            this.Hide();
        }
    }
}
