using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer;
using System.Data.SqlClient;
using Entidades;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;

namespace Negocio
{
    public class Business
    {
        public static bool GetEspecialidad(int id)
        {
            using (Datos.AcademiaEntities db = new Datos.AcademiaEntities())
            {
                if (db.especialidades.Find(id) != null)
                {
                    return true;
                }else return false;
            }                
        }
        public static List<especialidades> GetEspecialidades()
        {
            using(Datos.AcademiaEntities db = new Datos.AcademiaEntities())
            {
                return db.especialidades.ToList();
            }
        }
        #region ABM Especialidades
        public static void CreateEspecialidad(string desc)
        {
            using (AcademiaEntities db = new AcademiaEntities())
            {                
                especialidades esp = new especialidades();                
                esp.descEspecialidad = desc;
                db.especialidades.Add(esp);
                db.SaveChanges();                
            }
            
        }
        public static void RemoveEspecialidad(int id)
        {
            using (AcademiaEntities db = new AcademiaEntities())
            {
                
                if (db.especialidades.Find(id) != null)
                {
                    db.especialidades.Remove(db.especialidades.Find(id));
                    db.SaveChanges();
                }

            }
        }
        public static void ModifyEspecialidad(int id, string desc)
        {
            using (AcademiaEntities db = new AcademiaEntities())
            {
                especialidades esp = db.especialidades.Find(id);
                esp.descEspecialidad = desc;                                
                db.SaveChanges();
            }
        }
        #endregion
        public static bool GetPlan(int idPlan)
        {
            using (Datos.AcademiaEntities db = new Datos.AcademiaEntities())
            {
                if (db.planes.Find(idPlan) != null)
                {
                    return true;
                }
                else return false;
            }
        }
        public static List<planes> GetPlanes()
        {
            using (Datos.AcademiaEntities db = new Datos.AcademiaEntities())
            {
                return db.planes.ToList();
            }
        }
        #region ABM Planes
        public static void CreatePlan(string desc, int idEsp)
        {
            using (Datos.AcademiaEntities db = new Datos.AcademiaEntities())
            {
                planes p = new planes();
                p.id_especialidad = idEsp;
                p.desc_plan = desc;
                db.planes.Add(p);
                db.SaveChanges();
            }
        }
        public static void RemovePlan(int id)
        {
            using (AcademiaEntities db = new AcademiaEntities())
            {

                if (db.planes.Find(id) != null)
                {
                    db.planes.Remove(db.planes.Find(id));
                    db.SaveChanges();
                }

            }
        }
        public static void ModifyPlan(int idPlan, int idEsp, string desc)
        {
            using (AcademiaEntities db = new AcademiaEntities())
            {
                planes p = db.planes.Find(idPlan);
                p.desc_plan = desc;
                p.id_especialidad = idEsp;
                db.SaveChanges();
            }
        }
        #endregion
    }
}
