using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMINIO
{
    public class Empleado : Persona
    {
        private int _idEmpleado;

        public int IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

    }
}