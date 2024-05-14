namespace PingPong
{
    partial class MAJoueur
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Premier = new System.Windows.Forms.Button();
            this.Precedente = new System.Windows.Forms.Button();
            this.Suivant = new System.Windows.Forms.Button();
            this.Dernier = new System.Windows.Forms.Button();
            this.Fermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "NumJoueur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "NomJ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "NumEquipe :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(155, 237);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(155, 337);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 20);
            this.textBox4.TabIndex = 7;
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(449, 42);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 40);
            this.Ajouter.TabIndex = 8;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Enregistrer
            // 
            this.Enregistrer.Location = new System.Drawing.Point(449, 130);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(75, 40);
            this.Enregistrer.TabIndex = 9;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = true;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(449, 226);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 40);
            this.Modifier.TabIndex = 10;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(449, 326);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(75, 40);
            this.Supprimer.TabIndex = 11;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Premier
            // 
            this.Premier.Location = new System.Drawing.Point(18, 394);
            this.Premier.Name = "Premier";
            this.Premier.Size = new System.Drawing.Size(75, 23);
            this.Premier.TabIndex = 12;
            this.Premier.Text = "<<";
            this.Premier.UseVisualStyleBackColor = true;
            this.Premier.Click += new System.EventHandler(this.Premier_Click);
            // 
            // Precedente
            // 
            this.Precedente.Location = new System.Drawing.Point(170, 394);
            this.Precedente.Name = "Precedente";
            this.Precedente.Size = new System.Drawing.Size(75, 23);
            this.Precedente.TabIndex = 13;
            this.Precedente.Text = "<";
            this.Precedente.UseVisualStyleBackColor = true;
            this.Precedente.Click += new System.EventHandler(this.Precedente_Click);
            // 
            // Suivant
            // 
            this.Suivant.Location = new System.Drawing.Point(313, 394);
            this.Suivant.Name = "Suivant";
            this.Suivant.Size = new System.Drawing.Size(75, 23);
            this.Suivant.TabIndex = 14;
            this.Suivant.Text = ">";
            this.Suivant.UseVisualStyleBackColor = true;
            this.Suivant.Click += new System.EventHandler(this.Suivant_Click);
            // 
            // Dernier
            // 
            this.Dernier.Location = new System.Drawing.Point(449, 394);
            this.Dernier.Name = "Dernier";
            this.Dernier.Size = new System.Drawing.Size(75, 23);
            this.Dernier.TabIndex = 15;
            this.Dernier.Text = ">>";
            this.Dernier.UseVisualStyleBackColor = true;
            this.Dernier.Click += new System.EventHandler(this.Dernier_Click);
            // 
            // Fermer
            // 
            this.Fermer.Location = new System.Drawing.Point(114, 433);
            this.Fermer.Name = "Fermer";
            this.Fermer.Size = new System.Drawing.Size(299, 23);
            this.Fermer.TabIndex = 16;
            this.Fermer.Text = "Fermer";
            this.Fermer.UseVisualStyleBackColor = true;
            this.Fermer.Click += new System.EventHandler(this.Fermer_Click);
            // 
            // MAJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 468);
            this.Controls.Add(this.Fermer);
            this.Controls.Add(this.Dernier);
            this.Controls.Add(this.Suivant);
            this.Controls.Add(this.Precedente);
            this.Controls.Add(this.Premier);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MAJoueur";
            this.Text = "MAJoueur";
            this.Load += new System.EventHandler(this.MAJoueur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Premier;
        private System.Windows.Forms.Button Precedente;
        private System.Windows.Forms.Button Suivant;
        private System.Windows.Forms.Button Dernier;
        private System.Windows.Forms.Button Fermer;
    }
}