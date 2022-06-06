using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class AddEmployee : Form
    {
        HospitalEntities hh = new HospitalEntities();
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contol cc = new Contol();
            cc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {
                employee emp = new employee();
                emp.Emp_ID = int.Parse(txtid.Text);
                emp.Emp_Name = txtname.Text;
                emp.Emp_Phone = txtphone.Text;
                emp.Emp_Position = txtposition.Text;
                emp.Emp_Qualification = txtqulifications.Text;
                emp.Emp_Salary = decimal.Parse(txtsalary.Text);
                emp.Emp_Specialization = txtspecialization.Text;
                emp.Emp_Address = txtaddress.Text;
                emp.Emp_DOB = dateTimePicker1.Value.Date;
                if (male.Checked) emp.Emp_Gender = "Male";
                if (female.Checked) emp.Emp_Gender = "Female";
                hh.employees.Add(emp);
                hh.SaveChanges();
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

        private void male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            var xx = from q in hh.employees
                     select q.Emp_ID;
            int s = xx.Count();
            textBox7.Text = s.ToString();
        }
    }
}
