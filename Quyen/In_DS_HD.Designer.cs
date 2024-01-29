namespace Quyen
{
	partial class In_DS_HD
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.HOA_DONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLTCDataSet = new Quyen.QLTCDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HOA_DONTableAdapter = new Quyen.QLTCDataSetTableAdapters.HOA_DONTableAdapter();
            this.ChamSocThuCungDataSet = new Quyen.ChamSocThuCungDataSet();
            this.DichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DichVuTableAdapter = new Quyen.ChamSocThuCungDataSetTableAdapters.DichVuTableAdapter();
            this.KhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KhachHangTableAdapter = new Quyen.ChamSocThuCungDataSetTableAdapters.KhachHangTableAdapter();
            this.ChamSocThuCungDataSet1 = new Quyen.ChamSocThuCungDataSet1();
            this.HoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HoaDonTableAdapter = new Quyen.ChamSocThuCungDataSet1TableAdapters.HoaDonTableAdapter();
            this.ChiTietHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChiTietHDTableAdapter = new Quyen.ChamSocThuCungDataSet1TableAdapters.ChiTietHDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HOA_DONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChamSocThuCungDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DichVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChamSocThuCungDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HOA_DONBindingSource
            // 
            this.HOA_DONBindingSource.DataMember = "HOA_DON";
            this.HOA_DONBindingSource.DataSource = this.QLTCDataSet;
            // 
            // QLTCDataSet
            // 
            this.QLTCDataSet.DataSetName = "QLTCDataSet";
            this.QLTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "HoaDon";
            reportDataSource1.Value = this.HoaDonBindingSource;
            reportDataSource2.Name = "ChiTietHD";
            reportDataSource2.Value = this.ChiTietHDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quyen.Report_DSHD.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1205, 438);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // HOA_DONTableAdapter
            // 
            this.HOA_DONTableAdapter.ClearBeforeFill = true;
            // 
            // ChamSocThuCungDataSet
            // 
            this.ChamSocThuCungDataSet.DataSetName = "ChamSocThuCungDataSet";
            this.ChamSocThuCungDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DichVuBindingSource
            // 
            this.DichVuBindingSource.DataMember = "DichVu";
            this.DichVuBindingSource.DataSource = this.ChamSocThuCungDataSet;
            // 
            // DichVuTableAdapter
            // 
            this.DichVuTableAdapter.ClearBeforeFill = true;
            // 
            // KhachHangBindingSource
            // 
            this.KhachHangBindingSource.DataMember = "KhachHang";
            this.KhachHangBindingSource.DataSource = this.ChamSocThuCungDataSet;
            // 
            // KhachHangTableAdapter
            // 
            this.KhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // ChamSocThuCungDataSet1
            // 
            this.ChamSocThuCungDataSet1.DataSetName = "ChamSocThuCungDataSet1";
            this.ChamSocThuCungDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HoaDonBindingSource
            // 
            this.HoaDonBindingSource.DataMember = "HoaDon";
            this.HoaDonBindingSource.DataSource = this.ChamSocThuCungDataSet1;
            // 
            // HoaDonTableAdapter
            // 
            this.HoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // ChiTietHDBindingSource
            // 
            this.ChiTietHDBindingSource.DataMember = "ChiTietHD";
            this.ChiTietHDBindingSource.DataSource = this.ChamSocThuCungDataSet1;
            // 
            // ChiTietHDTableAdapter
            // 
            this.ChiTietHDTableAdapter.ClearBeforeFill = true;
            // 
            // In_DS_HD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 500);
            this.Controls.Add(this.reportViewer1);
            this.Name = "In_DS_HD";
            this.Text = "In_DS_HD";
            this.Load += new System.EventHandler(this.In_DS_HD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HOA_DONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChamSocThuCungDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DichVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChamSocThuCungDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHDBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource HOA_DONBindingSource;
		private QLTCDataSet QLTCDataSet;
		private QLTCDataSetTableAdapters.HOA_DONTableAdapter HOA_DONTableAdapter;
        private System.Windows.Forms.BindingSource DichVuBindingSource;
        private ChamSocThuCungDataSet ChamSocThuCungDataSet;
        private ChamSocThuCungDataSetTableAdapters.DichVuTableAdapter DichVuTableAdapter;
        private System.Windows.Forms.BindingSource KhachHangBindingSource;
        private ChamSocThuCungDataSetTableAdapters.KhachHangTableAdapter KhachHangTableAdapter;
        private System.Windows.Forms.BindingSource HoaDonBindingSource;
        private ChamSocThuCungDataSet1 ChamSocThuCungDataSet1;
        private System.Windows.Forms.BindingSource ChiTietHDBindingSource;
        private ChamSocThuCungDataSet1TableAdapters.HoaDonTableAdapter HoaDonTableAdapter;
        private ChamSocThuCungDataSet1TableAdapters.ChiTietHDTableAdapter ChiTietHDTableAdapter;
    }
}