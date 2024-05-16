namespace Ex4.AppData
{
    partial class Gestor
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
            this.btnOpenCourses = new System.Windows.Forms.Button();
            this.btnOpenStudents = new System.Windows.Forms.Button();
            this.btnOpenTeachers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenCourses
            // 
            this.btnOpenCourses.Location = new System.Drawing.Point(26, 12);
            this.btnOpenCourses.Name = "btnOpenCourses";
            this.btnOpenCourses.Size = new System.Drawing.Size(296, 53);
            this.btnOpenCourses.TabIndex = 0;
            this.btnOpenCourses.Text = "Gestionar Cursos";
            this.btnOpenCourses.UseVisualStyleBackColor = true;
            this.btnOpenCourses.Click += new System.EventHandler(this.btnOpenCourses_Click);
            // 
            // btnOpenStudents
            // 
            this.btnOpenStudents.Location = new System.Drawing.Point(26, 89);
            this.btnOpenStudents.Name = "btnOpenStudents";
            this.btnOpenStudents.Size = new System.Drawing.Size(296, 53);
            this.btnOpenStudents.TabIndex = 1;
            this.btnOpenStudents.Text = "Gestionar Alumnos";
            this.btnOpenStudents.UseVisualStyleBackColor = true;
            this.btnOpenStudents.Click += new System.EventHandler(this.btnOpenStudents_Click);
            // 
            // btnOpenTeachers
            // 
            this.btnOpenTeachers.Location = new System.Drawing.Point(26, 170);
            this.btnOpenTeachers.Name = "btnOpenTeachers";
            this.btnOpenTeachers.Size = new System.Drawing.Size(296, 53);
            this.btnOpenTeachers.TabIndex = 2;
            this.btnOpenTeachers.Text = "Gestionar Profesores";
            this.btnOpenTeachers.UseVisualStyleBackColor = true;
            this.btnOpenTeachers.Click += new System.EventHandler(this.btnOpenTeachers_Click);
            // 
            // Gestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 255);
            this.Controls.Add(this.btnOpenTeachers);
            this.Controls.Add(this.btnOpenStudents);
            this.Controls.Add(this.btnOpenCourses);
            this.Name = "Gestor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenCourses;
        private System.Windows.Forms.Button btnOpenStudents;
        private System.Windows.Forms.Button btnOpenTeachers;
    }
}