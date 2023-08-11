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
                //new Especialidad{ IdEspecialidad = 1 ,Descripcion = "Ingenieria en Sistemas"},
                //new Especialidad{ Descripcion = "Ingenieria Mecanica"},
                //new Especialidad{ Descripcion = "Ingenieria Civil"},
                //new Especialidad{ Descripcion = "Analista de sistemas"}
            };
    }
    public int ultimoIndice = 0;
    public Especialidad? obtenerEspecialidad(int idEsp)
    {
        Especialidad? esp = null;
        foreach (Especialidad e in _especialidades)
        {
            if (e.IdEspecialidad == idEsp)
            {
                esp = e;
            }else esp = null;
        }
        return esp;
    }
    public List<Especialidad> obtenerEspecialidades()
    {
        List<Especialidad> listaEsp = new List<Especialidad>();
        listaEsp = _especialidades;
        return listaEsp;
    }
    public void agregarEspecialidad(string desc)
    {
        ultimoIndice = _especialidades.Count + 1;
        Especialidad nuevaEsp = new Especialidad();
        nuevaEsp.IdEspecialidad = ultimoIndice;
        nuevaEsp.Descripcion = desc;
        _especialidades.Add(nuevaEsp);
    }
    public void eliminarEspecialidad(Especialidad esp)
    {
        _especialidades.Remove(esp);
    }
    public void modificarEspecialidad(int idEsp, string descNueva)
    {
        foreach (Especialidad e in _especialidades)
        {
            if (e.IdEspecialidad == idEsp)
            {
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
        return existe;
    }
}