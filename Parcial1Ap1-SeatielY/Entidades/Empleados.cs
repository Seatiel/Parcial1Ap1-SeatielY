using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Parcial1Ap1_SeatielY.Entidades
{
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public double Sueldo { get; set; }
    }
}
