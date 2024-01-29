namespace Exercise_7
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
            this.btnCopyRemove = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.btnOrderList = new System.Windows.Forms.Button();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCopyRemove
            // 
            this.btnCopyRemove.Location = new System.Drawing.Point(326, 268);
            this.btnCopyRemove.Name = "btnCopyRemove";
            this.btnCopyRemove.Size = new System.Drawing.Size(149, 55);
            this.btnCopyRemove.TabIndex = 13;
            this.btnCopyRemove.Text = "Copy Into New and Delete";
            this.btnCopyRemove.UseVisualStyleBackColor = true;
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(326, 366);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(149, 55);
            this.btnShowList.TabIndex = 12;
            this.btnShowList.Text = "Show Lists";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(326, 180);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(149, 55);
            this.btnCreateNew.TabIndex = 11;
            this.btnCreateNew.Text = "Copy Into New";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            // 
            // btnOrderList
            // 
            this.btnOrderList.Location = new System.Drawing.Point(326, 105);
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Size = new System.Drawing.Size(149, 55);
            this.btnOrderList.TabIndex = 10;
            this.btnOrderList.Text = "Order List";
            this.btnOrderList.UseVisualStyleBackColor = true;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(326, 30);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(149, 55);
            this.btnAddToList.TabIndex = 9;
            this.btnAddToList.Text = "Add To List";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCopyRemove);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.btnOrderList);
            this.Controls.Add(this.btnAddToList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCopyRemove;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.Button btnOrderList;
        private System.Windows.Forms.Button btnAddToList;
    }
}

