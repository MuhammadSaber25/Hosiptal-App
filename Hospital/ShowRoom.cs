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
    public partial class ShowRoom : Form
    {
        HospitalEntities hh = new HospitalEntities();
        public ShowRoom()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void ShowRoom_Load(object sender, EventArgs e)
        {
            var query = from q in hh.rooms
                        select new
                        {
                            RoomID = q.R_ID,
                            RoomStatus = q.R_Status,
                            RoomType = q.R_Type
                        };
            dataGridView1.DataSource = query.ToList();
        }
    }
}
