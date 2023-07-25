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
    public List<Especialidad> esp;

    public Planes()
    {
        _planes = new List<Plan>
        {
            new Plan{ Descripcion = "Plan 1995", IDEspecialidad = 1 },
            new Plan{ Descripcion = "Plan 2008", IDEspecialidad = 2 },
            new Plan{ Descripcion = "Plan 2023", IDEspecialidad = 3 }
        };
    }
    
    public bool agregarPlan(int idPlan, string desc)
    {
        bool existe = false;
        Plan nuevoPlan = new Plan();
        Especialidades esp = new Especialidades();
        if (esp.ExisteEspecialidad(idPlan))
        {
            Console.Clear();
            nuevoPlan.IDEspecialidad = idPlan;
            nuevoPlan.Descripcion = desc;
            _planes.Add(nuevoPlan);
            existe = true;
        }        
        return existe;
    }

    public void eliminarPlan(Plan plan)
    {
        _planes.Remove(plan);        
    }

    public void modificarPlan(Plan plan, int idNuevo, string descNueva)
    {       
        {
            plan.IDEspecialidad = idNuevo;
            plan.Descripcion = descNueva;
        }
    }

   public void MostrarPlanes()
    {
        foreach (var p in _planes)
        {
            Console.WriteLine("Descripción: " + p.Descripcion);
            Console.WriteLine("ID Especialidad: " + p.IDEspecialidad);
            Console.WriteLine("--------------------------");      
        }
    }
    public Plan? getPlanes(int id)
    {
        Plan plan = null;
        bool existe = false;
        foreach (Plan p in _planes)
        {
            if (p.IDEspecialidad == id)
            {
                plan = p;
            }
        }
        return plan;
    }
}

