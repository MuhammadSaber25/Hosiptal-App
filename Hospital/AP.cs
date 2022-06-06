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
    public partial class AP : Form
    {
        public AP()
        {
            InitializeComponent();
        }

        private void AP_Load(object sender, EventArgs e)
        {
            HospitalEntities f = new HospitalEntities();
            var query = from q in f.patients
                        select new { Name = q.p_Name,
                            Diagonsis = q.P_Diagonsis,
                            Gender = q.P_Gender,
                            Phone = q.P_Phone,
                            Age = q.P_Age,
                            Address = q.P_Addres
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
