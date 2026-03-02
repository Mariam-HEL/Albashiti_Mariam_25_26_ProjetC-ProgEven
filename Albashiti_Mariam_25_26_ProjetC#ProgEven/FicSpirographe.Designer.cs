namespace Albashiti_Mariam_25_26_ProjetC_ProgEven
{
    partial class FicSpirographe
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
            gbParametrag = new GroupBox();
            tbProfondeur = new TrackBar();
            tbDensite = new TrackBar();
            tbSommets = new TrackBar();
            bFond = new Button();
            bTrait = new Button();
            bGo = new Button();
            lProfondeur = new Label();
            IDensite = new Label();
            lSommets = new Label();
            cdCouleur = new ColorDialog();
            gbParametrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbProfondeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDensite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSommets).BeginInit();
            SuspendLayout();
            // 
            // gbParametrag
            // 
            gbParametrag.Controls.Add(tbProfondeur);
            gbParametrag.Controls.Add(tbDensite);
            gbParametrag.Controls.Add(tbSommets);
            gbParametrag.Controls.Add(bFond);
            gbParametrag.Controls.Add(bTrait);
            gbParametrag.Controls.Add(bGo);
            gbParametrag.Controls.Add(lProfondeur);
            gbParametrag.Controls.Add(IDensite);
            gbParametrag.Controls.Add(lSommets);
            gbParametrag.Location = new Point(23, 12);
            gbParametrag.Name = "gbParametrag";
            gbParametrag.Size = new Size(293, 431);
            gbParametrag.TabIndex = 0;
            gbParametrag.TabStop = false;
            gbParametrag.Text = "Parametrage";
            // 
            // tbProfondeur
            // 
            tbProfondeur.Location = new Point(6, 244);
            tbProfondeur.Name = "tbProfondeur";
            tbProfondeur.Size = new Size(262, 56);
            tbProfondeur.TabIndex = 7;
            // 
            // tbDensite
            // 
            tbDensite.Location = new Point(6, 137);
            tbDensite.Name = "tbDensite";
            tbDensite.Size = new Size(262, 56);
            tbDensite.TabIndex = 6;
            // 
            // tbSommets
            // 
            tbSommets.Location = new Point(6, 46);
            tbSommets.Name = "tbSommets";
            tbSommets.Size = new Size(262, 56);
            tbSommets.TabIndex = 1;
            // 
            // bFond
            // 
            bFond.Location = new Point(183, 382);
            bFond.Name = "bFond";
            bFond.Size = new Size(94, 29);
            bFond.TabIndex = 5;
            bFond.Text = "Fond";
            bFond.UseVisualStyleBackColor = true;
            bFond.Click += bFond_Click;
            // 
            // bTrait
            // 
            bTrait.Location = new Point(6, 382);
            bTrait.Name = "bTrait";
            bTrait.Size = new Size(94, 29);
            bTrait.TabIndex = 4;
            bTrait.Text = "Trait";
            bTrait.UseVisualStyleBackColor = true;
            bTrait.Click += bTrait_Click;
            // 
            // bGo
            // 
            bGo.Location = new Point(39, 329);
            bGo.Name = "bGo";
            bGo.Size = new Size(202, 29);
            bGo.TabIndex = 1;
            bGo.Text = "GO ! ";
            bGo.UseVisualStyleBackColor = true;
            bGo.Click += bGo_Click;
            // 
            // lProfondeur
            // 
            lProfondeur.AutoSize = true;
            lProfondeur.Location = new Point(6, 206);
            lProfondeur.Name = "lProfondeur";
            lProfondeur.Size = new Size(215, 20);
            lProfondeur.TabIndex = 3;
            lProfondeur.Text = "Profondeur de dessin ( 20 à 80)";
            // 
            // IDensite
            // 
            IDensite.AutoSize = true;
            IDensite.Location = new Point(6, 105);
            IDensite.Name = "IDensite";
            IDensite.Size = new Size(185, 20);
            IDensite.TabIndex = 2;
            IDensite.Text = "Densité de dessins (5 à 20)\r\n";
            // 
            // lSommets
            // 
            lSommets.AutoSize = true;
            lSommets.Location = new Point(6, 23);
            lSommets.Name = "lSommets";
            lSommets.Size = new Size(197, 20);
            lSommets.TabIndex = 1;
            lSommets.Text = "Nombre de Sommets (3 à 8)";
            // 
            // FicSpirographe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbParametrag);
            Name = "FicSpirographe";
            Text = "Spirographe";
            Paint += FicSpirographe_Paint;
            gbParametrag.ResumeLayout(false);
            gbParametrag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbProfondeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDensite).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSommets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbParametrag;
        private Label lProfondeur;
        private Label IDensite;
        private Label lSommets;
        private Button bFond;
        private Button bTrait;
        private Button bGo;
        private TrackBar tbProfondeur;
        private TrackBar tbDensite;
        private TrackBar tbSommets;
        private ColorDialog cdCouleur;
    }
}