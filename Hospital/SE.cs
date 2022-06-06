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
    public partial class SE : Form
    {
        HospitalEntities h = new HospitalEntities();
        public SE()
        {
            InitializeComponent();
        }

        private void SE_Load(object sender, EventArgs e)
        {
            var query = from q in h.employees
                        select new
                        {
                            Name = q.Emp_Name,
                            Position = q.Emp_Position,
                            Qulification = q.Emp_Qualification,
                            Specialization = q.Emp_Specialization,
                            DateOfBirth = q.Emp_DOB,
                            Phone = q.Emp_Phone,
                            Gender = q.Emp_Gender,
                            Salary = q.Emp_Salary
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contol cc = new Contol();
            cc.Show();
        }
    }
}
