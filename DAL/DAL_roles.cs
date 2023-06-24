using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Roles
    {
        public static Roles Insert(Roles Entidad)
        {
            using BDMPOO bd = new();
            Entidad.Activo = true;
            Entidad.FechaRegistro = DateTime.Now;
            bd.Roles.Add(Entidad);
            bd.SaveChanges();
            return Entidad;
        }
        public static bool Update(Roles Entidad)
        {
            using BDMPOO bd = new();
            var Registro = bd.Roles.Find(Entidad.IdRol);
            if (Registro == null)
            {
                return false;
            }
            Registro.Rol = Entidad.Rol;
            Registro.FechaActualizacion = DateTime.Now;
            return bd.SaveChanges() > 0;
        }
        public static bool Delete(Roles Entidad)
        {
            using BDMPOO bd = new();
            var Registro = bd.Roles.Find(Entidad.IdRol);
            if (Registro == null)
            {
                return false;
            }
            Registro.Activo = false;
            Registro.FechaActualizacion = DateTime.Now;
            return bd.SaveChanges() > 0;
        }
        public static Roles Registro(short IdRegistro)
        {
            using BDMPOO bd = new();
            return bd.Roles.Find(IdRegistro);
        }
        public static List<Roles> Listar(bool Activo = true)
        {
            using BDMPOO bd = new();
            return bd.Roles.Where(a => a.Activo == Activo).ToList();
        }
    }
}

