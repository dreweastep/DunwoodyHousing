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
        List<Resident> dormResidents = new List<Resident>();

        public Form1()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(Selection);
            tabControl1.TabPages.Remove(ResidentSearch);
            tabControl1.TabPages.Remove(NewResident);

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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(ResidentSearch);
            tabControl1.TabPages.Remove(Selection);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(NewResident);
            tabControl1.TabPages.Remove(Selection);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}