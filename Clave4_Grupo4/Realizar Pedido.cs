using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Clave4_Grupo4
{
    public partial class Realizar_Pedido : Form
    {
        private Usuario usuario;
       
        public Realizar_Pedido() // Constructor sin parámetros 
        {
            InitializeComponent();
        }
        public Realizar_Pedido(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            cbxlistadocomida.Items.Clear();
            cbxlistadocomida.Items.AddRange(comidas.Keys.ToArray());
            cbxlistadobebida.Items.Clear();
            cbxlistadobebida.Items.AddRange(bebidas.Keys.ToArray());
            cbxmetododepago.Items.Clear();
            cbxmetododepago.Items.AddRange(new string[] { "Efectivo", "Bitcoin", "Tarjeta" });
            cbxlistacafetines.Items.Clear();
            cbxlistacafetines.Items.AddRange(new string[] { "Cafetin 1", "Cafetin 2", "Cafetin 3", "Cafetin 4" });
        }

        //declaramos una libreria donde estan comida y precio
        private Dictionary<string, decimal> comidas= new Dictionary<string, decimal>()
    {
        { "Pupusas de arroz", 0.75m },
        { "Pupusas de frijol con queso", 0.60m },
        { "Pupusas con camarón", 1.25m },
        { "Pupusas de mora", 1.25m },
        { "Pupusas con pollo", 1.25m },
        { "Pupusas con jamón", 1.25m },
        { "Empanadas", 0.15m },
        { "Pastelitos", 0.15m },
        { "Atol", 0.25m }
    };
        //declaramos una libreria donde estan bebida y precio
        private Dictionary<string, decimal> bebidas = new Dictionary<string, decimal>()
    {
        { "Refresco", 0.75m },
        { "Jugo Natural", 1.00m },
        { "Café", 0.25m }
    };

        private void btningresarpedido_Click(object sender, EventArgs e)
        {
           //declaramos variable total
            decimal Total = 0;
            
            //el usuario selecciona que quiere del listado
            //listado comida
            string comidaSeleccionada = cbxlistadocomida.SelectedItem?.ToString();
            //listado bebida
            string bebidaSeleccionada = cbxlistadobebida.SelectedItem?.ToString();
            //metodo de pago
            string metodoPagoSeleccionado = cbxmetododepago.SelectedItem?.ToString();
            //cafetin donde quiere la comida y bebida
            string cafetinSeleccionado = cbxlistacafetines.SelectedItem?.ToString();
            //declaramos un date time custom
            datetimepedido.Format = DateTimePickerFormat.Custom;
            datetimepedido.CustomFormat = "dd/MM/yyyy HH:mm";
            datetimepedido.ShowUpDown = true;
            //validamos entradas vacias de txt comida
            if (!int.TryParse(txtcantidadcomida.Text, out int cantidadComida) || cantidadComida <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida de comida.");
                return;
            }
            //validamos entradas vacias de txt bebida
            if (!int.TryParse(txtcantidadbebida.Text, out int cantidadBebida) || cantidadBebida <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida de bebida.");
                return;
            }
            //Declaramos que el usuario ingrese fecha y hora de pedido
            DateTime fechaHoraPedido = datetimepedido.Value;
            //Validamos que los antojitos se puedan de 2 a 4 pm
            if ((comidaSeleccionada == "Empanadas" || comidaSeleccionada == "Pastelitos" || comidaSeleccionada == "Atol")
                && (fechaHoraPedido.Hour < 14 || fechaHoraPedido.Hour >= 16))
            {
                MessageBox.Show("Los antojitos (Atol, Pastelitos, Empanadas) solo se pueden pedir entre 2:00 PM y 4:00 PM.");
                return;
            }
            //proceso de seleccion de comida
            if (comidas.ContainsKey(comidaSeleccionada))
            {
                decimal precioComida = comidas[comidaSeleccionada];
                Total += precioComida * cantidadComida;

            }
            //proceso de seleccion de bebida
            if (bebidas.ContainsKey(bebidaSeleccionada))
            {
                decimal precioBebida = bebidas[bebidaSeleccionada];
                Total += precioBebida * cantidadBebida;
            }
            //Creamos un objeto pedido
            Pedido nuevoPedido = new Pedido(
         comidaSeleccionada,
         cantidadComida,
         bebidaSeleccionada,
         cantidadBebida,
         metodoPagoSeleccionado,
         cafetinSeleccionado,
         fechaHoraPedido,
         this.usuario,
         comidas, // Agregado
         bebidas  // Agregado
     );
            //mostramos un mensaje que muestra comida, bebida, total, metodo pago, cafetin y hora del pedido
            MessageBox.Show(nuevoPedido.ToString());


        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            //limpiamos los text box
            txtcantidadcomida.Text = "";
            txtcantidadbebida.Text = "";
            cbxlistacafetines.SelectedIndex = -1;
            cbxlistadobebida.SelectedIndex = -1;
            cbxlistadocomida.SelectedIndex = -1;
            cbxmetododepago.SelectedIndex = -1;
            txtcantidadcomida.Focus();
            txtcantidadbebida.Focus();

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
           //cierra formulario 
            this.Hide();
            //instanciamos el fomulario login para volver a el
            formingreso formingreso = new formingreso();
            //muestra el formulario ingreso
            formingreso.Show();

        }
    }
}
