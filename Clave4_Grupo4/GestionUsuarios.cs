using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave4_Grupo4

{
    public partial class GestionUsuarios : Form
    {
        private Usuario usuario;
        public GestionUsuarios()
        {
            InitializeComponent();
        }
        public GestionUsuarios(Usuario usuario) : this() // Llama al constructor por defecto
        {
            this.usuario = usuario; // Almacena el usuario
        }



        private void btnverusuario_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = ObtenerUsuarios();
            var userList = new List<Usuario>();
            if (usuario != null)
            {
                userList.Add(usuario); // Agregar el usuario que inició sesión
            }
            userList.AddRange(usuarios);
            dtgvergeneral.DataSource = null;
            dtgvergeneral.Rows.Clear();
            dtgvergeneral.DataSource = userList.Select(u => new { u.Correo, u.TipoUsuario }).ToList();


        }
        private List<Usuario> ObtenerUsuarios()
        {
            
            return new List<Usuario>
            {
                new Usuario("usuario1@gmail.com", "contraseña1", "administrador"),
                new Usuario("usuario2@gmail.com", "contraseña2", "estudiante"),
                new Usuario("usuario3@gmail.com","contraseña3","docente"),
                
            };
        }

        
        private void btnverpedido_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario("correo@ejemplo.com", "contraseña", "tipoUsuario");

            Dictionary<string, decimal> comidas = new Dictionary<string, decimal>
    {
        { "Pupusas", 0.75m }
        // Agrega más comidas y precios según sea necesario
    };

            Dictionary<string, decimal> bebidas = new Dictionary<string, decimal>
    {
        { "Refresco", 0.75m }
        // Agrega más bebidas y precios según sea necesario
    };

            List<Pedido> pedidos = new List<Pedido>
    {
        new Pedido(
            "Pupusas",        // Comida
            3,                // CantidadComida
            "Refresco",       // Bebida
            1,                // CantidadBebida
            "Efectivo",       // MetodoPago
            "Cafetin 1",      // Cafetin
            DateTime.Now,     // FechaHora
            usuario,          // Usuario
            comidas,          // Comidas precios
            bebidas           // Bebidas precios
        )
    };

            dtgvergeneral.DataSource = null; // Evitar problemas de refresco
            dtgvergeneral.Rows.Clear(); // Limpiar filas
            dtgvergeneral.DataSource = pedidos.Select(p => new
            {
                p.Comida,
                p.CantidadComida,
                p.Bebida,
                p.CantidadBebida,
                p.Total,
                p.MetodoPago,
                p.Cafetin,
                p.FechaHora,
                UsuarioNombre = p.Usuario != null ? p.Usuario.Correo : "Usuario no especificado" // Mostrar el correo del usuario
            }).ToList();
        }
        
        
            

    }
}
