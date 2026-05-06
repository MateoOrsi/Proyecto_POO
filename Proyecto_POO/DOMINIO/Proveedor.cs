using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMINIO
{
    public class Proveedor
    {
		private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

		private Rubro _rubro;

		public Rubro Rubro
		{
			get { return _rubro; }
			set { _rubro = value; }
		}

		private string _nombre;

		public string Nombre
		{
			get { return  _nombre; }
			set {  _nombre = value; }
		}

		private int _gastoParcial;

		public int GastoParcial
		{
			get { return _gastoParcial; }
			set { _gastoParcial = value; }
		}

		private int _cantidadPedidos;

		public int Cantidad_Pedidos
		{
			get { return _cantidadPedidos; }
			set { _cantidadPedidos = value; }
		}

		private List<Producto> _productos;

		public List<Producto> productos
		{
			get { return _productos; }
			set { _productos = value; }
		}

	}
}