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
            this.btnTriangleRectangle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // btnTriangleRectangle
            // 
            this.btnTriangleRectangle.Location = new System.Drawing.Point(231, 11);
            this.btnTriangleRectangle.Name = "btnTriangleRectangle";
            this.btnTriangleRectangle.Size = new System.Drawing.Size(186, 86);
            this.btnTriangleRectangle.TabIndex = 1;
            this.btnTriangleRectangle.Text = "Triangulo Rectangulo";
            this.btnTriangleRectangle.UseVisualStyleBackColor = true;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 109);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnTriangleRectangle);
            this.Controls.Add(this.btnTriangleEquilater);
            this.Name = "Form2";
            this.Text = "Tipo de triangulo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTriangleEquilater;
        private System.Windows.Forms.Button btnTriangleRectangle;
        private System.Windows.Forms.Button button3;
    }
}