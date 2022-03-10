
namespace TeknikServis.Formlar
{
    partial class FrmKategoriEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKategoriEkle));
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtKategoriAd = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKategoriAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(129, 82);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(135, 49);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.EditValue = "KATEGORİ ADI";
            this.txtKategoriAd.Location = new System.Drawing.Point(88, 54);
            this.txtKategoriAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.txtKategoriAd.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKategoriAd.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtKategoriAd.Properties.Appearance.Options.UseBackColor = true;
            this.txtKategoriAd.Properties.Appearance.Options.UseFont = true;
            this.txtKategoriAd.Properties.Appearance.Options.UseForeColor = true;
            this.txtKategoriAd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.txtKategoriAd.Size = new System.Drawing.Size(224, 24);
            this.txtKategoriAd.TabIndex = 8;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(35, 37);
            this.pictureEdit3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(48, 52);
            this.pictureEdit3.TabIndex = 9;
            // 
            // FrmKategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(350, 167);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtKategoriAd);
            this.Controls.Add(this.pictureEdit3);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKategoriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.txtKategoriAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtKategoriAd;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
    }
}