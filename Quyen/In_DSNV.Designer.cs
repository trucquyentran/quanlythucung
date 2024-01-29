namespace Quyen
{
	partial class In_DSNV
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
            this.NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChamSocThuCungDataSet = new Quyen.ChamSocThuCungDataSet();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NHAN_VIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLTCDataSet = new Quyen.QLTCDataSet();
            this.CHITIET_HDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CHITIET_HDTableAdapter = new Quyen.QLTCDataSetTableAdapters.CHITIET_HDTableAdapter();
            this.NHAN_VIENTableAdapter = new Quyen.QLTCDataSetTableAdapters.NHAN_VIENTableAdapter();
            this.THU_CUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.THU_CUNGTableAdapter = new Quyen.QLTCDataSetTableAdapters.THU_CUNGTableAdapter();
            this.NhanVienTableAdapter = new Quyen.ChamSocThuCungDataSetTableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChamSocThuCungDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHAN_VIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHITIET_HDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.THU_CUNGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NhanVienBindingSource
            // 
            this.NhanVienBindingSource.DataMember = "NhanVien";
            this.NhanVienBindingSource.DataSource = this.ChamSocThuCungDataSet;
            // 
            // ChamSocThuCungDataSet
            // 
            this.ChamSocThuCungDataSet.DataSetName = "ChamSocThuCungDataSet";
            this.ChamSocThuCungDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "NhanVien";
            reportDataSource1.Value = this.NhanVienBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Quyen.Report_DS_NV.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1370, 457);
            this.reportViewer2.TabIndex = 2;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // NHAN_VIENBindingSource
            // 
            this.NHAN_VIENBindingSource.DataMember = "NHAN_VIEN";
            this.NHAN_VIENBindingSource.DataSource = this.QLTCDataSet;
            // 
            // QLTCDataSet
            // 
            this.QLTCDataSet.DataSetName = "QLTCDataSet";
            this.QLTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CHITIET_HDBindingSource
            // 
            this.CHITIET_HDBindingSource.DataMember = "CHITIET_HD";
            this.CHITIET_HDBindingSource.DataSource = this.QLTCDataSet;
            // 
            // CHITIET_HDTableAdapter
            // 
            this.CHITIET_HDTableAdapter.ClearBeforeFill = true;
            // 
            // NHAN_VIENTableAdapter
            // 
            this.NHAN_VIENTableAdapter.ClearBeforeFill = true;
            // 
            // THU_CUNGBindingSource
            // 
            this.THU_CUNGBindingSource.DataMember = "THU_CUNG";
            this.THU_CUNGBindingSource.DataSource = this.QLTCDataSet;
            // 
            // THU_CUNGTableAdapter
            // 
            this.THU_CUNGTableAdapter.ClearBeforeFill = true;
            // 
            // NhanVienTableAdapter
            // 
            this.NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // In_DSNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.reportViewer2);
            this.Name = "In_DSNV";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChamSocThuCungDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHAN_VIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHITIET_HDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.THU_CUNGBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
		private System.Windows.Forms.BindingSource CHITIET_HDBindingSource;
		private QLTCDataSet QLTCDataSet;
		private QLTCDataSetTableAdapters.CHITIET_HDTableAdapter CHITIET_HDTableAdapter;
		private System.Windows.Forms.BindingSource NHAN_VIENBindingSource;
		private QLTCDataSetTableAdapters.NHAN_VIENTableAdapter NHAN_VIENTableAdapter;
        private System.Windows.Forms.BindingSource THU_CUNGBindingSource;
        private QLTCDataSetTableAdapters.THU_CUNGTableAdapter THU_CUNGTableAdapter;
        private System.Windows.Forms.BindingSource NhanVienBindingSource;
        private ChamSocThuCungDataSet ChamSocThuCungDataSet;
        private ChamSocThuCungDataSetTableAdapters.NhanVienTableAdapter NhanVienTableAdapter;
    }
}