using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMINIO
{
	public class Cliente : Persona
    {
		private int _idCliente;

		public int IdCliente
        {
			get { return _idCliente; }
			set { _idCliente = value; }
		}
    }
}