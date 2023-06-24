using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
    public static class BLL_RolPermisos
    {
        public static RoldePermisos Insert(RoldePermisos Entidad)
        {
            return DAL_RolPermisos.Insert(Entidad);
        }
        public static bool Update(RoldePermisos Entidad)
        {
            return DAL_RolPermisos.Update(Entidad);
        }
        public static bool Anular(RoldePermisos Entidad)
        {
            return DAL_RolPermisos.Anular(Entidad);
        }
        public static bool Existe(RoldePermisos Entidad)
        {
            return DAL_RolPermisos.Existe(Entidad);
        }
        public static RoldePermisos Registro(RoldePermisos Entidad)
        {
            return DAL_RolPermisos.Registro(Entidad);
        }
        public static List<RoldePermisos> Lista(bool Activo = true)
        {
            return DAL_RolPermisos.Lista(Activo);
        }
    }
}

