using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Usuario : BusinessEntity
    {
        private string _Apellido;
        private string _Clave;
        private string _Email;
        private bool _Habilitado;
        private string _Nombre;
        private string _NombreUsuario;

        public string Apellido
        {
            get => default;
            set
            {
            }
        }

        public string Clave
        {
            get => default;
            set
            {
            }
        }

        public string Email
        {
            get => default;
            set
            {
            }
        }

        public bool Habilitado
        {
            get => default;
            set
            {
            }
        }

        public string Nombre
        {
            get => default;
            set
            {
            }
        }

        public string NombreUsuario
        {
            get => default;
            set
            {
            }
        }
    }
}