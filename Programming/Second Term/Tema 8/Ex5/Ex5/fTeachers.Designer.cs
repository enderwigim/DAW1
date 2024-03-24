namespace Ex5
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteJustOneSubject = new System.Windows.Forms.Button();
            this.btnShowTeachersBySubject = new System.Windows.Forms.Button();
            this.btnDeleteSubjectsFromTeacher = new System.Windows.Forms.Button();
            this.btnAddSubjectToTeacher = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTeacherData = new System.Windows.Forms.Button();
            this.btnOrderTeachers = new System.Windows.Forms.Button();
            this.btnShowTeachers = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteJustOneSubject);
            this.groupBox2.Controls.Add(this.btnShowTeachersBySubject);
            this.groupBox2.Controls.Add(this.btnDeleteSubjectsFromTeacher);
            this.groupBox2.Controls.Add(this.btnAddSubjectToTeacher);
            this.groupBox2.Location = new System.Drawing.Point(16, 294);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1033, 244);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignaturas";
            // 
            // btnDeleteJustOneSubject
            // 
            this.btnDeleteJustOneSubject.Location = new System.Drawing.Point(423, 135);
            this.btnDeleteJustOneSubject.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteJustOneSubject.Name = "btnDeleteJustOneSubject";
            this.btnDeleteJustOneSubject.Size = new System.Drawing.Size(193, 55);
            this.btnDeleteJustOneSubject.TabIndex = 3;
            this.btnDeleteJustOneSubject.Text = "Eliminar una asignatura de un profesor";
            this.btnDeleteJustOneSubject.UseVisualStyleBackColor = true;
            this.btnDeleteJustOneSubject.Click += new System.EventHandler(this.btnDeleteJustOneSubject_Click);
            // 
            // btnShowTeachersBySubject
            // 
            this.btnShowTeachersBySubject.Location = new System.Drawing.Point(740, 102);
            this.btnShowTeachersBySubject.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowTeachersBySubject.Name = "btnShowTeachersBySubject";
            this.btnShowTeachersBySubject.Size = new System.Drawing.Size(193, 55);
            this.btnShowTeachersBySubject.TabIndex = 2;
            this.btnShowTeachersBySubject.Text = "Mostrar Profesores que imparten una asignatura";
            this.btnShowTeachersBySubject.UseVisualStyleBackColor = true;
            this.btnShowTeachersBySubject.Click += new System.EventHandler(this.btnShowTeachersBySubject_Click);
            // 
            // btnDeleteSubjectsFromTeacher
            // 
            this.btnDeleteSubjectsFromTeacher.Location = new System.Drawing.Point(423, 23);
            this.btnDeleteSubjectsFromTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteSubjectsFromTeacher.Name = "btnDeleteSubjectsFromTeacher";
            this.btnDeleteSubjectsFromTeacher.Size = new System.Drawing.Size(193, 55);
            this.btnDeleteSubjectsFromTeacher.TabIndex = 1;
            this.btnDeleteSubjectsFromTeacher.Text = "Eliminar las asignaturas de un profesor";
            this.btnDeleteSubjectsFromTeacher.UseVisualStyleBackColor = true;
            this.btnDeleteSubjectsFromTeacher.Click += new System.EventHandler(this.btnDeleteSubjectsFromTeacher_Click);
            // 
            // btnAddSubjectToTeacher
            // 
            this.btnAddSubjectToTeacher.Location = new System.Drawing.Point(92, 102);
            this.btnAddSubjectToTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSubjectToTeacher.Name = "btnAddSubjectToTeacher";
            this.btnAddSubjectToTeacher.Size = new System.Drawing.Size(193, 55);
            this.btnAddSubjectToTeacher.TabIndex = 0;
            this.btnAddSubjectToTeacher.Text = "Añadir Asignatura a Profesor";
            this.btnAddSubjectToTeacher.UseVisualStyleBackColor = true;
            this.btnAddSubjectToTeacher.Click += new System.EventHandler(this.btnAddSubjectToTeacher_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTeacherData);
            this.groupBox1.Controls.Add(this.btnOrderTeachers);
            this.groupBox1.Controls.Add(this.btnShowTeachers);
            this.groupBox1.Controls.Add(this.btnDeleteTeacher);
            this.groupBox1.Controls.Add(this.btnAddTeacher);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1033, 272);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profesores";
            // 
            // btnTeacherData
            // 
            this.btnTeacherData.Location = new System.Drawing.Point(579, 167);
            this.btnTeacherData.Margin = new System.Windows.Forms.Padding(4);
            this.btnTeacherData.Name = "btnTeacherData";
            this.btnTeacherData.Size = new System.Drawing.Size(219, 52);
            this.btnTeacherData.TabIndex = 4;
            this.btnTeacherData.Text = "Mostrar Datos Profesores";
            this.btnTeacherData.UseVisualStyleBackColor = true;
            this.btnTeacherData.Click += new System.EventHandler(this.btnTeacherData_Click);
            // 
            // btnOrderTeachers
            // 
            this.btnOrderTeachers.Location = new System.Drawing.Point(188, 167);
            this.btnOrderTeachers.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderTeachers.Name = "btnOrderTeachers";
            this.btnOrderTeachers.Size = new System.Drawing.Size(219, 52);
            this.btnOrderTeachers.TabIndex = 3;
            this.btnOrderTeachers.Text = "Ordernar Profesores Por Orden Alfabetico";
            this.btnOrderTeachers.UseVisualStyleBackColor = true;
            this.btnOrderTeachers.Click += new System.EventHandler(this.btnOrderTeachers_Click);
            // 
            // btnShowTeachers
            // 
            this.btnShowTeachers.Location = new System.Drawing.Point(715, 41);
            this.btnShowTeachers.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowTeachers.Name = "btnShowTeachers";
            this.btnShowTeachers.Size = new System.Drawing.Size(219, 52);
            this.btnShowTeachers.TabIndex = 2;
            this.btnShowTeachers.Text = "Mostrar Profesores";
            this.btnShowTeachers.UseVisualStyleBackColor = true;
            this.btnShowTeachers.Click += new System.EventHandler(this.btnShowTeachers_Click);
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.Location = new System.Drawing.Point(397, 41);
            this.btnDeleteTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(219, 52);
            this.btnDeleteTeacher.TabIndex = 1;
            this.btnDeleteTeacher.Text = "Eliminar Profesor";
            this.btnDeleteTeacher.UseVisualStyleBackColor = true;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(23, 41);
            this.btnAddTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(219, 52);
            this.btnAddTeacher.TabIndex = 0;
            this.btnAddTeacher.Text = "Introducir Profesor";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // fTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 555);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTeachers";
            this.Text = "fTeachers";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteJustOneSubject;
        private System.Windows.Forms.Button btnShowTeachersBySubject;
        private System.Windows.Forms.Button btnDeleteSubjectsFromTeacher;
        private System.Windows.Forms.Button btnAddSubjectToTeacher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTeacherData;
        private System.Windows.Forms.Button btnOrderTeachers;
        private System.Windows.Forms.Button btnShowTeachers;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.Button btnAddTeacher;
    }
}