using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave4_Grupo4
{
    class Usuario
    {
        public Usuario(string correo, string tipoUsuario)
        {
            Correo = correo;
            TipoUsuario = tipoUsuario;
        }

        public string Correo { get; set; }
        public string TipoUsuario { get; set; }
    }
}
