using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAAAA
{
    public partial class three : Form
    {
        public three()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            admission ss = new admission();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            receipt ss = new receipt();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            modification ss = new modification();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            expenses ss = new expenses();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Form1 ss = new Form1();
            ss.Show();
        }
    }
}
