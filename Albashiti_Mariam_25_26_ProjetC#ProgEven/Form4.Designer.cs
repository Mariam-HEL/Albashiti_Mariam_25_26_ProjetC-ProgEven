namespace Albashiti_Mariam_25_26_ProjetC_ProgEven
{
    partial class EcranAPropos
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
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btnConfirmer = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(286, 80);
            label1.Name = "label1";
            label1.Size = new Size(271, 31);
            label1.TabIndex = 0;
            label1.Text = "Premières Manipulations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(286, 123);
            label2.Name = "label2";
            label2.Size = new Size(261, 31);
            label2.TabIndex = 1;
            label2.Text = "Version sous alpha 1.0.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(264, 187);
            label3.Name = "label3";
            label3.Size = new Size(245, 38);
            label3.TabIndex = 2;
            label3.Text = "CopyRight NADA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 262);
            label4.Name = "label4";
            label4.Size = new Size(466, 20);
            label4.TabIndex = 3;
            label4.Text = "Et l'application se dit qu'un jour, elle deviendra aussi grande que NET";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.aproposIcon;
            pictureBox1.Location = new Point(161, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 62);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnConfirmer
            // 
            btnConfirmer.Location = new Point(307, 337);
            btnConfirmer.Name = "btnConfirmer";
            btnConfirmer.Size = new Size(138, 40);
            btnConfirmer.TabIndex = 5;
            btnConfirmer.Text = "Confirmer";
            btnConfirmer.UseVisualStyleBackColor = true;
            btnConfirmer.Click += btnConfirmer_Click;
            // 
            // EcranAPropos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmer);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EcranAPropos";
            Text = "EcranAPropos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btnConfirmer;
    }
}