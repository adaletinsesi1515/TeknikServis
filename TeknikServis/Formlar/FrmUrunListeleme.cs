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
    public partial class FrmUrunListeleme : Form
    {
        public FrmUrunListeleme()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        void Listeleme()
        {
            var degerler = from urun in db.TBLURUN
                           select new
                           {
                               urun.ID,
                               urun.AD,
                               urun.MARKA,
                               KATEGORIAD = urun.TBLKATEGORI.AD,
                               urun.ALISFIYAT,
                               urun.SATISFIYAT,
                               urun.STOK
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmUrunListeleme_Load(object sender, EventArgs e)
        {            
            Listeleme();
            lookKategori.Properties.DataSource = db.TBLKATEGORI.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();

            t.AD = txtUrunAdi.Text;
            t.MARKA = txtUrunMarka.Text;
            t.ALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
            t.SATISFIYAT = decimal.Parse(txtSatisFiyat.Text);
            t.STOK = short.Parse(txtStok.Text);
            t.DURUM = false;
            t.KATEGORI = byte.Parse(lookKategori.EditValue.ToString());

            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listeleme();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtUrunId.Text = "";
            txtUrunAdi.Text = "";
            txtUrunMarka.Text = "";
            txtAlisFiyat.Text = "";
            txtSatisFiyat.Text = "";
            txtStok.Text = "";
            lookKategori.Text = "";
        }

        //Gridview içindeki bir satıra tıklayınca ne olacak onun metodunu yazıyoruz burada (FocusRowChanged)
        //Tıklayınca ilgili alanları oluşturduğumuz textboxlara değerleri gönderiyoruz.
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtUrunId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtUrunAdi.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtUrunMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            txtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
            txtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            txtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUrunId.Text);
            var deger = db.TBLURUN.Find(id);
            db.TBLURUN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listeleme();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUrunId.Text);
            var deger = db.TBLURUN.Find(id);
            deger.AD = txtUrunAdi.Text;
            deger.MARKA = txtUrunMarka.Text;
            deger.ALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
            deger.SATISFIYAT= decimal.Parse(txtSatisFiyat.Text);
            deger.STOK = short.Parse(txtStok.Text);
            deger.KATEGORI = byte.Parse(lookKategori.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listeleme();
        }
    }
}
