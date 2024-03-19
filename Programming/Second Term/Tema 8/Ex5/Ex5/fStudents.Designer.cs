namespace Ex5
{
    partial class fStudents
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
            this.btnDeleteGrades = new System.Windows.Forms.Button();
            this.btnShowStudentsWithAVGLessThan5 = new System.Windows.Forms.Button();
            this.btnShowStudentsWithAVGUpperThan5 = new System.Windows.Forms.Button();
            this.btnAddGrades = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowStudentsFromCourse = new System.Windows.Forms.Button();
            this.btnShowStudentData = new System.Windows.Forms.Button();
            this.btnOrderByName = new System.Windows.Forms.Button();
            this.btnShowStudentList = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteGrades);
            this.groupBox2.Controls.Add(this.btnShowStudentsWithAVGLessThan5);
            this.groupBox2.Controls.Add(this.btnShowStudentsWithAVGUpperThan5);
            this.groupBox2.Controls.Add(this.btnAddGrades);
            this.groupBox2.Location = new System.Drawing.Point(13, 303);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(887, 271);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notas";
            // 
            // btnDeleteGrades
            // 
            this.btnDeleteGrades.Location = new System.Drawing.Point(25, 169);
            this.btnDeleteGrades.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteGrades.Name = "btnDeleteGrades";
            this.btnDeleteGrades.Size = new System.Drawing.Size(289, 50);
            this.btnDeleteGrades.TabIndex = 3;
            this.btnDeleteGrades.Text = "Eliminar las notas de un Alumno";
            this.btnDeleteGrades.UseVisualStyleBackColor = true;
            // 
            // btnShowStudentsWithAVGLessThan5
            // 
            this.btnShowStudentsWithAVGLessThan5.Location = new System.Drawing.Point(532, 169);
            this.btnShowStudentsWithAVGLessThan5.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowStudentsWithAVGLessThan5.Name = "btnShowStudentsWithAVGLessThan5";
            this.btnShowStudentsWithAVGLessThan5.Size = new System.Drawing.Size(289, 50);
            this.btnShowStudentsWithAVGLessThan5.TabIndex = 2;
            this.btnShowStudentsWithAVGLessThan5.Text = "Mostrar Alumnos con media menor a 5";
            this.btnShowStudentsWithAVGLessThan5.UseVisualStyleBackColor = true;
            // 
            // btnShowStudentsWithAVGUpperThan5
            // 
            this.btnShowStudentsWithAVGUpperThan5.Location = new System.Drawing.Point(532, 60);
            this.btnShowStudentsWithAVGUpperThan5.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowStudentsWithAVGUpperThan5.Name = "btnShowStudentsWithAVGUpperThan5";
            this.btnShowStudentsWithAVGUpperThan5.Size = new System.Drawing.Size(289, 50);
            this.btnShowStudentsWithAVGUpperThan5.TabIndex = 1;
            this.btnShowStudentsWithAVGUpperThan5.Text = "Mostrar Alumnos con media mayor a 5";
            this.btnShowStudentsWithAVGUpperThan5.UseVisualStyleBackColor = true;
            // 
            // btnAddGrades
            // 
            this.btnAddGrades.Location = new System.Drawing.Point(25, 60);
            this.btnAddGrades.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddGrades.Name = "btnAddGrades";
            this.btnAddGrades.Size = new System.Drawing.Size(289, 50);
            this.btnAddGrades.TabIndex = 0;
            this.btnAddGrades.Text = "Añadir notas a Alumno";
            this.btnAddGrades.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowStudentsFromCourse);
            this.groupBox1.Controls.Add(this.btnShowStudentData);
            this.groupBox1.Controls.Add(this.btnOrderByName);
            this.groupBox1.Controls.Add(this.btnShowStudentList);
            this.groupBox1.Controls.Add(this.btnDeleteStudent);
            this.groupBox1.Controls.Add(this.btnAddStudent);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(887, 272);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumnos";
            // 
            // btnShowStudentsFromCourse
            // 
            this.btnShowStudentsFromCourse.Location = new System.Drawing.Point(227, 209);
            this.btnShowStudentsFromCourse.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowStudentsFromCourse.Name = "btnShowStudentsFromCourse";
            this.btnShowStudentsFromCourse.Size = new System.Drawing.Size(351, 43);
            this.btnShowStudentsFromCourse.TabIndex = 5;
            this.btnShowStudentsFromCourse.Text = "Mostrar Alumnos pertenecientes a un curso";
            this.btnShowStudentsFromCourse.UseVisualStyleBackColor = true;
            // 
            // btnShowStudentData
            // 
            this.btnShowStudentData.Location = new System.Drawing.Point(475, 132);
            this.btnShowStudentData.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowStudentData.Name = "btnShowStudentData";
            this.btnShowStudentData.Size = new System.Drawing.Size(289, 46);
            this.btnShowStudentData.TabIndex = 4;
            this.btnShowStudentData.Text = "Mostrar Datos Alumno (por nombre)";
            this.btnShowStudentData.UseVisualStyleBackColor = true;
            // 
            // btnOrderByName
            // 
            this.btnOrderByName.Location = new System.Drawing.Point(95, 132);
            this.btnOrderByName.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderByName.Name = "btnOrderByName";
            this.btnOrderByName.Size = new System.Drawing.Size(220, 44);
            this.btnOrderByName.TabIndex = 3;
            this.btnOrderByName.Text = "Ordenar Alumnos en orden alfabetico";
            this.btnOrderByName.UseVisualStyleBackColor = true;
            // 
            // btnShowStudentList
            // 
            this.btnShowStudentList.Location = new System.Drawing.Point(601, 60);
            this.btnShowStudentList.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowStudentList.Name = "btnShowStudentList";
            this.btnShowStudentList.Size = new System.Drawing.Size(220, 39);
            this.btnShowStudentList.TabIndex = 2;
            this.btnShowStudentList.Text = "Mostrar Lista de Alumnos";
            this.btnShowStudentList.UseVisualStyleBackColor = true;
            this.btnShowStudentList.Click += new System.EventHandler(this.btnShowStudentList_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(308, 60);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(220, 38);
            this.btnDeleteStudent.TabIndex = 1;
            this.btnDeleteStudent.Text = "Eliminar Alumno";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(25, 60);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(220, 38);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Agregar Alumno";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // fStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 588);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fStudents";
            this.Text = "fStudents";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteGrades;
        private System.Windows.Forms.Button btnShowStudentsWithAVGLessThan5;
        private System.Windows.Forms.Button btnShowStudentsWithAVGUpperThan5;
        private System.Windows.Forms.Button btnAddGrades;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowStudentsFromCourse;
        private System.Windows.Forms.Button btnShowStudentData;
        private System.Windows.Forms.Button btnOrderByName;
        private System.Windows.Forms.Button btnShowStudentList;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnAddStudent;
    }
}