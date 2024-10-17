using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave4_Grupo4
{
    class Usuario
    {
        public Usuario(int iDUsuario, string nombre, string tipo, string correo, string contraseña)
        {
            IDUsuario = iDUsuario;
            Nombre = nombre;
            Tipo = tipo;
            Correo = correo;
            Contraseña = contraseña;
        }

        public int IDUsuario { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; } //estudiante,docente,administrativo
        public string Correo { get; set; }
        public string Contraseña { get; set; }
    }
}
