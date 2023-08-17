using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ModuloUsuario : BusinessEntity
    {
        private int _IDModulo;
        private int _IDUsuario;
        private bool _PermiteAlta;
        private bool _PermiteBaja;
        private bool _PermiteConsulta;
        private bool _PermiteModificacion;

        public int IDModulo
        {
            get => default;
            set
            {
            }
        }

        public int IDUsuario
        {
            get => default;
            set
            {
            }
        }

        public bool PermiteAlta
        {
            get => default;
            set
            {
            }
        }

        public bool PermiteBaja
        {
            get => default;
            set
            {
            }
        }

        public bool PermiteConsulta
        {
            get => default;
            set
            {
            }
        }

        public bool PermiteModificacion
        {
            get => default;
            set
            {
            }
        }
    }
}