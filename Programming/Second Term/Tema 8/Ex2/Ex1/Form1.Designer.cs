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
            this.btnCreateCircle = new System.Windows.Forms.Button();
            this.btnCreateSquare = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowSquares = new System.Windows.Forms.Button();
            this.btnShowEveryFigure = new System.Windows.Forms.Button();
            this.btnShowCircles = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateCircle
            // 
            this.btnCreateCircle.Location = new System.Drawing.Point(13, 42);
            this.btnCreateCircle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateCircle.Name = "btnCreateCircle";
            this.btnCreateCircle.Size = new System.Drawing.Size(200, 66);
            this.btnCreateCircle.TabIndex = 0;
            this.btnCreateCircle.Text = "Crear Circulo";
            this.btnCreateCircle.UseVisualStyleBackColor = true;
            this.btnCreateCircle.Click += new System.EventHandler(this.btnCreateCircle_Click);
            // 
            // btnCreateSquare
            // 
            this.btnCreateSquare.Location = new System.Drawing.Point(13, 150);
            this.btnCreateSquare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateSquare.Name = "btnCreateSquare";
            this.btnCreateSquare.Size = new System.Drawing.Size(200, 71);
            this.btnCreateSquare.TabIndex = 1;
            this.btnCreateSquare.Text = "Crear Cuadrado";
            this.btnCreateSquare.UseVisualStyleBackColor = true;
            this.btnCreateSquare.Click += new System.EventHandler(this.btnCreateSquare_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateCircle);
            this.groupBox1.Controls.Add(this.btnCreateSquare);
            this.groupBox1.Location = new System.Drawing.Point(61, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(221, 255);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Figuras";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowSquares);
            this.groupBox2.Controls.Add(this.btnShowEveryFigure);
            this.groupBox2.Controls.Add(this.btnShowCircles);
            this.groupBox2.Location = new System.Drawing.Point(403, 74);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(221, 321);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crear Figuras";
            // 
            // btnShowSquares
            // 
            this.btnShowSquares.Location = new System.Drawing.Point(13, 242);
            this.btnShowSquares.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowSquares.Name = "btnShowSquares";
            this.btnShowSquares.Size = new System.Drawing.Size(200, 71);
            this.btnShowSquares.TabIndex = 2;
            this.btnShowSquares.Text = "Mostrar Cuadrados";
            this.btnShowSquares.UseVisualStyleBackColor = true;
            this.btnShowSquares.Click += new System.EventHandler(this.btnShowSquares_Click);
            // 
            // btnShowEveryFigure
            // 
            this.btnShowEveryFigure.Location = new System.Drawing.Point(13, 31);
            this.btnShowEveryFigure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowEveryFigure.Name = "btnShowEveryFigure";
            this.btnShowEveryFigure.Size = new System.Drawing.Size(200, 66);
            this.btnShowEveryFigure.TabIndex = 0;
            this.btnShowEveryFigure.Text = "Mostrar todas las figuras";
            this.btnShowEveryFigure.UseVisualStyleBackColor = true;
            this.btnShowEveryFigure.Click += new System.EventHandler(this.btnShowEveryFigure_Click);
            // 
            // btnShowCircles
            // 
            this.btnShowCircles.Location = new System.Drawing.Point(13, 135);
            this.btnShowCircles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowCircles.Name = "btnShowCircles";
            this.btnShowCircles.Size = new System.Drawing.Size(200, 71);
            this.btnShowCircles.TabIndex = 1;
            this.btnShowCircles.Text = "Mostrar Circulos";
            this.btnShowCircles.UseVisualStyleBackColor = true;
            this.btnShowCircles.Click += new System.EventHandler(this.btnShowCircles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 494);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Ex2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateCircle;
        private System.Windows.Forms.Button btnCreateSquare;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowSquares;
        private System.Windows.Forms.Button btnShowEveryFigure;
        private System.Windows.Forms.Button btnShowCircles;
    }
}

