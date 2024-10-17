using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave4_Grupo4
{
    class Producto
    {
        public Producto(int iDProducto, string nombre, decimal precio, string categoria)
        {
            IDProducto = iDProducto;
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
        
        }
        public override string ToString()
        {
            return Nombre + "-$" + Precio.ToString("0.00");
        }

        public int IDProducto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
    }


}
