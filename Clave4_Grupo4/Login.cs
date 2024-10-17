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
            string Correo;
            string Contraseña;
            Correo = txtingresousuario.Text.Trim();
            Contraseña = txtcontraseña.Text.Trim();
            if(String.IsNullOrEmpty(txtingresousuario.Text))
            {
                MessageBox.Show("El campo no esta lleno" + Correo);
                return;
            }
            if(String.IsNullOrEmpty(txtcontraseña.Text))
            {
                MessageBox.Show("El campo no esta lleno" + Contraseña);
                return;
            }
                MessageBox.Show("Inicio de sesión exitoso.");
                this.Hide();
                MainMenuForm mainMenu = new MainMenuForm();
                mainMenu.Show();

            



        }
        



    }
}
