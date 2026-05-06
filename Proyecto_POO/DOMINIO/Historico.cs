using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMINIO
{
    public class Historico
    {
		private List<Producto> _listaProductos;

		public List<Producto> ListaProductos
		{
			get { return _listaProductos; }
		}

		private int _cantPedidos;

		public int CantPedidos
		{
			get { return _cantPedidos; }
			set { _cantPedidos = value; }
		}

		private int _gastoTotal;

		public int GastoTotal
		{
			get { return _gastoTotal; }
			set { _gastoTotal = value; }
		}

        public Historico()
        {
            _listaProductos = new List<Producto>();
        }

		public void AgregarProducto(Producto producto)
		{
			_listaProductos.Add(producto);
        }

		public void EliminarProducto(Producto producto)
		{
			_listaProductos.Remove(producto);
        }
    }
}