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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Main mn = new Main();
            mn.Show();
        }
    }
}
