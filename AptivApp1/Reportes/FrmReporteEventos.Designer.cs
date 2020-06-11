namespace AptivApp1.Reportes
{
    partial class FrmReporteEventos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DsAptiv = new AptivApp1.Reportes.DsAptiv();
            this.Eventos_ListarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Eventos_ListarTableAdapter = new AptivApp1.Reportes.DsAptivTableAdapters.Eventos_ListarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsAptiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eventos_ListarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DtsEventos";
            reportDataSource1.Value = this.Eventos_ListarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AptivApp1.Reportes.RptEventos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1185, 884);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsAptiv
            // 
            this.DsAptiv.DataSetName = "DsAptiv";
            this.DsAptiv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Eventos_ListarBindingSource
            // 
            this.Eventos_ListarBindingSource.DataMember = "Eventos_Listar";
            this.Eventos_ListarBindingSource.DataSource = this.DsAptiv;
            // 
            // Eventos_ListarTableAdapter
            // 
            this.Eventos_ListarTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 884);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteEventos";
            this.Text = "Reporte de Eventos";
            this.Load += new System.EventHandler(this.FrmReporteEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsAptiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eventos_ListarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Eventos_ListarBindingSource;
        private DsAptiv DsAptiv;
        private DsAptivTableAdapters.Eventos_ListarTableAdapter Eventos_ListarTableAdapter;
    }
}