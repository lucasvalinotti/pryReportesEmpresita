using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryReportesEmpresita
{
    public partial class Form1 : Form
    {
        DataTable tablaEmpleados = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            Empleado empleado = new Empleado();
            tablaEmpleados = empleado.GetData();
        }

        private void cargarDatosAlReporte() 
        {
            List<EmpleadoDetalle> detalles = new List<EmpleadoDetalle>();
            foreach (DataRow item in tablaEmpleados.Rows)
            {
                EmpleadoDetalle detalleEmpleado = new EmpleadoDetalle();
                detalleEmpleado.EmpleadoID = int.Parse(item["EmpleadoID"].ToString());
                detalleEmpleado.Nombre = (string)item["Nombre"];
                detalleEmpleado.Sector = (string)item["Sector"];
                detalles.Add(detalleEmpleado);
            }

            // Crear Objeto Report Data Source
            ReportDataSource rds = new ReportDataSource("DataSetEmpleados", detalles);
            // Asignar reporte diseñado al report viewer (esto se hace si no lo agregue desde el form o si quiero cambiar el reporte).
            //reportViewer1.LocalReport.ReportEmbeddedResource = "pryReportesEmpresita.informeEmpleados.rdlc";
            // Borro los data source que pueda tener el report viewer
            reportViewer1.LocalReport.DataSources.Clear();
            // Agrego el data source que cree
            reportViewer1.LocalReport.DataSources.Add(rds);
            // Refrescar la vista del report viewer
            this.reportViewer1.RefreshReport();

        }

        private void cmdGenerarReporte_Click(object sender, EventArgs e)
        {
            cargarDatosAlReporte();
        }
    }
}
