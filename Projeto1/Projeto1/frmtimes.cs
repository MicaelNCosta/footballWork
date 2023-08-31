using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto1.models;


namespace projeto1
{
    public partial class frmtimes : Form
    {
        string ligas;
        public frmtimes(string ligas)
        {
            this.ligas = ligas;
            InitializeComponent();
            using (MyDbContext db = new MyDbContext())
            {
                string query =  @"SELECT * FROM times AS t JOIN ligas AS l ON t.ligas_id = l.id WHERE l.ligas IN ("+ligas+") ; ";
                List<frmtimes> frmtimes = db.Database.SqlQuery<frmtimes>(query).ToList();
                dataGVtimes.DataSource = frmtimes;
            }
        }

        private void frmtimes_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
