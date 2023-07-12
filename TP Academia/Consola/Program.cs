using System.Numerics;
using System;
using Entidades;
public class NotImplementedException : SystemException{ } // PREGUNTARLE AL PROFE QUE ONDA ESTO
class Program
{
    static void Main(string[] args)
    {

        Planes planes = new Planes();

        // Ejemplo de alta de un plan
        Plan nuevoPlan = new Plan();
        nuevoPlan.Descripcion = "Plan A";
        nuevoPlan.IDEspecialidad = 1;
        planes.AgregarPlan(nuevoPlan);

        // Ejemplo de modificación de un plan
        //Plan planExistente = // Obtener plan existente de alguna forma (puede ser por búsqueda, selección de lista, etc.)
        // nuevoPlan.ModificarPlan(planExistente, "Nuevo nombre", 2);

        // Ejemplo de baja de un plan
        //planes.EliminarPlan(planExistente);

        // Resto de la lógica de tu aplicación...
        throw new NotImplementedException();
    }
}
