﻿using MySql.Data.MySqlClient;
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
    internal class Conexion
    {
        //Codigo para conexion
        static string servidor = "localhost"; // Nombre o id servidor SQL
        static string bd = "cafetin"; // Nombre de la base
        static string usuario = "root"; //Usuario de acceso a MySQL
        static string password = "1234"; //Contraseña de usuario de acceso a MySQL
                                         //Crearemos la cadena de conexión concatenando las variables
        static string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor +
        "; User Id=" + usuario + "; Password=" + password + "";
        //Instancia para conexión a MySQL, recibe la cadena de conexión
        static MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

    }
    public partial class GestorUsuario : Form
    {
        public GestorUsuario()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
