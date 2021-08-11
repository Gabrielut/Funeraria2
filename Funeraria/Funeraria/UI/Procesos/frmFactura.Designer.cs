
namespace UTN.Winform.Funeraria.UI.Procesos
{
    partial class frmFactura
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.toolTNumFactura = new System.Windows.Forms.ToolTip(this.components);
            this.toolTBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.facturaFinalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetActivo = new UTN.Winform.Funeraria.UI.Reportes.DataSetActivo();
            this.facturaFinalTableAdapter = new UTN.Winform.Funeraria.UI.Reportes.DataSetActivoTableAdapters.FacturaFinalTableAdapter();
            this.PaqueteFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturaFinalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetActivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaqueteFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.label23);
            this.pnlMenu.Controls.Add(this.btnCerrar);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.pnlMenu.Size = new System.Drawing.Size(1101, 51);
            this.pnlMenu.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Goldenrod;
            this.label23.Location = new System.Drawing.Point(429, 11);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(169, 23);
            this.label23.TabIndex = 75;
            this.label23.Text = "Detalle de Factura";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.facturaFinalBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.PaqueteFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UTN.Winform.Funeraria.UI.Procesos.rptReporteFacturaFinal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 57);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1089, 651);
            this.reportViewer1.TabIndex = 3;
            this.reportViewer1.ZoomPercent = 80;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(135)))), ((int)(((byte)(18)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.Location = new System.Drawing.Point(1056, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 31);
            this.btnCerrar.TabIndex = 24;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // facturaFinalBindingSource
            // 
            this.facturaFinalBindingSource.DataMember = "FacturaFinal";
            this.facturaFinalBindingSource.DataSource = this.dataSetActivo;
            // 
            // dataSetActivo
            // 
            this.dataSetActivo.DataSetName = "DataSetActivo";
            this.dataSetActivo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturaFinalTableAdapter
            // 
            this.facturaFinalTableAdapter.ClearBeforeFill = true;
            // 
            // PaqueteFacturaBindingSource
            // 
            this.PaqueteFacturaBindingSource.DataMember = "PaqueteFactura";
            this.PaqueteFacturaBindingSource.DataSource = this.dataSetActivo;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 713);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFactura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturaFinalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetActivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaqueteFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ToolTip toolTNumFactura;
        private System.Windows.Forms.ToolTip toolTBuscar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reportes.DataSetActivo dataSetActivo;
        private System.Windows.Forms.BindingSource facturaFinalBindingSource;
        private Reportes.DataSetActivoTableAdapters.FacturaFinalTableAdapter facturaFinalTableAdapter;
        private System.Windows.Forms.BindingSource PaqueteFacturaBindingSource;
    }
}