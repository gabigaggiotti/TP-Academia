using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Especialidad : BusinessEntity
    {
        //private int _IdEspecialidad;
        //private string _Descripcion;
        public int IdEspecialidad
        { get; set; }
        public string Descripcion
        { get; set; }
    }
}