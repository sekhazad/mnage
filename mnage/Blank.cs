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
    public partial class Blank : Form

    {
        string attendance,ttt;
        public Blank()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            attendance = "Absent";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            attendance = "Present";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=INFINITY;Initial Catalog=mange;Integrated Security=True");
            con.Open();
            string querry = "insert into rstd values('" + textBox1.Text + "','" + textBox2.Text + "','" + attendance + "','" + richTextBox1.Text + "','" + ttt + "','" + textBox3.Text + "')";
            SqlCommand cmd = new SqlCommand(querry, con);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("You HAVE Register Successfully!!!");
                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox6.Text = "";
               





            }
            else
            {
                MessageBox.Show("FAILED TO REGISTER!!!");
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=INFINITY;Initial Catalog=mange;Integrated Security=True");
            con.Open();
            string querry = "select * from student";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(querry, con);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=INFINITY;Initial Catalog=mange;Integrated Security=True");
            con.Open();
            string querry = "select * from student where std_name like'" + textBox1.Text + "%'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(querry, con);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Blank_Load(object sender, EventArgs e)
        {
            textBox3.Text = staff.stafflog.staff_log_nm;
            DateTime now = DateTime.Now;
            ttt = DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}
