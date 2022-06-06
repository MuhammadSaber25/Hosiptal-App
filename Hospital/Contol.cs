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
    public partial class Contol : Form
    {
        public Contol()
        {
            InitializeComponent();
        }

        private void Contol_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Patient a = new Add_Patient();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            search_patient s = new search_patient();
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AP ap = new AP();
            ap.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SE s = new SE();
            s.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchEmployee sp = new SearchEmployee();
            sp.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowRoom ss = new ShowRoom();
            ss.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Showlab ss = new Showlab();
            ss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployee aa = new AddEmployee();
            aa.Show();
        }
    }
}
