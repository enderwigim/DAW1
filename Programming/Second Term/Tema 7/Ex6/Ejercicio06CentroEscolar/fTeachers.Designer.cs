namespace Ejercicio06CentroEscolar
{
    partial class fTeachers
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTeacherData = new System.Windows.Forms.Button();
            this.btnOrderTeachers = new System.Windows.Forms.Button();
            this.btnShowTeachers = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowTeachersBySubject = new System.Windows.Forms.Button();
            this.btnDeleteSubjectsFromTeacher = new System.Windows.Forms.Button();
            this.btnAddSubjectToTeacher = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTeacherData);
            this.groupBox1.Controls.Add(this.btnOrderTeachers);
            this.groupBox1.Controls.Add(this.btnShowTeachers);
            this.groupBox1.Controls.Add(this.btnDeleteTeacher);
            this.groupBox1.Controls.Add(this.btnAddTeacher);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profesores";
            // 
            // btnTeacherData
            // 
            this.btnTeacherData.Location = new System.Drawing.Point(434, 136);
            this.btnTeacherData.Name = "btnTeacherData";
            this.btnTeacherData.Size = new System.Drawing.Size(164, 42);
            this.btnTeacherData.TabIndex = 4;
            this.btnTeacherData.Text = "Mostrar Datos Profesores";
            this.btnTeacherData.UseVisualStyleBackColor = true;
            this.btnTeacherData.Click += new System.EventHandler(this.btnTeacherData_Click);
            // 
            // btnOrderTeachers
            // 
            this.btnOrderTeachers.Location = new System.Drawing.Point(141, 136);
            this.btnOrderTeachers.Name = "btnOrderTeachers";
            this.btnOrderTeachers.Size = new System.Drawing.Size(164, 42);
            this.btnOrderTeachers.TabIndex = 3;
            this.btnOrderTeachers.Text = "Ordernar Profesores Por Orden Alfabetico";
            this.btnOrderTeachers.UseVisualStyleBackColor = true;
            this.btnOrderTeachers.Click += new System.EventHandler(this.btnOrderTeachers_Click);
            // 
            // btnShowTeachers
            // 
            this.btnShowTeachers.Location = new System.Drawing.Point(536, 33);
            this.btnShowTeachers.Name = "btnShowTeachers";
            this.btnShowTeachers.Size = new System.Drawing.Size(164, 42);
            this.btnShowTeachers.TabIndex = 2;
            this.btnShowTeachers.Text = "Mostrar Profesores";
            this.btnShowTeachers.UseVisualStyleBackColor = true;
            this.btnShowTeachers.Click += new System.EventHandler(this.btnShowTeachers_Click);
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.Location = new System.Drawing.Point(298, 33);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(164, 42);
            this.btnDeleteTeacher.TabIndex = 1;
            this.btnDeleteTeacher.Text = "Eliminar Profesor";
            this.btnDeleteTeacher.UseVisualStyleBackColor = true;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(17, 33);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(164, 42);
            this.btnAddTeacher.TabIndex = 0;
            this.btnAddTeacher.Text = "Introducir Profesor";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowTeachersBySubject);
            this.groupBox2.Controls.Add(this.btnDeleteSubjectsFromTeacher);
            this.groupBox2.Controls.Add(this.btnAddSubjectToTeacher);
            this.groupBox2.Location = new System.Drawing.Point(13, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignaturas";
            // 
            // btnShowTeachersBySubject
            // 
            this.btnShowTeachersBySubject.Location = new System.Drawing.Point(555, 83);
            this.btnShowTeachersBySubject.Name = "btnShowTeachersBySubject";
            this.btnShowTeachersBySubject.Size = new System.Drawing.Size(145, 45);
            this.btnShowTeachersBySubject.TabIndex = 2;
            this.btnShowTeachersBySubject.Text = "Mostrar Profesores que imparten una asignatura";
            this.btnShowTeachersBySubject.UseVisualStyleBackColor = true;
            this.btnShowTeachersBySubject.Click += new System.EventHandler(this.btnShowTeachersBySubject_Click);
            // 
            // btnDeleteSubjectsFromTeacher
            // 
            this.btnDeleteSubjectsFromTeacher.Location = new System.Drawing.Point(317, 83);
            this.btnDeleteSubjectsFromTeacher.Name = "btnDeleteSubjectsFromTeacher";
            this.btnDeleteSubjectsFromTeacher.Size = new System.Drawing.Size(145, 45);
            this.btnDeleteSubjectsFromTeacher.TabIndex = 1;
            this.btnDeleteSubjectsFromTeacher.Text = "Eliminar las asignaturas de un profesor";
            this.btnDeleteSubjectsFromTeacher.UseVisualStyleBackColor = true;
            this.btnDeleteSubjectsFromTeacher.Click += new System.EventHandler(this.btnDeleteSubjectsFromTeacher_Click);
            // 
            // btnAddSubjectToTeacher
            // 
            this.btnAddSubjectToTeacher.Location = new System.Drawing.Point(69, 83);
            this.btnAddSubjectToTeacher.Name = "btnAddSubjectToTeacher";
            this.btnAddSubjectToTeacher.Size = new System.Drawing.Size(145, 45);
            this.btnAddSubjectToTeacher.TabIndex = 0;
            this.btnAddSubjectToTeacher.Text = "Añadir Asignatura a Profesor";
            this.btnAddSubjectToTeacher.UseVisualStyleBackColor = true;
            this.btnAddSubjectToTeacher.Click += new System.EventHandler(this.btnAddSubjectToTeacher_Click);
            // 
            // fTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fTeachers";
            this.Text = "fTeachers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTeacherData;
        private System.Windows.Forms.Button btnOrderTeachers;
        private System.Windows.Forms.Button btnShowTeachers;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowTeachersBySubject;
        private System.Windows.Forms.Button btnDeleteSubjectsFromTeacher;
        private System.Windows.Forms.Button btnAddSubjectToTeacher;
    }
}