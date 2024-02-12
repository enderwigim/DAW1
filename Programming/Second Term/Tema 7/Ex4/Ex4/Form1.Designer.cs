namespace Ex4
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
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.btnBirthDay = new System.Windows.Forms.Button();
            this.btnShowEmployeeList = new System.Windows.Forms.Button();
            this.btnAddSell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Location = new System.Drawing.Point(124, 95);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(259, 53);
            this.btnNewEmployee.TabIndex = 0;
            this.btnNewEmployee.Text = "Nuevo Empleado";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnBirthDay
            // 
            this.btnBirthDay.Location = new System.Drawing.Point(124, 282);
            this.btnBirthDay.Name = "btnBirthDay";
            this.btnBirthDay.Size = new System.Drawing.Size(259, 53);
            this.btnBirthDay.TabIndex = 1;
            this.btnBirthDay.Text = "Cumpleaños Empleado";
            this.btnBirthDay.UseVisualStyleBackColor = true;
            this.btnBirthDay.Click += new System.EventHandler(this.btnBirthDay_Click);
            // 
            // btnShowEmployeeList
            // 
            this.btnShowEmployeeList.Location = new System.Drawing.Point(457, 95);
            this.btnShowEmployeeList.Name = "btnShowEmployeeList";
            this.btnShowEmployeeList.Size = new System.Drawing.Size(259, 56);
            this.btnShowEmployeeList.TabIndex = 2;
            this.btnShowEmployeeList.Text = "Mostrar Lista Empleados";
            this.btnShowEmployeeList.UseVisualStyleBackColor = true;
            this.btnShowEmployeeList.Click += new System.EventHandler(this.btnShowEmployeeList_Click);
            // 
            // btnAddSell
            // 
            this.btnAddSell.Location = new System.Drawing.Point(457, 282);
            this.btnAddSell.Name = "btnAddSell";
            this.btnAddSell.Size = new System.Drawing.Size(259, 53);
            this.btnAddSell.TabIndex = 3;
            this.btnAddSell.Text = "Añadir Venta";
            this.btnAddSell.UseVisualStyleBackColor = true;
            this.btnAddSell.Click += new System.EventHandler(this.btnAddSell_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddSell);
            this.Controls.Add(this.btnShowEmployeeList);
            this.Controls.Add(this.btnBirthDay);
            this.Controls.Add(this.btnNewEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.Button btnBirthDay;
        private System.Windows.Forms.Button btnShowEmployeeList;
        private System.Windows.Forms.Button btnAddSell;
    }
}

