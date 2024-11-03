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


namespace Proje_Hastane
{
    public partial class FrmSekreterDuyurular : Form
    {
        public FrmSekreterDuyurular()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("Select * From Tbl_Duyurular",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void DuyuruSil_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string DuyuruAd = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
 
            SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Duyurular WHERE Duyuru=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",DuyuruAd);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru silme işlemi başarı ile gerçekleşti", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
