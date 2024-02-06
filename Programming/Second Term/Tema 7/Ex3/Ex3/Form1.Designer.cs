namespace Ex3
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
            this.btnReadDate = new System.Windows.Forms.Button();
            this.btnShowDate = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadDate
            // 
            this.btnReadDate.Location = new System.Drawing.Point(287, 38);
            this.btnReadDate.Name = "btnReadDate";
            this.btnReadDate.Size = new System.Drawing.Size(156, 61);
            this.btnReadDate.TabIndex = 0;
            this.btnReadDate.Text = "Read Dates";
            this.btnReadDate.UseVisualStyleBackColor = true;
            this.btnReadDate.Click += new System.EventHandler(this.btnReadDate_Click);
            // 
            // btnShowDate
            // 
            this.btnShowDate.Location = new System.Drawing.Point(287, 262);
            this.btnShowDate.Name = "btnShowDate";
            this.btnShowDate.Size = new System.Drawing.Size(156, 61);
            this.btnShowDate.TabIndex = 1;
            this.btnShowDate.Text = "Show Dates";
            this.btnShowDate.UseVisualStyleBackColor = true;
            this.btnShowDate.Click += new System.EventHandler(this.btnShowDate_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(287, 150);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(156, 61);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order Dates";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnShowDate);
            this.Controls.Add(this.btnReadDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadDate;
        private System.Windows.Forms.Button btnShowDate;
        private System.Windows.Forms.Button btnOrder;
    }
}

