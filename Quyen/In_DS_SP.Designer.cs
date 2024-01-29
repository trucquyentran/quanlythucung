namespace Quyen
{
	partial class In_DS_SP
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
            this.HOA_DONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLTCDataSet = new Quyen.QLTCDataSet();
            this.SAN_PHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SAN_PHAMTableAdapter = new Quyen.QLTCDataSetTableAdapters.SAN_PHAMTableAdapter();
            this.DICH_VUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DICH_VUTableAdapter = new Quyen.QLTCDataSetTableAdapters.DICH_VUTableAdapter();
            this.ChamSocThuCungDataSet = new Quyen.ChamSocThuCungDataSet();
            this.SanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SanPhamTableAdapter = new Quyen.ChamSocThuCungDataSetTableAdapters.SanPhamTableAdapter();
            this.HOA_DONTableAdapter = new Quyen.QLTCDataSetTableAdapters.HOA_DONTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.HOA_DONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SAN_PHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DICH_VUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChamSocThuCungDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).BeginInit();
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
            // SAN_PHAMBindingSource
            // 
            this.SAN_PHAMBindingSource.DataMember = "SAN_PHAM";
            this.SAN_PHAMBindingSource.DataSource = this.QLTCDataSet;
            // 
            // SAN_PHAMTableAdapter
            // 
            this.SAN_PHAMTableAdapter.ClearBeforeFill = true;
            // 
            // DICH_VUBindingSource
            // 
            this.DICH_VUBindingSource.DataMember = "DICH_VU";
            this.DICH_VUBindingSource.DataSource = this.QLTCDataSet;
            // 
            // DICH_VUTableAdapter
            // 
            this.DICH_VUTableAdapter.ClearBeforeFill = true;
            // 
            // ChamSocThuCungDataSet
            // 
            this.ChamSocThuCungDataSet.DataSetName = "ChamSocThuCungDataSet";
            this.ChamSocThuCungDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SanPhamBindingSource
            // 
            this.SanPhamBindingSource.DataMember = "SanPham";
            this.SanPhamBindingSource.DataSource = this.ChamSocThuCungDataSet;
            // 
            // SanPhamTableAdapter
            // 
            this.SanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // HOA_DONTableAdapter
            // 
            this.HOA_DONTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "SanPham";
            reportDataSource1.Value = this.SanPhamBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quyen.Report_DSSP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1249, 452);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // In_DS_SP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "In_DS_SP";
            this.Text = "In_DS_SP";
            this.Load += new System.EventHandler(this.In_DS_SP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HOA_DONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SAN_PHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DICH_VUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChamSocThuCungDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource SAN_PHAMBindingSource;
		private QLTCDataSet QLTCDataSet;
		private QLTCDataSetTableAdapters.SAN_PHAMTableAdapter SAN_PHAMTableAdapter;
        private System.Windows.Forms.BindingSource DICH_VUBindingSource;
        private QLTCDataSetTableAdapters.DICH_VUTableAdapter DICH_VUTableAdapter;
        private System.Windows.Forms.BindingSource SanPhamBindingSource;
        private ChamSocThuCungDataSet ChamSocThuCungDataSet;
        private ChamSocThuCungDataSetTableAdapters.SanPhamTableAdapter SanPhamTableAdapter;
        private System.Windows.Forms.BindingSource HOA_DONBindingSource;
        private QLTCDataSetTableAdapters.HOA_DONTableAdapter HOA_DONTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}