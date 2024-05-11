namespace Ex3
{
    partial class SelectCharacter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectCharacter));
            this.btnShowNext = new System.Windows.Forms.Button();
            this.btnShowPrevious = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFaction = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.characterImg = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnChangeCharacters = new System.Windows.Forms.Button();
            this.factionImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.characterImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factionImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowNext
            // 
            this.btnShowNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnShowNext.Location = new System.Drawing.Point(433, 462);
            this.btnShowNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowNext.Name = "btnShowNext";
            this.btnShowNext.Size = new System.Drawing.Size(149, 39);
            this.btnShowNext.TabIndex = 63;
            this.btnShowNext.Text = "NEXT";
            this.btnShowNext.UseVisualStyleBackColor = true;
            this.btnShowNext.Click += new System.EventHandler(this.btnShowNext_Click);
            // 
            // btnShowPrevious
            // 
            this.btnShowPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnShowPrevious.Location = new System.Drawing.Point(88, 462);
            this.btnShowPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowPrevious.Name = "btnShowPrevious";
            this.btnShowPrevious.Size = new System.Drawing.Size(149, 39);
            this.btnShowPrevious.TabIndex = 62;
            this.btnShowPrevious.Text = "PREVIOUS";
            this.btnShowPrevious.UseVisualStyleBackColor = true;
            this.btnShowPrevious.Click += new System.EventHandler(this.btnShowPrevious_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Sylfaen", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(121, 362);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(135, 31);
            this.lblLocation.TabIndex = 61;
            this.lblLocation.Text = "Stormwind";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Sylfaen", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(211, 277);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(40, 31);
            this.lblLevel.TabIndex = 60;
            this.lblLevel.Text = "80";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 31);
            this.label4.TabIndex = 59;
            this.label4.Text = "Level:";
            // 
            // lblFaction
            // 
            this.lblFaction.AutoSize = true;
            this.lblFaction.Font = new System.Drawing.Font("Sylfaen", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaction.Location = new System.Drawing.Point(121, 209);
            this.lblFaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFaction.Name = "lblFaction";
            this.lblFaction.Size = new System.Drawing.Size(103, 31);
            this.lblFaction.TabIndex = 57;
            this.lblFaction.Text = "Alliance";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Sylfaen", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(121, 133);
            this.lblClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(95, 31);
            this.lblClass.TabIndex = 56;
            this.lblClass.Text = "Paladin";
            // 
            // characterImg
            // 
            this.characterImg.Image = ((System.Drawing.Image)(resources.GetObject("characterImg.Image")));
            this.characterImg.Location = new System.Drawing.Point(333, 133);
            this.characterImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.characterImg.Name = "characterImg";
            this.characterImg.Size = new System.Drawing.Size(211, 309);
            this.characterImg.TabIndex = 55;
            this.characterImg.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Sylfaen", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(255, 39);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 44);
            this.lblName.TabIndex = 54;
            this.lblName.Text = "Ender";
            // 
            // btnChangeCharacters
            // 
            this.btnChangeCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnChangeCharacters.Location = new System.Drawing.Point(260, 462);
            this.btnChangeCharacters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangeCharacters.Name = "btnChangeCharacters";
            this.btnChangeCharacters.Size = new System.Drawing.Size(149, 39);
            this.btnChangeCharacters.TabIndex = 64;
            this.btnChangeCharacters.Text = "CHANGE";
            this.btnChangeCharacters.UseVisualStyleBackColor = true;
            this.btnChangeCharacters.Click += new System.EventHandler(this.btnChangeCharacters_Click);
            // 
            // factionImg
            // 
            this.factionImg.Image = ((System.Drawing.Image)(resources.GetObject("factionImg.Image")));
            this.factionImg.Location = new System.Drawing.Point(433, 22);
            this.factionImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.factionImg.Name = "factionImg";
            this.factionImg.Size = new System.Drawing.Size(109, 103);
            this.factionImg.TabIndex = 65;
            this.factionImg.TabStop = false;
            // 
            // SelectCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 545);
            this.Controls.Add(this.factionImg);
            this.Controls.Add(this.btnChangeCharacters);
            this.Controls.Add(this.btnShowNext);
            this.Controls.Add(this.btnShowPrevious);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFaction);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.characterImg);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SelectCharacter";
            this.Text = "SelectCharacter";
            this.Load += new System.EventHandler(this.ViewCharacter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.characterImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factionImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowNext;
        private System.Windows.Forms.Button btnShowPrevious;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFaction;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.PictureBox characterImg;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnChangeCharacters;
        private System.Windows.Forms.PictureBox factionImg;
    }
}