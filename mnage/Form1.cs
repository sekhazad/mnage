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
    public partial class Form1 : Form

    {
        public static class Loginfo
        {
            public static string fk_ad_name;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
         
            SqlConnection con = new SqlConnection("Data Source=INFINITY;Initial Catalog=mange;Integrated Security=True");
            con.Open();
            string name = textBox1.Text;
            string password = textBox2.Text;
            SqlCommand cmd = new SqlCommand("select name,password from adminDB where name='" + textBox1.Text + "'and password='" + textBox2.Text + "'", con);
            
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
               MessageBox.Show("Successfully login");
                //studentRegister str = new studentRegister();
                //str.Show();
                Form2 fm_ch = new Form2();
                fm_ch.Show();
                this.Hide();
                Loginfo.fk_ad_name = textBox1.Text;
                


            }
            else
            {
                MessageBox.Show("Please Enter valid Username and Password");
            }

            textBox1.Text = "";
            textBox2.Text = "";
            







        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            Main mn = new Main();
            mn.Show();

        }
    }
}
