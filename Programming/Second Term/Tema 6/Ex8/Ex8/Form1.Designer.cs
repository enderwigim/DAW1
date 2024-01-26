namespace Ex8
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
            this.btnGeneratePrimitiva = new System.Windows.Forms.Button();
            this.btnBuyTicket = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnGodMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeneratePrimitiva
            // 
            this.btnGeneratePrimitiva.Location = new System.Drawing.Point(284, 12);
            this.btnGeneratePrimitiva.Name = "btnGeneratePrimitiva";
            this.btnGeneratePrimitiva.Size = new System.Drawing.Size(166, 62);
            this.btnGeneratePrimitiva.TabIndex = 0;
            this.btnGeneratePrimitiva.Text = "Generate Primitiva";
            this.btnGeneratePrimitiva.UseVisualStyleBackColor = true;
            this.btnGeneratePrimitiva.Click += new System.EventHandler(this.btnGeneratePrimitiva_Click);
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.Location = new System.Drawing.Point(284, 99);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(166, 62);
            this.btnBuyTicket.TabIndex = 1;
            this.btnBuyTicket.Text = "Buy a ticket";
            this.btnBuyTicket.UseVisualStyleBackColor = true;
            this.btnBuyTicket.Click += new System.EventHandler(this.btnBuyTicket_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(284, 355);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(166, 62);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnGodMode
            // 
            this.btnGodMode.Location = new System.Drawing.Point(607, 355);
            this.btnGodMode.Name = "btnGodMode";
            this.btnGodMode.Size = new System.Drawing.Size(166, 62);
            this.btnGodMode.TabIndex = 3;
            this.btnGodMode.Text = "GOD MODE ACTIVATED";
            this.btnGodMode.UseVisualStyleBackColor = true;
            this.btnGodMode.Click += new System.EventHandler(this.btnGodMode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGodMode);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnBuyTicket);
            this.Controls.Add(this.btnGeneratePrimitiva);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeneratePrimitiva;
        private System.Windows.Forms.Button btnBuyTicket;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnGodMode;
    }
}

