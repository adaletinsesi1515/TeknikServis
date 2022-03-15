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
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        void listele()
        {
            var deger = db.TBLURUN.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            });
            gridControl1.DataSource = deger.ToList();

        }
        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            listele();
            lblToplamUrunSayisi.Text = db.TBLURUN.Count().ToString();
            lblToplamMarkaSayisi.Text = (from x in db.TBLURUN
                                         select x.MARKA
                                       ).Distinct().Count().ToString();

            lblEnFazlaUrunuMarka.Text= (from x in db.TBLURUN
                                        orderby x.STOK descending
                                        select x.MARKA).FirstOrDefault();

            lblEnYuksekUrunuMarka.Text = (from x in db.TBLURUN
                                         orderby x.SATISFIYAT descending
                                         select x.MARKA).FirstOrDefault();

            chartControl1.Series["Series 1"].Points.AddPoint("Siemens", 4);

            chartControl2.Series["Kategoriler"].Points.AddPoint("Beyaz Eşya", 2);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Bilgisayar", 4);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Küçük Ev Eşyaları", 6);

        }
    }
}
