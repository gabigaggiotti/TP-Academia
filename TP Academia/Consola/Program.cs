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

            //ALTA DE UN PLAN
            if (opcion == "1")
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
                    Console.Clear();
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("El plan con ID {0} fue creado exitosamente.", idPlan);
                    Console.WriteLine("------------------------------------------");
                    foreach (Plan plan in planes.obtenerPlanes())
                    {
                        Console.WriteLine("Descripción: " + plan.Descripcion);
                        Console.WriteLine("ID Especialidad: " + plan.IDEspecialidad);
                        Console.WriteLine("--------------------------");
                    }
                    Console.WriteLine("Presione una tecla para continuar.");
                    Console.ReadKey();
                }
                else Console.WriteLine("Los datos del plan son invalidos.");

            }
            //BAJA DE UN PLAN
            if (opcion == "2") 
            {
                Console.Clear();
                int idPlan;
                Plan plan;
                foreach (Plan p in planes.obtenerPlanes())
                {
                    Console.WriteLine("Descripción: " + p.Descripcion);
                    Console.WriteLine("ID Especialidad: " + p.IDEspecialidad);
                    Console.WriteLine("--------------------------");
                }
                Console.Write("Ingrese el ID del plan que quiere eliminar: ");
                idPlan = int.Parse(Console.ReadLine());
                plan = planes.obtenerPlan(idPlan);
                if (plan != null) 
                {
                    planes.eliminarPlan(plan);
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("El plan con ID {0} fue eliminado en la lista.", idPlan);
                    Console.WriteLine("------------------------------------------");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("Lista actualizada de los planes:\n------------------------------------------");
                    foreach (Plan p in planes.obtenerPlanes())
                    {
                        Console.WriteLine("Descripción: " + p.Descripcion);
                        Console.WriteLine("ID Especialidad: " + p.IDEspecialidad);
                        Console.WriteLine("--------------------------");
                    }
                    Console.WriteLine("Presione una tecla para continuar.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("El plan con ID {0} no existe en la lista.", idPlan);
                    Console.WriteLine("------------------------------------------");
                    Thread.Sleep(3000);
                    Console.Clear();
                }                
            }
            //MODIFICAR PLAN
            if (opcion == "3") 
            {
                Console.Clear();
                int idPlan, idNuevo;
                Plan plan;
                bool existe;
                foreach (Plan p in planes.obtenerPlanes())
                {
                    Console.WriteLine("Descripción: " + p.Descripcion);
                    Console.WriteLine("ID Especialidad: " + p.IDEspecialidad);
                    Console.WriteLine("--------------------------");
                }
                Console.Write("ID del plan a modificar: ");
                idPlan = int.Parse(Console.ReadLine());
                plan = planes.obtenerPlan(idPlan);
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
                    foreach (Plan p in planes.obtenerPlanes())
                    {
                        Console.WriteLine("Descripción: " + p.Descripcion);
                        Console.WriteLine("ID Especialidad: " + p.IDEspecialidad);
                        Console.WriteLine("--------------------------");
                    }
                }
                else Console.WriteLine("El plan no se encontró en la lista.");
            }
            //MOSTRAR PLANES EXISTENTES
            if (opcion == "4")
            {
                Console.Clear();
                foreach (Plan p in planes.obtenerPlanes())
                {
                    Console.WriteLine("Descripción: " + p.Descripcion);
                    Console.WriteLine("ID Especialidad: " + p.IDEspecialidad);
                    Console.WriteLine("--------------------------");
                }
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();

            }
            //ALTA DE UNA ESPECIALIDAD
            if (opcion == "5")
            {
                int idEsp;
                string descEsp;
                bool espCreada;
                Console.Write("ID de la especialidad: ");
                idEsp = int.Parse(Console.ReadLine());
                Console.Write("Descripcion de la especialidad: ");
                descEsp = Console.ReadLine();
                espCreada = especialidades.agregarEspecialidad(idEsp, descEsp);
                if (espCreada)
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("La especialidad con ID {0} fue creada exitosamente.", idEsp);
                    Console.WriteLine("------------------------------------------");
                    foreach (Especialidad esp in especialidades.obtenerEspecialidades())
                    {
                        Console.WriteLine("ID Especialidad: " + esp.IdEspecialidad);
                        Console.WriteLine("Descripción: " + esp.Descripcion);
                        Console.WriteLine("--------------------------");
                    }
                    Console.WriteLine("Presione una tecla para continuar.");
                    Console.ReadKey();
                }
                else Console.WriteLine("Los datos de la especialidad son invalidos.");
                Console.Clear();
            }
            //BAJA DE UNA ESPECIALIDAD
            if (opcion == "6")
            {
                int idEspDelete;
                Especialidad esp;
                Console.Clear();
                foreach (Especialidad e in especialidades.obtenerEspecialidades())
                {
                    Console.WriteLine("ID Especialidad: " + e.IdEspecialidad);
                    Console.WriteLine("Descripción: " + e.Descripcion);
                    Console.WriteLine("--------------------------");
                }
                Console.Write("Ingrese el ID de la especialidad que quiere eliminar: ");
                idEspDelete = int.Parse(Console.ReadLine());
                esp = especialidades.obtenerEspecialidad(idEspDelete);
                if (esp == null)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("La especialidad con ID {0} no existe en la lista.", idEspDelete);
                    Console.WriteLine("------------------------------------------");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                if (esp != null)
                {
                    especialidades.eliminarEspecialidad(esp);
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("La especialidad con ID {0} fue eliminado en la lista.", idEspDelete);
                    Console.WriteLine("------------------------------------------");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("Lista actualizada de las especialidades:\n------------------------------------------");
                    foreach (Especialidad e in especialidades.obtenerEspecialidades())
                    {
                        Console.WriteLine("ID Especialidad: " + e.IdEspecialidad);
                        Console.WriteLine("Descripción: " + e.Descripcion);
                        Console.WriteLine("--------------------------");
                    }
                    Console.WriteLine("Presione una tecla para continuar.");
                    Console.ReadKey();
                }        
            }
            //MODIFICAR ESPECIALIDAD
            if (opcion == "7")
            {
                int idEsp, idNuevo;
                string descNueva;
                Console.Clear();
                foreach (Especialidad esp in especialidades.obtenerEspecialidades())
                {
                    Console.WriteLine("ID Especialidad: " + esp.IdEspecialidad);
                    Console.WriteLine("Descripción: " + esp.Descripcion);
                    Console.WriteLine("--------------------------");
                }
                Console.Write("ID de la especialidad a modificar: ");
                idEsp = int.Parse(Console.ReadLine());
                bool encontrado = false;
                encontrado = especialidades.ExisteEspecialidad(idEsp);
                if (encontrado == false) Console.WriteLine("La especialidad no se encontró en la lista.");
                if (encontrado)
                {
                    Console.Write("Nuevo ID: ");
                    idNuevo = int.Parse(Console.ReadLine());
                    Console.Write("Nueva descripcion: ");
                    descNueva = Console.ReadLine();
                    especialidades.modificarEspecialidad(idEsp, idNuevo, descNueva);
                    Console.Clear();
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("La especialidad fue modificada.", especialidad.IdEspecialidad);
                    Console.WriteLine("------------------------------------------");
                    foreach (Especialidad esp in especialidades.obtenerEspecialidades())
                    {
                        Console.WriteLine("ID Especialidad: " + esp.IdEspecialidad);
                        Console.WriteLine("Descripción: " + esp.Descripcion);
                        Console.WriteLine("--------------------------");
                    }
                    Console.WriteLine("Presione una tecla para continuar.");
                    Console.ReadKey();
                }
            }
            //MOSTRAR ESPECIALIDADES EXISTENTES
            if (opcion == "8")
            {
                Console.Clear();
                foreach (Especialidad e in especialidades.obtenerEspecialidades())
                {
                    Console.WriteLine("ID Especialidad: " + e.IdEspecialidad);
                    Console.WriteLine("Descripción: " + e.Descripcion);
                    Console.WriteLine("--------------------------");
                }
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();
            }            
        }
    }
}
