using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmKategoriListesi : Form
    {
        public FrmKategoriListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        void Temizle()
        {
            txtKategoriId.Text = "";
            txtKategoriAdi.Text = "";
        }

        void Listeleme()
        {
            var degerler = from kategori in db.TBLKATEGORI
                           select new
                           {
                               kategori.ID,
                               kategori.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmKategoriListesi_Load(object sender, EventArgs e)
        {
            Listeleme();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtKategoriId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtKategoriAdi.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLKATEGORI t = new TBLKATEGORI();            
            t.AD = txtKategoriAdi.Text;
            db.TBLKATEGORI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listeleme();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            var id = byte.Parse(txtKategoriId.Text);
            var deger = db.TBLKATEGORI.Find(id);
            db.TBLKATEGORI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listeleme();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var id = byte.Parse(txtKategoriId.Text);
            var deger = db.TBLKATEGORI.Find(id);
            deger.AD = txtKategoriAdi.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Listeleme();
        }
    }
}
