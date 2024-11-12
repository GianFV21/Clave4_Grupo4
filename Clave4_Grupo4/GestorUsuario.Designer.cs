
namespace Clave4_Grupo4
{
    partial class GestorUsuario
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
            this.btnconexionbasedatos = new System.Windows.Forms.Button();
            this.btnverusuarios = new System.Windows.Forms.Button();
            this.btnverpedidos = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.dtgver = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgver)).BeginInit();
            this.SuspendLayout();
            // 
            // btnconexionbasedatos
            // 
            this.btnconexionbasedatos.Location = new System.Drawing.Point(487, 56);
            this.btnconexionbasedatos.Name = "btnconexionbasedatos";
            this.btnconexionbasedatos.Size = new System.Drawing.Size(98, 48);
            this.btnconexionbasedatos.TabIndex = 0;
            this.btnconexionbasedatos.Text = "Conexion Base Datos";
            this.btnconexionbasedatos.UseVisualStyleBackColor = true;
            // 
            // btnverusuarios
            // 
            this.btnverusuarios.Location = new System.Drawing.Point(487, 142);
            this.btnverusuarios.Name = "btnverusuarios";
            this.btnverusuarios.Size = new System.Drawing.Size(98, 48);
            this.btnverusuarios.TabIndex = 1;
            this.btnverusuarios.Text = "Ver Usuarios";
            this.btnverusuarios.UseVisualStyleBackColor = true;
            // 
            // btnverpedidos
            // 
            this.btnverpedidos.Location = new System.Drawing.Point(487, 213);
            this.btnverpedidos.Name = "btnverpedidos";
            this.btnverpedidos.Size = new System.Drawing.Size(98, 48);
            this.btnverpedidos.TabIndex = 2;
            this.btnverpedidos.Text = "Ver pedidos";
            this.btnverpedidos.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(487, 294);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(98, 48);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(487, 369);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(98, 48);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // dtgver
            // 
            this.dtgver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgver.Location = new System.Drawing.Point(32, 93);
            this.dtgver.Name = "dtgver";
            this.dtgver.Size = new System.Drawing.Size(431, 279);
            this.dtgver.TabIndex = 5;
            // 
            // GestorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.dtgver);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnverpedidos);
            this.Controls.Add(this.btnverusuarios);
            this.Controls.Add(this.btnconexionbasedatos);
            this.Name = "GestorUsuario";
            this.Text = "GestorUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dtgver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnconexionbasedatos;
        private System.Windows.Forms.Button btnverusuarios;
        private System.Windows.Forms.Button btnverpedidos;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridView dtgver;
    }
}