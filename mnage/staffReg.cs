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
    public partial class staffReg : Form
    {
        string Gender,ttt;
        public staffReg()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Main mn = new Main();
            mn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recordstaff rd_stf = new recordstaff();
            rd_stf.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=INFINITY;Initial Catalog=mange;Integrated Security=True");
            con.Open();
            string querry = "insert into staffDB values('" + textBox1.Text + "','" + Gender + "','" + richTextBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" +comboBox1.Text+ "','" +textBox2.Text + "','" +textBox5.Text + "','"+ttt+"','"+textBox6.Text+ "','" + comboBox2.Text + "')";
            SqlCommand cmd = new SqlCommand(querry, con);
            if(cmd.ExecuteNonQuery()==1)
            {
                MessageBox.Show("You HAVE Register Successfully!!!");
                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";





            }
            else
            {
                MessageBox.Show("FAILED TO REGISTER!!!");
                con.Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // mn = new Main();
            //mn.Show();
            Form2 fm_mn = new Form2();
            fm_mn.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void staffReg_Load(object sender, EventArgs e)
        {
            textBox6.Text = Form1.Loginfo.fk_ad_name;
            DateTime now = DateTime.Now;
            ttt = DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}
