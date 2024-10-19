
namespace Clave4_Grupo4
{
    partial class GestionUsuarios
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
            this.btnverusuario = new System.Windows.Forms.Button();
            this.btnverpedido = new System.Windows.Forms.Button();
            this.dtgvergeneral = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvergeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // btnverusuario
            // 
            this.btnverusuario.Location = new System.Drawing.Point(53, 44);
            this.btnverusuario.Name = "btnverusuario";
            this.btnverusuario.Size = new System.Drawing.Size(92, 36);
            this.btnverusuario.TabIndex = 0;
            this.btnverusuario.Text = "Ver Usuario";
            this.btnverusuario.UseVisualStyleBackColor = true;
            this.btnverusuario.Click += new System.EventHandler(this.btnverusuario_Click);
            // 
            // btnverpedido
            // 
            this.btnverpedido.Location = new System.Drawing.Point(393, 44);
            this.btnverpedido.Name = "btnverpedido";
            this.btnverpedido.Size = new System.Drawing.Size(92, 36);
            this.btnverpedido.TabIndex = 1;
            this.btnverpedido.Text = "Ver Pedido";
            this.btnverpedido.UseVisualStyleBackColor = true;
            this.btnverpedido.Click += new System.EventHandler(this.btnverpedido_Click);
            // 
            // dtgvergeneral
            // 
            this.dtgvergeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvergeneral.Location = new System.Drawing.Point(12, 97);
            this.dtgvergeneral.Name = "dtgvergeneral";
            this.dtgvergeneral.Size = new System.Drawing.Size(673, 237);
            this.dtgvergeneral.TabIndex = 2;
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvergeneral);
            this.Controls.Add(this.btnverpedido);
            this.Controls.Add(this.btnverusuario);
            this.Name = "GestionUsuarios";
            this.Text = "GestionUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvergeneral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnverusuario;
        private System.Windows.Forms.Button btnverpedido;
        private System.Windows.Forms.DataGridView dtgvergeneral;
    }
}