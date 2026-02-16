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
            SuspendLayout();
            // 
            // INom
            // 
            INom.AutoSize = true;
            INom.Location = new Point(637, 126);
            INom.Name = "INom";
            INom.Size = new Size(50, 20);
            INom.TabIndex = 0;
            INom.Text = "label1";
            // 
            // IQualite
            // 
            IQualite.AutoSize = true;
            IQualite.Location = new Point(637, 87);
            IQualite.Name = "IQualite";
            IQualite.Size = new Size(50, 20);
            IQualite.TabIndex = 1;
            IQualite.Text = "label2";
            // 
            // IFichier
            // 
            IFichier.AutoSize = true;
            IFichier.Location = new Point(637, 182);
            IFichier.Name = "IFichier";
            IFichier.Size = new Size(50, 20);
            IFichier.TabIndex = 2;
            IFichier.Text = "label3";
            IFichier.Click += IFichier_Click;
            // 
            // bAnnuler
            // 
            bAnnuler.Location = new Point(402, 60);
            bAnnuler.Name = "bAnnuler";
            bAnnuler.Size = new Size(94, 29);
            bAnnuler.TabIndex = 3;
            bAnnuler.Text = "button1";
            bAnnuler.UseVisualStyleBackColor = true;
            // 
            // bConfirmer
            // 
            bConfirmer.Location = new Point(402, 117);
            bConfirmer.Name = "bConfirmer";
            bConfirmer.Size = new Size(94, 29);
            bConfirmer.TabIndex = 4;
            bConfirmer.Text = "button2";
            bConfirmer.UseVisualStyleBackColor = true;
            // 
            // bOuvrir
            // 
            bOuvrir.Location = new Point(402, 173);
            bOuvrir.Name = "bOuvrir";
            bOuvrir.Size = new Size(94, 29);
            bOuvrir.TabIndex = 5;
            bOuvrir.Text = "button3";
            bOuvrir.UseVisualStyleBackColor = true;
            // 
            // bEnregistrer
            // 
            bEnregistrer.Location = new Point(402, 235);
            bEnregistrer.Name = "bEnregistrer";
            bEnregistrer.Size = new Size(94, 29);
            bEnregistrer.TabIndex = 6;
            bEnregistrer.Text = "button4";
            bEnregistrer.UseVisualStyleBackColor = true;
            // 
            // bSupprimer
            // 
            bSupprimer.Location = new Point(402, 294);
            bSupprimer.Name = "bSupprimer";
            bSupprimer.Size = new Size(94, 29);
            bSupprimer.TabIndex = 7;
            bSupprimer.Text = "button5";
            bSupprimer.UseVisualStyleBackColor = true;
            // 
            // bAjouter
            // 
            bAjouter.Location = new Point(402, 353);
            bAjouter.Name = "bAjouter";
            bAjouter.Size = new Size(94, 29);
            bAjouter.TabIndex = 8;
            bAjouter.Text = "button6";
            bAjouter.UseVisualStyleBackColor = true;
            // 
            // lbPersonne
            // 
            lbPersonne.FormattingEnabled = true;
            lbPersonne.Location = new Point(83, 42);
            lbPersonne.Name = "lbPersonne";
            lbPersonne.Size = new Size(150, 104);
            lbPersonne.TabIndex = 9;
            // 
            // cbQualite
            // 
            cbQualite.FormattingEnabled = true;
            cbQualite.Location = new Point(82, 182);
            cbQualite.Name = "cbQualite";
            cbQualite.Size = new Size(151, 28);
            cbQualite.TabIndex = 10;
            // 
            // gbDetail
            // 
            gbDetail.Location = new Point(82, 257);
            gbDetail.Name = "gbDetail";
            gbDetail.Size = new Size(250, 125);
            gbDetail.TabIndex = 11;
            gbDetail.TabStop = false;
            gbDetail.Text = "groupBox1";
            // 
            // tbNom
            // 
            tbNom.Location = new Point(637, 235);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(125, 27);
            tbNom.TabIndex = 12;
            // 
            // EcranListe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbNom);
            Controls.Add(gbDetail);
            Controls.Add(cbQualite);
            Controls.Add(lbPersonne);
            Controls.Add(bAjouter);
            Controls.Add(bSupprimer);
            Controls.Add(bEnregistrer);
            Controls.Add(bOuvrir);
            Controls.Add(bConfirmer);
            Controls.Add(bAnnuler);
            Controls.Add(IFichier);
            Controls.Add(IQualite);
            Controls.Add(INom);
            Name = "EcranListe";
            Text = "Manipulation d'une liste";
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
    }
}