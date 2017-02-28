using Microsoft.Reporting.WinForms;
using Parcial1Ap1_SeatielY.BLL;
using Parcial1Ap1_SeatielY.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parcial1Ap1_SeatielY.UI.Reportes
{
    public partial class ReporteEmpleados : Form
    {
        public ReporteEmpleados()
        {
            InitializeComponent();
        }

        private void ReporteEmpleados_Load(object sender, EventArgs e)
        {
            var db = new Repositorio<Empleados>();
            
            this.EmpleadosreportViewer.RefreshReport();

            EmpleadosreportViewer.Reset();
            EmpleadosreportViewer.ProcessingMode = ProcessingMode.Local;
            EmpleadosreportViewer.LocalReport.ReportPath = @"C:\Users\Seatiel\Desktop\Parcial1Ap1-SeatielY\Parcial1Ap1-SeatielY\UI\Reportes\EmpleadosReport.rdlc";
            ReportDataSource source = new ReportDataSource("DataSet", db.GetListAll());
            EmpleadosreportViewer.LocalReport.DataSources.Add(source);

            this.EmpleadosreportViewer.RefreshReport();

        }
    }
}
