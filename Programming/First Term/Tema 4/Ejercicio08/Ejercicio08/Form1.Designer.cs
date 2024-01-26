namespace Ejercicio08
{
    partial class Form1
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
            this.btnCalcularNota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcularNota
            // 
            this.btnCalcularNota.Location = new System.Drawing.Point(299, 238);
            this.btnCalcularNota.Name = "btnCalcularNota";
            this.btnCalcularNota.Size = new System.Drawing.Size(339, 147);
            this.btnCalcularNota.TabIndex = 0;
            this.btnCalcularNota.Text = "CALCULAR NOTA";
            this.btnCalcularNota.UseVisualStyleBackColor = true;
            this.btnCalcularNota.Click += new System.EventHandler(this.btnCalcularNota_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularNota);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularNota;
    }
}

