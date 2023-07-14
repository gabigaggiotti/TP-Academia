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

    public Planes()
    {
        //_planes = new List<Plan>();
        _planes = new List<Plan>
        {
            new Plan{ Descripcion = "Plan 1995", IDEspecialidad = 1 },
            new Plan{ Descripcion = "Plan 2008", IDEspecialidad = 2 },
            new Plan{ Descripcion = "Plan 2023", IDEspecialidad = 3 }
        };
    }

    public void agregarPlan()
    {
        Planes planes = new Planes();
        Plan nuevoPlan = new Plan();
        string idPlan;
        Console.Write("Descripcion del plan: ");
        nuevoPlan.Descripcion = Console.ReadLine();
        Console.Write("ID de especialidad del plan: ");
        idPlan = Console.ReadLine();
        Console.Clear();
        nuevoPlan.IDEspecialidad = int.Parse(idPlan);
        _planes.Add(nuevoPlan);
        MostrarPlanes();
    }

    public void eliminarPlan()
    {
        int _idPlanDelete;
        Console.Clear();
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
                break; // Opcional: si solo quieres encontrar la primera coincidencia y salir del bucle
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

    public void modificarPlan(Plan plan, string nuevaDescripcion, int nuevoIdEspecialidad)
    {
        plan.Descripcion = nuevaDescripcion;
        plan.IDEspecialidad = nuevoIdEspecialidad;
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

