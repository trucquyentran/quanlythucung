namespace Quyen
{
	partial class In_DSKH
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
            this.KHACH_HANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLTCDataSet = new Quyen.QLTCDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KHACH_HANGTableAdapter = new Quyen.QLTCDataSetTableAdapters.KHACH_HANGTableAdapter();
            this.ChamSocThuCungDataSet = new Quyen.ChamSocThuCungDataSet();
            this.NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NhanVienTableAdapter = new Quyen.ChamSocThuCungDataSetTableAdapters.NhanVienTableAdapter();
            this.KhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KhachHangTableAdapter = new Quyen.ChamSocThuCungDataSetTableAdapters.KhachHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KHACH_HANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChamSocThuCungDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // KHACH_HANGBindingSource
            // 
            this.KHACH_HANGBindingSource.DataMember = "KHACH_HANG";
            this.KHACH_HANGBindingSource.DataSource = this.QLTCDataSet;
            // 
            // QLTCDataSet
            // 
            this.QLTCDataSet.DataSetName = "QLTCDataSet";
            this.QLTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "KhachHang";
            reportDataSource1.Value = this.KhachHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quyen.Report_DS_KH.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(993, 419);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // KHACH_HANGTableAdapter
            // 
            this.KHACH_HANGTableAdapter.ClearBeforeFill = true;
            // 
            // ChamSocThuCungDataSet
            // 
            this.ChamSocThuCungDataSet.DataSetName = "ChamSocThuCungDataSet";
            this.ChamSocThuCungDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NhanVienBindingSource
            // 
            this.NhanVienBindingSource.DataMember = "NhanVien";
            this.NhanVienBindingSource.DataSource = this.ChamSocThuCungDataSet;
            // 
            // NhanVienTableAdapter
            // 
            this.NhanVienTableAdapter.ClearBeforeFill = true;
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
            // In_DSKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 500);
            this.Controls.Add(this.reportViewer1);
            this.Name = "In_DSKH";
            this.Text = "In_DSKH";
            this.Load += new System.EventHandler(this.In_DSKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KHACH_HANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChamSocThuCungDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource KHACH_HANGBindingSource;
		private QLTCDataSet QLTCDataSet;
		private QLTCDataSetTableAdapters.KHACH_HANGTableAdapter KHACH_HANGTableAdapter;
        private System.Windows.Forms.BindingSource NhanVienBindingSource;
        private ChamSocThuCungDataSet ChamSocThuCungDataSet;
        private ChamSocThuCungDataSetTableAdapters.NhanVienTableAdapter NhanVienTableAdapter;
        private System.Windows.Forms.BindingSource KhachHangBindingSource;
        private ChamSocThuCungDataSetTableAdapters.KhachHangTableAdapter KhachHangTableAdapter;
    }
}