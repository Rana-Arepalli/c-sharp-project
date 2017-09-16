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
    public partial class Form1 : Form
    {
        OleDbCommand cmd;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data source= d:\database\" + @"data.mdb");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string s = "insert into user_profiles values('"+username.Text+"','"+password.Text+"')";
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New user is added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
