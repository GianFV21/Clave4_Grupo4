
namespace Clave4_Grupo4
{
    partial class MainMenuForm
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
            this.btnrealizarpedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnrealizarpedido
            // 
            this.btnrealizarpedido.Location = new System.Drawing.Point(24, 121);
            this.btnrealizarpedido.Name = "btnrealizarpedido";
            this.btnrealizarpedido.Size = new System.Drawing.Size(94, 62);
            this.btnrealizarpedido.TabIndex = 1;
            this.btnrealizarpedido.Text = "Realizar Pedido";
            this.btnrealizarpedido.UseVisualStyleBackColor = true;
            this.btnrealizarpedido.Click += new System.EventHandler(this.btnrealizarpedido_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.btnrealizarpedido);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnrealizarpedido;
    }
}