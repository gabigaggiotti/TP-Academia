using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Plan : BusinessEntity
    {
        private static int contador = 0;
        public int _IdPlan;
        public string _Descripcion;
        private int _IDEspecialidad;

        public int IdPlan
        { get;  set; }
        public string Descripcion
        { get; set; }
        public int IDEspecialidad
        { get; set; }

        public Plan() 
        {
            //IdPlan = contador;
            //contador++; 
        }
    }
}    


