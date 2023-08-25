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
        public frmtimes()
        {
            InitializeComponent();
            using (MyDbContext db = new MyDbContext())
            {
                string query = " SELECT * FROM times ;";
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
