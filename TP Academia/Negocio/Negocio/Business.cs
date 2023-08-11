using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Business
    {
        //public static object Especialidades { get; set; }

        public static List<especialidades> Get()
        {
            using(Datos.AcademiaEntities db = new Datos.AcademiaEntities())
            {
                return db.especialidades.ToList();
            }
        }
    }
}
