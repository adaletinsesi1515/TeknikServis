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

        private void btnUrunListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmUrunListeleme fr = new Formlar.FrmUrunListeleme();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}
