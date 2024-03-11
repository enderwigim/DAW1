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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateShape = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowSquares = new System.Windows.Forms.Button();
            this.btnShowEveryFigure = new System.Windows.Forms.Button();
            this.btnShowCircles = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateShape);
            this.groupBox1.Location = new System.Drawing.Point(51, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 272);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Figuras";
            // 
            // btnCreateShape
            // 
            this.btnCreateShape.Location = new System.Drawing.Point(10, 25);
            this.btnCreateShape.Name = "btnCreateShape";
            this.btnCreateShape.Size = new System.Drawing.Size(150, 230);
            this.btnCreateShape.TabIndex = 2;
            this.btnCreateShape.Text = "Crear Figuras";
            this.btnCreateShape.UseVisualStyleBackColor = true;
            this.btnCreateShape.Click += new System.EventHandler(this.btnCreateTriangle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowSquares);
            this.groupBox2.Controls.Add(this.btnShowEveryFigure);
            this.groupBox2.Controls.Add(this.btnShowCircles);
            this.groupBox2.Location = new System.Drawing.Point(302, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 272);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crear Figuras";
            // 
            // btnShowSquares
            // 
            this.btnShowSquares.Location = new System.Drawing.Point(10, 197);
            this.btnShowSquares.Name = "btnShowSquares";
            this.btnShowSquares.Size = new System.Drawing.Size(150, 58);
            this.btnShowSquares.TabIndex = 2;
            this.btnShowSquares.Text = "Mostrar Cuadrados";
            this.btnShowSquares.UseVisualStyleBackColor = true;
            this.btnShowSquares.Click += new System.EventHandler(this.btnShowSquares_Click);
            // 
            // btnShowEveryFigure
            // 
            this.btnShowEveryFigure.Location = new System.Drawing.Point(10, 25);
            this.btnShowEveryFigure.Name = "btnShowEveryFigure";
            this.btnShowEveryFigure.Size = new System.Drawing.Size(150, 54);
            this.btnShowEveryFigure.TabIndex = 0;
            this.btnShowEveryFigure.Text = "Mostrar todas las figuras";
            this.btnShowEveryFigure.UseVisualStyleBackColor = true;
            this.btnShowEveryFigure.Click += new System.EventHandler(this.btnShowEveryFigure_Click);
            // 
            // btnShowCircles
            // 
            this.btnShowCircles.Location = new System.Drawing.Point(10, 110);
            this.btnShowCircles.Name = "btnShowCircles";
            this.btnShowCircles.Size = new System.Drawing.Size(150, 58);
            this.btnShowCircles.TabIndex = 1;
            this.btnShowCircles.Text = "Mostrar Circulos";
            this.btnShowCircles.UseVisualStyleBackColor = true;
            this.btnShowCircles.Click += new System.EventHandler(this.btnShowCircles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ex2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowSquares;
        private System.Windows.Forms.Button btnShowEveryFigure;
        private System.Windows.Forms.Button btnShowCircles;
        private System.Windows.Forms.Button btnCreateShape;
    }
}

