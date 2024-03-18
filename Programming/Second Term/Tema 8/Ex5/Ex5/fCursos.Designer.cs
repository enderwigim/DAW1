namespace Ex5
{
    partial class fCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.ShowEveryStudentInCourse = new System.Windows.Forms.Button();
            this.btnShowEveryCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(72, 61);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(143, 48);
            this.btnAddCourse.TabIndex = 8;
            this.btnAddCourse.Text = "Añadir Curso";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // ShowEveryStudentInCourse
            // 
            this.ShowEveryStudentInCourse.Location = new System.Drawing.Point(72, 223);
            this.ShowEveryStudentInCourse.Name = "ShowEveryStudentInCourse";
            this.ShowEveryStudentInCourse.Size = new System.Drawing.Size(143, 48);
            this.ShowEveryStudentInCourse.TabIndex = 7;
            this.ShowEveryStudentInCourse.Text = "Mostrar Alumnos Pertenecientes a un curso";
            this.ShowEveryStudentInCourse.UseVisualStyleBackColor = true;
            this.ShowEveryStudentInCourse.Click += new System.EventHandler(this.ShowEveryStudentInCourse_Click);
            // 
            // btnShowEveryCourse
            // 
            this.btnShowEveryCourse.Location = new System.Drawing.Point(72, 169);
            this.btnShowEveryCourse.Name = "btnShowEveryCourse";
            this.btnShowEveryCourse.Size = new System.Drawing.Size(143, 48);
            this.btnShowEveryCourse.TabIndex = 6;
            this.btnShowEveryCourse.Text = "Mostrar todo los cursos";
            this.btnShowEveryCourse.UseVisualStyleBackColor = true;
            this.btnShowEveryCourse.Click += new System.EventHandler(this.btnShowEveryCourse_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(72, 115);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(143, 48);
            this.btnDeleteCourse.TabIndex = 5;
            this.btnDeleteCourse.Text = "Eliminar Curso";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // fCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 335);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.ShowEveryStudentInCourse);
            this.Controls.Add(this.btnShowEveryCourse);
            this.Controls.Add(this.btnDeleteCourse);
            this.Name = "fCursos";
            this.Text = "fCursos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button ShowEveryStudentInCourse;
        private System.Windows.Forms.Button btnShowEveryCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
    }
}