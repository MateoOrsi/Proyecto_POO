using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMINIO
{
    public class Persona
    {
		private int _dni;

		public int DNI
		{
			get { return _dni;  }
			set { _dni = value; }
		}

		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _apellido;
		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
        }	

    }
}