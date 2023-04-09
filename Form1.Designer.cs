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
            this.pnlJ1 = new System.Windows.Forms.Panel();
            this.rdoJ1R = new System.Windows.Forms.RadioButton();
            this.rdoJ1J = new System.Windows.Forms.RadioButton();
            this.pnlJ2 = new System.Windows.Forms.Panel();
            this.rdoJ2J = new System.Windows.Forms.RadioButton();
            this.rdoJ2R = new System.Windows.Forms.RadioButton();
            this.lblJ2 = new System.Windows.Forms.Label();
            this.lblJ1 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.grptaille = new System.Windows.Forms.GroupBox();
            this.lblLigne = new System.Windows.Forms.Label();
            this.lblColonnes = new System.Windows.Forms.Label();
            this.nudCollones = new System.Windows.Forms.NumericUpDown();
            this.nudLigne = new System.Windows.Forms.NumericUpDown();
            this.grpJoueur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageJ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageIA)).BeginInit();
            this.grpCouleur.SuspendLayout();
            this.pnlJ1.SuspendLayout();
            this.pnlJ2.SuspendLayout();
            this.grptaille.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLigne)).BeginInit();
            this.SuspendLayout();
            // 
            // grpJoueur
            // 
            this.grpJoueur.Controls.Add(this.rdoJ2);
            this.grpJoueur.Controls.Add(this.lblJoueur);
            this.grpJoueur.Controls.Add(this.rdoIA);
            this.grpJoueur.Location = new System.Drawing.Point(71, 148);
            this.grpJoueur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpJoueur.Name = "grpJoueur";
            this.grpJoueur.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpJoueur.Size = new System.Drawing.Size(606, 115);
            this.grpJoueur.TabIndex = 0;
            this.grpJoueur.TabStop = false;
            this.grpJoueur.Text = "Choix des joueurs";
            this.grpJoueur.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdoJ2
            // 
            this.rdoJ2.AutoSize = true;
            this.rdoJ2.Location = new System.Drawing.Point(407, 52);
            this.rdoJ2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoJ2.Name = "rdoJ2";
            this.rdoJ2.Size = new System.Drawing.Size(150, 22);
            this.rdoJ2.TabIndex = 1;
            this.rdoJ2.Text = "joueur 1 VS joueur 2";
            this.rdoJ2.UseVisualStyleBackColor = true;
            this.rdoJ2.CheckedChanged += new System.EventHandler(this.rdoJ2_CheckedChanged);
            // 
            // lblJoueur
            // 
            this.lblJoueur.AutoSize = true;
            this.lblJoueur.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJoueur.Location = new System.Drawing.Point(7, 52);
            this.lblJoueur.Name = "lblJoueur";
            this.lblJoueur.Size = new System.Drawing.Size(153, 28);
            this.lblJoueur.TabIndex = 2;
            this.lblJoueur.Text = "Mode de jeux :\r\n";
            this.lblJoueur.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdoIA
            // 
            this.rdoIA.AutoSize = true;
            this.rdoIA.Checked = true;
            this.rdoIA.Location = new System.Drawing.Point(253, 52);
            this.rdoIA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoIA.Name = "rdoIA";
            this.rdoIA.Size = new System.Drawing.Size(112, 22);
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
            this.imageJ2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imageJ2.Name = "imageJ2";
            this.imageJ2.Size = new System.Drawing.Size(758, 671);
            this.imageJ2.TabIndex = 4;
            this.imageJ2.TabStop = false;
            this.imageJ2.Visible = false;
            // 
            // imageIA
            // 
            this.imageIA.Image = global::puissance_4.Properties.Resources.IA;
            this.imageIA.Location = new System.Drawing.Point(0, 0);
            this.imageIA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imageIA.Name = "imageIA";
            this.imageIA.Size = new System.Drawing.Size(755, 680);
            this.imageIA.TabIndex = 3;
            this.imageIA.TabStop = false;
            this.imageIA.Click += new System.EventHandler(this.imageIA_Click);
            // 
            // grpCouleur
            // 
            this.grpCouleur.Controls.Add(this.pnlJ1);
            this.grpCouleur.Controls.Add(this.pnlJ2);
            this.grpCouleur.Controls.Add(this.lblJ2);
            this.grpCouleur.Controls.Add(this.lblJ1);
            this.grpCouleur.Location = new System.Drawing.Point(71, 270);
            this.grpCouleur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpCouleur.Name = "grpCouleur";
            this.grpCouleur.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpCouleur.Size = new System.Drawing.Size(606, 132);
            this.grpCouleur.TabIndex = 5;
            this.grpCouleur.TabStop = false;
            this.grpCouleur.Text = "Choix des couleurs";
            // 
            // pnlJ1
            // 
            this.pnlJ1.BackColor = System.Drawing.SystemColors.Control;
            this.pnlJ1.Controls.Add(this.rdoJ1R);
            this.pnlJ1.Controls.Add(this.rdoJ1J);
            this.pnlJ1.Location = new System.Drawing.Point(202, 34);
            this.pnlJ1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlJ1.Name = "pnlJ1";
            this.pnlJ1.Size = new System.Drawing.Size(366, 32);
            this.pnlJ1.TabIndex = 7;
            // 
            // rdoJ1R
            // 
            this.rdoJ1R.AutoSize = true;
            this.rdoJ1R.Location = new System.Drawing.Point(205, 4);
            this.rdoJ1R.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoJ1R.Name = "rdoJ1R";
            this.rdoJ1R.Size = new System.Drawing.Size(61, 22);
            this.rdoJ1R.TabIndex = 3;
            this.rdoJ1R.Text = "rouge";
            this.rdoJ1R.UseVisualStyleBackColor = true;
            this.rdoJ1R.CheckedChanged += new System.EventHandler(this.rdoJ1R_CheckedChanged);
            // 
            // rdoJ1J
            // 
            this.rdoJ1J.AutoSize = true;
            this.rdoJ1J.Checked = true;
            this.rdoJ1J.Location = new System.Drawing.Point(51, 4);
            this.rdoJ1J.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoJ1J.Name = "rdoJ1J";
            this.rdoJ1J.Size = new System.Drawing.Size(60, 22);
            this.rdoJ1J.TabIndex = 2;
            this.rdoJ1J.TabStop = true;
            this.rdoJ1J.Text = "jaune";
            this.rdoJ1J.UseVisualStyleBackColor = true;
            this.rdoJ1J.CheckedChanged += new System.EventHandler(this.rdoJ1J_CheckedChanged);
            // 
            // pnlJ2
            // 
            this.pnlJ2.Controls.Add(this.rdoJ2J);
            this.pnlJ2.Controls.Add(this.rdoJ2R);
            this.pnlJ2.Location = new System.Drawing.Point(202, 84);
            this.pnlJ2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlJ2.Name = "pnlJ2";
            this.pnlJ2.Size = new System.Drawing.Size(366, 34);
            this.pnlJ2.TabIndex = 6;
            // 
            // rdoJ2J
            // 
            this.rdoJ2J.AutoSize = true;
            this.rdoJ2J.Location = new System.Drawing.Point(51, 4);
            this.rdoJ2J.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoJ2J.Name = "rdoJ2J";
            this.rdoJ2J.Size = new System.Drawing.Size(60, 22);
            this.rdoJ2J.TabIndex = 5;
            this.rdoJ2J.Text = "jaune";
            this.rdoJ2J.UseVisualStyleBackColor = true;
            this.rdoJ2J.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rdoJ2R
            // 
            this.rdoJ2R.AutoSize = true;
            this.rdoJ2R.Checked = true;
            this.rdoJ2R.Location = new System.Drawing.Point(205, 4);
            this.rdoJ2R.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoJ2R.Name = "rdoJ2R";
            this.rdoJ2R.Size = new System.Drawing.Size(61, 22);
            this.rdoJ2R.TabIndex = 4;
            this.rdoJ2R.TabStop = true;
            this.rdoJ2R.Text = "rouge";
            this.rdoJ2R.UseVisualStyleBackColor = true;
            this.rdoJ2R.CheckedChanged += new System.EventHandler(this.rdoJ2R_CheckedChanged);
            // 
            // lblJ2
            // 
            this.lblJ2.AutoSize = true;
            this.lblJ2.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJ2.Location = new System.Drawing.Point(7, 88);
            this.lblJ2.Name = "lblJ2";
            this.lblJ2.Size = new System.Drawing.Size(100, 28);
            this.lblJ2.TabIndex = 1;
            this.lblJ2.Text = "Joueur2 :";
            this.lblJ2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblJ1
            // 
            this.lblJ1.AutoSize = true;
            this.lblJ1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJ1.Location = new System.Drawing.Point(7, 38);
            this.lblJ1.Name = "lblJ1";
            this.lblJ1.Size = new System.Drawing.Size(98, 28);
            this.lblJ1.TabIndex = 0;
            this.lblJ1.Text = "Joueur1 :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(150, 568);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(435, 83);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "validez";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.button1_Click);
            // 
            // grptaille
            // 
            this.grptaille.Controls.Add(this.lblLigne);
            this.grptaille.Controls.Add(this.lblColonnes);
            this.grptaille.Controls.Add(this.nudCollones);
            this.grptaille.Controls.Add(this.nudLigne);
            this.grptaille.Location = new System.Drawing.Point(71, 409);
            this.grptaille.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grptaille.Name = "grptaille";
            this.grptaille.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grptaille.Size = new System.Drawing.Size(606, 103);
            this.grptaille.TabIndex = 7;
            this.grptaille.TabStop = false;
            this.grptaille.Text = "Taille du plateau";
            this.grptaille.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // lblLigne
            // 
            this.lblLigne.AutoSize = true;
            this.lblLigne.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLigne.Location = new System.Drawing.Point(7, 29);
            this.lblLigne.Name = "lblLigne";
            this.lblLigne.Size = new System.Drawing.Size(195, 28);
            this.lblLigne.TabIndex = 4;
            this.lblLigne.Text = "Nombres de ligne :";
            // 
            // lblColonnes
            // 
            this.lblColonnes.AutoSize = true;
            this.lblColonnes.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblColonnes.Location = new System.Drawing.Point(7, 68);
            this.lblColonnes.Name = "lblColonnes";
            this.lblColonnes.Size = new System.Drawing.Size(226, 28);
            this.lblColonnes.TabIndex = 3;
            this.lblColonnes.Text = "Nombres de collones :";
            // 
            // nudCollones
            // 
            this.nudCollones.Location = new System.Drawing.Point(407, 68);
            this.nudCollones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudCollones.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCollones.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudCollones.Name = "nudCollones";
            this.nudCollones.Size = new System.Drawing.Size(137, 22);
            this.nudCollones.TabIndex = 1;
            this.nudCollones.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // nudLigne
            // 
            this.nudLigne.Location = new System.Drawing.Point(407, 26);
            this.nudLigne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudLigne.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLigne.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudLigne.Name = "nudLigne";
            this.nudLigne.Size = new System.Drawing.Size(137, 22);
            this.nudLigne.TabIndex = 0;
            this.nudLigne.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 679);
            this.Controls.Add(this.grptaille);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.grpCouleur);
            this.Controls.Add(this.grpJoueur);
            this.Controls.Add(this.imageIA);
            this.Controls.Add(this.imageJ2);
            this.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grpJoueur.ResumeLayout(false);
            this.grpJoueur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageJ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageIA)).EndInit();
            this.grpCouleur.ResumeLayout(false);
            this.grpCouleur.PerformLayout();
            this.pnlJ1.ResumeLayout(false);
            this.pnlJ1.PerformLayout();
            this.pnlJ2.ResumeLayout(false);
            this.pnlJ2.PerformLayout();
            this.grptaille.ResumeLayout(false);
            this.grptaille.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLigne)).EndInit();
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
        private Button btnValider;
        private GroupBox grptaille;
        private Label lblColonnes;
        private NumericUpDown nudCollones;
        private NumericUpDown nudLigne;
        private Label lblLigne;
    }
}