using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Clave4_Grupo4
{
    public partial class GestorUsuario : Form
    {
        static string servidor = "localhost"; // Nombre o IP del servidor de MySQL
        static string bd = "cafetin"; // Nombre de la base de datos
        static string usuario = "root"; // Usuario de acceso a MySQL
        static string password = "1234"; // Contraseña de usuario de acceso a MySQL

        // Cadena de conexión concatenando las variables
        static string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor +
        "; User Id=" + usuario + "; Password=" + password + "";

        // Instancia para conexión a MySQL
        static MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

        // Declarar los controles correctamente
        private TextBox txtPedidoID; // Control de texto para ID de pedido
        private DataGridView dataGridViewPedidos; // Control DataGridView para mostrar los datos

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
                conexionBD.Open(); // Se abre la conexión

                MessageBox.Show("Conexión Exitosa!"); // Muestra el estado de conexión
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexionBD.Close(); // Se cierra la conexión
            }
        }

        private void btnverusuarios_Click(object sender, EventArgs e)
        {
            MySqlCommand consulta = new MySqlCommand();
            conexionBD.Open(); // Se abre la conexión
            consulta.Connection = conexionBD;
            consulta.CommandText = "SELECT * FROM Usuarios";

            try
            {
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla);

                // Asigna la tabla al DataGridView para mostrar los resultados
               dtgver.DataSource = tabla;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnverpedidos_Click(object sender, EventArgs e)
        {
            MySqlCommand consulta = new MySqlCommand();
            conexionBD.Open();
            consulta.Connection = conexionBD;

            // Consulta de todos los pedidos y sus detalles
            consulta.CommandText = @"SELECT p.ID AS PedidoID, u.Usuario AS NombreUsuario, p.Fecha, 
                                     m.Nombre AS NombreProducto, dp.Cantidad, m.Precio
                                     FROM Pedidos p
                                     JOIN Usuarios u ON p.IDUsuario = u.ID
                                     JOIN DetallesPedido dp ON dp.IDPedido = p.ID
                                     JOIN Menu m ON dp.IDMenu = m.ID";

            try
            {
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla);

                // Asigna la tabla al DataGridView para mostrar los resultados
                dtgver.DataSource = tabla;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int pedidoId;
            if (int.TryParse(txtPedidoID.Text, out pedidoId))
            {
                MySqlCommand consulta = new MySqlCommand();
                conexionBD.Open();
                consulta.Connection = conexionBD;

                // Consulta para eliminar un pedido específ
            }
        }
    }
}