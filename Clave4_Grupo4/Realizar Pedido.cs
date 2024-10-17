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
        public Realizar_Pedido()
        {
            InitializeComponent();
            cbxlistadocomida.Items.Clear();
            cbxlistadocomida.Items.AddRange(comidas.Keys.ToArray());
            cbxlistadobebida.Items.Clear();
            cbxlistadobebida.Items.AddRange(bebidas.Keys.ToArray());
        }

       
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
        private Dictionary<string, decimal> bebidas = new Dictionary<string, decimal>()
    {
        { "Refresco", 0.75m },
        { "Jugo Natural", 1.00m },
        { "Café", 0.25m }
    };

        private void btningresarpedido_Click(object sender, EventArgs e)
        {
            decimal Total = 0;
            string comidaSeleccionada = cbxlistadocomida.SelectedItem?.ToString();
            string bebidaSeleccionada = cbxlistadobebida.SelectedItem?.ToString();
            datetimepedido.Format = DateTimePickerFormat.Custom;
            datetimepedido.CustomFormat = "dd/MM/yyyy HH:mm";
            datetimepedido.ShowUpDown = true;
            if (!int.TryParse(txtcantidadcomida.Text, out int cantidadComida) || cantidadComida <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida de comida.");
                return;
            }
            if (!int.TryParse(txtcantidadbebida.Text, out int cantidadBebida) || cantidadBebida <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida de bebida.");
                return;
            }

            if (comidas.ContainsKey(comidaSeleccionada))
            {
                decimal precioComida = comidas[comidaSeleccionada];
                Total += precioComida * cantidadComida;

            }
            if (bebidas.ContainsKey(bebidaSeleccionada))
            {
                decimal precioBebida = bebidas[bebidaSeleccionada];
                Total += precioBebida * cantidadBebida;
            }
            DateTime fechaHoraPedido = datetimepedido.Value;
            MessageBox.Show($"Total a pagar por {cantidadComida} comida(s) y {cantidadBebida} bebida(s): ${Total:F2}\n" +
                    $"Su pedido se ha programado para: {fechaHoraPedido:dd/MM/yyyy HH:mm}");
        

    }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcantidadcomida.Text = "";
            txtcantidadbebida.Text = "";
            txtcantidadcomida.Focus();
            txtcantidadbebida.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            formingreso formingreso = new formingreso();
            formingreso.Show();

        }
    }
}
