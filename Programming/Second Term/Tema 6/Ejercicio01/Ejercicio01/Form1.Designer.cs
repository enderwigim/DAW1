namespace Ejercicio01
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.btnShowFirstPosition = new System.Windows.Forms.Button();
            this.btnShowPositionOfValues = new System.Windows.Forms.Button();
            this.btnRemoveFirst = new System.Windows.Forms.Button();
            this.btnRemoveValues = new System.Windows.Forms.Button();
            this.btnRemovePosition = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(24, 69);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(177, 37);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert Number";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(24, 130);
            this.btnShowList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(177, 37);
            this.btnShowList.TabIndex = 2;
            this.btnShowList.Text = "Show List";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // btnShowFirstPosition
            // 
            this.btnShowFirstPosition.Location = new System.Drawing.Point(24, 186);
            this.btnShowFirstPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowFirstPosition.Name = "btnShowFirstPosition";
            this.btnShowFirstPosition.Size = new System.Drawing.Size(177, 37);
            this.btnShowFirstPosition.TabIndex = 3;
            this.btnShowFirstPosition.Text = "Show First Position of Value";
            this.btnShowFirstPosition.UseVisualStyleBackColor = true;
            this.btnShowFirstPosition.Click += new System.EventHandler(this.btnShowFirstPosition_Click);
            // 
            // btnShowPositionOfValues
            // 
            this.btnShowPositionOfValues.Location = new System.Drawing.Point(24, 236);
            this.btnShowPositionOfValues.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowPositionOfValues.Name = "btnShowPositionOfValues";
            this.btnShowPositionOfValues.Size = new System.Drawing.Size(177, 37);
            this.btnShowPositionOfValues.TabIndex = 4;
            this.btnShowPositionOfValues.Text = "Show Position of Values";
            this.btnShowPositionOfValues.UseVisualStyleBackColor = true;
            this.btnShowPositionOfValues.Click += new System.EventHandler(this.btnShowPositionOfValues_Click);
            // 
            // btnRemoveFirst
            // 
            this.btnRemoveFirst.Location = new System.Drawing.Point(362, 43);
            this.btnRemoveFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveFirst.Name = "btnRemoveFirst";
            this.btnRemoveFirst.Size = new System.Drawing.Size(177, 37);
            this.btnRemoveFirst.TabIndex = 5;
            this.btnRemoveFirst.Text = "Remove (first) Value";
            this.btnRemoveFirst.UseVisualStyleBackColor = true;
            this.btnRemoveFirst.Click += new System.EventHandler(this.btnRemoveFirst_Click);
            // 
            // btnRemoveValues
            // 
            this.btnRemoveValues.Location = new System.Drawing.Point(362, 96);
            this.btnRemoveValues.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveValues.Name = "btnRemoveValues";
            this.btnRemoveValues.Size = new System.Drawing.Size(177, 37);
            this.btnRemoveValues.TabIndex = 6;
            this.btnRemoveValues.Text = "Remove Values";
            this.btnRemoveValues.UseVisualStyleBackColor = true;
            this.btnRemoveValues.Click += new System.EventHandler(this.btnRemoveValues_Click);
            // 
            // btnRemovePosition
            // 
            this.btnRemovePosition.Location = new System.Drawing.Point(362, 146);
            this.btnRemovePosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemovePosition.Name = "btnRemovePosition";
            this.btnRemovePosition.Size = new System.Drawing.Size(177, 37);
            this.btnRemovePosition.TabIndex = 7;
            this.btnRemovePosition.Text = "Remove Position";
            this.btnRemovePosition.UseVisualStyleBackColor = true;
            this.btnRemovePosition.Click += new System.EventHandler(this.btnRemovePosition_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(362, 198);
            this.btnSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(177, 37);
            this.btnSort.TabIndex = 8;
            this.btnSort.Text = "Sort List";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(362, 254);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(177, 37);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Remove All Elements";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 18);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(177, 37);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Number";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.btnShowList);
            this.groupBox1.Controls.Add(this.btnShowFirstPosition);
            this.groupBox1.Controls.Add(this.btnShowPositionOfValues);
            this.groupBox1.Location = new System.Drawing.Point(33, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 290);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRemovePosition);
            this.Controls.Add(this.btnRemoveValues);
            this.Controls.Add(this.btnRemoveFirst);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Button btnShowFirstPosition;
        private System.Windows.Forms.Button btnShowPositionOfValues;
        private System.Windows.Forms.Button btnRemoveFirst;
        private System.Windows.Forms.Button btnRemoveValues;
        private System.Windows.Forms.Button btnRemovePosition;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

