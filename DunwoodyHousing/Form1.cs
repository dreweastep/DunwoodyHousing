using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace DunwoodyHousing
{
    public partial class Form1 : Form
    {
        //DECLARATIONS
        List<Resident> residentList = new List<Resident>();
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        string FILENAME = "resident_records.txt";

        private void ReadIn()
        {
            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            residentList = (List<Resident>)binaryFormatter.Deserialize(inFile);

            inFile.Close();
        }

        public Form1()
        {
            //ReadIn();
            InitializeComponent();
            tabControl1.TabPages.Remove(Home);
            tabControl1.TabPages.Remove(ResidentSearch);
            tabControl1.TabPages.Remove(NewResident);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "home" && password == "1234")
            {
                tabControl1.TabPages.Add(Home);
                tabControl1.TabPages.Remove(LogIn);

                textBox1.Clear();
                textBox2.Clear();

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
            tabControl1.TabPages.Remove(Home);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(NewResident);
            tabControl1.TabPages.Remove(Home);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(LogIn);
            tabControl1.TabPages.Remove(Home);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(LogIn);
            tabControl1.TabPages.Remove(ResidentSearch);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(LogIn);
            tabControl1.TabPages.Remove(NewResident);

            ClearNewResident();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(Home);
            tabControl1.TabPages.Remove(ResidentSearch);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(Home);
            tabControl1.TabPages.Remove(NewResident);

            ClearNewResident();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Student Worker")
            {
                label9.Show();
                comboBox2.Show();

                label13.Show();
                textBox7.Show();

                comboBox2.SelectedIndex = -1;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("1");
                comboBox2.Items.Add("2");
                comboBox2.Items.Add("3");

            }

            if (comboBox1.Text == "Student Athlete")
            {
                label9.Show();
                comboBox2.Show();

                label13.Hide();
                textBox7.Hide();

                comboBox2.SelectedIndex = -1;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("4");
                comboBox2.Items.Add("5");
                comboBox2.Items.Add("6");

            }

            if (comboBox1.Text == "Scholarship Recipient")
            {
                label9.Show();
                comboBox2.Show();

                label13.Hide();
                textBox7.Hide();

                comboBox2.SelectedIndex = -1;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("7");
                comboBox2.Items.Add("8");

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string IDNumber = textBox3.Text;
            string firstName = textBox4.Text;
            string lastName = textBox5.Text;
            string roomNumber = textBox6.Text;
            string floorNumber = comboBox2.Text;
            int monthlyHours = Int32.Parse(textBox7.Text);

            if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(comboBox2.Text))
            {
                label16.Show();
            }
            else
            {
                foreach (var resident in residentList)
                {
                    if (resident.floorNumber == floorNumber && resident.roomNumber == roomNumber)
                    {
                        label14.Show();
                        break;
                    }

                    if (resident.IDNumber == IDNumber)
                    {
                        label15.Show();
                        break;
                    }
                }
                
                if (comboBox1.Text == "Student Worker")
                {
                    var myResident = new StudentWorker(IDNumber, firstName, lastName, roomNumber, floorNumber, monthlyHours);
                    residentList.Add(myResident);

                    ClearNewResident();
                }

                if (comboBox1.Text == "Student Athlete")
                {
                    var myResident = new StudentAthlete(IDNumber, firstName, lastName, roomNumber, floorNumber);
                    residentList.Add(myResident);

                    ClearNewResident();
                }

                if (comboBox1.Text == "Scholarship Recipient")
                {
                    var myResident = new ScholarshipRecipient(IDNumber, firstName, lastName, roomNumber, floorNumber);
                    residentList.Add(myResident);

                    ClearNewResident();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label15.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label14.Hide();
        }
        
        private void ClearNewResident()
        {
            label13.Hide();
            label14.Hide();
            label15.Hide();
            label16.Hide();
            textBox7.Hide();

            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Text = "0";

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
    }
}