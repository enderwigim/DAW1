namespace Ex3
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
            this.btnAddToList = new System.Windows.Forms.Button();
            this.btnCopyPrime = new System.Windows.Forms.Button();
            this.btnRemovePrime = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(327, 12);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(149, 55);
            this.btnAddToList.TabIndex = 0;
            this.btnAddToList.Text = "Add To List";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // btnCopyPrime
            // 
            this.btnCopyPrime.Location = new System.Drawing.Point(327, 87);
            this.btnCopyPrime.Name = "btnCopyPrime";
            this.btnCopyPrime.Size = new System.Drawing.Size(149, 55);
            this.btnCopyPrime.TabIndex = 1;
            this.btnCopyPrime.Text = "Copy Prime Numbers";
            this.btnCopyPrime.UseVisualStyleBackColor = true;
            this.btnCopyPrime.Click += new System.EventHandler(this.btnCopyPrime_Click);
            // 
            // btnRemovePrime
            // 
            this.btnRemovePrime.Location = new System.Drawing.Point(327, 162);
            this.btnRemovePrime.Name = "btnRemovePrime";
            this.btnRemovePrime.Size = new System.Drawing.Size(149, 55);
            this.btnRemovePrime.TabIndex = 2;
            this.btnRemovePrime.Text = "Remove Prime Numbers";
            this.btnRemovePrime.UseVisualStyleBackColor = true;
            this.btnRemovePrime.Click += new System.EventHandler(this.btnRemovePrime_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(327, 348);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(149, 55);
            this.btnShowList.TabIndex = 3;
            this.btnShowList.Text = "Show Lists";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
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

        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Button btnCopyPrime;
        private System.Windows.Forms.Button btnRemovePrime;
        private System.Windows.Forms.Button btnShowList;
    }
}

