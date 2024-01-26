namespace Ejercicio_13
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
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnWhileLoop = new System.Windows.Forms.Button();
            this.btnForLoop = new System.Windows.Forms.Button();
            this.lblIntroduzcaNum = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(520, 244);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(145, 59);
            this.btnDoWhile.TabIndex = 9;
            this.btnDoWhile.Text = "DO WHILE";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnWhileLoop
            // 
            this.btnWhileLoop.Location = new System.Drawing.Point(330, 244);
            this.btnWhileLoop.Name = "btnWhileLoop";
            this.btnWhileLoop.Size = new System.Drawing.Size(145, 59);
            this.btnWhileLoop.TabIndex = 8;
            this.btnWhileLoop.Text = "WHILE";
            this.btnWhileLoop.UseVisualStyleBackColor = true;
            this.btnWhileLoop.Click += new System.EventHandler(this.btnWhileLoop_Click);
            // 
            // btnForLoop
            // 
            this.btnForLoop.Location = new System.Drawing.Point(136, 244);
            this.btnForLoop.Name = "btnForLoop";
            this.btnForLoop.Size = new System.Drawing.Size(145, 59);
            this.btnForLoop.TabIndex = 7;
            this.btnForLoop.Text = "FOR";
            this.btnForLoop.UseVisualStyleBackColor = true;
            this.btnForLoop.Click += new System.EventHandler(this.btnForLoop_Click);
            // 
            // lblIntroduzcaNum
            // 
            this.lblIntroduzcaNum.AutoSize = true;
            this.lblIntroduzcaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroduzcaNum.Location = new System.Drawing.Point(189, 148);
            this.lblIntroduzcaNum.Name = "lblIntroduzcaNum";
            this.lblIntroduzcaNum.Size = new System.Drawing.Size(149, 20);
            this.lblIntroduzcaNum.TabIndex = 6;
            this.lblIntroduzcaNum.Text = "Introduzca Numero:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(344, 148);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(207, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhileLoop);
            this.Controls.Add(this.btnForLoop);
            this.Controls.Add(this.lblIntroduzcaNum);
            this.Controls.Add(this.txtNumero);
            this.Name = "Form1";
            this.Text = "Ejercicio 13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnWhileLoop;
        private System.Windows.Forms.Button btnForLoop;
        private System.Windows.Forms.Label lblIntroduzcaNum;
        private System.Windows.Forms.TextBox txtNumero;
    }
}

