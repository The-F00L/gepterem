namespace GepteremProjekt
{
    partial class Form1
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
            this.panel_Utcakep = new System.Windows.Forms.Panel();
            this.button_Mentes = new System.Windows.Forms.Button();
            this.button_Balra = new System.Windows.Forms.Button();
            this.button_Jobbra = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Utcakep
            // 
            this.panel_Utcakep.Location = new System.Drawing.Point(330, 23);
            this.panel_Utcakep.Name = "panel_Utcakep";
            this.panel_Utcakep.Size = new System.Drawing.Size(524, 388);
            this.panel_Utcakep.TabIndex = 6;
            // 
            // button_Mentes
            // 
            this.button_Mentes.BackgroundImage = global::GepteremProjekt.Properties.Resources.ment;
            this.button_Mentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Mentes.Location = new System.Drawing.Point(97, 353);
            this.button_Mentes.Name = "button_Mentes";
            this.button_Mentes.Size = new System.Drawing.Size(116, 113);
            this.button_Mentes.TabIndex = 5;
            this.button_Mentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Mentes.UseVisualStyleBackColor = true;
            this.button_Mentes.Click += new System.EventHandler(this.button_Mentes_Click);
            // 
            // button_Balra
            // 
            this.button_Balra.BackColor = System.Drawing.Color.Transparent;
            this.button_Balra.BackgroundImage = global::GepteremProjekt.Properties.Resources.bal;
            this.button_Balra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Balra.FlatAppearance.BorderSize = 0;
            this.button_Balra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Balra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Balra.Location = new System.Drawing.Point(12, 173);
            this.button_Balra.Name = "button_Balra";
            this.button_Balra.Size = new System.Drawing.Size(68, 56);
            this.button_Balra.TabIndex = 3;
            this.button_Balra.UseVisualStyleBackColor = false;
            this.button_Balra.Click += new System.EventHandler(this.button_Balra_Click);
            // 
            // button_Jobbra
            // 
            this.button_Jobbra.BackColor = System.Drawing.Color.Transparent;
            this.button_Jobbra.BackgroundImage = global::GepteremProjekt.Properties.Resources.jobb;
            this.button_Jobbra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Jobbra.FlatAppearance.BorderSize = 0;
            this.button_Jobbra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Jobbra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Jobbra.Location = new System.Drawing.Point(248, 173);
            this.button_Jobbra.Name = "button_Jobbra";
            this.button_Jobbra.Size = new System.Drawing.Size(66, 56);
            this.button_Jobbra.TabIndex = 4;
            this.button_Jobbra.UseVisualStyleBackColor = false;
            this.button_Jobbra.Click += new System.EventHandler(this.button_Jobbra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(86, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 266);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 513);
            this.Controls.Add(this.panel_Utcakep);
            this.Controls.Add(this.button_Mentes);
            this.Controls.Add(this.button_Balra);
            this.Controls.Add(this.button_Jobbra);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Balra;
        private System.Windows.Forms.Button button_Jobbra;
        private System.Windows.Forms.Button button_Mentes;
        private System.Windows.Forms.Panel panel_Utcakep;
    }
}

