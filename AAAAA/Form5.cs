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
    public partial class receipt : Form
    {
        OleDbCommand cmd;
        OleDbConnection con=new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data source= d:\database\" + @"data.mdb");
        OleDbDataAdapter ada;
        public receipt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void dbbtn_Click(object sender, EventArgs e)
        {

            
            con.Open();
            string s = "select * from std_data ";

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void cnfbtn_Click(object sender, EventArgs e)
        {
           
            con.Open();
            string s = "insert into receipt values (" + stdid.Text + ",'"+date.Text+"','"+name.Text+"','"+comboBox1.Text+"','"+feespaid.Text+"','"+amount.Text+"','"+balance.Text+"')";
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The form is subitted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void feesdue_MouseHover(object sender, EventArgs e)
        {
            balance.Text = (Double.Parse(amount.Text) - Double.Parse(feespaid.Text)).ToString();
        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void feespaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void receipt_Load(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void stdid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data source= d:\database\" + @"data.mdb";
            con.Open();
            string s = "select * from std_data where std_id="+ stdid.Text;
             cmd = new OleDbCommand(s, con);
            OleDbDataReader rdr;
            rdr = cmd.ExecuteReader();
            try
            {
                rdr.Read();
               // MessageBox.Show(""+rdr[1]);
                panel1.Show();
                name.Text = ""+rdr["name"];
                comboBox1.Text=""+rdr["course"];
            }
            catch (Exception )
            {
                MessageBox.Show("No such ID");
            }
                 

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void date_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

      
        }
    }

