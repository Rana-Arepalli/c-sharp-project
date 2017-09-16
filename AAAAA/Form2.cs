using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace AAAAA
{
    public partial class two : Form
    {
       
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter adp;
        OleDbDataReader rdr;
        public two()
        {
            InitializeComponent();
            textBox2.PasswordChar='$';
        }
        private void button1_Click(object sender, EventArgs e)
        {

            con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
      @"Data source= D:\database\" +
      @"data.mdb";
            con.Open();
            string s = "select count(*) from user_profiles where user_name='" + textBox1.Text + "' and password='" + textBox2.Text + "'";
            adp = new OleDbDataAdapter(s, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                three ss = new three();
                ss.Show();
 
            }
            else
            {
                MessageBox.Show("please check your credentials");
            }
           /* cmd.Connection
            * rdr = cmd.ExecuteReader();
            int count = 0;
            while (rdr.Read())
            {
                count = count++;
            }
            if (count==1)
            {
                this.Hide();
                three ss = new three();
                ss.Show();
            }
             if (count > 1)
            {
                MessageBox.Show("username and password are duplicated");
            }
            else 
            {
                MessageBox.Show("please check your credentials");
            }*/
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
