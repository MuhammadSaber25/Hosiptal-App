﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using Hospital;

namespace Hospital
{
    public partial class Home : Form
    {

        HospitalEntities h = new HospitalEntities();


        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string ss = textBox2.Text;
            
            if (ss=="saber"&&s=="5353")
            {
                this.Hide();
                Contol c = new Contol();
                c.Show();
            }
            else
            {
                MessageBox.Show(" Invalid Data !! ");
                textBox1.Clear();
                textBox2.Clear();

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
