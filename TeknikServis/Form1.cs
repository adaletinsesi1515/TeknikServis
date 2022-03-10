using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }
               

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Burada öncelikle formun newlenmesini sağlıyoruz. 

        
        Formlar.FrmUrunListeleme frmUrunListeleme;
        Formlar.FrmYeniUrun frmYeniUrun;
        Formlar.FrmKategoriListesi frmKategoriListesi;
        Formlar.FrmKategoriEkle frmKategoriEkle;
        Formlar.FrmIstatistik frmIstatistik;

        private void btnUrunListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {              
            if (frmUrunListeleme == null || frmUrunListeleme.IsDisposed)
            {
                frmUrunListeleme = new Formlar.FrmUrunListeleme();
                frmUrunListeleme.MdiParent = this;
                frmUrunListeleme.Show();
            }
        }

        private void btnYenıUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmYeniUrun== null || frmYeniUrun.IsDisposed)
            {
                frmYeniUrun = new Formlar.FrmYeniUrun();
                //frmYeniUrun.MdiParent = this;
                frmYeniUrun.Show();
            }
        }

        private void btnKategoriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKategoriListesi == null || frmKategoriListesi.IsDisposed)
            {
                frmKategoriListesi = new Formlar.FrmKategoriListesi();
                frmKategoriListesi.MdiParent = this;
                frmKategoriListesi.Show();
            }
        }

        private void btnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKategoriEkle== null || frmKategoriEkle.IsDisposed)
            {
                frmKategoriEkle = new Formlar.FrmKategoriEkle();
                frmKategoriEkle.Show();
            }
        }

        private void btnIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmIstatistik == null || frmIstatistik.IsDisposed)
            {
                frmIstatistik  = new Formlar.FrmIstatistik();
                frmIstatistik.MdiParent = this;
                frmIstatistik.Show();
            }
        }
    }
}
