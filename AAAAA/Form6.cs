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
    public partial class modification : Form
    {
        OleDbCommand cmd;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data source= d:\database\" + @"data.mdb");
        OleDbDataReader rdr;
        public modification()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void modification_Load(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string s = "select * from std_data where std_id=" + stdid.Text;
            OleDbCommand cmd = new OleDbCommand(s, con);
            rdr = cmd.ExecuteReader();
            try
            {
                rdr.Read();
                panel1.Show();
                name.Text = "" + rdr["name"];
            }
            catch(Exception)
            {
                MessageBox.Show("No such record exists");
            }
            
            
    
       }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
        @"Data source= d:\database\" +
        @"data.mdb";
            con.Open();
            string s1 = "update  std_data set std_id=" + stdid.Text + ",name='" + name.Text + "',date='" + date.Text + "',course='" + course.Text + "',fees='" + fees.Text + "',timmings='" + timmings.Text + "',address='" + address.Text + "',phone='" + phone.Text + "',due='" + due.Text + "' where std_id=" + stdid.Text;
            cmd = new OleDbCommand(s1, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("You got it");
         }
        
        private void stdid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) &&ch!=8 && ch!=46)
            {
                e.Handled = true;
            }
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsLetter(ch) &&ch!=8 &&ch!=46)
            {
                e.Handled=true;
            }
        }

        private void fees_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void timmings_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void due_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

      
    }
}
