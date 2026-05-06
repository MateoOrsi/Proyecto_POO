using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMINIO
{
    public class Producto
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

		private int _cantidad;

		public int Cantidad
		{
			get { return _cantidad; }
			set { _cantidad = value; }
		}

		private int _precio;

		public int Precio
		{
			get { return _precio; }
			set { _precio = value; }
		}

		private int _costo;

		public int Costo
		{
			get { return _costo; }
			set { _costo = value; }
		}

		private Estado _estado;

		public Estado Estado
		{
			get { return _estado; }
			set { _estado = value; }
		}

		private int _stockminimo;

		public int StockMinimo
		{
			get { return _stockminimo; }
			set { _stockminimo = value; }
		}

	}
}