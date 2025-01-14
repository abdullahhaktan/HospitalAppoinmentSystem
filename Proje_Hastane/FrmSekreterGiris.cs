﻿using System;
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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }

        public string Tc;

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Sekreter where SekterTC=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
              FrmSekreterDetay frs=new FrmSekreterDetay();
                frs.TcNumara = MskTC.Text  ;
                frs.Show();
                this.Hide();
            }
            else
            { 
                MessageBox.Show("Hatalı TC & Şifre");
            }
            bgl.baglanti().Close();
        }

        private void MskTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void LnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void FrmSekreterGiris_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmGirisler fr=new FrmGirisler();
            fr.Show();
            this.Hide();
        }
    }
}
