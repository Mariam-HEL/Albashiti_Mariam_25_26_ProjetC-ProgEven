namespace Albashiti_Mariam_25_26_ProjetC_ProgEven
{
    partial class EcranListe
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
            INom = new Label();
            IQualite = new Label();
            IFichier = new Label();
            bAnnuler = new Button();
            bConfirmer = new Button();
            bOuvrir = new Button();
            bEnregistrer = new Button();
            bSupprimer = new Button();
            bAjouter = new Button();
            lbPersonne = new ListBox();
            cbQualite = new ComboBox();
            gbDetail = new GroupBox();
            tbNom = new TextBox();
            ofdOuvrir = new OpenFileDialog();
            sfdEnregistrer = new SaveFileDialog();
            bModifier = new Button();
            gbDetail.SuspendLayout();
            SuspendLayout();
            // 
            // INom
            // 
            INom.AutoSize = true;
            INom.Location = new Point(19, 90);
            INom.Name = "INom";
            INom.Size = new Size(42, 20);
            INom.TabIndex = 0;
            INom.Text = "Nom";
            // 
            // IQualite
            // 
            IQualite.AutoSize = true;
            IQualite.Location = new Point(19, 23);
            IQualite.Name = "IQualite";
            IQualite.Size = new Size(57, 20);
            IQualite.TabIndex = 1;
            IQualite.Text = "Qualite";
            // 
            // IFichier
            // 
            IFichier.AutoSize = true;
            IFichier.Location = new Point(58, 9);
            IFichier.Name = "IFichier";
            IFichier.Size = new Size(108, 20);
            IFichier.TabIndex = 2;
            IFichier.Text = "Nom du fichier";
            // 
            // bAnnuler
            // 
            bAnnuler.Location = new Point(135, 163);
            bAnnuler.Name = "bAnnuler";
            bAnnuler.Size = new Size(94, 29);
            bAnnuler.TabIndex = 3;
            bAnnuler.Text = "Annuler";
            bAnnuler.UseVisualStyleBackColor = true;
            bAnnuler.Click += bAnnuler_Click;
            // 
            // bConfirmer
            // 
            bConfirmer.Location = new Point(19, 163);
            bConfirmer.Name = "bConfirmer";
            bConfirmer.Size = new Size(94, 29);
            bConfirmer.TabIndex = 4;
            bConfirmer.Text = "Confirmer";
            bConfirmer.UseVisualStyleBackColor = true;
            bConfirmer.Click += bConfirmer_Click;
            // 
            // bOuvrir
            // 
            bOuvrir.Location = new Point(58, 214);
            bOuvrir.Name = "bOuvrir";
            bOuvrir.Size = new Size(94, 29);
            bOuvrir.TabIndex = 5;
            bOuvrir.Text = "Ouvrir";
            bOuvrir.UseVisualStyleBackColor = true;
            bOuvrir.Click += bOuvrir_Click;
            // 
            // bEnregistrer
            // 
            bEnregistrer.Location = new Point(58, 254);
            bEnregistrer.Name = "bEnregistrer";
            bEnregistrer.Size = new Size(94, 29);
            bEnregistrer.TabIndex = 6;
            bEnregistrer.Text = "Enregistrer";
            bEnregistrer.UseVisualStyleBackColor = true;
            bEnregistrer.Click += bEnregistrer_Click;
            // 
            // bSupprimer
            // 
            bSupprimer.Location = new Point(58, 363);
            bSupprimer.Name = "bSupprimer";
            bSupprimer.Size = new Size(94, 29);
            bSupprimer.TabIndex = 7;
            bSupprimer.Text = "Supprimer";
            bSupprimer.UseVisualStyleBackColor = true;
            bSupprimer.Click += bSupprimer_Click;
            // 
            // bAjouter
            // 
            bAjouter.Location = new Point(58, 322);
            bAjouter.Name = "bAjouter";
            bAjouter.Size = new Size(94, 29);
            bAjouter.TabIndex = 8;
            bAjouter.Text = "Ajouter";
            bAjouter.UseVisualStyleBackColor = true;
            bAjouter.Click += bAjouter_Click;
            // 
            // lbPersonne
            // 
            lbPersonne.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPersonne.ForeColor = Color.DarkGray;
            lbPersonne.FormattingEnabled = true;
            lbPersonne.ItemHeight = 25;
            lbPersonne.Location = new Point(58, 32);
            lbPersonne.Name = "lbPersonne";
            lbPersonne.Size = new Size(793, 154);
            lbPersonne.TabIndex = 9;
            lbPersonne.MouseDoubleClick += lbPersonne_MouseDoubleClick;
            // 
            // cbQualite
            // 
            cbQualite.BackColor = Color.Gainsboro;
            cbQualite.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbQualite.FormattingEnabled = true;
            cbQualite.Items.AddRange(new object[] { "Madame", "Mademoiselle", "Monsieur", "Mondamoiseau", "Mondamoiseau" });
            cbQualite.Location = new Point(19, 54);
            cbQualite.Name = "cbQualite";
            cbQualite.Size = new Size(151, 33);
            cbQualite.TabIndex = 10;
            // 
            // gbDetail
            // 
            gbDetail.Controls.Add(tbNom);
            gbDetail.Controls.Add(IQualite);
            gbDetail.Controls.Add(cbQualite);
            gbDetail.Controls.Add(INom);
            gbDetail.Controls.Add(bConfirmer);
            gbDetail.Controls.Add(bAnnuler);
            gbDetail.Location = new Point(266, 214);
            gbDetail.Name = "gbDetail";
            gbDetail.Size = new Size(412, 208);
            gbDetail.TabIndex = 11;
            gbDetail.TabStop = false;
            gbDetail.Text = "Detail presonne";
            // 
            // tbNom
            // 
            tbNom.BackColor = SystemColors.ButtonFace;
            tbNom.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbNom.Location = new Point(19, 113);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(125, 30);
            tbNom.TabIndex = 12;
            // 
            // bModifier
            // 
            bModifier.Location = new Point(58, 409);
            bModifier.Name = "bModifier";
            bModifier.Size = new Size(94, 29);
            bModifier.TabIndex = 12;
            bModifier.Text = "Modifier";
            bModifier.UseVisualStyleBackColor = true;
            bModifier.Click += bModifier_Click;
            // 
            // EcranListe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(863, 450);
            Controls.Add(bModifier);
            Controls.Add(gbDetail);
            Controls.Add(lbPersonne);
            Controls.Add(bAjouter);
            Controls.Add(bSupprimer);
            Controls.Add(bEnregistrer);
            Controls.Add(bOuvrir);
            Controls.Add(IFichier);
            Name = "EcranListe";
            Text = "Manipulation d'une liste";
            Load += EcranListe_Load;
            gbDetail.ResumeLayout(false);
            gbDetail.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label INom;
        private Label IQualite;
        private Label IFichier;
        private Button bAnnuler;
        private Button bConfirmer;
        private Button bOuvrir;
        private Button bEnregistrer;
        private Button bSupprimer;
        private Button bAjouter;
        private ListBox lbPersonne;
        private ComboBox cbQualite;
        private GroupBox gbDetail;
        private TextBox tbNom;
        private OpenFileDialog ofdOuvrir;
        private SaveFileDialog sfdEnregistrer;
        private Button bModifier;
    }
}