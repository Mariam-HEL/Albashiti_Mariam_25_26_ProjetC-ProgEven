namespace Albashiti_Mariam_25_26_ProjetC_ProgEven
{
    partial class Form3
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
            menuStrip1 = new MenuStrip();
            controlesToolStripMenuItem = new ToolStripMenuItem();
            listeToolStripMenuItem = new ToolStripMenuItem();
            barreDeProgressionToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            applicationsToolStripMenuItem = new ToolStripMenuItem();
            aideToolStripMenuItem = new ToolStripMenuItem();
            editeurToolStripMenuItem = new ToolStripMenuItem();
            aProposToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { controlesToolStripMenuItem, applicationsToolStripMenuItem, aideToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // controlesToolStripMenuItem
            // 
            controlesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeToolStripMenuItem, barreDeProgressionToolStripMenuItem, toolStripSeparator1, quitterToolStripMenuItem });
            controlesToolStripMenuItem.Name = "controlesToolStripMenuItem";
            controlesToolStripMenuItem.Size = new Size(86, 24);
            controlesToolStripMenuItem.Text = "Controles";
            // 
            // listeToolStripMenuItem
            // 
            listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            listeToolStripMenuItem.Size = new Size(230, 26);
            listeToolStripMenuItem.Text = "Liste";
            // 
            // barreDeProgressionToolStripMenuItem
            // 
            barreDeProgressionToolStripMenuItem.Name = "barreDeProgressionToolStripMenuItem";
            barreDeProgressionToolStripMenuItem.Size = new Size(230, 26);
            barreDeProgressionToolStripMenuItem.Text = "Barre de progression";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(227, 6);
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.Q;
            quitterToolStripMenuItem.Size = new Size(230, 26);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // applicationsToolStripMenuItem
            // 
            applicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editeurToolStripMenuItem });
            applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            applicationsToolStripMenuItem.Size = new Size(106, 24);
            applicationsToolStripMenuItem.Text = "Applications";
            // 
            // aideToolStripMenuItem
            // 
            aideToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aProposToolStripMenuItem });
            aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            aideToolStripMenuItem.Size = new Size(54, 24);
            aideToolStripMenuItem.Text = "Aide";
            // 
            // editeurToolStripMenuItem
            // 
            editeurToolStripMenuItem.Name = "editeurToolStripMenuItem";
            editeurToolStripMenuItem.Size = new Size(224, 26);
            editeurToolStripMenuItem.Text = "Editeur";
            // 
            // aProposToolStripMenuItem
            // 
            aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            aProposToolStripMenuItem.Size = new Size(224, 26);
            aProposToolStripMenuItem.Text = "A propos";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form3";
            Text = "Fenetre principale ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem controlesToolStripMenuItem;
        private ToolStripMenuItem applicationsToolStripMenuItem;
        private ToolStripMenuItem aideToolStripMenuItem;
        private ToolStripMenuItem listeToolStripMenuItem;
        private ToolStripMenuItem barreDeProgressionToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem editeurToolStripMenuItem;
        private ToolStripMenuItem aProposToolStripMenuItem;
    }
}