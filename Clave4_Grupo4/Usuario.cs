using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave4_Grupo4
{
   public class Usuario
    {
        public Usuario(string correo, string contraseña, string tipoUsuario)
        {
            Correo = correo;
            Contraseña = contraseña;
            TipoUsuario = tipoUsuario;
        }

        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string TipoUsuario { get; set; }
    }
}
