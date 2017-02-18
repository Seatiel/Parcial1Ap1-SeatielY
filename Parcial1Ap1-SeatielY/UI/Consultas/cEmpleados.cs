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

        private void cEmpleados_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(FiltartextBox.Text))
            {
                FiltrarerrorProvider.SetError(FiltartextBox, "Por favor llenar campos.");
                return true;
            }
            return false;
        }

        public void LlenarCombo()
        {
            FiltrarcomboBox.Items.Insert(0, "Todos");
            FiltrarcomboBox.Items.Insert(1, "Nombre");
            FiltrarcomboBox.Items.Insert(2, "Fecha");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Todos";
        }

        public void FiltrarOpcion()
        {
            using (var db = new Repositorio<Empleados>())
            {
                if (FiltrarcomboBox.SelectedIndex == 0)
                {
                    EmpleadosdataGridView.DataSource = db.GetListAll();
                }
                if (FiltrarcomboBox.SelectedIndex == 1)
                {
                    EmpleadosdataGridView.DataSource = db.GetList(em => em.Nombre == FiltartextBox.Text);
                }
                if (FiltrarcomboBox.SelectedIndex == 2)
                {
                    if (DesdedateTimePicker.Value.Date <= HastadateTimePicker.Value.Date)
                    {
                        EmpleadosdataGridView.DataSource = db.GetList(em => em.Fecha >= DesdedateTimePicker.Value.Date && em.Fecha <= HastadateTimePicker.Value.Date);
                    }
                }                
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            FiltrarOpcion();
        }                
    }
}
