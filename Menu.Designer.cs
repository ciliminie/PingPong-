namespace PingPong
{
    partial class Tournoi
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
            this.MAJ = new System.Windows.Forms.Button();
            this.FormerEq = new System.Windows.Forms.Button();
            this.JeuS = new System.Windows.Forms.Button();
            this.JeuD = new System.Windows.Forms.Button();
            this.Quitter = new System.Windows.Forms.Button();
            this.PaysT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MAJ
            // 
            this.MAJ.Location = new System.Drawing.Point(57, 76);
            this.MAJ.Name = "MAJ";
            this.MAJ.Size = new System.Drawing.Size(117, 64);
            this.MAJ.TabIndex = 0;
            this.MAJ.Text = "Mise a Jour";
            this.MAJ.UseVisualStyleBackColor = true;
            this.MAJ.Click += new System.EventHandler(this.MAJ_Click);
            // 
            // FormerEq
            // 
            this.FormerEq.Location = new System.Drawing.Point(57, 188);
            this.FormerEq.Name = "FormerEq";
            this.FormerEq.Size = new System.Drawing.Size(117, 64);
            this.FormerEq.TabIndex = 1;
            this.FormerEq.Text = "Former des equipes";
            this.FormerEq.UseVisualStyleBackColor = true;
            this.FormerEq.Click += new System.EventHandler(this.FormerEq_Click);
            // 
            // JeuS
            // 
            this.JeuS.Location = new System.Drawing.Point(57, 294);
            this.JeuS.Name = "JeuS";
            this.JeuS.Size = new System.Drawing.Size(117, 64);
            this.JeuS.TabIndex = 2;
            this.JeuS.Text = "Jeu Simple";
            this.JeuS.UseVisualStyleBackColor = true;
            this.JeuS.Click += new System.EventHandler(this.JeuS_Click);
            // 
            // JeuD
            // 
            this.JeuD.Location = new System.Drawing.Point(402, 76);
            this.JeuD.Name = "JeuD";
            this.JeuD.Size = new System.Drawing.Size(117, 64);
            this.JeuD.TabIndex = 3;
            this.JeuD.Text = "Jeu Double";
            this.JeuD.UseVisualStyleBackColor = true;
            this.JeuD.Click += new System.EventHandler(this.JeuD_Click);
            // 
            // Quitter
            // 
            this.Quitter.Location = new System.Drawing.Point(402, 294);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(117, 64);
            this.Quitter.TabIndex = 4;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.button5_Click);
            // 
            // PaysT
            // 
            this.PaysT.Location = new System.Drawing.Point(402, 188);
            this.PaysT.Name = "PaysT";
            this.PaysT.Size = new System.Drawing.Size(117, 64);
            this.PaysT.TabIndex = 5;
            this.PaysT.Text = "Pays";
            this.PaysT.UseVisualStyleBackColor = true;
            this.PaysT.Click += new System.EventHandler(this.PaysT_Click);
            // 
            // Tournoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 388);
            this.Controls.Add(this.PaysT);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.JeuD);
            this.Controls.Add(this.JeuS);
            this.Controls.Add(this.FormerEq);
            this.Controls.Add(this.MAJ);
            this.Name = "Tournoi";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MAJ;
        private System.Windows.Forms.Button FormerEq;
        private System.Windows.Forms.Button JeuS;
        private System.Windows.Forms.Button JeuD;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Button PaysT;
    }
}

