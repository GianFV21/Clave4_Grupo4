
namespace Clave4_Grupo4
{
    partial class formingreso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formingreso));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureboxlogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtingresousuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtingresar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxtipousuario = new System.Windows.Forms.ComboBox();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese usuario";
            // 
            // pictureboxlogo
            // 
            this.pictureboxlogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxlogo.Image")));
            this.pictureboxlogo.Location = new System.Drawing.Point(12, 23);
            this.pictureboxlogo.Name = "pictureboxlogo";
            this.pictureboxlogo.Size = new System.Drawing.Size(82, 99);
            this.pictureboxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxlogo.TabIndex = 1;
            this.pictureboxlogo.TabStop = false;
            this.pictureboxlogo.Click += new System.EventHandler(this.pictureboxlogo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(123, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtingresousuario
            // 
            this.txtingresousuario.Location = new System.Drawing.Point(136, 201);
            this.txtingresousuario.Name = "txtingresousuario";
            this.txtingresousuario.Size = new System.Drawing.Size(268, 20);
            this.txtingresousuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(136, 272);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(268, 20);
            this.txtcontraseña.TabIndex = 5;
            // 
            // txtingresar
            // 
            this.txtingresar.Location = new System.Drawing.Point(78, 339);
            this.txtingresar.Name = "txtingresar";
            this.txtingresar.Size = new System.Drawing.Size(97, 34);
            this.txtingresar.TabIndex = 6;
            this.txtingresar.Text = "Ingresar";
            this.txtingresar.UseVisualStyleBackColor = true;
            this.txtingresar.Click += new System.EventHandler(this.txtingresar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo Usuario";
            // 
            // cbxtipousuario
            // 
            this.cbxtipousuario.FormattingEnabled = true;
            this.cbxtipousuario.Items.AddRange(new object[] {
            "Estudiante",
            "Docente",
            "Personal administrativo"});
            this.cbxtipousuario.Location = new System.Drawing.Point(162, 159);
            this.cbxtipousuario.Name = "cbxtipousuario";
            this.cbxtipousuario.Size = new System.Drawing.Size(193, 21);
            this.cbxtipousuario.TabIndex = 8;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(228, 339);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(97, 34);
            this.btnsalir.TabIndex = 9;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // formingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.cbxtipousuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtingresar);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtingresousuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureboxlogo);
            this.Controls.Add(this.label1);
            this.Name = "formingreso";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureboxlogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtingresousuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Button txtingresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxtipousuario;
        private System.Windows.Forms.Button btnsalir;
    }
}

