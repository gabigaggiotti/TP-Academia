using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

public class Planes
{
    private List<Plan> _planes;

    public Planes()
    {
        _planes = new List<Plan>();
    }

    public void AgregarPlan(Plan plan)
    {
        _planes.Add(plan);
    }

    public void EliminarPlan(Plan plan)
    {
        _planes.Remove(plan);
    }

    public void ModificarPlan(Plan plan, string nuevaDescripcion, int nuevoIdEspecialidad)
    {
        plan.Descripcion = nuevaDescripcion;
        plan.IDEspecialidad = nuevoIdEspecialidad;
    }

}

