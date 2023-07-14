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
        /*string idPlan;
        Console.WriteLine("Descripcion del plan: ");
        nuevoPlan.Descripcion = Console.ReadLine();
        Console.WriteLine("ID de especialidad del plan: ");
        idPlan = Console.ReadLine();
        nuevoPlan.IDEspecialidad = int.Parse(idPlan);
        planes.agregarPlan(nuevoPlan);
        planes.MostrarPlanes();*/

        // Ejemplo de modificación de un plan
        //Plan planExistente = // Obtener plan existente de alguna forma (puede ser por búsqueda, selección de lista, etc.)
        // nuevoPlan.ModificarPlan(planExistente, "Nuevo nombre", 2);        
        bool salir = false;
        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("----- MENÚ -----");
            Console.WriteLine("1. Dar de alta un nuevo plan");
            Console.WriteLine("2. Dar de baja un plan existente");
            Console.WriteLine("3. Modificar un plan un plan existente");
            Console.WriteLine("0. Salir");
            Console.WriteLine("-----------------");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("ALTA DE UN PLAN");
                    planes.agregarPlan();
                    // Lógica relacionada con la opción 1
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("ELIMINAR PLAN");
                    planes.eliminarPlan();                    
                    break;
                case "3":
                    Console.WriteLine("Ha seleccionado la Opción 3");
                    // Lógica relacionada con la opción 3
                    break;
                case "0":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
