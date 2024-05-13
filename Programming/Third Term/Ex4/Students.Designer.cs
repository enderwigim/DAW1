namespace Ex4
{
    partial class FStudents
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtTlf = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnShowEveryStudent = new System.Windows.Forms.Button();
            this.btnLookBySurname = new System.Windows.Forms.Button();
            this.lblEntryNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowLastTeacher = new System.Windows.Forms.Button();
            this.btnShowNextTeacher = new System.Windows.Forms.Button();
            this.btnShowPreviousTeacher = new System.Windows.Forms.Button();
            this.btnShowFirstTeacher = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(463, 229);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(251, 22);
            this.txtAddress.TabIndex = 72;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(463, 150);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(251, 22);
            this.txtApellidos.TabIndex = 71;
            // 
            // txtTlf
            // 
            this.txtTlf.Location = new System.Drawing.Point(90, 229);
            this.txtTlf.Margin = new System.Windows.Forms.Padding(4);
            this.txtTlf.Name = "txtTlf";
            this.txtTlf.Size = new System.Drawing.Size(251, 22);
            this.txtTlf.TabIndex = 70;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(90, 150);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(251, 22);
            this.txtNombre.TabIndex = 69;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(90, 57);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(251, 22);
            this.txtDNI.TabIndex = 68;
            // 
            // btnShowEveryStudent
            // 
            this.btnShowEveryStudent.Location = new System.Drawing.Point(789, 206);
            this.btnShowEveryStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowEveryStudent.Name = "btnShowEveryStudent";
            this.btnShowEveryStudent.Size = new System.Drawing.Size(229, 69);
            this.btnShowEveryStudent.TabIndex = 67;
            this.btnShowEveryStudent.Text = "Mostrar Alumnos";
            this.btnShowEveryStudent.UseVisualStyleBackColor = true;
            this.btnShowEveryStudent.Click += new System.EventHandler(this.btnShowEveryStudent_Click);
            // 
            // btnLookBySurname
            // 
            this.btnLookBySurname.Location = new System.Drawing.Point(789, 101);
            this.btnLookBySurname.Margin = new System.Windows.Forms.Padding(4);
            this.btnLookBySurname.Name = "btnLookBySurname";
            this.btnLookBySurname.Size = new System.Drawing.Size(229, 69);
            this.btnLookBySurname.TabIndex = 66;
            this.btnLookBySurname.Text = "Buscar Apellido";
            this.btnLookBySurname.UseVisualStyleBackColor = true;
            this.btnLookBySurname.Click += new System.EventHandler(this.btnLookBySurname_Click);
            // 
            // lblEntryNumber
            // 
            this.lblEntryNumber.AutoSize = true;
            this.lblEntryNumber.Location = new System.Drawing.Point(879, 50);
            this.lblEntryNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntryNumber.Name = "lblEntryNumber";
            this.lblEntryNumber.Size = new System.Drawing.Size(0, 16);
            this.lblEntryNumber.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(817, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "Registro: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox3.Location = new System.Drawing.Point(559, 432);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(452, 107);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actualizar y Eliminar";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDelete.Location = new System.Drawing.Point(229, 23);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(215, 54);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnUpdate.Location = new System.Drawing.Point(8, 23);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(215, 54);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveNew);
            this.groupBox2.Controls.Add(this.btnAddTeacher);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(26, 432);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(500, 107);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo Registro";
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnSaveNew.Location = new System.Drawing.Point(247, 23);
            this.btnSaveNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(215, 54);
            this.btnSaveNew.TabIndex = 5;
            this.btnSaveNew.Text = "Guardar Nuevo";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAddTeacher.Location = new System.Drawing.Point(24, 23);
            this.btnAddTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(215, 54);
            this.btnAddTeacher.TabIndex = 4;
            this.btnAddTeacher.Text = "Añadir";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowLastTeacher);
            this.groupBox1.Controls.Add(this.btnShowNextTeacher);
            this.groupBox1.Controls.Add(this.btnShowPreviousTeacher);
            this.groupBox1.Controls.Add(this.btnShowFirstTeacher);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(26, 299);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(985, 107);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navegar";
            // 
            // btnShowLastTeacher
            // 
            this.btnShowLastTeacher.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnShowLastTeacher.Location = new System.Drawing.Point(763, 23);
            this.btnShowLastTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowLastTeacher.Name = "btnShowLastTeacher";
            this.btnShowLastTeacher.Size = new System.Drawing.Size(215, 54);
            this.btnShowLastTeacher.TabIndex = 3;
            this.btnShowLastTeacher.Text = "Ultimo";
            this.btnShowLastTeacher.UseVisualStyleBackColor = true;
            this.btnShowLastTeacher.Click += new System.EventHandler(this.btnShowLastTeacher_Click);
            // 
            // btnShowNextTeacher
            // 
            this.btnShowNextTeacher.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnShowNextTeacher.Location = new System.Drawing.Point(533, 23);
            this.btnShowNextTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowNextTeacher.Name = "btnShowNextTeacher";
            this.btnShowNextTeacher.Size = new System.Drawing.Size(215, 54);
            this.btnShowNextTeacher.TabIndex = 2;
            this.btnShowNextTeacher.Text = "Siguiente";
            this.btnShowNextTeacher.UseVisualStyleBackColor = true;
            this.btnShowNextTeacher.Click += new System.EventHandler(this.btnShowNextTeacher_Click);
            // 
            // btnShowPreviousTeacher
            // 
            this.btnShowPreviousTeacher.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnShowPreviousTeacher.Location = new System.Drawing.Point(285, 23);
            this.btnShowPreviousTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowPreviousTeacher.Name = "btnShowPreviousTeacher";
            this.btnShowPreviousTeacher.Size = new System.Drawing.Size(215, 54);
            this.btnShowPreviousTeacher.TabIndex = 1;
            this.btnShowPreviousTeacher.Text = "Anterior";
            this.btnShowPreviousTeacher.UseVisualStyleBackColor = true;
            this.btnShowPreviousTeacher.Click += new System.EventHandler(this.btnShowPreviousTeacher_Click);
            // 
            // btnShowFirstTeacher
            // 
            this.btnShowFirstTeacher.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnShowFirstTeacher.Location = new System.Drawing.Point(24, 23);
            this.btnShowFirstTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowFirstTeacher.Name = "btnShowFirstTeacher";
            this.btnShowFirstTeacher.Size = new System.Drawing.Size(215, 54);
            this.btnShowFirstTeacher.TabIndex = 0;
            this.btnShowFirstTeacher.Text = "Primero";
            this.btnShowFirstTeacher.UseVisualStyleBackColor = true;
            this.btnShowFirstTeacher.Click += new System.EventHandler(this.btnShowFirstTeacher_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 60;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Tlf:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "DNI:";
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 607);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtTlf);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.btnShowEveryStudent);
            this.Controls.Add(this.btnLookBySurname);
            this.Controls.Add(this.lblEntryNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Students";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtTlf;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnShowEveryStudent;
        private System.Windows.Forms.Button btnLookBySurname;
        private System.Windows.Forms.Label lblEntryNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowLastTeacher;
        private System.Windows.Forms.Button btnShowNextTeacher;
        private System.Windows.Forms.Button btnShowPreviousTeacher;
        private System.Windows.Forms.Button btnShowFirstTeacher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}