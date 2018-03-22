using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DunwoodyHousing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(Selection);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "home" && password == "1234")
            {
                tabControl1.TabPages.Add(Selection);
                tabControl1.TabPages.Remove(LogIn);

            }
            else
            {
                label5.Show();
            }

        }
    }
}
