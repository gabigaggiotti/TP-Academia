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
    
    public void agregarPlan()
    {
        //Planes planes = new Planes();
        Plan nuevoPlan = new Plan();
        Especialidades esp = new Especialidades();
        int idPlan;
        Console.Write("Descripcion del plan: ");
        nuevoPlan.Descripcion = Console.ReadLine();
        Console.Write("ID de especialidad del plan: ");
        idPlan = int.Parse(Console.ReadLine());
        if (esp.ExisteEspecialidad(idPlan))
        {
            Console.Clear();
            nuevoPlan.IDEspecialidad = idPlan;
            _planes.Add(nuevoPlan);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("El plan con ID {0} fue creado exitosamente.", idPlan);
            Console.WriteLine("------------------------------------------");
            MostrarPlanes();
        }        
        else
        {
            Console.WriteLine("No existe ninguna especialidad con ID {0}.", idPlan);
        }
    }

    public void eliminarPlan()
    {
        int _idPlanDelete;
        Console.Clear();
        MostrarPlanes();
        Console.WriteLine("Ingrese el ID del plan que quiere eliminar: ");        
        _idPlanDelete = int.Parse(Console.ReadLine());
        Plan planRemove;
        bool encontrado = false;
        foreach (Plan plan in _planes) 
        {
            if (plan.IDEspecialidad == _idPlanDelete)
            {
                encontrado = true;
                planRemove = plan;
                _planes.Remove(planRemove);
                break;
            }
        }
        if (encontrado)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("El plan con ID {0} fue eliminado en la lista.", _idPlanDelete);
            Console.WriteLine("------------------------------------------");
            MostrarPlanes();
        }
        else
        {
            Console.WriteLine("El plan con ID {0} no se encontró en la lista.", _idPlanDelete);
        }
    }

    public void modificarPlan(Plan plan)
    {       
        {
            int idPlan, idNuevo;
            MostrarPlanes();
            Console.Write("ID del plan a modificar: ");
            idPlan = int.Parse(Console.ReadLine());
            bool encontrado = false;
            foreach (Plan p in _planes)
            {
                if (p.IDEspecialidad == idPlan)
                {
                    encontrado = true;
                    Console.Write("Nuevo ID: ");
                    idNuevo = int.Parse(Console.ReadLine());
                    p.IDEspecialidad = idNuevo;
                    string descNueva;
                    Console.Write("Nueva descripcion: ");
                    descNueva = Console.ReadLine();
                    p.Descripcion = descNueva;
                    Console.Clear();
                    break;
                }
            }
            if (encontrado)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("El plan fue modificado.", plan.IDEspecialidad);
                Console.WriteLine("------------------------------------------");
                MostrarPlanes();
            }
            else
            {
                Console.WriteLine("El plan no se encontró en la lista.");
            }
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
}

