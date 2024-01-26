namespace Ejercicio14
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
            this.btnFOR = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFOR
            // 
            this.btnFOR.Location = new System.Drawing.Point(173, 255);
            this.btnFOR.Name = "btnFOR";
            this.btnFOR.Size = new System.Drawing.Size(149, 54);
            this.btnFOR.TabIndex = 0;
            this.btnFOR.Text = "FOR";
            this.btnFOR.UseVisualStyleBackColor = true;
            this.btnFOR.Click += new System.EventHandler(this.btnFOR_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(473, 255);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(149, 54);
            this.btnWhile.TabIndex = 1;
            this.btnWhile.Text = "WHILE";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFOR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFOR;
        private System.Windows.Forms.Button btnWhile;
    }
}

