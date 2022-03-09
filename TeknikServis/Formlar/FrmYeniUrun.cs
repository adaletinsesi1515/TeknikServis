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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {
            lookUpKategori.Properties.DataSource = db.TBLKATEGORI.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();

            t.AD = txtUrunAd.Text;
            t.MARKA = txtUrunMarka.Text;
            t.ALISFIYAT = decimal.Parse(txtAlisFiyati.Text);
            t.SATISFIYAT = decimal.Parse(txtSatisFiyati.Text);
            t.STOK = short.Parse(txtStok.Text);
            t.DURUM = false;
            t.KATEGORI = byte.Parse(lookUpKategori.EditValue.ToString());

            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
