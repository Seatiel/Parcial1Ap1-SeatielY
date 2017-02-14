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

namespace Parcial1Ap1_SeatielY.UI.Consultas
{
    public partial class cEmpleados : Form
    {
        public cEmpleados()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (FiltartextBox == null)            
                EmpleadosdataGridView.DataSource = EmpleadosBLL.GetListNombre(FiltartextBox.Text);
            else            
                EmpleadosdataGridView.DataSource = EmpleadosBLL.GetListFecha(DesdedateTimePicker.Value.Date, HastadateTimePicker.Value.Date);
        }
    }
}
