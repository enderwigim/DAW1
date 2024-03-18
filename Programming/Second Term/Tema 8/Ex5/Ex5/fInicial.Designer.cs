namespace Ex5
{
    partial class Cursos
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
            this.btnTeachersAdministration = new System.Windows.Forms.Button();
            this.btnGestionAlumnos = new System.Windows.Forms.Button();
            this.bCursos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTeachersAdministration
            // 
            this.btnTeachersAdministration.Location = new System.Drawing.Point(38, 121);
            this.btnTeachersAdministration.Name = "btnTeachersAdministration";
            this.btnTeachersAdministration.Size = new System.Drawing.Size(136, 29);
            this.btnTeachersAdministration.TabIndex = 11;
            this.btnTeachersAdministration.Text = "Gestión de Profesores";
            this.btnTeachersAdministration.UseVisualStyleBackColor = true;
            this.btnTeachersAdministration.Click += new System.EventHandler(this.btnTeachersAdministration_Click);
            // 
            // btnGestionAlumnos
            // 
            this.btnGestionAlumnos.Location = new System.Drawing.Point(38, 70);
            this.btnGestionAlumnos.Name = "btnGestionAlumnos";
            this.btnGestionAlumnos.Size = new System.Drawing.Size(136, 29);
            this.btnGestionAlumnos.TabIndex = 10;
            this.btnGestionAlumnos.Text = "Gestión de Alumnos";
            this.btnGestionAlumnos.UseVisualStyleBackColor = true;
            this.btnGestionAlumnos.Click += new System.EventHandler(this.btnGestionAlumnos_Click);
            // 
            // bCursos
            // 
            this.bCursos.Location = new System.Drawing.Point(38, 20);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(136, 29);
            this.bCursos.TabIndex = 9;
            this.bCursos.Text = "Gestión de Cursos";
            this.bCursos.UseVisualStyleBackColor = true;
            this.bCursos.Click += new System.EventHandler(this.bCursos_Click);
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 174);
            this.Controls.Add(this.btnTeachersAdministration);
            this.Controls.Add(this.btnGestionAlumnos);
            this.Controls.Add(this.bCursos);
            this.Name = "Cursos";
            this.Text = "Gestion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTeachersAdministration;
        private System.Windows.Forms.Button btnGestionAlumnos;
        private System.Windows.Forms.Button bCursos;
    }
}

