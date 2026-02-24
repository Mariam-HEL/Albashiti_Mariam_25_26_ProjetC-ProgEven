namespace Albashiti_Mariam_25_26_ProjetC_ProgEven
{
    partial class EcranEditeur
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
            pMenu = new Panel();
            pbQuitter = new PictureBox();
            pbNouveau = new PictureBox();
            pbEnregistrer = new PictureBox();
            pbOuvrir = new PictureBox();
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            nouveauToolStripMenuItem = new ToolStripMenuItem();
            ouvrirToolStripMenuItem = new ToolStripMenuItem();
            enregistrerToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            edToolStripMenuItem = new ToolStripMenuItem();
            copierToolStripMenuItem = new ToolStripMenuItem();
            couperToolStripMenuItem = new ToolStripMenuItem();
            collerToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            justifierToolStripMenuItem = new ToolStripMenuItem();
            gaucheToolStripMenuItem = new ToolStripMenuItem();
            centreToolStripMenuItem = new ToolStripMenuItem();
            droiteToolStripMenuItem = new ToolStripMenuItem();
            policeToolStripMenuItem = new ToolStripMenuItem();
            caractèreToolStripMenuItem = new ToolStripMenuItem();
            grasToolStripMenuItem = new ToolStripMenuItem();
            italiqueToolStripMenuItem = new ToolStripMenuItem();
            soulignéToolStripMenuItem = new ToolStripMenuItem();
            barréToolStripMenuItem = new ToolStripMenuItem();
            rtbTexte = new RichTextBox();
            ofdOuvrir = new OpenFileDialog();
            sfdEnregistrer = new SaveFileDialog();
            fdPolice = new FontDialog();
            pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbQuitter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNouveau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnregistrer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOuvrir).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pMenu
            // 
            pMenu.Controls.Add(pbQuitter);
            pMenu.Controls.Add(pbNouveau);
            pMenu.Controls.Add(pbEnregistrer);
            pMenu.Controls.Add(pbOuvrir);
            pMenu.Location = new Point(-3, 26);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(803, 42);
            pMenu.TabIndex = 0;
            pMenu.Paint += pMenu_Paint;
            // 
            // pbQuitter
            // 
            pbQuitter.Location = new Point(275, 1);
            pbQuitter.Name = "pbQuitter";
            pbQuitter.Size = new Size(63, 38);
            pbQuitter.TabIndex = 3;
            pbQuitter.TabStop = false;
            // 
            // pbNouveau
            // 
            pbNouveau.Location = new Point(15, 3);
            pbNouveau.Name = "pbNouveau";
            pbNouveau.Size = new Size(55, 35);
            pbNouveau.TabIndex = 1;
            pbNouveau.TabStop = false;
            // 
            // pbEnregistrer
            // 
            pbEnregistrer.Location = new Point(184, 1);
            pbEnregistrer.Name = "pbEnregistrer";
            pbEnregistrer.Size = new Size(62, 40);
            pbEnregistrer.TabIndex = 0;
            pbEnregistrer.TabStop = false;
            // 
            // pbOuvrir
            // 
            pbOuvrir.Location = new Point(94, 1);
            pbOuvrir.Name = "pbOuvrir";
            pbOuvrir.Size = new Size(57, 38);
            pbOuvrir.TabIndex = 2;
            pbOuvrir.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, edToolStripMenuItem, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nouveauToolStripMenuItem, ouvrirToolStripMenuItem, enregistrerToolStripMenuItem, quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(66, 24);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            nouveauToolStripMenuItem.Size = new Size(163, 26);
            nouveauToolStripMenuItem.Text = "Nouveau";
            nouveauToolStripMenuItem.Click += nouveauToolStripMenuItem_Click;
            // 
            // ouvrirToolStripMenuItem
            // 
            ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            ouvrirToolStripMenuItem.Size = new Size(163, 26);
            ouvrirToolStripMenuItem.Text = "Ouvrir";
            ouvrirToolStripMenuItem.Click += ouvrirToolStripMenuItem_Click;
            // 
            // enregistrerToolStripMenuItem
            // 
            enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            enregistrerToolStripMenuItem.Size = new Size(163, 26);
            enregistrerToolStripMenuItem.Text = "Enregistrer";
            enregistrerToolStripMenuItem.Click += enregistrerToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(163, 26);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // edToolStripMenuItem
            // 
            edToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copierToolStripMenuItem, couperToolStripMenuItem, collerToolStripMenuItem });
            edToolStripMenuItem.Name = "edToolStripMenuItem";
            edToolStripMenuItem.Size = new Size(70, 24);
            edToolStripMenuItem.Text = "Edition";
            // 
            // copierToolStripMenuItem
            // 
            copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            copierToolStripMenuItem.Size = new Size(140, 26);
            copierToolStripMenuItem.Text = "Copier";
            copierToolStripMenuItem.Click += copierToolStripMenuItem_Click;
            // 
            // couperToolStripMenuItem
            // 
            couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            couperToolStripMenuItem.Size = new Size(140, 26);
            couperToolStripMenuItem.Text = "Couper";
            couperToolStripMenuItem.Click += couperToolStripMenuItem_Click;
            // 
            // collerToolStripMenuItem
            // 
            collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            collerToolStripMenuItem.Size = new Size(140, 26);
            collerToolStripMenuItem.Text = "Coller";
            collerToolStripMenuItem.Click += collerToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { justifierToolStripMenuItem, policeToolStripMenuItem, caractèreToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(70, 24);
            formatToolStripMenuItem.Text = "Format";
            // 
            // justifierToolStripMenuItem
            // 
            justifierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gaucheToolStripMenuItem, centreToolStripMenuItem, droiteToolStripMenuItem });
            justifierToolStripMenuItem.Name = "justifierToolStripMenuItem";
            justifierToolStripMenuItem.Size = new Size(224, 26);
            justifierToolStripMenuItem.Text = "Justifier";
            // 
            // gaucheToolStripMenuItem
            // 
            gaucheToolStripMenuItem.Name = "gaucheToolStripMenuItem";
            gaucheToolStripMenuItem.Size = new Size(224, 26);
            gaucheToolStripMenuItem.Text = "Gauche";
            gaucheToolStripMenuItem.Click += gaucheToolStripMenuItem_Click;
            // 
            // centreToolStripMenuItem
            // 
            centreToolStripMenuItem.Name = "centreToolStripMenuItem";
            centreToolStripMenuItem.Size = new Size(224, 26);
            centreToolStripMenuItem.Text = "Centre";
            centreToolStripMenuItem.Click += centreToolStripMenuItem_Click;
            // 
            // droiteToolStripMenuItem
            // 
            droiteToolStripMenuItem.Name = "droiteToolStripMenuItem";
            droiteToolStripMenuItem.Size = new Size(224, 26);
            droiteToolStripMenuItem.Text = "Droite ";
            droiteToolStripMenuItem.Click += droiteToolStripMenuItem_Click;
            // 
            // policeToolStripMenuItem
            // 
            policeToolStripMenuItem.Name = "policeToolStripMenuItem";
            policeToolStripMenuItem.Size = new Size(224, 26);
            policeToolStripMenuItem.Text = "Police";
            policeToolStripMenuItem.Click += policeToolStripMenuItem_Click;
            // 
            // caractèreToolStripMenuItem
            // 
            caractèreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grasToolStripMenuItem, italiqueToolStripMenuItem, soulignéToolStripMenuItem, barréToolStripMenuItem });
            caractèreToolStripMenuItem.Name = "caractèreToolStripMenuItem";
            caractèreToolStripMenuItem.Size = new Size(224, 26);
            caractèreToolStripMenuItem.Text = "Caractère";
            // 
            // grasToolStripMenuItem
            // 
            grasToolStripMenuItem.Name = "grasToolStripMenuItem";
            grasToolStripMenuItem.Size = new Size(150, 26);
            grasToolStripMenuItem.Text = "Gras";
            grasToolStripMenuItem.Click += grasToolStripMenuItem_Click;
            // 
            // italiqueToolStripMenuItem
            // 
            italiqueToolStripMenuItem.Name = "italiqueToolStripMenuItem";
            italiqueToolStripMenuItem.Size = new Size(150, 26);
            italiqueToolStripMenuItem.Text = "Italique";
            italiqueToolStripMenuItem.Click += italiqueToolStripMenuItem_Click;
            // 
            // soulignéToolStripMenuItem
            // 
            soulignéToolStripMenuItem.Name = "soulignéToolStripMenuItem";
            soulignéToolStripMenuItem.Size = new Size(150, 26);
            soulignéToolStripMenuItem.Text = "Souligné";
            soulignéToolStripMenuItem.Click += soulignéToolStripMenuItem_Click;
            // 
            // barréToolStripMenuItem
            // 
            barréToolStripMenuItem.Name = "barréToolStripMenuItem";
            barréToolStripMenuItem.Size = new Size(150, 26);
            barréToolStripMenuItem.Text = "Barré ";
            barréToolStripMenuItem.Click += barréToolStripMenuItem_Click;
            // 
            // rtbTexte
            // 
            rtbTexte.Location = new Point(12, 74);
            rtbTexte.Name = "rtbTexte";
            rtbTexte.Size = new Size(776, 364);
            rtbTexte.TabIndex = 2;
            rtbTexte.Text = "";
            rtbTexte.TextChanged += rtbTexte_TextChanged;
            // 
            // ofdOuvrir
            // 
            ofdOuvrir.FileName = "openFileDialog1";
            // 
            // EcranEditeur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbTexte);
            Controls.Add(pMenu);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "EcranEditeur";
            Text = "traitement de texte....en toute modestie";
            Load += EcranEditeur_Load;
            pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbQuitter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNouveau).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnregistrer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOuvrir).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pMenu;
        private PictureBox pbQuitter;
        private PictureBox pbNouveau;
        private PictureBox pbEnregistrer;
        private PictureBox pbOuvrir;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem edToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private RichTextBox rtbTexte;
        private OpenFileDialog ofdOuvrir;
        private SaveFileDialog sfdEnregistrer;
        private FontDialog fdPolice;
        private ToolStripMenuItem nouveauToolStripMenuItem;
        private ToolStripMenuItem ouvrirToolStripMenuItem;
        private ToolStripMenuItem enregistrerToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem copierToolStripMenuItem;
        private ToolStripMenuItem couperToolStripMenuItem;
        private ToolStripMenuItem collerToolStripMenuItem;
        private ToolStripMenuItem justifierToolStripMenuItem;
        private ToolStripMenuItem gaucheToolStripMenuItem;
        private ToolStripMenuItem centreToolStripMenuItem;
        private ToolStripMenuItem droiteToolStripMenuItem;
        private ToolStripMenuItem policeToolStripMenuItem;
        private ToolStripMenuItem caractèreToolStripMenuItem;
        private ToolStripMenuItem grasToolStripMenuItem;
        private ToolStripMenuItem italiqueToolStripMenuItem;
        private ToolStripMenuItem soulignéToolStripMenuItem;
        private ToolStripMenuItem barréToolStripMenuItem;
    }
}