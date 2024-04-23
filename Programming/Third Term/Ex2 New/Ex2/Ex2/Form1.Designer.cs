namespace Ex2
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
            this.btnShowEveryTeacher = new System.Windows.Forms.Button();
            this.btnLookBySurname = new System.Windows.Forms.Button();
            this.lblEntryNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTlf = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txteMail = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
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
            // btnShowEveryTeacher
            // 
            this.btnShowEveryTeacher.Location = new System.Drawing.Point(602, 154);
            this.btnShowEveryTeacher.Name = "btnShowEveryTeacher";
            this.btnShowEveryTeacher.Size = new System.Drawing.Size(172, 56);
            this.btnShowEveryTeacher.TabIndex = 33;
            this.btnShowEveryTeacher.Text = "Mostrar Profesores";
            this.btnShowEveryTeacher.UseVisualStyleBackColor = true;
            // 
            // btnLookBySurname
            // 
            this.btnLookBySurname.Location = new System.Drawing.Point(602, 69);
            this.btnLookBySurname.Name = "btnLookBySurname";
            this.btnLookBySurname.Size = new System.Drawing.Size(172, 56);
            this.btnLookBySurname.TabIndex = 32;
            this.btnLookBySurname.Text = "Buscar Apellido";
            this.btnLookBySurname.UseVisualStyleBackColor = true;
            // 
            // lblEntryNumber
            // 
            this.lblEntryNumber.AutoSize = true;
            this.lblEntryNumber.Location = new System.Drawing.Point(670, 28);
            this.lblEntryNumber.Name = "lblEntryNumber";
            this.lblEntryNumber.Size = new System.Drawing.Size(0, 13);
            this.lblEntryNumber.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(623, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Registro: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(80, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 20);
            this.txtNombre.TabIndex = 29;
            // 
            // txtTlf
            // 
            this.txtTlf.Location = new System.Drawing.Point(80, 173);
            this.txtTlf.Name = "txtTlf";
            this.txtTlf.Size = new System.Drawing.Size(170, 20);
            this.txtTlf.TabIndex = 28;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(331, 109);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(170, 20);
            this.txtApellidos.TabIndex = 27;
            // 
            // txteMail
            // 
            this.txteMail.Location = new System.Drawing.Point(331, 173);
            this.txteMail.Name = "txteMail";
            this.txteMail.Size = new System.Drawing.Size(170, 20);
            this.txteMail.TabIndex = 26;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(80, 26);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(170, 20);
            this.txtDNI.TabIndex = 25;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox3.Location = new System.Drawing.Point(430, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 87);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actualizar y Eliminar";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDelete.Location = new System.Drawing.Point(172, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 44);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnUpdate.Location = new System.Drawing.Point(6, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 44);
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
            this.groupBox2.Location = new System.Drawing.Point(30, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 87);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo Registro";
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnSaveNew.Location = new System.Drawing.Point(185, 19);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(161, 44);
            this.btnSaveNew.TabIndex = 5;
            this.btnSaveNew.Text = "Guardar Nuevo";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAddTeacher.Location = new System.Drawing.Point(18, 19);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(161, 44);
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
            this.groupBox1.Location = new System.Drawing.Point(30, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 87);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navegar";
            // 
            // btnShowLastTeacher
            // 
            this.btnShowLastTeacher.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnShowLastTeacher.Location = new System.Drawing.Point(572, 19);
            this.btnShowLastTeacher.Name = "btnShowLastTeacher";
            this.btnShowLastTeacher.Size = new System.Drawing.Size(161, 44);
            this.btnShowLastTeacher.TabIndex = 3;
            this.btnShowLastTeacher.Text = "Ultimo";
            this.btnShowLastTeacher.UseVisualStyleBackColor = true;
            this.btnShowLastTeacher.Click += new System.EventHandler(this.btnShowLastTeacher_Click);
            // 
            // btnShowNextTeacher
            // 
            this.btnShowNextTeacher.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnShowNextTeacher.Location = new System.Drawing.Point(400, 19);
            this.btnShowNextTeacher.Name = "btnShowNextTeacher";
            this.btnShowNextTeacher.Size = new System.Drawing.Size(161, 44);
            this.btnShowNextTeacher.TabIndex = 2;
            this.btnShowNextTeacher.Text = "Siguiente";
            this.btnShowNextTeacher.UseVisualStyleBackColor = true;
            this.btnShowNextTeacher.Click += new System.EventHandler(this.btnShowNextTeacher_Click);
            // 
            // btnShowPreviousTeacher
            // 
            this.btnShowPreviousTeacher.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnShowPreviousTeacher.Location = new System.Drawing.Point(214, 19);
            this.btnShowPreviousTeacher.Name = "btnShowPreviousTeacher";
            this.btnShowPreviousTeacher.Size = new System.Drawing.Size(161, 44);
            this.btnShowPreviousTeacher.TabIndex = 1;
            this.btnShowPreviousTeacher.Text = "Anterior";
            this.btnShowPreviousTeacher.UseVisualStyleBackColor = true;
            this.btnShowPreviousTeacher.Click += new System.EventHandler(this.btnShowPreviousTeacher_Click);
            // 
            // btnShowFirstTeacher
            // 
            this.btnShowFirstTeacher.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnShowFirstTeacher.Location = new System.Drawing.Point(18, 19);
            this.btnShowFirstTeacher.Name = "btnShowFirstTeacher";
            this.btnShowFirstTeacher.Size = new System.Drawing.Size(161, 44);
            this.btnShowFirstTeacher.TabIndex = 0;
            this.btnShowFirstTeacher.Text = "Primero";
            this.btnShowFirstTeacher.UseVisualStyleBackColor = true;
            this.btnShowFirstTeacher.Click += new System.EventHandler(this.btnShowFirstTeacher_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tlf:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "DNI:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowEveryTeacher);
            this.Controls.Add(this.btnLookBySurname);
            this.Controls.Add(this.lblEntryNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtTlf);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txteMail);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowEveryTeacher;
        private System.Windows.Forms.Button btnLookBySurname;
        private System.Windows.Forms.Label lblEntryNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTlf;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txteMail;
        private System.Windows.Forms.TextBox txtDNI;
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

