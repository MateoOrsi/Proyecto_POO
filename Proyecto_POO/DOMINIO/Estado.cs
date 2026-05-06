using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMINIO
{
    public class Estado
    {
		private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}


	}
}