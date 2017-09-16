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
    public partial class expenses : Form
    {
        OleDbCommand cmd;
        OleDbConnection con = new OleDbConnection( @"Provider=Microsoft.Jet.OLEDB.4.0;" +
        @"Data source= d:\database\" +
        @"data.mdb");
        public expenses()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            con.Open();
            string s = "insert into expenses values (" +voucherno.Text + ",'"+companyname.Text+"','" + amount.Text + "','" + due.Text + "','" + nature.Text + "')";
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The form is subitted");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void voucherno_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
