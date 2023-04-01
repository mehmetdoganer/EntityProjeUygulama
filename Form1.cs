using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            var kategoriler = db.TBLKATERGORI.ToList();
            dataGridView1.DataSource = kategoriler; 
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
           TBLKATERGORI t = new TBLKATERGORI();
            t.AD = textBox2.Text;
            db.TBLKATERGORI.Add(t); 
            db.SaveChanges();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.TBLKATERGORI.Find(x);
            db.TBLKATERGORI.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi");


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.TBLKATERGORI.Find(x);
            ktgr.AD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Güncellendi");
        }
    }
}
