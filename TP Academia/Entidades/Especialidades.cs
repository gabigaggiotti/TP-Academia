using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

public class Especialidades : Especialidad
{
    public List<Especialidad> _especialidades;

    public Especialidades()
    {        
        _especialidades = new List<Especialidad>
            {
                new Especialidad{ IdEspecialidad = 1, Descripcion = "Ingenieria en Sistemas"},
                new Especialidad{ IdEspecialidad = 2, Descripcion = "Ingenieria Mecanica"},
                new Especialidad{ IdEspecialidad = 3, Descripcion = "Ingenieria Civil"},
                new Especialidad{ IdEspecialidad = 4, Descripcion = "Analista de sistemas"}
            };
    }
    public Especialidad? obtenerEspecialidad(int id)
    {
        Especialidad esp = null;
        foreach (Especialidad e in _especialidades)
        {
            if (e.IdEspecialidad == id) esp = e;
        }
        return esp;
    }
    public List<Especialidad> obtenerEspecialidades()
    {
        List<Especialidad> listaEsp = new List<Especialidad>();
        listaEsp = _especialidades;
        return listaEsp;
    }
    public bool agregarEspecialidad(int id, string desc)
    {
        bool existe = true;
        Especialidades especialidades = new Especialidades();
        Especialidad nuevaEsp = new Especialidad();
        nuevaEsp.IdEspecialidad = id;
        nuevaEsp.Descripcion = desc;
        _especialidades.Add(nuevaEsp);
        return existe;
    }
    public void eliminarEspecialidad(Especialidad esp)
    {
        _especialidades.Remove(esp);
    }
    public void modificarEspecialidad(int idEsp, int idNuevo, string descNueva)
    {
        foreach (Especialidad e in _especialidades)
        {
            if (e.IdEspecialidad == idEsp)
            {
                e.IdEspecialidad = idNuevo;
                e.Descripcion = descNueva;      
            }
        }        
    }
    public bool ExisteEspecialidad(int idEsp)
    {
        bool existe = false;
        foreach (Especialidad esp in _especialidades)
        {
            if (esp.IdEspecialidad == idEsp)
            {                
                existe = true;
                break;
            }
        }
        if (existe) return true;
        else return false;
    }
    
}