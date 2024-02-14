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
            this.btnShowEmployeeList = new System.Windows.Forms.Button();
            this.btnAddSell = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete_Employee = new System.Windows.Forms.Button();
            this.btnShowEmployeeData = new System.Windows.Forms.Button();
            this.btnOrderEmployees = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeleteSells = new System.Windows.Forms.Button();
            this.btnMostSellerEmployee = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Location = new System.Drawing.Point(34, 105);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(184, 53);
            this.btnNewEmployee.TabIndex = 0;
            this.btnNewEmployee.Text = "Nuevo Empleado";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnShowEmployeeList
            // 
            this.btnShowEmployeeList.Location = new System.Drawing.Point(34, 30);
            this.btnShowEmployeeList.Name = "btnShowEmployeeList";
            this.btnShowEmployeeList.Size = new System.Drawing.Size(184, 55);
            this.btnShowEmployeeList.TabIndex = 2;
            this.btnShowEmployeeList.Text = "Mostrar Lista Empleados";
            this.btnShowEmployeeList.UseVisualStyleBackColor = true;
            this.btnShowEmployeeList.Click += new System.EventHandler(this.btnShowEmployeeList_Click);
            // 
            // btnAddSell
            // 
            this.btnAddSell.Location = new System.Drawing.Point(49, 28);
            this.btnAddSell.Name = "btnAddSell";
            this.btnAddSell.Size = new System.Drawing.Size(184, 53);
            this.btnAddSell.TabIndex = 3;
            this.btnAddSell.Text = "Añadir Venta";
            this.btnAddSell.UseVisualStyleBackColor = true;
            this.btnAddSell.Click += new System.EventHandler(this.btnAddSell_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOrderEmployees);
            this.groupBox1.Controls.Add(this.btnShowEmployeeData);
            this.groupBox1.Controls.Add(this.btnDelete_Employee);
            this.groupBox1.Controls.Add(this.btnNewEmployee);
            this.groupBox1.Controls.Add(this.btnShowEmployeeList);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 206);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleados";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMostSellerEmployee);
            this.groupBox2.Controls.Add(this.btnDeleteSells);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnAddSell);
            this.groupBox2.Location = new System.Drawing.Point(12, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 180);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ventas";
            // 
            // btnDelete_Employee
            // 
            this.btnDelete_Employee.Location = new System.Drawing.Point(267, 105);
            this.btnDelete_Employee.Name = "btnDelete_Employee";
            this.btnDelete_Employee.Size = new System.Drawing.Size(184, 53);
            this.btnDelete_Employee.TabIndex = 4;
            this.btnDelete_Employee.Text = "Eliminar Empleado";
            this.btnDelete_Employee.UseVisualStyleBackColor = true;
            this.btnDelete_Employee.Click += new System.EventHandler(this.btnDelete_Employee_Click);
            // 
            // btnShowEmployeeData
            // 
            this.btnShowEmployeeData.Location = new System.Drawing.Point(267, 30);
            this.btnShowEmployeeData.Name = "btnShowEmployeeData";
            this.btnShowEmployeeData.Size = new System.Drawing.Size(184, 53);
            this.btnShowEmployeeData.TabIndex = 5;
            this.btnShowEmployeeData.Text = "Mostrar Datos Empleado";
            this.btnShowEmployeeData.UseVisualStyleBackColor = true;
            this.btnShowEmployeeData.Click += new System.EventHandler(this.btnShowEmployeeData_Click);
            // 
            // btnOrderEmployees
            // 
            this.btnOrderEmployees.Location = new System.Drawing.Point(486, 71);
            this.btnOrderEmployees.Name = "btnOrderEmployees";
            this.btnOrderEmployees.Size = new System.Drawing.Size(184, 53);
            this.btnOrderEmployees.TabIndex = 6;
            this.btnOrderEmployees.Text = "Ordenar Empleados";
            this.btnOrderEmployees.UseVisualStyleBackColor = true;
            this.btnOrderEmployees.Click += new System.EventHandler(this.btnOrderEmployees_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ordenar Empleados por Ventas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSells
            // 
            this.btnDeleteSells.Location = new System.Drawing.Point(49, 103);
            this.btnDeleteSells.Name = "btnDeleteSells";
            this.btnDeleteSells.Size = new System.Drawing.Size(184, 53);
            this.btnDeleteSells.TabIndex = 6;
            this.btnDeleteSells.Text = "Eliminar las ventas de un empleado";
            this.btnDeleteSells.UseVisualStyleBackColor = true;
            this.btnDeleteSells.Click += new System.EventHandler(this.btnDeleteSells_Click);
            // 
            // btnMostSellerEmployee
            // 
            this.btnMostSellerEmployee.Location = new System.Drawing.Point(486, 28);
            this.btnMostSellerEmployee.Name = "btnMostSellerEmployee";
            this.btnMostSellerEmployee.Size = new System.Drawing.Size(184, 53);
            this.btnMostSellerEmployee.TabIndex = 7;
            this.btnMostSellerEmployee.Text = "Mostrar Empleado Con Mayores Ventas";
            this.btnMostSellerEmployee.UseVisualStyleBackColor = true;
            this.btnMostSellerEmployee.Click += new System.EventHandler(this.btnMostSellerEmployee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.Button btnShowEmployeeList;
        private System.Windows.Forms.Button btnAddSell;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete_Employee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowEmployeeData;
        private System.Windows.Forms.Button btnOrderEmployees;
        private System.Windows.Forms.Button btnDeleteSells;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMostSellerEmployee;
    }
}

