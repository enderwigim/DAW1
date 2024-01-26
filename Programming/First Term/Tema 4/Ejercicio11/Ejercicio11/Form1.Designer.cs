namespace Ejercicio11
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
            this.btnEsBisiesto = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEsBisiesto
            // 
            this.btnEsBisiesto.Location = new System.Drawing.Point(305, 299);
            this.btnEsBisiesto.Name = "btnEsBisiesto";
            this.btnEsBisiesto.Size = new System.Drawing.Size(162, 65);
            this.btnEsBisiesto.TabIndex = 0;
            this.btnEsBisiesto.Text = "CALCULAR";
            this.btnEsBisiesto.UseVisualStyleBackColor = true;
            this.btnEsBisiesto.Click += new System.EventHandler(this.btnEsBisiesto_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(305, 112);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(162, 20);
            this.txtYear.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.btnEsBisiesto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEsBisiesto;
        private System.Windows.Forms.TextBox txtYear;
    }
}

