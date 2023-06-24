using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
    public static class DAL_RolPermisos
    {
        public static RoldePermisos Insert(RoldePermisos Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                bd.RolPermisos.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(RoldePermisos Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                var Registro = bd.RolPermisos.Find(Entidad.IdRolPermiso);
                Registro.IdRol = Entidad.IdRol;
                Registro.IdPermiso = Entidad.IdPermiso;
                Registro.IdRolForumulario = Entidad.IdRolForumulario;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Anular(RoldePermisos Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                var Registro = bd.RolPermisos.Find(Entidad.IdRolPermiso);
                Registro.Activo = Entidad.Activo;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Existe(RoldePermisos Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                return bd.RolPermisos.Where(a => a.IdRolPermiso == Entidad.IdRolPermiso).Count() > 0;
            }
        }
        public static RoldePermisos Registro(RoldePermisos Entidad)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                return bd.RolPermisos.Where(a => a.IdRolPermiso == Entidad.IdRolPermiso).SingleOrDefault();
            }
        }
        public static List<RoldePermisos> Lista(bool Activo = true)
        {
            using (BDMPOO bd = new BDMPOO())
            {
                return bd.RolPermisos.Where(a => a.Activo == Activo).ToList();
            }
        }
    }
}

