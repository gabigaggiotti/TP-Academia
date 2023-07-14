using System.Numerics;
using System;
using Entidades;
class Program
{

    static void Main()
    {
        // ALTA DE UN PLAN
        Planes planes = new Planes();
        Plan nuevoPlan = new Plan();
        string idPlan;
        Console.WriteLine("Descripcion del plan: ");
        nuevoPlan.Descripcion = Console.ReadLine();
        Console.WriteLine("ID de especialidad del plan: ");
        idPlan = Console.ReadLine();
        nuevoPlan.IDEspecialidad = int.Parse(idPlan);
        planes.agregarPlan(nuevoPlan);
        planes.MostrarPlanes();

        // Ejemplo de modificación de un plan
        //Plan planExistente = // Obtener plan existente de alguna forma (puede ser por búsqueda, selección de lista, etc.)
        // nuevoPlan.ModificarPlan(planExistente, "Nuevo nombre", 2);

        // BAJA DE UN PLAN
        int idPlanDelete;
        Console.WriteLine("Ingrese el ID del plan que quiere eliminar: ");
        idPlanDelete = int.Parse(Console.ReadLine());
        planes.eliminarPlan(idPlanDelete);
        planes.MostrarPlanes();

        // Resto de la lógica de tu aplicación...
        //throw new NotImplementedException();

    }
}
