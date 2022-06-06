using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Hospital
{
    public partial class Add_Patient : Form
    {
        HospitalEntities h = new HospitalEntities();
      
        patient p = new patient();
        media_records md = new media_records();

        public Add_Patient()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            { 
                p.P_ID = int.Parse(textBox1.Text);
                p.p_Name = textBox2.Text;
                p.P_Addres = textBox3.Text;
                p.P_Diagonsis = textBox4.Text;
                p.P_Age = int.Parse(textBox5.Text);
                p.P_Phone = textBox6.Text;
                if (radioButton1.Checked) p.P_Status = true;
                if (radioButton2.Checked) p.P_Status = false;
                if (radioButton3.Checked) p.P_Gender = "Male";
                if (radioButton4.Checked) p.P_Gender = "Female";
                md.MR_ID = p.P_ID;
                h.patients.Add(p);
                md.MR_Problem = p.P_Diagonsis;
                md.MR_Date_of_Examinatio = dateTimePicker1.Value.Date;
                md.P_ID = p.P_ID;
                h.media_records.Add(md);
                h.SaveChanges();
                MessageBox.Show(" Saved ");
                this.Close();
                Contol c = new Contol();
                c.Show();
            }
            catch (Exception)
            {

                MessageBox.Show(" Invalid Data !!! ");
            }






        }

        private void Add_Patient_Load(object sender, EventArgs e)
        {
            var xx = from q in h.patients
                     select q.P_ID;
              int s =xx.Count();
            textBox7.Text = s.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Contol c = new Contol();
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
