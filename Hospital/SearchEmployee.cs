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
    public partial class SearchEmployee : Form
    {
       

        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contol aa = new Contol();
            aa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string y = txtsearch.Text;

            using (var context = new HospitalEntities())
            {
                var query = from st in context.employees
                            where st.Emp_Name == y
                            select st;

                var x = query.FirstOrDefault<employee>();
                txtname.Text = x.Emp_Name;
                txtphone.Text = x.Emp_Phone;
                txtposition.Text= x.Emp_Position;
                txtqualification.Text = x.Emp_Qualification;
                txtspecialization.Text = x.Emp_Specialization;
                txtaddress.Text = x.Emp_Address;
                txtgender.Text = x.Emp_Gender;
                txtsalary.Text = x.Emp_Salary.ToString();
                txtdob.Text = x.Emp_DOB.ToString();
            };
        }

        private void SearchEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
