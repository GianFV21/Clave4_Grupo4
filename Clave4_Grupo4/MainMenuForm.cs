﻿using System;
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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        
        private void btnrealizarpedido_Click(object sender, EventArgs e)
        {
           //instanciamos un nuevo formulario
            Realizar_Pedido realizar_Pedido = new Realizar_Pedido();
            //muestra formulario realizar pedido
            realizar_Pedido.Show();
        }
    }
}
