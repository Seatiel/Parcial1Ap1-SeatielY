using Parcial1Ap1_SeatielY.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Parcial1Ap1_SeatielY.DAL
{
    public class Parcial1Ap1Db : DbContext 
    {
        public Parcial1Ap1Db() : base("ConStr")
        {

        }

        public DbSet<Empleados> Empleado { get; set; }
    }
}
