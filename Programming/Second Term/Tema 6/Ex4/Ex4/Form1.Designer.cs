namespace Ex4
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
            this.btnShowList = new System.Windows.Forms.Button();
            this.btnRemovePrime = new System.Windows.Forms.Button();
            this.btnCopyPrime = new System.Windows.Forms.Button();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(326, 366);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(149, 55);
            this.btnShowList.TabIndex = 7;
            this.btnShowList.Text = "Show Lists";
            this.btnShowList.UseVisualStyleBackColor = true;
            // 
            // btnRemovePrime
            // 
            this.btnRemovePrime.Location = new System.Drawing.Point(326, 180);
            this.btnRemovePrime.Name = "btnRemovePrime";
            this.btnRemovePrime.Size = new System.Drawing.Size(149, 55);
            this.btnRemovePrime.TabIndex = 6;
            this.btnRemovePrime.Text = "Remove Prime Numbers";
            this.btnRemovePrime.UseVisualStyleBackColor = true;
            // 
            // btnCopyPrime
            // 
            this.btnCopyPrime.Location = new System.Drawing.Point(326, 105);
            this.btnCopyPrime.Name = "btnCopyPrime";
            this.btnCopyPrime.Size = new System.Drawing.Size(149, 55);
            this.btnCopyPrime.TabIndex = 5;
            this.btnCopyPrime.Text = "Copy Prime Numbers";
            this.btnCopyPrime.UseVisualStyleBackColor = true;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(326, 30);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(149, 55);
            this.btnAddToList.TabIndex = 4;
            this.btnAddToList.Text = "Add To List";
            this.btnAddToList.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.btnRemovePrime);
            this.Controls.Add(this.btnCopyPrime);
            this.Controls.Add(this.btnAddToList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Button btnRemovePrime;
        private System.Windows.Forms.Button btnCopyPrime;
        private System.Windows.Forms.Button btnAddToList;
    }
}

