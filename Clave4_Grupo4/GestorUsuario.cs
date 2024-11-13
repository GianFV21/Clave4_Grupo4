using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave4_Grupo4
{

    public partial class GestorUsuario : Form
    {
        static string servidor = "localhost"; //Nombre o ip del servidor de MySQL
        static string bd = "cafetin"; //Nombre de la base de datos
        static string usuario = "root"; //Usuario de acceso a MySQL
        static string password = "1234"; //Contraseña de usuario de acceso a MySQL
                                         //Crearemos la cadena de conexión concatenando las variables
        static string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor +
        "; User Id=" + usuario + "; Password=" + password + "";

        //Instancia para conexión a MySQL, recibe la cadena de conexión
        static MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

        public GestorUsuario()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnconexionbasedatos_Click(object sender, EventArgs e)
        {
                try
                {
                    conexionBD.Open(); //se abre la conexion de la variable declarada en la parte superior del formulario

                MessageBox.Show("Conexión Exitosa!"); //se manda un mensaje de estado de conexion
                }
                catch (Exception ex)
                {
                MessageBox.Show("Error: " + ex);
                }
                finally
                {
                    conexionBD.Close(); //se cierra la conexion
                }
            }
            




        private void btnverusuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnverpedidos_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
