using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parcial1Ap1_SeatielY
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void registroEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rEmpleados re = new UI.Registros.rEmpleados();
            re.Show();
        }

        private void consultasEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Consultas.cEmpleados ce = new UI.Consultas.cEmpleados();
            ce.Show();
        }
    }
}
