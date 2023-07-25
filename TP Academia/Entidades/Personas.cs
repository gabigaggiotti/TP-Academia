using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Personas : BusinessEntity
    {
        private string _Apellido;
        private string _Direccion;
        private string _Email;
        private DateTime _Fecha_Nacimiento;
        private int _IDPlan;
        private int _Legajo;
        private string _Nombre;
        private string _Telefono;
        private int _TipoPersona;

        public string? Apellido
        { get; set; }

        public string? Direccion
        { get; set; }

        public string? Email
        { get; set; }

        public DateTime FechaNacimiento
        { get; set; }

        public int IDPlan
        { get; set; }

        public int Legajo
        { get; set; }

        public string? Nombre
        { get; set; }

        public string? Telefono
        { get; set; }

        public int TipoPersona
        { get; set; }
    }
}