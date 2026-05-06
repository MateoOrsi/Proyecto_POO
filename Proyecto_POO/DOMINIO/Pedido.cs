using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMINIO
{
    public class Pedido
    {
		private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

		private int _cantidad;

		public int Cantidad
		{
			get { return _cantidad; }
			set { _cantidad = value; }
		}

		private int _idProd;

		public int IdProd
		{
			get { return _idProd; }
			set { _idProd = value; }
		}

		private int _idProv;

		public int IdProv
		{
			get { return _idProv; }
			set { _idProv = value; }
		}

		private DateTime _fecha;

		public DateTime Fecha
		{
			get { return _fecha; }
			set { _fecha = value; }
		}

		private DateTime _fechallegada;

		public DateTime FechaLlegada
		{
			get { return _fechallegada; }
			set { _fechallegada = value; }
		}

		private int _importe;

		public int Importe
		{
			get { return _importe; }
			set { _importe = value; }
		}

	}
}