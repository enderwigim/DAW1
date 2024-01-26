namespace Ejercicio09
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCantidadPesetas = new TextBox();
            btnCalcular = new Button();
            lblPesetas = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(234, 79);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 0;
            label1.Text = "Valor: ";
            // 
            // txtCantidadPesetas
            // 
            txtCantidadPesetas.Location = new Point(310, 77);
            txtCantidadPesetas.Name = "txtCantidadPesetas";
            txtCantidadPesetas.Size = new Size(202, 23);
            txtCantidadPesetas.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(310, 137);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(199, 49);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblPesetas
            // 
            lblPesetas.AutoSize = true;
            lblPesetas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPesetas.Location = new Point(312, 239);
            lblPesetas.Name = "lblPesetas";
            lblPesetas.Size = new Size(0, 21);
            lblPesetas.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPesetas);
            Controls.Add(btnCalcular);
            Controls.Add(txtCantidadPesetas);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ejercicio 09";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCantidadPesetas;
        private Button btnCalcular;
        private Label lblPesetas;
    }
}