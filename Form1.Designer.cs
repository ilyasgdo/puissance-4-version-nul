namespace puissance_4
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
            this.grpJoueur = new System.Windows.Forms.GroupBox();
            this.rdoJ2 = new System.Windows.Forms.RadioButton();
            this.lblJoueur = new System.Windows.Forms.Label();
            this.rdoIA = new System.Windows.Forms.RadioButton();
            this.imageJ2 = new System.Windows.Forms.PictureBox();
            this.imageIA = new System.Windows.Forms.PictureBox();
            this.grpCouleur = new System.Windows.Forms.GroupBox();
            this.lblJ1 = new System.Windows.Forms.Label();
            this.lblJ2 = new System.Windows.Forms.Label();
            this.rdoJ1J = new System.Windows.Forms.RadioButton();
            this.rdoJ1R = new System.Windows.Forms.RadioButton();
            this.rdoJ2R = new System.Windows.Forms.RadioButton();
            this.rdoJ2J = new System.Windows.Forms.RadioButton();
            this.pnlJ2 = new System.Windows.Forms.Panel();
            this.pnlJ1 = new System.Windows.Forms.Panel();
            this.grpJoueur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageJ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageIA)).BeginInit();
            this.grpCouleur.SuspendLayout();
            this.pnlJ2.SuspendLayout();
            this.pnlJ1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpJoueur
            // 
            this.grpJoueur.Controls.Add(this.rdoJ2);
            this.grpJoueur.Controls.Add(this.lblJoueur);
            this.grpJoueur.Controls.Add(this.rdoIA);
            this.grpJoueur.Location = new System.Drawing.Point(62, 123);
            this.grpJoueur.Name = "grpJoueur";
            this.grpJoueur.Size = new System.Drawing.Size(530, 96);
            this.grpJoueur.TabIndex = 0;
            this.grpJoueur.TabStop = false;
            this.grpJoueur.Text = "Choix des joueurs";
            this.grpJoueur.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdoJ2
            // 
            this.rdoJ2.AutoSize = true;
            this.rdoJ2.Location = new System.Drawing.Point(320, 43);
            this.rdoJ2.Name = "rdoJ2";
            this.rdoJ2.Size = new System.Drawing.Size(130, 19);
            this.rdoJ2.TabIndex = 1;
            this.rdoJ2.Text = "joueur 1 VS joueur 2";
            this.rdoJ2.UseVisualStyleBackColor = true;
            this.rdoJ2.CheckedChanged += new System.EventHandler(this.rdoJ2_CheckedChanged);
            // 
            // lblJoueur
            // 
            this.lblJoueur.AutoSize = true;
            this.lblJoueur.Location = new System.Drawing.Point(6, 43);
            this.lblJoueur.Name = "lblJoueur";
            this.lblJoueur.Size = new System.Drawing.Size(130, 15);
            this.lblJoueur.TabIndex = 2;
            this.lblJoueur.Text = "Choix du mode de jeux";
            this.lblJoueur.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdoIA
            // 
            this.rdoIA.AutoSize = true;
            this.rdoIA.Checked = true;
            this.rdoIA.Location = new System.Drawing.Point(177, 39);
            this.rdoIA.Name = "rdoIA";
            this.rdoIA.Size = new System.Drawing.Size(98, 19);
            this.rdoIA.TabIndex = 0;
            this.rdoIA.TabStop = true;
            this.rdoIA.Text = "joueur 1 VS IA";
            this.rdoIA.UseVisualStyleBackColor = true;
            this.rdoIA.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // imageJ2
            // 
            this.imageJ2.Image = global::puissance_4.Properties.Resources._2J;
            this.imageJ2.Location = new System.Drawing.Point(-2, 0);
            this.imageJ2.Name = "imageJ2";
            this.imageJ2.Size = new System.Drawing.Size(663, 559);
            this.imageJ2.TabIndex = 4;
            this.imageJ2.TabStop = false;
            this.imageJ2.Visible = false;
            // 
            // imageIA
            // 
            this.imageIA.Image = global::puissance_4.Properties.Resources.IA;
            this.imageIA.Location = new System.Drawing.Point(0, 0);
            this.imageIA.Name = "imageIA";
            this.imageIA.Size = new System.Drawing.Size(661, 567);
            this.imageIA.TabIndex = 3;
            this.imageIA.TabStop = false;
            // 
            // grpCouleur
            // 
            this.grpCouleur.Controls.Add(this.pnlJ1);
            this.grpCouleur.Controls.Add(this.pnlJ2);
            this.grpCouleur.Controls.Add(this.lblJ2);
            this.grpCouleur.Controls.Add(this.lblJ1);
            this.grpCouleur.Location = new System.Drawing.Point(62, 242);
            this.grpCouleur.Name = "grpCouleur";
            this.grpCouleur.Size = new System.Drawing.Size(530, 121);
            this.grpCouleur.TabIndex = 5;
            this.grpCouleur.TabStop = false;
            this.grpCouleur.Text = "Choix des couleurs";
            // 
            // lblJ1
            // 
            this.lblJ1.AutoSize = true;
            this.lblJ1.Location = new System.Drawing.Point(33, 32);
            this.lblJ1.Name = "lblJ1";
            this.lblJ1.Size = new System.Drawing.Size(54, 15);
            this.lblJ1.TabIndex = 0;
            this.lblJ1.Text = "Joueur1 :";
            // 
            // lblJ2
            // 
            this.lblJ2.AutoSize = true;
            this.lblJ2.Location = new System.Drawing.Point(33, 75);
            this.lblJ2.Name = "lblJ2";
            this.lblJ2.Size = new System.Drawing.Size(54, 15);
            this.lblJ2.TabIndex = 1;
            this.lblJ2.Text = "Joueur2 :";
            this.lblJ2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdoJ1J
            // 
            this.rdoJ1J.AutoSize = true;
            this.rdoJ1J.Location = new System.Drawing.Point(16, 4);
            this.rdoJ1J.Name = "rdoJ1J";
            this.rdoJ1J.Size = new System.Drawing.Size(54, 19);
            this.rdoJ1J.TabIndex = 2;
            this.rdoJ1J.TabStop = true;
            this.rdoJ1J.Text = "jaune";
            this.rdoJ1J.UseVisualStyleBackColor = true;
            this.rdoJ1J.CheckedChanged += new System.EventHandler(this.rdoJ1J_CheckedChanged);
            // 
            // rdoJ1R
            // 
            this.rdoJ1R.AutoSize = true;
            this.rdoJ1R.Location = new System.Drawing.Point(179, 5);
            this.rdoJ1R.Name = "rdoJ1R";
            this.rdoJ1R.Size = new System.Drawing.Size(56, 19);
            this.rdoJ1R.TabIndex = 3;
            this.rdoJ1R.TabStop = true;
            this.rdoJ1R.Text = "rouge";
            this.rdoJ1R.UseVisualStyleBackColor = true;
            this.rdoJ1R.CheckedChanged += new System.EventHandler(this.rdoJ1R_CheckedChanged);
            // 
            // rdoJ2R
            // 
            this.rdoJ2R.AutoSize = true;
            this.rdoJ2R.Location = new System.Drawing.Point(179, 3);
            this.rdoJ2R.Name = "rdoJ2R";
            this.rdoJ2R.Size = new System.Drawing.Size(56, 19);
            this.rdoJ2R.TabIndex = 4;
            this.rdoJ2R.TabStop = true;
            this.rdoJ2R.Text = "rouge";
            this.rdoJ2R.UseVisualStyleBackColor = true;
            this.rdoJ2R.CheckedChanged += new System.EventHandler(this.rdoJ2R_CheckedChanged);
            // 
            // rdoJ2J
            // 
            this.rdoJ2J.AutoSize = true;
            this.rdoJ2J.Location = new System.Drawing.Point(16, 3);
            this.rdoJ2J.Name = "rdoJ2J";
            this.rdoJ2J.Size = new System.Drawing.Size(54, 19);
            this.rdoJ2J.TabIndex = 5;
            this.rdoJ2J.TabStop = true;
            this.rdoJ2J.Text = "jaune";
            this.rdoJ2J.UseVisualStyleBackColor = true;
            this.rdoJ2J.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // pnlJ2
            // 
            this.pnlJ2.Controls.Add(this.rdoJ2J);
            this.pnlJ2.Controls.Add(this.rdoJ2R);
            this.pnlJ2.Location = new System.Drawing.Point(177, 70);
            this.pnlJ2.Name = "pnlJ2";
            this.pnlJ2.Size = new System.Drawing.Size(320, 28);
            this.pnlJ2.TabIndex = 6;
            // 
            // pnlJ1
            // 
            this.pnlJ1.BackColor = System.Drawing.SystemColors.Control;
            this.pnlJ1.Controls.Add(this.rdoJ1R);
            this.pnlJ1.Controls.Add(this.rdoJ1J);
            this.pnlJ1.Location = new System.Drawing.Point(177, 28);
            this.pnlJ1.Name = "pnlJ1";
            this.pnlJ1.Size = new System.Drawing.Size(320, 27);
            this.pnlJ1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 566);
            this.Controls.Add(this.grpCouleur);
            this.Controls.Add(this.grpJoueur);
            this.Controls.Add(this.imageIA);
            this.Controls.Add(this.imageJ2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpJoueur.ResumeLayout(false);
            this.grpJoueur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageJ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageIA)).EndInit();
            this.grpCouleur.ResumeLayout(false);
            this.grpCouleur.PerformLayout();
            this.pnlJ2.ResumeLayout(false);
            this.pnlJ2.PerformLayout();
            this.pnlJ1.ResumeLayout(false);
            this.pnlJ1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpJoueur;
        private RadioButton rdoIA;
        private RadioButton rdoJ2;
        private Label lblJoueur;
        private PictureBox imageJ2;
        private PictureBox imageIA;
        private GroupBox grpCouleur;
        private Label lblJ2;
        private Label lblJ1;
        private Panel pnlJ1;
        private RadioButton rdoJ1R;
        private RadioButton rdoJ1J;
        private Panel pnlJ2;
        private RadioButton rdoJ2J;
        private RadioButton rdoJ2R;
    }
}