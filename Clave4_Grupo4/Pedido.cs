using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave4_Grupo4
{
   public class Pedido
    {
        
    
        public string Comida { get; set; }
        public int CantidadComida { get; set; }
        public string Bebida { get; set; }
        public int CantidadBebida { get; set; }
        public string MetodoPago { get; set; }
        public string Cafetin { get; set; }
        public DateTime FechaHora { get; set; }
        public decimal Total { get; private set; }
        public Usuario Usuario { get; set; }
        private readonly Dictionary<string, decimal> comidas;
        private readonly Dictionary<string, decimal> bebidas;

        //Generamos constructor
        public Pedido(string comida, int cantidadComida, string bebida, int cantidadBebida,
                  string metodoPago, string cafetin, DateTime fechaHora, Usuario usuario,
                  Dictionary<string, decimal> comidasPrecios, Dictionary<string, decimal> bebidasPrecios)
        {
            Comida = comida;
            CantidadComida = cantidadComida;
            Bebida = bebida;
            CantidadBebida = cantidadBebida;
            MetodoPago = metodoPago;
            Cafetin = cafetin;
            FechaHora = fechaHora;
            Usuario = usuario; 
            comidas = comidasPrecios;
            bebidas = bebidasPrecios;
            CalcularTotal();

        }
       //Metodo para calcular el total de comidas y bebidas
        private void CalcularTotal()
        {
            Total = 0;

            // Calcular total de la comida
            if (comidas.ContainsKey(Comida))
            {
                Total += comidas[Comida] * CantidadComida;
            }

            // Calcular total de la bebida
            if (bebidas.ContainsKey(Bebida))
            {
                Total += bebidas[Bebida] * CantidadBebida;
            }
        }

        // Método para ver el resumen del pedido
        public override string ToString()
        {
            string usuarioNombre = Usuario != null ? Usuario.Correo : "Usuario no especificado";
            return $"Pedido: {Comida} x {CantidadComida}, {Bebida} x {CantidadBebida}\n" +
                   $"Total: {Total:C}, Método de Pago: {MetodoPago}, Cafetín: {Cafetin}\n" +
                   $"Hora del pedido: {FechaHora}, Usuario: {usuarioNombre}";
        }

    }

    
}
