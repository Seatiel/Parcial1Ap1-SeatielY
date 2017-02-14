using Parcial1Ap1_SeatielY.DAL;
using Parcial1Ap1_SeatielY.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Parcial1Ap1_SeatielY.BLL
{
    public class EmpleadosBLL
    {
        public static bool Guardar(Empleados empleado)
        {
            bool retorno = false;
            using (var db = new Parcial1Ap1Db())
            {
                try
                {
                    db.Empleado.Add(empleado);
                    db.SaveChanges();
                    retorno = true;
                }
                catch (Exception)
                {
                    throw;
                }
                return retorno;
            }
        }

        public static bool Modificar(Empleados empleado)
        {
            bool retorno = false;
            using (var db = new Parcial1Ap1Db())
            {
                try
                {
                    if (Buscar(empleado.EmpleadoId) == null)
                        db.Empleado.Add(empleado);
                    else
                        db.Entry(empleado).State = EntityState.Modified;
                    db.SaveChanges();
                    retorno = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return retorno;
            }
        }

        public static bool Eliminar(Empleados empleados)
        {
            bool retorno = false;
            using (var db = new Parcial1Ap1Db())
            {
                try
                {
                    db.Entry(empleados).State = EntityState.Deleted;
                    db.SaveChanges();
                    retorno = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return retorno;
            }
        }

        public static Empleados Buscar(int id)
        {
            var empleado = new Empleados();
            using (var db = new Parcial1Ap1Db())
            {
                try
                {
                    empleado = db.Empleado.Find(id);
                }
                catch (Exception)
                {

                    throw;
                }
                return empleado;
            }
        }

        public static List<Empleados> GetList()
        {
            List<Empleados> lista = new List<Empleados>();
            using (var db = new Parcial1Ap1Db())
            {
                try
                {
                    if (db.Empleado.ToList().Count > 0)
                    {
                        lista = db.Empleado.ToList();
                    }
                    else
                    {
                        lista = null;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }

        public static List<Empleados> GetListNombre(string nombre)
        {
            List<Empleados> lista = new List<Empleados>();
            using (var db = new Parcial1Ap1Db())
            {
                try
                {
                    lista = db.Empleado.Where(p => p.Nombre == nombre).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }

        public static List<Empleados> GetListFecha(DateTime desde, DateTime hasta)
        {
            List<Empleados> lista = new List<Empleados>();
            using (var db = new Parcial1Ap1Db())
            {
                try
                {
                    lista = db.Empleado.Where(p => p.Fecha >= desde.Date && p.Fecha <= hasta).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }

    }
}
