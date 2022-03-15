
namespace TeknikServis.Formlar
{
    partial class FrmMarkalar
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarkalar));
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Doughnut3DSeriesView doughnut3DSeriesView1 = new DevExpress.XtraCharts.Doughnut3DSeriesView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblToplamUrunSayisi = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEnFazlaUrunuMarka = new DevExpress.XtraEditors.LabelControl();
            this.marka1 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblToplamMarkaSayisi = new DevExpress.XtraEditors.LabelControl();
            this.Marka = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblEnYuksekUrunuMarka = new DevExpress.XtraEditors.LabelControl();
            this.MARKA2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnut3DSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(383, 611);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Silver;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblToplamUrunSayisi);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(400, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 150);
            this.panel1.TabIndex = 4;
            // 
            // lblToplamUrunSayisi
            // 
            this.lblToplamUrunSayisi.Appearance.Font = new System.Drawing.Font("Verdana", 30F);
            this.lblToplamUrunSayisi.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblToplamUrunSayisi.Appearance.Options.UseFont = true;
            this.lblToplamUrunSayisi.Appearance.Options.UseForeColor = true;
            this.lblToplamUrunSayisi.Location = new System.Drawing.Point(19, 60);
            this.lblToplamUrunSayisi.Margin = new System.Windows.Forms.Padding(2);
            this.lblToplamUrunSayisi.Name = "lblToplamUrunSayisi";
            this.lblToplamUrunSayisi.Size = new System.Drawing.Size(75, 48);
            this.lblToplamUrunSayisi.TabIndex = 1;
            this.lblToplamUrunSayisi.Text = "584";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(19, 19);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(139, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Toplam Ürün Sayısı";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(233)))), ((int)(((byte)(148)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblEnFazlaUrunuMarka);
            this.panel2.Controls.Add(this.marka1);
            this.panel2.Location = new System.Drawing.Point(864, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 150);
            this.panel2.TabIndex = 5;
            // 
            // lblEnFazlaUrunuMarka
            // 
            this.lblEnFazlaUrunuMarka.Appearance.Font = new System.Drawing.Font("Verdana", 30F);
            this.lblEnFazlaUrunuMarka.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblEnFazlaUrunuMarka.Appearance.Options.UseFont = true;
            this.lblEnFazlaUrunuMarka.Appearance.Options.UseForeColor = true;
            this.lblEnFazlaUrunuMarka.Location = new System.Drawing.Point(19, 60);
            this.lblEnFazlaUrunuMarka.Margin = new System.Windows.Forms.Padding(2);
            this.lblEnFazlaUrunuMarka.Name = "lblEnFazlaUrunuMarka";
            this.lblEnFazlaUrunuMarka.Size = new System.Drawing.Size(75, 48);
            this.lblEnFazlaUrunuMarka.TabIndex = 1;
            this.lblEnFazlaUrunuMarka.Text = "584";
            // 
            // marka1
            // 
            this.marka1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.marka1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.marka1.Appearance.Options.UseFont = true;
            this.marka1.Appearance.Options.UseForeColor = true;
            this.marka1.Location = new System.Drawing.Point(19, 19);
            this.marka1.Margin = new System.Windows.Forms.Padding(2);
            this.marka1.Name = "marka1";
            this.marka1.Size = new System.Drawing.Size(192, 19);
            this.marka1.TabIndex = 0;
            this.marka1.Text = "En Fazla Ürünü Olan Marka";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(47)))), ((int)(((byte)(6)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblToplamMarkaSayisi);
            this.panel3.Controls.Add(this.Marka);
            this.panel3.Location = new System.Drawing.Point(632, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 150);
            this.panel3.TabIndex = 5;
            // 
            // lblToplamMarkaSayisi
            // 
            this.lblToplamMarkaSayisi.Appearance.Font = new System.Drawing.Font("Verdana", 30F);
            this.lblToplamMarkaSayisi.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblToplamMarkaSayisi.Appearance.Options.UseFont = true;
            this.lblToplamMarkaSayisi.Appearance.Options.UseForeColor = true;
            this.lblToplamMarkaSayisi.Location = new System.Drawing.Point(19, 60);
            this.lblToplamMarkaSayisi.Margin = new System.Windows.Forms.Padding(2);
            this.lblToplamMarkaSayisi.Name = "lblToplamMarkaSayisi";
            this.lblToplamMarkaSayisi.Size = new System.Drawing.Size(75, 48);
            this.lblToplamMarkaSayisi.TabIndex = 1;
            this.lblToplamMarkaSayisi.Text = "584";
            // 
            // Marka
            // 
            this.Marka.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Marka.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Marka.Appearance.Options.UseFont = true;
            this.Marka.Appearance.Options.UseForeColor = true;
            this.Marka.Location = new System.Drawing.Point(19, 19);
            this.Marka.Margin = new System.Windows.Forms.Padding(2);
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(146, 19);
            this.Marka.TabIndex = 0;
            this.Marka.Text = "Toplam Marka Sayısı";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblEnYuksekUrunuMarka);
            this.panel4.Controls.Add(this.MARKA2);
            this.panel4.Location = new System.Drawing.Point(1098, 11);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 150);
            this.panel4.TabIndex = 6;
            // 
            // lblEnYuksekUrunuMarka
            // 
            this.lblEnYuksekUrunuMarka.Appearance.Font = new System.Drawing.Font("Verdana", 30F);
            this.lblEnYuksekUrunuMarka.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblEnYuksekUrunuMarka.Appearance.Options.UseFont = true;
            this.lblEnYuksekUrunuMarka.Appearance.Options.UseForeColor = true;
            this.lblEnYuksekUrunuMarka.Location = new System.Drawing.Point(19, 60);
            this.lblEnYuksekUrunuMarka.Margin = new System.Windows.Forms.Padding(2);
            this.lblEnYuksekUrunuMarka.Name = "lblEnYuksekUrunuMarka";
            this.lblEnYuksekUrunuMarka.Size = new System.Drawing.Size(75, 48);
            this.lblEnYuksekUrunuMarka.TabIndex = 1;
            this.lblEnYuksekUrunuMarka.Text = "584";
            // 
            // MARKA2
            // 
            this.MARKA2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.MARKA2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.MARKA2.Appearance.Options.UseFont = true;
            this.MARKA2.Appearance.Options.UseForeColor = true;
            this.MARKA2.Location = new System.Drawing.Point(19, 19);
            this.MARKA2.Margin = new System.Windows.Forms.Padding(2);
            this.MARKA2.Name = "MARKA2";
            this.MARKA2.Size = new System.Drawing.Size(166, 19);
            this.MARKA2.TabIndex = 0;
            this.MARKA2.Text = "En Yüksek Fiyatlı Marka";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chartControl1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(402, 177);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(460, 446);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "İstatistik - Grafik";
            // 
            // chartControl1
            // 
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(5, 151);
            this.chartControl1.Name = "chartControl1";
            series1.LegendTextPattern = "{A}";
            series1.Name = "Series 1";
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(450, 290);
            this.chartControl1.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(29, 60);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(394, 85);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = resources.GetString("labelControl3.Text");
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(125, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(201, 28);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Marka ve İstatistikler";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.chartControl2);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Location = new System.Drawing.Point(868, 177);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(460, 300);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "groupControl2";
            // 
            // groupControl3
            // 
            this.groupControl3.Location = new System.Drawing.Point(868, 483);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(460, 140);
            this.groupControl3.TabIndex = 9;
            this.groupControl3.Text = "groupControl3";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(29, 60);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(411, 34);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Sistemimizde bir ürün giriş ve ürün takibi hem masaüstü hem de kargo \r\nnoktasında" +
    " web tarafından yapılabilmektedir. \r\n";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(125, 26);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(186, 28);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Ürün ve Kategoriler";
            // 
            // chartControl2
            // 
            simpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1";
            this.chartControl2.Diagram = simpleDiagram3D1;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Location = new System.Drawing.Point(5, 151);
            this.chartControl2.Name = "chartControl2";
            series2.Name = "Kategoriler";
            series2.View = doughnut3DSeriesView1;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl2.Size = new System.Drawing.Size(450, 144);
            this.chartControl2.TabIndex = 3;
            // 
            // FrmMarkalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 635);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmMarkalar";
            this.Text = "Marka İstatistikleri";
            this.Load += new System.EventHandler(this.FrmMarkalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnut3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblToplamUrunSayisi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblEnFazlaUrunuMarka;
        private DevExpress.XtraEditors.LabelControl marka1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl lblToplamMarkaSayisi;
        private DevExpress.XtraEditors.LabelControl Marka;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl lblEnYuksekUrunuMarka;
        private DevExpress.XtraEditors.LabelControl MARKA2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}