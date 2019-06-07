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
    public partial class studentRegister : Form
    {
        public studentRegister()
        { 
            InitializeComponent();
        }
        public String Gender,ttt,cmb;

        private void studentRegister_Load(object sender, EventArgs e)
        {
            textBox6.Text = Form1.Loginfo.fk_ad_name;
            DateTime now = DateTime.Now;
            ttt = DateTime.Now.ToString("yyyy-MM-dd");
            //cmb=comboBox1.Text;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(textBox6.Text);
            SqlConnection con = new SqlConnection("Data Source=INFINITY;Initial Catalog=mange;Integrated Security=True");
            con.Open();
            string querry = "insert into student values('"+textBox1.Text+"','"+textBox2.Text+"','"+Gender+"','"+richTextBox1.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+ttt+"','"+textBox6.Text+"','"+comboBox1.Text+"')";
            SqlCommand cmd = new SqlCommand(querry,con);
            if(cmd.ExecuteNonQuery()==1)
            {
                MessageBox.Show("You HAVE Register Successfully!!!");
                con.Close(); //clear
                textBox1.Text = "";
                textBox2.Text = "";
                Gender = "";
                richTextBox1.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                comboBox1.Text = "";

            }
            else
            {
                MessageBox.Show("FAILED TO REGISTER!!!");
                con.Close();
            }
            
            

           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male"; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Main mn = new Main();
            mn.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            record rnd = new record();
            rnd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Main mn = new Main();
            // mn.Show();
            Form2 fm_mn = new Form2();
            fm_mn.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }
    }
}
