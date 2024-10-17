
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 165);
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
            this.txtingresousuario.Location = new System.Drawing.Point(136, 162);
            this.txtingresousuario.Name = "txtingresousuario";
            this.txtingresousuario.Size = new System.Drawing.Size(268, 20);
            this.txtingresousuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(136, 216);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(268, 20);
            this.txtcontraseña.TabIndex = 5;
            // 
            // txtingresar
            // 
            this.txtingresar.Location = new System.Drawing.Point(198, 271);
            this.txtingresar.Name = "txtingresar";
            this.txtingresar.Size = new System.Drawing.Size(97, 34);
            this.txtingresar.TabIndex = 6;
            this.txtingresar.Text = "Ingresar";
            this.txtingresar.UseVisualStyleBackColor = true;
            this.txtingresar.Click += new System.EventHandler(this.txtingresar_Click);
            // 
            // formingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
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
    }
}

