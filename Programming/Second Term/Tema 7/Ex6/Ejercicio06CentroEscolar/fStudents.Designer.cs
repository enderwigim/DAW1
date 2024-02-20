namespace Ejercicio06CentroEscolar
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
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnShowStudentList = new System.Windows.Forms.Button();
            this.btnOrderByName = new System.Windows.Forms.Button();
            this.btnShowStudentData = new System.Windows.Forms.Button();
            this.btnShowStudentsFromCourse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(19, 49);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(165, 31);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Agregar Alumno";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowStudentsFromCourse);
            this.groupBox1.Controls.Add(this.btnShowStudentData);
            this.groupBox1.Controls.Add(this.btnOrderByName);
            this.groupBox1.Controls.Add(this.btnShowStudentList);
            this.groupBox1.Controls.Add(this.btnDeleteStudent);
            this.groupBox1.Controls.Add(this.btnAddStudent);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 221);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumnos";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(231, 49);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(165, 31);
            this.btnDeleteStudent.TabIndex = 1;
            this.btnDeleteStudent.Text = "Eliminar Alumno";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnShowStudentList
            // 
            this.btnShowStudentList.Location = new System.Drawing.Point(451, 49);
            this.btnShowStudentList.Name = "btnShowStudentList";
            this.btnShowStudentList.Size = new System.Drawing.Size(165, 32);
            this.btnShowStudentList.TabIndex = 2;
            this.btnShowStudentList.Text = "Mostrar Lista de Alumnos";
            this.btnShowStudentList.UseVisualStyleBackColor = true;
            this.btnShowStudentList.Click += new System.EventHandler(this.btnShowStudentList_Click);
            // 
            // btnOrderByName
            // 
            this.btnOrderByName.Location = new System.Drawing.Point(71, 107);
            this.btnOrderByName.Name = "btnOrderByName";
            this.btnOrderByName.Size = new System.Drawing.Size(165, 36);
            this.btnOrderByName.TabIndex = 3;
            this.btnOrderByName.Text = "Ordenar Alumnos en orden alfabetico";
            this.btnOrderByName.UseVisualStyleBackColor = true;
            // 
            // btnShowStudentData
            // 
            this.btnShowStudentData.Location = new System.Drawing.Point(356, 107);
            this.btnShowStudentData.Name = "btnShowStudentData";
            this.btnShowStudentData.Size = new System.Drawing.Size(217, 37);
            this.btnShowStudentData.TabIndex = 4;
            this.btnShowStudentData.Text = "Mostrar Datos Alumno (por nombre)";
            this.btnShowStudentData.UseVisualStyleBackColor = true;
            this.btnShowStudentData.Click += new System.EventHandler(this.btnShowStudentData_Click);
            // 
            // btnShowStudentsFromCourse
            // 
            this.btnShowStudentsFromCourse.Location = new System.Drawing.Point(170, 170);
            this.btnShowStudentsFromCourse.Name = "btnShowStudentsFromCourse";
            this.btnShowStudentsFromCourse.Size = new System.Drawing.Size(263, 35);
            this.btnShowStudentsFromCourse.TabIndex = 5;
            this.btnShowStudentsFromCourse.Text = "Mostrar Alumnos pertenecientes a un curso";
            this.btnShowStudentsFromCourse.UseVisualStyleBackColor = true;
            // 
            // fStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 492);
            this.Controls.Add(this.groupBox1);
            this.Name = "fStudents";
            this.Text = "fStudents";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowStudentsFromCourse;
        private System.Windows.Forms.Button btnShowStudentData;
        private System.Windows.Forms.Button btnOrderByName;
        private System.Windows.Forms.Button btnShowStudentList;
        private System.Windows.Forms.Button btnDeleteStudent;
    }
}