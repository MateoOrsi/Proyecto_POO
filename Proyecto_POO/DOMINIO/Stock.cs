using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMINIO
{
    public class Stock
    {
		private List<Producto> _stock;

		public List<Producto> stock
		{
			get { return _stock; }
		}

		private int _cantprod;

		public int CantProd
		{
			get { return _cantprod; }
			set { _cantprod = value; }
		}

        public Stock()
        {
            _stock = new List<Producto>();
        }

		public void AgregarProducto(Producto producto)
		{
			_stock.Add(producto);
        }

    }
}