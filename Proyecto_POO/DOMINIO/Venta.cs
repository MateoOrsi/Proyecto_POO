using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMINIO
{
    public class Venta
    {
		private int _idCliente;

		public int IdCliente
		{
			get { return _idCliente; }
			set { _idCliente = value; }
		}

		private int _idProducto;

		public int IdProducto
		{
			get { return _idProducto; }
			set { _idProducto = value; }
		}

		private int _cantidad;
		public int Cantidad
		{
			get { return _cantidad; }
			set { _cantidad = value; }
        }
		private int _importeTotal;

		public int ImporteTotal
		{
			get { return _importeTotal; }
			set { _importeTotal = value; }
		}

        public Venta()
        {
            
        }
    }
}