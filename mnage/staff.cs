using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace mnage
{
    public partial class staff : Form
    {
        public static class stafflog
        {
            public static string staff_log_nm;
        }
            
        
        public staff()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            staffReg stfR = new staffReg();
            stfR.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            Main mn = new Main();
            mn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=INFINITY;Initial Catalog=mange;Integrated Security=True");
            con.Open();
            string querry = "select * from staffDB where stf_username='" + textBox1.Text + "'and stf_password='" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                stafflog.staff_log_nm = textBox1.Text;
                Blank bk = new Blank();
                bk.Show();
            }
            else
            {
                Main mn = new Main();
                mn.Show();
                this.Hide();
            }
        }

        private void staff_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
