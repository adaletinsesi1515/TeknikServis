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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {

            lblToplamUrunSayisi.Text = db.TBLURUN.Count().ToString();
            lblToplamKategoriSayisi.Text = db.TBLKATEGORI.Count().ToString();
            lblToplamStokSayisi.Text = db.TBLURUN.Sum(x => x.STOK).ToString();

            //Önce stok adedine göre en fazla olanı sıralıyoruz(descending), sonra ürün adını seçip, ilk gelen değeri yazdırıyoruz
            lblEnFazlaStokluUrun.Text = (from x in db.TBLURUN
                                         orderby x.STOK descending
                                         select x.AD).FirstOrDefault();
            
            //Önce stok adedine göre en az olanı sıralıyoruz (ascending), sonra ürün adını seçip, ilk gelen değeri yazdırıyoruz
            lblEnAzStokluUrun.Text = (from x in db.TBLURUN
                                      orderby x.STOK ascending
                                      select x.AD).FirstOrDefault();


            lblEnYuksekFiyatliUrun.Text = (from x in db.TBLURUN
                                           orderby x.SATISFIYAT descending
                                           select x.AD).FirstOrDefault();

            lblEnDusukFiyatliUrun.Text = (from x in db.TBLURUN
                                           orderby x.SATISFIYAT ascending
                                           select x.AD).FirstOrDefault();


            lblBilgisayarStokSayisi.Text = db.TBLURUN.Count(x=>x.KATEGORI == 1).ToString();
            lblYaziciStokSayisi.Text = db.TBLURUN.Count(x => x.KATEGORI == 9).ToString();

            lblToplamMarkaSayisi.Text = (from x in db.TBLURUN
                                         select x.MARKA
                                       ).Distinct().Count().ToString();


        }
    }
}
