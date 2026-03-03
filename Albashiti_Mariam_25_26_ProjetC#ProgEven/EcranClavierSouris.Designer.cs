namespace Albashiti_Mariam_25_26_ProjetC_ProgEven
{
    partial class EcranClavierSouris
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
            pnlSouris = new Panel();
            lblClavier = new Label();
            lblClicGauche = new Label();
            lblClicDroit = new Label();
            lblPositionX = new Label();
            lblPositionY = new Label();
            lsbClavier = new ListBox();
            butRAZ = new Button();
            tbxClicGauche = new TextBox();
            tbxClicDroit = new TextBox();
            tbxPositionX = new TextBox();
            tbxPositionY = new TextBox();
            SuspendLayout();
            // 
            // pnlSouris
            // 
            pnlSouris.Location = new Point(243, 77);
            pnlSouris.Name = "pnlSouris";
            pnlSouris.Size = new Size(416, 361);
            pnlSouris.TabIndex = 0;
            pnlSouris.MouseDown += pnlSouris_MouseDown;
            pnlSouris.MouseMove += pnlSouris_MouseMove;
            // 
            // lblClavier
            // 
            lblClavier.AutoSize = true;
            lblClavier.Location = new Point(12, 9);
            lblClavier.Name = "lblClavier";
            lblClavier.Size = new Size(136, 20);
            lblClavier.TabIndex = 1;
            lblClavier.Text = "Interception clavier";
            // 
            // lblClicGauche
            // 
            lblClicGauche.AutoSize = true;
            lblClicGauche.Location = new Point(243, 9);
            lblClicGauche.Name = "lblClicGauche";
            lblClicGauche.Size = new Size(85, 20);
            lblClicGauche.TabIndex = 2;
            lblClicGauche.Text = "Clic gauche";
            // 
            // lblClicDroit
            // 
            lblClicDroit.AutoSize = true;
            lblClicDroit.Location = new Point(373, 9);
            lblClicDroit.Name = "lblClicDroit";
            lblClicDroit.Size = new Size(69, 20);
            lblClicDroit.TabIndex = 3;
            lblClicDroit.Text = "Clic droit";
            // 
            // lblPositionX
            // 
            lblPositionX.AutoSize = true;
            lblPositionX.Location = new Point(478, 9);
            lblPositionX.Name = "lblPositionX";
            lblPositionX.Size = new Size(74, 20);
            lblPositionX.TabIndex = 4;
            lblPositionX.Text = "Position X";
            // 
            // lblPositionY
            // 
            lblPositionY.AutoSize = true;
            lblPositionY.Location = new Point(579, 9);
            lblPositionY.Name = "lblPositionY";
            lblPositionY.Size = new Size(77, 20);
            lblPositionY.TabIndex = 5;
            lblPositionY.Text = "Position Y ";
            // 
            // lsbClavier
            // 
            lsbClavier.FormattingEnabled = true;
            lsbClavier.Location = new Point(12, 44);
            lsbClavier.Name = "lsbClavier";
            lsbClavier.Size = new Size(203, 344);
            lsbClavier.TabIndex = 6;
            // 
            // butRAZ
            // 
            butRAZ.Location = new Point(12, 409);
            butRAZ.Name = "butRAZ";
            butRAZ.Size = new Size(203, 29);
            butRAZ.TabIndex = 7;
            butRAZ.Text = "Remise a zero";
            butRAZ.UseVisualStyleBackColor = true;
            // 
            // tbxClicGauche
            // 
            tbxClicGauche.Location = new Point(243, 44);
            tbxClicGauche.Name = "tbxClicGauche";
            tbxClicGauche.Size = new Size(85, 27);
            tbxClicGauche.TabIndex = 8;
            // 
            // tbxClicDroit
            // 
            tbxClicDroit.Location = new Point(373, 44);
            tbxClicDroit.Name = "tbxClicDroit";
            tbxClicDroit.Size = new Size(78, 27);
            tbxClicDroit.TabIndex = 9;
            // 
            // tbxPositionX
            // 
            tbxPositionX.Location = new Point(478, 44);
            tbxPositionX.Name = "tbxPositionX";
            tbxPositionX.Size = new Size(81, 27);
            tbxPositionX.TabIndex = 10;
            // 
            // tbxPositionY
            // 
            tbxPositionY.Location = new Point(579, 44);
            tbxPositionY.Name = "tbxPositionY";
            tbxPositionY.Size = new Size(80, 27);
            tbxPositionY.TabIndex = 11;
            // 
            // EcranClavierSouris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbxPositionY);
            Controls.Add(tbxPositionX);
            Controls.Add(tbxClicDroit);
            Controls.Add(tbxClicGauche);
            Controls.Add(butRAZ);
            Controls.Add(lsbClavier);
            Controls.Add(lblPositionY);
            Controls.Add(lblPositionX);
            Controls.Add(lblClicDroit);
            Controls.Add(lblClicGauche);
            Controls.Add(lblClavier);
            Controls.Add(pnlSouris);
            Name = "EcranClavierSouris";
            Text = "Espoinagge du clavier et de la souris";
            Load += EcranClavierSouris_Load;
            KeyDown += EcranClavierSouris_KeyDown;
            KeyPress += EcranClavierSouris_KeyPress;
            KeyUp += EcranClavierSouris_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSouris;
        private Label lblClavier;
        private Label lblClicGauche;
        private Label lblClicDroit;
        private Label lblPositionX;
        private Label lblPositionY;
        private ListBox lsbClavier;
        private Button butRAZ;
        private TextBox tbxClicGauche;
        private TextBox tbxClicDroit;
        private TextBox tbxPositionX;
        private TextBox tbxPositionY;
    }
}