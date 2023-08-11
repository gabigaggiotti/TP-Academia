using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Entidades;

public class Planes : Plan
{
    public List<Plan> _planes;
    //public List<Especialidad> esp;

    public Planes()
    {
        _planes = new List<Plan>
        {
            //new Plan{ Descripcion = "Plan 1995", IDEspecialidad = 1 },
            //new Plan{ Descripcion = "Plan 2008", IDEspecialidad = 2 },
            //new Plan{ Descripcion = "Plan 2023", IDEspecialidad = 3 }
        };
    }
    public int indiceId = 0;
    
    public bool agregarPlan(int idEsp, string desc, Especialidades esp)
    {
        bool existe = true;
        Plan nuevoPlan = new Plan();
        Especialidad? eAP;
        eAP = esp.obtenerEspecialidad(idEsp);
        if (eAP != null)
        {
            indiceId = _planes.Count + 1;            
            nuevoPlan.IdPlan = indiceId;
            nuevoPlan.IDEspecialidad = idEsp;
            nuevoPlan.Descripcion = desc;
            _planes.Add(nuevoPlan);
            existe = true;
        }
        else existe = false;        
        return existe;
    }

    public void eliminarPlan(Plan plan)
    {
        _planes.Remove(plan);        
    }

    public bool modificarPlan(Plan plan, int idEsp, string descNueva, Especialidades esp)
    {       
        {
            bool modificado = false;
            Especialidad? eMP;
            eMP = esp.obtenerEspecialidad(idEsp);
            if (eMP != null)
            {
                plan.IDEspecialidad = idEsp;
                plan.Descripcion = descNueva;
                modificado = true;
            }
            return modificado;
            
        }
    }
   public List<Plan> obtenerPlanes()
    {
        List<Plan> listaPlanes = new List<Plan>();
        listaPlanes = _planes;
        return listaPlanes;
    }
    public Plan? obtenerPlan(int id)
    {
        Plan? plan = null;
        foreach (Plan p in _planes)
        {
            if (p.IdPlan == id) plan = p;
        }
        return plan;
    }
}

