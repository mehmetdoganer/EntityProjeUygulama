﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FIYAT,
                                            x.TBLKATERGORI.AD,
                                            x.DURUM
                                        }).ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = TxtUrunAd.Text;
            t.MARKA = TxtMarka.Text;
            t.STOK = short.Parse(TxtStok.Text);
            t.KATEGORI = int.Parse(comboBox1.SelectedValue.ToString());
            t.FIYAT = decimal.Parse(TxtFıyat.Text);
            t.DURUM = true;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Kaydedildi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Txtid.Text);
            var urun = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Txtid.Text);
            var urun = db.TBLURUN.Find(x);
            urun.URUNAD = TxtUrunAd.Text;
            urun.STOK = short.Parse(TxtStok.Text);
            urun.MARKA = TxtMarka.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");

        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBLKATERGORI
                               select new
                               {
                                   x.ID,
                                   x.AD
                               }
                               ).ToList();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "AD";
            comboBox1.DataSource = kategoriler;

        }
    }
}