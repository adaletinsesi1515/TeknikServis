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
    }
}
