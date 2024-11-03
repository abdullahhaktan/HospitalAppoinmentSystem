using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmDoktorDuyurular : Form
    {
        public FrmDoktorDuyurular()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmDoktorDuyurular_Load(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("Select * From Tbl_Duyurular",bgl.baglanti());
            dt.Fill(tbl);
            dataGridView1.DataSource=tbl;
            bgl.baglanti().Close();
        }
    }
}
