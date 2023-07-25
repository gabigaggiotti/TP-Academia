using Entidades;
using System.Numerics;

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

            if (opcion == "1") //ALTA DE UN PLAN
            {
                Console.Clear();
                int idPlan;
                bool planCreado;
                string desc;
                Console.Write("Descripcion del plan: ");
                desc = Console.ReadLine();
                Console.Write("ID de especialidad del plan: ");
                idPlan = int.Parse(Console.ReadLine());
                planCreado = planes.agregarPlan(idPlan, desc);
                if (planCreado)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("El plan con ID {0} fue creado exitosamente.", idPlan);
                    Console.WriteLine("------------------------------------------");
                    planes.MostrarPlanes();
                }
                else Console.WriteLine("Los datos del plan son invalidos.");

            }
            if (opcion == "2") //BAJA DE UN PLAN
            {
                Console.Clear();
                int idPlan;
                Plan plan;
                planes.MostrarPlanes();
                Console.Write("Ingrese el ID del plan que quiere eliminar: ");
                idPlan = int.Parse(Console.ReadLine());
                plan = planes.getPlanes(idPlan);
                if (plan != null) 
                {
                    planes.eliminarPlan(plan);
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("El plan con ID {0} fue eliminado en la lista.", idPlan);
                    Console.WriteLine("------------------------------------------");
                    Thread.Sleep(3000);
                    Console.Clear();
                    planes.MostrarPlanes();
                }
                else
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("El plan con ID {0} no existe en la lista.", idPlan);
                    Console.WriteLine("------------------------------------------");
                }                
            }
            if (opcion == "3") //MODIFICAR PLAN
            {
                Console.Clear();
                int idPlan, idNuevo;
                Plan plan;
                bool existe;
                planes.MostrarPlanes();
                Console.Write("ID del plan a modificar: ");
                idPlan = int.Parse(Console.ReadLine());
                plan = planes.getPlanes(idPlan);
                if (plan != null) 
                {
                    Console.Write("Nuevo ID: ");
                    idNuevo = int.Parse(Console.ReadLine());
                    string descNueva;
                    Console.Write("Nueva descripcion: ");
                    descNueva = Console.ReadLine();
                    planes.modificarPlan(plan, idNuevo, descNueva);
                    Console.Clear();
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("El plan fue modificado.");
                    Console.WriteLine("------------------------------------------");                    
                    planes.MostrarPlanes();
                }
                else Console.WriteLine("El plan no se encontró en la lista.");
            }
            /*switch (opcion)
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
            }*/
            Console.ReadKey();
        }
    }
}
