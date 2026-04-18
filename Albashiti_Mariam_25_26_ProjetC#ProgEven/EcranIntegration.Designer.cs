namespace Albashiti_Mariam_25_26_ProjetC_ProgEven
{
    partial class EcranIntegration
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
            bPointeurTrigonometrique = new Button();
            bPointeurPolynome = new Button();
            bPointeurPoly = new Button();
            bPolynome = new Button();
            lbResultats = new ListBox();
            tbNbInt = new TextBox();
            tbDroite = new TextBox();
            tbGauche = new TextBox();
            lNbInt = new Label();
            lDroite = new Label();
            lGauche = new Label();
            SuspendLayout();
            // 
            // bPointeurTrigonometrique
            // 
            bPointeurTrigonometrique.Location = new Point(307, 404);
            bPointeurTrigonometrique.Name = "bPointeurTrigonometrique";
            bPointeurTrigonometrique.Size = new Size(121, 30);
            bPointeurTrigonometrique.TabIndex = 21;
            bPointeurTrigonometrique.Text = "Idem pointeur";
            bPointeurTrigonometrique.UseVisualStyleBackColor = true;
            bPointeurTrigonometrique.Click += bPointeurTrigonometrique_Click;
            // 
            // bPointeurPolynome
            // 
            bPointeurPolynome.Location = new Point(83, 404);
            bPointeurPolynome.Name = "bPointeurPolynome";
            bPointeurPolynome.Size = new Size(202, 30);
            bPointeurPolynome.TabIndex = 20;
            bPointeurPolynome.Text = "Trigonometrique:sin(x)";
            bPointeurPolynome.UseVisualStyleBackColor = true;
            bPointeurPolynome.Click += bPointeurPolynome_Click;
            // 
            // bPointeurPoly
            // 
            bPointeurPoly.Location = new Point(307, 337);
            bPointeurPoly.Name = "bPointeurPoly";
            bPointeurPoly.Size = new Size(121, 30);
            bPointeurPoly.TabIndex = 19;
            bPointeurPoly.Text = "Idem pointer";
            bPointeurPoly.UseVisualStyleBackColor = true;
            bPointeurPoly.Click += bPointeurPoly_Click;
            // 
            // bPolynome
            // 
            bPolynome.Location = new Point(83, 337);
            bPolynome.Name = "bPolynome";
            bPolynome.Size = new Size(202, 30);
            bPolynome.TabIndex = 18;
            bPolynome.Text = "Polynome : x*x + 2 ";
            bPolynome.UseVisualStyleBackColor = true;
            bPolynome.Click += bPolynome_Click;
            // 
            // lbResultats
            // 
            lbResultats.FormattingEnabled = true;
            lbResultats.Location = new Point(83, 124);
            lbResultats.Name = "lbResultats";
            lbResultats.Size = new Size(345, 164);
            lbResultats.TabIndex = 17;
            // 
            // tbNbInt
            // 
            tbNbInt.Location = new Point(328, 46);
            tbNbInt.Name = "tbNbInt";
            tbNbInt.Size = new Size(100, 27);
            tbNbInt.TabIndex = 16;
            // 
            // tbDroite
            // 
            tbDroite.Location = new Point(200, 46);
            tbDroite.Name = "tbDroite";
            tbDroite.Size = new Size(85, 27);
            tbDroite.TabIndex = 15;
            // 
            // tbGauche
            // 
            tbGauche.Location = new Point(83, 46);
            tbGauche.Name = "tbGauche";
            tbGauche.Size = new Size(85, 27);
            tbGauche.TabIndex = 14;
            // 
            // lNbInt
            // 
            lNbInt.AutoSize = true;
            lNbInt.Location = new Point(328, 9);
            lNbInt.Name = "lNbInt";
            lNbInt.Size = new Size(100, 20);
            lNbInt.TabIndex = 13;
            lNbInt.Text = "NB Intervalles";
            // 
            // lDroite
            // 
            lDroite.AutoSize = true;
            lDroite.Location = new Point(200, 9);
            lDroite.Name = "lDroite";
            lDroite.Size = new Size(51, 20);
            lDroite.TabIndex = 12;
            lDroite.Text = "Droite";
            // 
            // lGauche
            // 
            lGauche.AutoSize = true;
            lGauche.Location = new Point(83, 9);
            lGauche.Name = "lGauche";
            lGauche.Size = new Size(58, 20);
            lGauche.TabIndex = 11;
            lGauche.Text = "Gauche";
            // 
            // EcranIntegration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 473);
            Controls.Add(bPointeurTrigonometrique);
            Controls.Add(bPointeurPolynome);
            Controls.Add(bPointeurPoly);
            Controls.Add(bPolynome);
            Controls.Add(lbResultats);
            Controls.Add(tbNbInt);
            Controls.Add(tbDroite);
            Controls.Add(tbGauche);
            Controls.Add(lNbInt);
            Controls.Add(lDroite);
            Controls.Add(lGauche);
            Name = "EcranIntegration";
            Text = "EcranIntegration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bPointeurTrigonometrique;
        private Button bPointeurPolynome;
        private Button bPointeurPoly;
        private Button bPolynome;
        private ListBox lbResultats;
        private TextBox tbNbInt;
        private TextBox tbDroite;
        private TextBox tbGauche;
        private Label lNbInt;
        private Label lDroite;
        private Label lGauche;
    }
}