namespace Quyen
{
	partial class In_DS_DV
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
            this.DICH_VUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLTCDataSet = new Quyen.QLTCDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DICH_VUTableAdapter = new Quyen.QLTCDataSetTableAdapters.DICH_VUTableAdapter();
            this.ChamSocThuCungDataSet = new Quyen.ChamSocThuCungDataSet();
            this.ThuCungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThuCungTableAdapter = new Quyen.ChamSocThuCungDataSetTableAdapters.ThuCungTableAdapter();
            this.DichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DichVuTableAdapter = new Quyen.ChamSocThuCungDataSetTableAdapters.DichVuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DICH_VUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChamSocThuCungDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuCungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DichVuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DICH_VUBindingSource
            // 
            this.DICH_VUBindingSource.DataMember = "DICH_VU";
            this.DICH_VUBindingSource.DataSource = this.QLTCDataSet;
            // 
            // QLTCDataSet
            // 
            this.QLTCDataSet.DataSetName = "QLTCDataSet";
            this.QLTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DichVu";
            reportDataSource1.Value = this.DichVuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quyen.Report_DSDV.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1258, 491);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
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
            // ThuCungBindingSource
            // 
            this.ThuCungBindingSource.DataMember = "ThuCung";
            this.ThuCungBindingSource.DataSource = this.ChamSocThuCungDataSet;
            // 
            // ThuCungTableAdapter
            // 
            this.ThuCungTableAdapter.ClearBeforeFill = true;
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
            // In_DS_DV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 500);
            this.Controls.Add(this.reportViewer1);
            this.Name = "In_DS_DV";
            this.Text = "In_DS_DV";
            this.Load += new System.EventHandler(this.In_DS_DV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DICH_VUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChamSocThuCungDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuCungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DichVuBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource DICH_VUBindingSource;
		private QLTCDataSet QLTCDataSet;
		private QLTCDataSetTableAdapters.DICH_VUTableAdapter DICH_VUTableAdapter;
        private System.Windows.Forms.BindingSource ThuCungBindingSource;
        private ChamSocThuCungDataSet ChamSocThuCungDataSet;
        private ChamSocThuCungDataSetTableAdapters.ThuCungTableAdapter ThuCungTableAdapter;
        private System.Windows.Forms.BindingSource DichVuBindingSource;
        private ChamSocThuCungDataSetTableAdapters.DichVuTableAdapter DichVuTableAdapter;
    }
}