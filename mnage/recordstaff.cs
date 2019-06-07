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
    public partial class recordstaff : Form
    {
        SqlConnection con = new SqlConnection("Data Source=INFINITY;Initial Catalog=mange;Integrated Security=True");

        public recordstaff()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Main mn = new Main();
            mn.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string querry = "select * from staffDB where stf_name like'" + textBox1.Text + "%'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(querry, con);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from staffDB where stf_id='" + textBox8.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textBox8.Text = dt.Rows[0][0].ToString();
            textBox7.Text = dt.Rows[0][1].ToString();
            richTextBox1.Text = dt.Rows[0][3].ToString();
            textBox3.Text = dt.Rows[0][4].ToString();
            textBox4.Text = dt.Rows[0][5].ToString();
            textBox5.Text = dt.Rows[0][11].ToString();
            textBox6.Text = dt.Rows[0][10].ToString();
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            string querry = "update staffDB set stf_address='" + richTextBox1.Text + "',stf_mobile='" + textBox3.Text + "',stf_higherqualification='" + textBox4.Text + "',stf_allocatedcourse='" + textBox5.Text + "' where stf_id='" + textBox8.Text + "'";
            SqlCommand cmd = new SqlCommand(querry, con);
            if (cmd.ExecuteNonQuery() == 1)
            {
                string errmsg = "Sucessfully Update ";
                label3.Text = errmsg;
            }
            else
            {
                string errmsg = "failed to update ";
               label3.Text = errmsg;
            }
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            string querry = "delete from student where stf_id='" + textBox8.Text + "'";
            SqlCommand cmd = new SqlCommand(querry, con);
            if (cmd.ExecuteNonQuery() == 1)
            {
                string errmsg = "Sucessfully delete ";
                label3.Text = errmsg;
            }
            else
            {
                string errmsg = "failed to delete ";
                label3.Text = errmsg;
            }
            con.Close();
        }
    }
}
