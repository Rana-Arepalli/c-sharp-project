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
    public partial class admission : Form
    {
        OleDbCommand cmd;
        OleDbConnection con =new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data source= d:\database\" + @"data.mdb");
          public admission()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void admission_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            string s = "insert into std_data values(" + stdid.Text + ",'" + name.Text + "','" + dateTimePicker1.Text + "','" + address.Text + "','" + course.Text + "','" + fees.Text + "','" + phone.Text + "','" + timmings.Text + "','"+due.Text+"')";
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record inserted successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void feestext_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch!=8 &&ch!=46)
            {
                e.Handled = true;
            }
        }

        private void phonetext_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void phonetext_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch!=8 && ch!=46)
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) &&ch!=8 &&ch!=46)
            {
                e.Handled = true;
            }
        }

        private void timmingstext_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) &&ch!=8 &&ch!=46)
            {
                e.Handled = true;
            }
        }

        private void nametext_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsLetter(ch) &&ch!=8 &&ch!=46)
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           /* OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter="jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|all files(*.*)|*.*";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                string path=dlg.FileName.ToString();
                pictureBox1.ImageLocation=path;*/
            }
        }
    }

