namespace Ejercicio_20
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblBase = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblExponente = new System.Windows.Forms.Label();
            this.txtExponente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(360, 244);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(145, 59);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(198, 146);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(130, 20);
            this.lblBase.TabIndex = 10;
            this.lblBase.Text = "Introduzca Base:";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(374, 148);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(207, 20);
            this.txtBase.TabIndex = 9;
            // 
            // lblExponente
            // 
            this.lblExponente.AutoSize = true;
            this.lblExponente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExponente.Location = new System.Drawing.Point(198, 184);
            this.lblExponente.Name = "lblExponente";
            this.lblExponente.Size = new System.Drawing.Size(170, 20);
            this.lblExponente.TabIndex = 13;
            this.lblExponente.Text = "Introduzca Exponente:";
            // 
            // txtExponente
            // 
            this.txtExponente.Location = new System.Drawing.Point(374, 186);
            this.txtExponente.Name = "txtExponente";
            this.txtExponente.Size = new System.Drawing.Size(207, 20);
            this.txtExponente.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblExponente);
            this.Controls.Add(this.txtExponente);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.txtBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblExponente;
        private System.Windows.Forms.TextBox txtExponente;
    }
}

