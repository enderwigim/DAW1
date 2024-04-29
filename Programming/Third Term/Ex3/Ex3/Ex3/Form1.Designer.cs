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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtFaction = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.btnUpdateChar = new System.Windows.Forms.Button();
            this.btnDeleteChar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAddNeyCharacter = new System.Windows.Forms.Button();
            this.btnShowFirst = new System.Windows.Forms.Button();
            this.btnShowNext = new System.Windows.Forms.Button();
            this.btnShowPrevious = new System.Windows.Forms.Button();
            this.btnShowLast = new System.Windows.Forms.Button();
            this.lblEntryNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Faction";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 12);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(411, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(72, 64);
            this.txtClass.Margin = new System.Windows.Forms.Padding(4);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(411, 22);
            this.txtClass.TabIndex = 6;
            // 
            // txtFaction
            // 
            this.txtFaction.Location = new System.Drawing.Point(72, 131);
            this.txtFaction.Margin = new System.Windows.Forms.Padding(4);
            this.txtFaction.Name = "txtFaction";
            this.txtFaction.Size = new System.Drawing.Size(411, 22);
            this.txtFaction.TabIndex = 7;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(605, 60);
            this.txtLevel.Margin = new System.Windows.Forms.Padding(4);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(411, 22);
            this.txtLevel.TabIndex = 8;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(605, 131);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(411, 22);
            this.txtLocation.TabIndex = 9;
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(7, 87);
            this.btnCreateNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(224, 57);
            this.btnCreateNew.TabIndex = 10;
            this.btnCreateNew.Text = "Create New Character";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // btnUpdateChar
            // 
            this.btnUpdateChar.Location = new System.Drawing.Point(7, 217);
            this.btnUpdateChar.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateChar.Name = "btnUpdateChar";
            this.btnUpdateChar.Size = new System.Drawing.Size(224, 57);
            this.btnUpdateChar.TabIndex = 11;
            this.btnUpdateChar.Text = "Update Character";
            this.btnUpdateChar.UseVisualStyleBackColor = true;
            this.btnUpdateChar.Click += new System.EventHandler(this.btnUpdateChar_Click);
            // 
            // btnDeleteChar
            // 
            this.btnDeleteChar.Location = new System.Drawing.Point(7, 152);
            this.btnDeleteChar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteChar.Name = "btnDeleteChar";
            this.btnDeleteChar.Size = new System.Drawing.Size(224, 57);
            this.btnDeleteChar.TabIndex = 11;
            this.btnDeleteChar.Text = "Delete Character";
            this.btnDeleteChar.UseVisualStyleBackColor = true;
            this.btnDeleteChar.Click += new System.EventHandler(this.btnDeleteChar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(545, 202);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 57);
            this.button4.TabIndex = 12;
            this.button4.Text = "Show Every Character";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnAddNeyCharacter
            // 
            this.btnAddNeyCharacter.Location = new System.Drawing.Point(7, 22);
            this.btnAddNeyCharacter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNeyCharacter.Name = "btnAddNeyCharacter";
            this.btnAddNeyCharacter.Size = new System.Drawing.Size(224, 57);
            this.btnAddNeyCharacter.TabIndex = 13;
            this.btnAddNeyCharacter.Text = "Add New Character";
            this.btnAddNeyCharacter.UseVisualStyleBackColor = true;
            this.btnAddNeyCharacter.Click += new System.EventHandler(this.btnAddNeyCharacter_Click);
            // 
            // btnShowFirst
            // 
            this.btnShowFirst.Location = new System.Drawing.Point(7, 22);
            this.btnShowFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowFirst.Name = "btnShowFirst";
            this.btnShowFirst.Size = new System.Drawing.Size(224, 57);
            this.btnShowFirst.TabIndex = 14;
            this.btnShowFirst.Text = "First Character";
            this.btnShowFirst.UseVisualStyleBackColor = true;
            this.btnShowFirst.Click += new System.EventHandler(this.btnShowFirst_Click);
            // 
            // btnShowNext
            // 
            this.btnShowNext.Location = new System.Drawing.Point(7, 87);
            this.btnShowNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowNext.Name = "btnShowNext";
            this.btnShowNext.Size = new System.Drawing.Size(224, 57);
            this.btnShowNext.TabIndex = 15;
            this.btnShowNext.Text = "Next";
            this.btnShowNext.UseVisualStyleBackColor = true;
            this.btnShowNext.Click += new System.EventHandler(this.btnShowNext_Click);
            // 
            // btnShowPrevious
            // 
            this.btnShowPrevious.Location = new System.Drawing.Point(7, 152);
            this.btnShowPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowPrevious.Name = "btnShowPrevious";
            this.btnShowPrevious.Size = new System.Drawing.Size(224, 57);
            this.btnShowPrevious.TabIndex = 16;
            this.btnShowPrevious.Text = "Previous";
            this.btnShowPrevious.UseVisualStyleBackColor = true;
            this.btnShowPrevious.Click += new System.EventHandler(this.btnShowPrevious_Click);
            // 
            // btnShowLast
            // 
            this.btnShowLast.Location = new System.Drawing.Point(7, 217);
            this.btnShowLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowLast.Name = "btnShowLast";
            this.btnShowLast.Size = new System.Drawing.Size(224, 57);
            this.btnShowLast.TabIndex = 17;
            this.btnShowLast.Text = "Last";
            this.btnShowLast.UseVisualStyleBackColor = true;
            this.btnShowLast.Click += new System.EventHandler(this.btnShowLast_Click);
            // 
            // lblEntryNumber
            // 
            this.lblEntryNumber.AutoSize = true;
            this.lblEntryNumber.Location = new System.Drawing.Point(899, 18);
            this.lblEntryNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntryNumber.Name = "lblEntryNumber";
            this.lblEntryNumber.Size = new System.Drawing.Size(0, 16);
            this.lblEntryNumber.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(837, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Registro: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddNeyCharacter);
            this.groupBox1.Controls.Add(this.btnCreateNew);
            this.groupBox1.Controls.Add(this.btnDeleteChar);
            this.groupBox1.Controls.Add(this.btnUpdateChar);
            this.groupBox1.Location = new System.Drawing.Point(16, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 292);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRUD";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowFirst);
            this.groupBox2.Controls.Add(this.btnShowNext);
            this.groupBox2.Controls.Add(this.btnShowPrevious);
            this.groupBox2.Controls.Add(this.btnShowLast);
            this.groupBox2.Location = new System.Drawing.Point(289, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 292);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nav";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEntryNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtFaction);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "World Of Warcraft";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtFaction;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.Button btnUpdateChar;
        private System.Windows.Forms.Button btnDeleteChar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAddNeyCharacter;
        private System.Windows.Forms.Button btnShowFirst;
        private System.Windows.Forms.Button btnShowNext;
        private System.Windows.Forms.Button btnShowPrevious;
        private System.Windows.Forms.Button btnShowLast;
        private System.Windows.Forms.Label lblEntryNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

