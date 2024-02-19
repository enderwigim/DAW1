namespace Ejercicio06CentroEscolar
{
    partial class fCursos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnShowEveryCourse = new System.Windows.Forms.Button();
            this.ShowEveryStudentInCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(71, 80);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(143, 48);
            this.btnDeleteCourse.TabIndex = 1;
            this.btnDeleteCourse.Text = "Eliminar Curso";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnShowEveryCourse
            // 
            this.btnShowEveryCourse.Location = new System.Drawing.Point(71, 134);
            this.btnShowEveryCourse.Name = "btnShowEveryCourse";
            this.btnShowEveryCourse.Size = new System.Drawing.Size(143, 48);
            this.btnShowEveryCourse.TabIndex = 2;
            this.btnShowEveryCourse.Text = "Mostrar todo los cursos";
            this.btnShowEveryCourse.UseVisualStyleBackColor = true;
            this.btnShowEveryCourse.Click += new System.EventHandler(this.btnShowEveryCourse_Click);
            // 
            // ShowEveryStudentInCourse
            // 
            this.ShowEveryStudentInCourse.Location = new System.Drawing.Point(71, 188);
            this.ShowEveryStudentInCourse.Name = "ShowEveryStudentInCourse";
            this.ShowEveryStudentInCourse.Size = new System.Drawing.Size(143, 48);
            this.ShowEveryStudentInCourse.TabIndex = 3;
            this.ShowEveryStudentInCourse.Text = "Mostrar Alumnos Pertenecientes a un curso";
            this.ShowEveryStudentInCourse.UseVisualStyleBackColor = true;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(71, 26);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(143, 48);
            this.btnAddCourse.TabIndex = 4;
            this.btnAddCourse.Text = "Añadir Curso";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // fCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.ShowEveryStudentInCourse);
            this.Controls.Add(this.btnShowEveryCourse);
            this.Controls.Add(this.btnDeleteCourse);
            this.Name = "fCursos";
            this.Text = "fCursos";
            this.Load += new System.EventHandler(this.fCursos_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnShowEveryCourse;
        private System.Windows.Forms.Button ShowEveryStudentInCourse;
        private System.Windows.Forms.Button btnAddCourse;
    }
}