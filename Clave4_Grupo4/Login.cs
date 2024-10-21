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

    public partial class formingreso : Form
    {
        private List<Pedido> listaPedidos;
        public formingreso()
        {
            InitializeComponent();
            listaPedidos = new List<Pedido>();
        }

        private void pictureboxlogo_Click(object sender, EventArgs e)
        {
            pictureboxlogo.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                pictureboxlogo.Image = Image.FromFile(@"C:\Users\bligh\Downloads\800px-Logo_UES.jpg");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar" + ex.Message);
            }
        }

        private void txtingresar_Click(object sender, EventArgs e)
        {
            //Creamos instancia Usuario
            Usuario usuario = new Usuario(
                txtingresousuario.Text.Trim(),//usuario
                txtcontraseña.Text.Trim(),//contraseña
                cbxtipousuario.SelectedItem.ToString()//tipo de usuario
                );
            List<Pedido> listaPedidos = new List<Pedido>();
            //Validacion del tipo de usuario
            if (usuario.TipoUsuario == "Estudiante" || usuario.TipoUsuario == "Docente" || usuario.TipoUsuario == "Personal administrativo")
            {
                // Mensaje de inicio de sesión exitoso
                MessageBox.Show("Inicio de sesión exitoso.");
                MessageBox.Show($"Usuario: {usuario.Correo}, Tipo: {usuario.TipoUsuario}");

                //cierra el formulario login
                this.Hide();
                //instanciamos un nuevo formulario
                Realizar_Pedido realizar_Pedido = new Realizar_Pedido(listaPedidos, usuario);
                realizar_Pedido.Show();



            }
            //para personal administrativo cuando tengamos el sql





        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
