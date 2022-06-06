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
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace Hospital
{

    public partial class search_patient : Form
    {
        
        
        public search_patient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string d = textBox1.Text;
            using (var context = new HospitalEntities())
            {
                var query = from st in context.patients
                            join mt in context.media_records
                            on st.P_ID equals mt.P_ID
                            join r in context.rooms
                            on st.P_ID equals r.P_ID
                            where st.p_Name == d
                            select new
                            {
                                Name = st.p_Name,
                                Diagnosis = st.P_Diagonsis,
                                DateOfExamnition = mt.MR_Date_of_Examinatio,
                                Phone = st.P_Phone,
                                Address = st.P_Addres,
                                Age = st.P_Age,
                                Gender = st.P_Gender,
                                RoomNumber = r.R_ID,
                                DateIn = r.R_Date_In,
                                DateOut = r.R_Date_Out
                            };
                dataGridView1.DataSource = query.ToList();
            }

            





        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contol c = new Contol();
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }


