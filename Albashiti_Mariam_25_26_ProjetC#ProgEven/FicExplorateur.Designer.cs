namespace Albashiti_Mariam_25_26_ProjetC_ProgEven
{
    partial class EcranExplorateur
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranExplorateur));
            tsCommandes = new ToolStrip();
            tsbQuitter = new ToolStripButton();
            ToolStripSeparator = new ToolStripSeparator();
            tsddbApparence = new ToolStripDropDownButton();
            tsaPetitesIcones = new ToolStripMenuItem();
            tsaGrandesIcones = new ToolStripMenuItem();
            tsaListe = new ToolStripMenuItem();
            tsaDetail = new ToolStripMenuItem();
            ssMessage = new StatusStrip();
            slMessage = new ToolStripStatusLabel();
            scSeparateur = new SplitContainer();
            tvRepertoire = new TreeView();
            lvFichiers = new ListView();
            colNom = new ColumnHeader();
            colTaille = new ColumnHeader();
            colCREA = new ColumnHeader();
            colMODI = new ColumnHeader();
            ilTreeView = new ImageList(components);
            ilGrand = new ImageList(components);
            ilPetit = new ImageList(components);
            tsCommandes.SuspendLayout();
            ssMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scSeparateur).BeginInit();
            scSeparateur.Panel1.SuspendLayout();
            scSeparateur.Panel2.SuspendLayout();
            scSeparateur.SuspendLayout();
            SuspendLayout();
            // 
            // tsCommandes
            // 
            tsCommandes.ImageScalingSize = new Size(20, 20);
            tsCommandes.Items.AddRange(new ToolStripItem[] { tsbQuitter, ToolStripSeparator, tsddbApparence });
            tsCommandes.Location = new Point(0, 0);
            tsCommandes.Name = "tsCommandes";
            tsCommandes.Size = new Size(800, 27);
            tsCommandes.TabIndex = 0;
            tsCommandes.Text = "toolStrip1";
            // 
            // tsbQuitter
            // 
            tsbQuitter.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbQuitter.Image = (Image)resources.GetObject("tsbQuitter.Image");
            tsbQuitter.ImageTransparentColor = Color.Magenta;
            tsbQuitter.Name = "tsbQuitter";
            tsbQuitter.Size = new Size(29, 24);
            tsbQuitter.Text = "toolStripButton1";
            // 
            // ToolStripSeparator
            // 
            ToolStripSeparator.Name = "ToolStripSeparator";
            ToolStripSeparator.Size = new Size(6, 27);
            // 
            // tsddbApparence
            // 
            tsddbApparence.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsddbApparence.DropDownItems.AddRange(new ToolStripItem[] { tsaPetitesIcones, tsaGrandesIcones, tsaListe, tsaDetail });
            tsddbApparence.Image = (Image)resources.GetObject("tsddbApparence.Image");
            tsddbApparence.ImageTransparentColor = Color.Magenta;
            tsddbApparence.Name = "tsddbApparence";
            tsddbApparence.Size = new Size(34, 24);
            tsddbApparence.Text = "toolStripDropDownButton1";
            // 
            // tsaPetitesIcones
            // 
            tsaPetitesIcones.Name = "tsaPetitesIcones";
            tsaPetitesIcones.Size = new Size(192, 26);
            tsaPetitesIcones.Text = "Petites Icones";
            // 
            // tsaGrandesIcones
            // 
            tsaGrandesIcones.Name = "tsaGrandesIcones";
            tsaGrandesIcones.Size = new Size(192, 26);
            tsaGrandesIcones.Text = "Grandes Icones";
            // 
            // tsaListe
            // 
            tsaListe.Name = "tsaListe";
            tsaListe.Size = new Size(192, 26);
            tsaListe.Text = "Liste";
            // 
            // tsaDetail
            // 
            tsaDetail.Name = "tsaDetail";
            tsaDetail.Size = new Size(192, 26);
            tsaDetail.Text = "Detail";
            // 
            // ssMessage
            // 
            ssMessage.ImageScalingSize = new Size(20, 20);
            ssMessage.Items.AddRange(new ToolStripItem[] { slMessage });
            ssMessage.Location = new Point(0, 424);
            ssMessage.Name = "ssMessage";
            ssMessage.Size = new Size(800, 26);
            ssMessage.TabIndex = 1;
            ssMessage.Text = "Bienvenue";
            // 
            // slMessage
            // 
            slMessage.Name = "slMessage";
            slMessage.Size = new Size(77, 20);
            slMessage.Text = "Bienvenue";
            // 
            // scSeparateur
            // 
            scSeparateur.Dock = DockStyle.Fill;
            scSeparateur.Location = new Point(0, 27);
            scSeparateur.Name = "scSeparateur";
            // 
            // scSeparateur.Panel1
            // 
            scSeparateur.Panel1.Controls.Add(tvRepertoire);
            // 
            // scSeparateur.Panel2
            // 
            scSeparateur.Panel2.Controls.Add(lvFichiers);
            scSeparateur.Size = new Size(800, 397);
            scSeparateur.SplitterDistance = 266;
            scSeparateur.TabIndex = 2;
            // 
            // tvRepertoire
            // 
            tvRepertoire.Location = new Point(3, 3);
            tvRepertoire.Name = "tvRepertoire";
            tvRepertoire.Size = new Size(260, 394);
            tvRepertoire.TabIndex = 0;
            tvRepertoire.BeforeExpand += tvRepertoire_BeforeExpand;
            // 
            // lvFichiers
            // 
            lvFichiers.Columns.AddRange(new ColumnHeader[] { colNom, colTaille, colCREA, colMODI });
            lvFichiers.Location = new Point(3, 0);
            lvFichiers.Name = "lvFichiers";
            lvFichiers.Size = new Size(524, 391);
            lvFichiers.TabIndex = 0;
            lvFichiers.UseCompatibleStateImageBehavior = false;
            lvFichiers.View = View.Details;
            lvFichiers.SelectedIndexChanged += lvFichiers_SelectedIndexChanged;
            // 
            // colNom
            // 
            colNom.Text = "Nom";
            colNom.Width = 200;
            // 
            // colTaille
            // 
            colTaille.Text = "Taille";
            colTaille.Width = 100;
            // 
            // colCREA
            // 
            colCREA.Text = "Creation";
            colCREA.Width = 110;
            // 
            // colMODI
            // 
            colMODI.Text = "Modification";
            colMODI.Width = 110;
            // 
            // ilTreeView
            // 
            ilTreeView.ColorDepth = ColorDepth.Depth32Bit;
            ilTreeView.ImageSize = new Size(16, 16);
            ilTreeView.TransparentColor = Color.Transparent;
            // 
            // ilGrand
            // 
            ilGrand.ColorDepth = ColorDepth.Depth32Bit;
            ilGrand.ImageSize = new Size(16, 16);
            ilGrand.TransparentColor = Color.Transparent;
            // 
            // ilPetit
            // 
            ilPetit.ColorDepth = ColorDepth.Depth32Bit;
            ilPetit.ImageSize = new Size(16, 16);
            ilPetit.TransparentColor = Color.Transparent;
            // 
            // EcranExplorateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scSeparateur);
            Controls.Add(ssMessage);
            Controls.Add(tsCommandes);
            Name = "EcranExplorateur";
            Text = "Windows exploateur";
            Load += EcranExplorateur_Load;
            tsCommandes.ResumeLayout(false);
            tsCommandes.PerformLayout();
            ssMessage.ResumeLayout(false);
            ssMessage.PerformLayout();
            scSeparateur.Panel1.ResumeLayout(false);
            scSeparateur.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scSeparateur).EndInit();
            scSeparateur.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsCommandes;
        private ToolStripButton tsbQuitter;
        private ToolStripSeparator ToolStripSeparator;
        private ToolStripDropDownButton tsddbApparence;
        private ToolStripMenuItem tsaPetitesIcones;
        private ToolStripMenuItem tsaGrandesIcones;
        private ToolStripMenuItem tsaListe;
        private ToolStripMenuItem tsaDetail;
        private StatusStrip ssMessage;
        private ToolStripStatusLabel slMessage;
        private SplitContainer scSeparateur;
        private TreeView tvRepertoire;
        private ListView lvFichiers;
        private ColumnHeader colNom;
        private ColumnHeader colTaille;
        private ColumnHeader colCREA;
        private ColumnHeader colMODI;
        private ImageList ilTreeView;
        private ImageList ilGrand;
        private ImageList ilPetit;
    }
}