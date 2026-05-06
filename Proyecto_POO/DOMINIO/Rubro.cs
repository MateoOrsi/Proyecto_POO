using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMINIO
{
    public class Rubro
    {
		private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _descripcion;

		public string Descripcion
		{
			get { return _descripcion; }
			set { _descripcion = value; }
		}

	}
}