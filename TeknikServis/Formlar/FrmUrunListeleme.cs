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

        private void FrmUrunListeleme_Load(object sender, EventArgs e)
        {
            //Listeleme

            var degerler = db.TBLURUN.ToList();
            gridControl1.DataSource = degerler;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            
            t.AD = txtUrunAdi.Text;
            t.MARKA = txtUrunMarka.Text;
            t.ALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
            t.SATISFIYAT= decimal.Parse(txtSatisFiyat.Text);
            t.STOK = short.Parse(txtStok.Text);
            t.DURUM = false;

            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var degerler = db.TBLURUN.ToList();
            gridControl1.DataSource = degerler;
        }
    }
}
