namespace Ex1
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
            this.btnCreateCircle = new System.Windows.Forms.Button();
            this.btnCreateSquare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateCircle
            // 
            this.btnCreateCircle.Location = new System.Drawing.Point(38, 37);
            this.btnCreateCircle.Name = "btnCreateCircle";
            this.btnCreateCircle.Size = new System.Drawing.Size(192, 78);
            this.btnCreateCircle.TabIndex = 0;
            this.btnCreateCircle.Text = "Crear Circulo";
            this.btnCreateCircle.UseVisualStyleBackColor = true;
            this.btnCreateCircle.Click += new System.EventHandler(this.btnCreateCircle_Click);
            // 
            // btnCreateSquare
            // 
            this.btnCreateSquare.Location = new System.Drawing.Point(325, 37);
            this.btnCreateSquare.Name = "btnCreateSquare";
            this.btnCreateSquare.Size = new System.Drawing.Size(192, 78);
            this.btnCreateSquare.TabIndex = 1;
            this.btnCreateSquare.Text = "Crear Cuadrado";
            this.btnCreateSquare.UseVisualStyleBackColor = true;
            this.btnCreateSquare.Click += new System.EventHandler(this.btnCreateSquare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 164);
            this.Controls.Add(this.btnCreateSquare);
            this.Controls.Add(this.btnCreateCircle);
            this.Name = "Form1";
            this.Text = "Ex1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateCircle;
        private System.Windows.Forms.Button btnCreateSquare;
    }
}

