namespace Ex2
{
    partial class TypeOfTriangle
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
            this.btnTriangleEquilater = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCreateCircle = new System.Windows.Forms.Button();
            this.btnCreateSquare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTriangleEquilater
            // 
            this.btnTriangleEquilater.Location = new System.Drawing.Point(12, 12);
            this.btnTriangleEquilater.Name = "btnTriangleEquilater";
            this.btnTriangleEquilater.Size = new System.Drawing.Size(186, 86);
            this.btnTriangleEquilater.TabIndex = 0;
            this.btnTriangleEquilater.Text = "Triangulo Equilatero";
            this.btnTriangleEquilater.UseVisualStyleBackColor = true;
            this.btnTriangleEquilater.Click += new System.EventHandler(this.btnTriangleEquilater_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(231, 11);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(186, 86);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.Text = "Rectangulo";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(450, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 86);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnCreateCircle
            // 
            this.btnCreateCircle.Location = new System.Drawing.Point(125, 153);
            this.btnCreateCircle.Name = "btnCreateCircle";
            this.btnCreateCircle.Size = new System.Drawing.Size(186, 86);
            this.btnCreateCircle.TabIndex = 3;
            this.btnCreateCircle.Text = "Circulo";
            this.btnCreateCircle.UseVisualStyleBackColor = true;
            this.btnCreateCircle.Click += new System.EventHandler(this.btnCreateCircle_Click);
            // 
            // btnCreateSquare
            // 
            this.btnCreateSquare.Location = new System.Drawing.Point(356, 153);
            this.btnCreateSquare.Name = "btnCreateSquare";
            this.btnCreateSquare.Size = new System.Drawing.Size(186, 86);
            this.btnCreateSquare.TabIndex = 4;
            this.btnCreateSquare.Text = "Cuadrado";
            this.btnCreateSquare.UseVisualStyleBackColor = true;
            this.btnCreateSquare.Click += new System.EventHandler(this.btnCreateSquare_Click);
            // 
            // TypeOfTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 288);
            this.Controls.Add(this.btnCreateSquare);
            this.Controls.Add(this.btnCreateCircle);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnTriangleEquilater);
            this.Name = "TypeOfTriangle";
            this.Text = "Tipo de triangulo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTriangleEquilater;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCreateCircle;
        private System.Windows.Forms.Button btnCreateSquare;
    }
}