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
    public partial class Showlab : Form
    {
        HospitalEntities hh = new HospitalEntities();
        public Showlab()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contol c = new Contol();
            c.Show();
        }

        private void Showlab_Load(object sender, EventArgs e)
        {
            var query = from q in hh.labs
                        select new { LabNumber = q.L_ID, LabName = q.L_NAME };
            dataGridView1.DataSource = query.ToList();
        }
    }
}
