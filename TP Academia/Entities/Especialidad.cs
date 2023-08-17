using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Especialidad : BusinessEntity
    {
        private static int contador = 0;
        public int IdEspecialidad
        { get;  set; }
        public string Descripcion
        { get; set; }
    }
}