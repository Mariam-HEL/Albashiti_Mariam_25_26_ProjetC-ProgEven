namespace Albashiti_Mariam_25_26_ProjetC_ProgEven
{
    partial class EcranProgression
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
            label1 = new Label();
            label2 = new Label();
            bpPrincipale = new ProgressBar();
            pbSecondaire = new ProgressBar();
            bExecuter = new Button();
            bQuitter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 36);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "Index principale";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 118);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 1;
            label2.Text = "Index secondaire";
            // 
            // bpPrincipale
            // 
            bpPrincipale.BackColor = Color.Firebrick;
            bpPrincipale.ForeColor = Color.LightCoral;
            bpPrincipale.Location = new Point(53, 74);
            bpPrincipale.Name = "bpPrincipale";
            bpPrincipale.Size = new Size(335, 29);
            bpPrincipale.TabIndex = 2;
            // 
            // pbSecondaire
            // 
            pbSecondaire.ForeColor = SystemColors.GradientActiveCaption;
            pbSecondaire.Location = new Point(53, 162);
            pbSecondaire.Name = "pbSecondaire";
            pbSecondaire.Size = new Size(335, 29);
            pbSecondaire.TabIndex = 3;
            // 
            // bExecuter
            // 
            bExecuter.Location = new Point(53, 240);
            bExecuter.Name = "bExecuter";
            bExecuter.Size = new Size(94, 29);
            bExecuter.TabIndex = 4;
            bExecuter.Text = "Executer";
            bExecuter.UseVisualStyleBackColor = true;
            bExecuter.Click += bExecuter_Click;
            // 
            // bQuitter
            // 
            bQuitter.Location = new Point(183, 240);
            bQuitter.Name = "bQuitter";
            bQuitter.Size = new Size(94, 29);
            bQuitter.TabIndex = 5;
            bQuitter.Text = "Quitter";
            bQuitter.UseVisualStyleBackColor = true;
            bQuitter.Click += bQuitter_Click;
            // 
            // EcranProgression
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bQuitter);
            Controls.Add(bExecuter);
            Controls.Add(pbSecondaire);
            Controls.Add(bpPrincipale);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EcranProgression";
            Text = "EcranProgression";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ProgressBar bpPrincipale;
        private ProgressBar pbSecondaire;
        private Button bExecuter;
        private Button bQuitter;
    }
}