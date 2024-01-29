namespace Quyen
{
	partial class In_DS_TC
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
            this.THU_CUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLTCDataSet = new Quyen.QLTCDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.THU_CUNGTableAdapter = new Quyen.QLTCDataSetTableAdapters.THU_CUNGTableAdapter();
            this.DICH_VUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DICH_VUTableAdapter = new Quyen.QLTCDataSetTableAdapters.DICH_VUTableAdapter();
            this.ChamSocThuCungDataSet = new Quyen.ChamSocThuCungDataSet();
            this.ThuCungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThuCungTableAdapter = new Quyen.ChamSocThuCungDataSetTableAdapters.ThuCungTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.THU_CUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DICH_VUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChamSocThuCungDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuCungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // THU_CUNGBindingSource
            // 
            this.THU_CUNGBindingSource.DataMember = "THU_CUNG";
            this.THU_CUNGBindingSource.DataSource = this.QLTCDataSet;
            // 
            // QLTCDataSet
            // 
            this.QLTCDataSet.DataSetName = "QLTCDataSet";
            this.QLTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ThuCung";
            reportDataSource1.Value = this.ThuCungBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quyen.Report_DS_TC.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1263, 447);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // THU_CUNGTableAdapter
            // 
            this.THU_CUNGTableAdapter.ClearBeforeFill = true;
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
            // ThuCungBindingSource
            // 
            this.ThuCungBindingSource.DataMember = "ThuCung";
            this.ThuCungBindingSource.DataSource = this.ChamSocThuCungDataSet;
            // 
            // ThuCungTableAdapter
            // 
            this.ThuCungTableAdapter.ClearBeforeFill = true;
            // 
            // In_DS_TC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 494);
            this.Controls.Add(this.reportViewer1);
            this.Name = "In_DS_TC";
            this.Text = "In_DS_TC";
            this.Load += new System.EventHandler(this.In_DS_TC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.THU_CUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DICH_VUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChamSocThuCungDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuCungBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource THU_CUNGBindingSource;
		private QLTCDataSet QLTCDataSet;
		private QLTCDataSetTableAdapters.THU_CUNGTableAdapter THU_CUNGTableAdapter;
        private System.Windows.Forms.BindingSource DICH_VUBindingSource;
        private QLTCDataSetTableAdapters.DICH_VUTableAdapter DICH_VUTableAdapter;
        private System.Windows.Forms.BindingSource ThuCungBindingSource;
        private ChamSocThuCungDataSet ChamSocThuCungDataSet;
        private ChamSocThuCungDataSetTableAdapters.ThuCungTableAdapter ThuCungTableAdapter;
    }
}