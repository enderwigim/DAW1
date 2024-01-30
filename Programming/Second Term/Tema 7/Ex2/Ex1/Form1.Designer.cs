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
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnShowPerson = new System.Windows.Forms.Button();
            this.btnShowEveryone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(282, 52);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(175, 80);
            this.btnAddPerson.TabIndex = 0;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnShowPerson
            // 
            this.btnShowPerson.Location = new System.Drawing.Point(282, 169);
            this.btnShowPerson.Name = "btnShowPerson";
            this.btnShowPerson.Size = new System.Drawing.Size(175, 80);
            this.btnShowPerson.TabIndex = 1;
            this.btnShowPerson.Text = "Show Person";
            this.btnShowPerson.UseVisualStyleBackColor = true;
            this.btnShowPerson.Click += new System.EventHandler(this.btnShowPerson_Click);
            // 
            // btnShowEveryone
            // 
            this.btnShowEveryone.Location = new System.Drawing.Point(282, 274);
            this.btnShowEveryone.Name = "btnShowEveryone";
            this.btnShowEveryone.Size = new System.Drawing.Size(175, 80);
            this.btnShowEveryone.TabIndex = 2;
            this.btnShowEveryone.Text = "Show Every Text";
            this.btnShowEveryone.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowEveryone);
            this.Controls.Add(this.btnShowPerson);
            this.Controls.Add(this.btnAddPerson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnShowPerson;
        private System.Windows.Forms.Button btnShowEveryone;
    }
}

