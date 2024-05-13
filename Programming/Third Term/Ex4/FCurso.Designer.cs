namespace Ex4
{
    partial class FCurso
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblEntryNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowLastCourse = new System.Windows.Forms.Button();
            this.btnShowNextCourse = new System.Windows.Forms.Button();
            this.btnShowPreviousCourse = new System.Windows.Forms.Button();
            this.btnShowFirstCourse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtName.Location = new System.Drawing.Point(560, 74);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtNombre";
            this.txtName.Size = new System.Drawing.Size(251, 22);
            this.txtName.TabIndex = 69;
            // 
            // txtDNI
            // 
            this.txtID.Location = new System.Drawing.Point(98, 75);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtDNI";
            this.txtID.Size = new System.Drawing.Size(251, 22);
            this.txtID.TabIndex = 68;
            // 
            // lblEntryNumber
            // 
            this.lblEntryNumber.AutoSize = true;
            this.lblEntryNumber.Location = new System.Drawing.Point(846, 9);
            this.lblEntryNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntryNumber.Name = "lblEntryNumber";
            this.lblEntryNumber.Size = new System.Drawing.Size(0, 16);
            this.lblEntryNumber.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(784, 9);
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
            this.groupBox3.Location = new System.Drawing.Point(546, 278);
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
            this.groupBox2.Controls.Add(this.btnAddCourse);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(13, 278);
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
            // btnAddCourse
            // 
            this.btnAddCourse.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAddCourse.Location = new System.Drawing.Point(24, 23);
            this.btnAddCourse.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(215, 54);
            this.btnAddCourse.TabIndex = 4;
            this.btnAddCourse.Text = "Añadir";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowLastCourse);
            this.groupBox1.Controls.Add(this.btnShowNextCourse);
            this.groupBox1.Controls.Add(this.btnShowPreviousCourse);
            this.groupBox1.Controls.Add(this.btnShowFirstCourse);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(985, 107);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navegar";
            // 
            // btnShowLastCourse
            // 
            this.btnShowLastCourse.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnShowLastCourse.Location = new System.Drawing.Point(763, 23);
            this.btnShowLastCourse.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowLastCourse.Name = "btnShowLastCourse";
            this.btnShowLastCourse.Size = new System.Drawing.Size(215, 54);
            this.btnShowLastCourse.TabIndex = 3;
            this.btnShowLastCourse.Text = "Ultimo";
            this.btnShowLastCourse.UseVisualStyleBackColor = true;
            this.btnShowLastCourse.Click += new System.EventHandler(this.btnShowLastCourse_Click);
            // 
            // btnShowNextCourse
            // 
            this.btnShowNextCourse.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnShowNextCourse.Location = new System.Drawing.Point(533, 23);
            this.btnShowNextCourse.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowNextCourse.Name = "btnShowNextCourse";
            this.btnShowNextCourse.Size = new System.Drawing.Size(215, 54);
            this.btnShowNextCourse.TabIndex = 2;
            this.btnShowNextCourse.Text = "Siguiente";
            this.btnShowNextCourse.UseVisualStyleBackColor = true;
            this.btnShowNextCourse.Click += new System.EventHandler(this.btnShowNextCourse_Click);
            // 
            // btnShowPreviousCourse
            // 
            this.btnShowPreviousCourse.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnShowPreviousCourse.Location = new System.Drawing.Point(285, 23);
            this.btnShowPreviousCourse.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowPreviousCourse.Name = "btnShowPreviousCourse";
            this.btnShowPreviousCourse.Size = new System.Drawing.Size(215, 54);
            this.btnShowPreviousCourse.TabIndex = 1;
            this.btnShowPreviousCourse.Text = "Anterior";
            this.btnShowPreviousCourse.UseVisualStyleBackColor = true;
            this.btnShowPreviousCourse.Click += new System.EventHandler(this.btnShowPreviousCourse_Click);
            // 
            // btnShowFirstCourse
            // 
            this.btnShowFirstCourse.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnShowFirstCourse.Location = new System.Drawing.Point(24, 23);
            this.btnShowFirstCourse.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowFirstCourse.Name = "btnShowFirstCourse";
            this.btnShowFirstCourse.Size = new System.Drawing.Size(215, 54);
            this.btnShowFirstCourse.TabIndex = 0;
            this.btnShowFirstCourse.Text = "Primero";
            this.btnShowFirstCourse.UseVisualStyleBackColor = true;
            this.btnShowFirstCourse.Click += new System.EventHandler(this.btnShowFirstCourse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "ID:";
            // 
            // FCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 416);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblEntryNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FCurso";
            this.Text = "FCurso";
            this.Load += new System.EventHandler(this.FCurso_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblEntryNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowLastCourse;
        private System.Windows.Forms.Button btnShowNextCourse;
        private System.Windows.Forms.Button btnShowPreviousCourse;
        private System.Windows.Forms.Button btnShowFirstCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}