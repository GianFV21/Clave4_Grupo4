using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave4_Grupo4
{
    class Pedido
    {
        public Pedido(int iDPedido, Usuario usuario, List<Producto> productos, DateTime fechaPedido, TimeSpan horaReserva, string metodoPago, decimal total)
        {
            IDPedido = iDPedido;
            Usuario = usuario;
            Productos = productos;
            FechaPedido = fechaPedido;
            HoraReserva = horaReserva;
            MetodoPago = metodoPago;
            Total = total;
        }
        public decimal CalcularTotal()
        {
            return Productos.Sum(p => p.Precio);
        }
        public Pedido()
        {
            Productos = new List<Producto>();
        }

        public int IDPedido { get; set; }
        public Usuario Usuario { get; set; }
        public List<Producto>Productos { get; set; }
        public DateTime FechaPedido { get; set; }
        public TimeSpan HoraReserva { get; set; }
        public string MetodoPago { get; set; }
        public decimal Total { get; set; } = 0.0m;
    }

    
}
