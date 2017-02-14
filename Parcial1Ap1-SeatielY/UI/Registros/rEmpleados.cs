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

namespace Parcial1Ap1_SeatielY.UI.Registros
{
    public partial class rEmpleados : Form
    {
        public rEmpleados()
        {
            InitializeComponent();
        }

        private Empleados LlenarCampos()
        {
            var empleado = new Empleados();
            empleado.Nombre = NombretextBox.Text;
            empleado.Fecha = FechaNacimientodateTimePicker.Value;
            empleado.Sueldo = Utilidades.ToInt(SueldotextBox.Text);
            return empleado;
        }

        public void Limpiar()
        {
            EmpleadoIdtextBox.Clear();
            NombretextBox.Clear();
            FechaNacimientodateTimePicker.Value = DateTime.Today;
            SueldotextBox.Clear();
        }

        public bool Validar()
        {
            bool retorno = true;
            if ((string.IsNullOrEmpty(NombretextBox.Text)) || (string.IsNullOrEmpty(SueldotextBox.Text)))
            {
                NombreerrorProvider.SetError(NombretextBox, "Debe de ingresar el Nombre.");
                SueldoerrorProvider.SetError(SueldotextBox, "Debe de ingresar el Sueldo.");
                retorno = false;
            }
            return retorno;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Empleados empleado = null;
            empleado = LlenarCampos();
            if (!Validar())
            {
                MessageBox.Show("Debe de completar los campos");
            }            
            if (empleado != null)
            {                
                if(EmpleadosBLL.Guardar(empleado)) 
                {
                    MessageBox.Show("El Empleado ha sido Guardado");
                    Limpiar();
                }
                else if (EmpleadosBLL.Modificar(empleado))
                {
                    MessageBox.Show("El Empleado ha sido modificado");
                }
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var empleado = EmpleadosBLL.Buscar(Utilidades.ToInt(EmpleadoIdtextBox.Text));
            if (empleado != null)
            {
                if (EmpleadosBLL.Eliminar(empleado))
                {
                    MessageBox.Show("El Empleado ha sido eliminado");
                    Limpiar();
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EmpleadoIdtextBox.Text))
            {
                var empleado = EmpleadosBLL.Buscar(Utilidades.ToInt(EmpleadoIdtextBox.Text));
                if (empleado != null)
                {
                    NombretextBox.Text = empleado.Nombre;                    
                    FechaNacimientodateTimePicker.Value = empleado.Fecha;
                    SueldotextBox.Text = empleado.Sueldo.ToString();
                }
                else
                {
                    MessageBox.Show("El Empleado no ha sido creado");
                }
            }
        }

    }
}
