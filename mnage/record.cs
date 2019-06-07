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
    public partial class record : Form
    {
        public record()
        {
            InitializeComponent();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=INFINITY;Initial Catalog=mange;Integrated Security=True");
            con.Open();
            string querry = "select * from student where std_name like'" + textBox1.Text + "%'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(querry, con);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=INFINITY;Initial Catalog=mange;Integrated Security=True");
            con.Open();
            string querry = "select * from student where std_name like'"+textBox1.Text+"%'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(querry, con);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Main mn = new Main();
            mn.Show();
        }

        private void record_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=INFINITY;Initial Catalog=mange;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from student where std_id='"+textBox8.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textBox8.Text = dt.Rows[0][0].ToString();
            textBox7.Text = dt.Rows[0][1].ToString();
            textBox2.Text = dt.Rows[0][2].ToString();
            richTextBox1.Text = dt.Rows[0][4].ToString();
            textBox3.Text = dt.Rows[0][5].ToString();
            textBox4.Text = dt.Rows[0][6].ToString();
            textBox5.Text = dt.Rows[0][7].ToString();
            textBox6.Text = dt.Rows[0][9].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=INFINITY;Initial Catalog=mange;Integrated Security=True");
            con.Open();
            string querry = "update student set std_address='" + richTextBox1.Text + "',std_mobile='" + textBox3.Text + "',std_class='" + textBox4.Text + "',std_branch='" + textBox5.Text + "' where std_id='" + textBox8.Text + "'";
            SqlCommand cmd = new SqlCommand(querry,con);
            if(cmd.ExecuteNonQuery()==1)
            {
                string errmsg = "Sucessfully Update ";
                label10.Text = errmsg;
            }
            else
            {
                string errmsg = "failed to update ";
                label10.Text = errmsg;
            }
            con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=INFINITY;Initial Catalog=mange;Integrated Security=True");
            con.Open();
            string querry = "delete from student where std_id='" + textBox8.Text + "'";
            SqlCommand cmd = new SqlCommand(querry, con);
            if (cmd.ExecuteNonQuery() == 1)
            {
                string errmsg = "Sucessfully delete ";
                label10.Text = errmsg;
            }
            else
            {
                string errmsg = "failed to delete ";
                label10.Text = errmsg;
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
            this.Hide();
        }
    }
}
