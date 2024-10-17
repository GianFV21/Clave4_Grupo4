
namespace Clave4_Grupo4
{
    partial class Realizar_Pedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbxlistadocomida = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxlistadobebida = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcantidadbebida = new System.Windows.Forms.TextBox();
            this.btningresarpedido = new System.Windows.Forms.Button();
            this.datetimepedido = new System.Windows.Forms.DateTimePicker();
            this.txtcantidadcomida = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btncerrarsesion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxlistacafetines = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxmetododepago = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "\t\tMENU",
            "Comidas:",
            "Pupusas de arroz -----------------------------------0.75",
            "",
            "Pupusas de frijo con queso-------------------------0.60",
            "",
            "Pupusas especiales:",
            "Pupusas con camaraon-----------------------------1.25",
            "",
            "Pupusas de mora-----------------------------------1.25",
            "",
            "Pupusas con pollo----------------------------------1.25",
            "",
            "Pupusas con jamon---------------------------------1.25",
            "",
            "Bebidas",
            "Refresco---------------------------------------------0.75",
            "",
            "Jugo Natural-----------------------------------------1.00",
            "",
            "Cafe--------------------------------------------------0.25",
            "",
            "Antojitos:",
            "Empanadas--------------------------------------------0.15",
            "",
            "Pastelitos\t----------------------------------------------0.15",
            "",
            "Atol-----------------------------------------------------0.25"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(242, 381);
            this.listBox1.TabIndex = 0;
            // 
            // cbxlistadocomida
            // 
            this.cbxlistadocomida.FormattingEnabled = true;
            this.cbxlistadocomida.Items.AddRange(new object[] {
            "Pupusas de arroz",
            "Pupusas de frijol con queso",
            "Pupusas con camaron",
            "Pupusas de mora",
            "Pupusas con pollo",
            "Pupusas con jamon",
            "Empanadas",
            "Pastelitos",
            "Atol"});
            this.cbxlistadocomida.Location = new System.Drawing.Point(322, 73);
            this.cbxlistadocomida.Name = "cbxlistadocomida";
            this.cbxlistadocomida.Size = new System.Drawing.Size(121, 21);
            this.cbxlistadocomida.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "que desea comer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "que desea beber";
            // 
            // cbxlistadobebida
            // 
            this.cbxlistadobebida.FormattingEnabled = true;
            this.cbxlistadobebida.Items.AddRange(new object[] {
            "Refresco",
            "Jugo natural",
            "cafe"});
            this.cbxlistadobebida.Location = new System.Drawing.Point(479, 73);
            this.cbxlistadobebida.Name = "cbxlistadobebida";
            this.cbxlistadobebida.Size = new System.Drawing.Size(121, 21);
            this.cbxlistadobebida.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese la cantidad";
            // 
            // txtcantidadbebida
            // 
            this.txtcantidadbebida.Location = new System.Drawing.Point(495, 132);
            this.txtcantidadbebida.Name = "txtcantidadbebida";
            this.txtcantidadbebida.Size = new System.Drawing.Size(100, 20);
            this.txtcantidadbebida.TabIndex = 6;
            // 
            // btningresarpedido
            // 
            this.btningresarpedido.Location = new System.Drawing.Point(283, 345);
            this.btningresarpedido.Name = "btningresarpedido";
            this.btningresarpedido.Size = new System.Drawing.Size(83, 48);
            this.btningresarpedido.TabIndex = 7;
            this.btningresarpedido.Text = "Ingresar pedido";
            this.btningresarpedido.UseVisualStyleBackColor = true;
            this.btningresarpedido.Click += new System.EventHandler(this.btningresarpedido_Click);
            // 
            // datetimepedido
            // 
            this.datetimepedido.CustomFormat = "dd/MM/yyyy HH:mm";
            this.datetimepedido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepedido.Location = new System.Drawing.Point(310, 287);
            this.datetimepedido.Name = "datetimepedido";
            this.datetimepedido.ShowUpDown = true;
            this.datetimepedido.Size = new System.Drawing.Size(242, 20);
            this.datetimepedido.TabIndex = 8;
            // 
            // txtcantidadcomida
            // 
            this.txtcantidadcomida.Location = new System.Drawing.Point(363, 129);
            this.txtcantidadcomida.Name = "txtcantidadcomida";
            this.txtcantidadcomida.Size = new System.Drawing.Size(100, 20);
            this.txtcantidadcomida.TabIndex = 9;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(401, 345);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(83, 48);
            this.btnlimpiar.TabIndex = 10;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btncerrarsesion
            // 
            this.btncerrarsesion.Location = new System.Drawing.Point(512, 345);
            this.btncerrarsesion.Name = "btncerrarsesion";
            this.btncerrarsesion.Size = new System.Drawing.Size(83, 48);
            this.btncerrarsesion.TabIndex = 11;
            this.btncerrarsesion.Text = "Cerrar Sesion";
            this.btncerrarsesion.UseVisualStyleBackColor = true;
            this.btncerrarsesion.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lista de cafetines";
            // 
            // cbxlistacafetines
            // 
            this.cbxlistacafetines.FormattingEnabled = true;
            this.cbxlistacafetines.Items.AddRange(new object[] {
            "Cafetin 1",
            "Cafetin 2",
            "Cafetin 3",
            "Cafetin 4"});
            this.cbxlistacafetines.Location = new System.Drawing.Point(365, 189);
            this.cbxlistacafetines.Name = "cbxlistacafetines";
            this.cbxlistacafetines.Size = new System.Drawing.Size(121, 21);
            this.cbxlistacafetines.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Metodo de pago";
            // 
            // cbxmetododepago
            // 
            this.cbxmetododepago.FormattingEnabled = true;
            this.cbxmetododepago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta ",
            "Bitcoin"});
            this.cbxmetododepago.Location = new System.Drawing.Point(365, 241);
            this.cbxmetododepago.Name = "cbxmetododepago";
            this.cbxmetododepago.Size = new System.Drawing.Size(121, 21);
            this.cbxmetododepago.TabIndex = 15;
            // 
            // Realizar_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxmetododepago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxlistacafetines);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncerrarsesion);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtcantidadcomida);
            this.Controls.Add(this.datetimepedido);
            this.Controls.Add(this.btningresarpedido);
            this.Controls.Add(this.txtcantidadbebida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxlistadobebida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxlistadocomida);
            this.Controls.Add(this.listBox1);
            this.Name = "Realizar_Pedido";
            this.Text = "Realizar_Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cbxlistadocomida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxlistadobebida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcantidadbebida;
        private System.Windows.Forms.Button btningresarpedido;
        private System.Windows.Forms.DateTimePicker datetimepedido;
        private System.Windows.Forms.TextBox txtcantidadcomida;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btncerrarsesion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxlistacafetines;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxmetododepago;
    }
}