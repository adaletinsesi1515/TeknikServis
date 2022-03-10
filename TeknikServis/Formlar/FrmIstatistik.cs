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
            var sorgu1 = db.TBLURUN.Count();
            lblToplamUrunSayisi.Text = sorgu1.ToString();

            var sorgu2 = db.TBLKATEGORI.Count();
            lblToplamKategoriSayisi.Text = sorgu2.ToString();

        }
    }
}
