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
        public formingreso()
        {
            InitializeComponent();
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
            //declaracion de variables a usar dentro del formulario login
            string Correo;
            string Contraseña;
            Correo = txtingresousuario.Text.Trim();
            Contraseña = txtcontraseña.Text.Trim();
            //seleccion del usuario dentro del formulario
            string tipoUsuario = cbxtipousuario.SelectedItem.ToString();
            //validacion para que el usuario elija un tipo usuario
            if (tipoUsuario == "Estudiante" || tipoUsuario == "Docente"|| tipoUsuario=="Personal administrativo")
            {
               //mensaje de inicio de sesion con exito
                MessageBox.Show("Inicio de sesión exitoso.");
                //cierra el formulario login
                this.Hide();
                //instanciamos el formulario menu
                MainMenuForm mainMenu = new MainMenuForm();
                //se dirige al formulario menu
                mainMenu.Show();
            }
           




        }

       
    }
}
