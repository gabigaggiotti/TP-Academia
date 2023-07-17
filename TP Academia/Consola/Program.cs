using System.Numerics;
using System;
using Entidades;
class Program
{

    static void Main()
    {
        Planes planes = new Planes();
        Plan nuevoPlan = new Plan();
        Especialidades especialidades = new Especialidades();
        Especialidad especialidad = new Especialidad();
        
        bool salir = false;
        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("----- MENÚ -----");
            Console.WriteLine("1. Dar de alta un nuevo plan");
            Console.WriteLine("2. Dar de baja un plan existente");
            Console.WriteLine("3. Modificar un plan un plan existente");
            Console.WriteLine("4. Mostrar planes");
            Console.WriteLine("5. Dar de alta una nueva especialidad");
            Console.WriteLine("6. Dar de baja una especialidad existente");
            Console.WriteLine("7. Modificar una especialidad existente");
            Console.WriteLine("8. Mostrar especialidades");
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
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("ELIMINAR PLAN");
                    planes.eliminarPlan();                    
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("MODIFICAR PLAN");
                    planes.modificarPlan(nuevoPlan);
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("MOSTRAR PLANES");
                    planes.MostrarPlanes();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("ALTA DE UNA ESPECIALIDAD");
                    especialidades.agregarEspecialidad();
                    break;
                case "6":
                    Console.Clear();
                    Console.WriteLine("ELIMINAR ESPECIALIDAD");
                    especialidades.eliminarEspecialidad();
                    break;
                case "7":
                    Console.Clear();
                    Console.WriteLine("MODIFICAR ESPECIALIDAD");
                    especialidades.modificarEspecialidad(especialidad);
                    break;
                case "8":
                    Console.Clear();
                    Console.WriteLine("MOSTRAR ESPECIALIDADES");
                    especialidades.MostrarEspecialidades();
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
