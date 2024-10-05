using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineTicketReservationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Flight Route : " + comboBox1.Text + " - " + comboBox2.Text + " ～  Date Of flight : " + dateTimePicker1.Text + " ～  Time of flight : " + maskedTextBox1.Text);

            listBox2.Items.Add("Name : " + textBox1.Text + " ～ Surname : " + textBox2.Text + " ～ National İdentitty : " + maskedTextBox2.Text + " ～ Phone Number : " + maskedTextBox3.Text);

            MessageBox.Show(" You have successfully created a reservation !! ");
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            label10.Text = comboBox2.Text;

            comboBox2.Text = comboBox1.Text;

            comboBox1.Text = label10.Text;
            
            


        }
    }
}
