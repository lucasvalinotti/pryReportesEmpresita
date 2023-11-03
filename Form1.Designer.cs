namespace pryReportesEmpresita
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmdGenerarReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "pryReportesEmpresita.informeEmpleados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 65);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 373);
            this.reportViewer1.TabIndex = 0;
            // 
            // cmdGenerarReporte
            // 
            this.cmdGenerarReporte.Location = new System.Drawing.Point(12, 12);
            this.cmdGenerarReporte.Name = "cmdGenerarReporte";
            this.cmdGenerarReporte.Size = new System.Drawing.Size(158, 36);
            this.cmdGenerarReporte.TabIndex = 1;
            this.cmdGenerarReporte.Text = "Generar Reporte";
            this.cmdGenerarReporte.UseVisualStyleBackColor = true;
            this.cmdGenerarReporte.Click += new System.EventHandler(this.cmdGenerarReporte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdGenerarReporte);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button cmdGenerarReporte;
    }
}

