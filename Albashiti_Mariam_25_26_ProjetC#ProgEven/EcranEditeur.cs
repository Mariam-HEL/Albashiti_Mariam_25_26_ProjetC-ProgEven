using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Albashiti_Mariam_25_26_ProjetC_ProgEven
{
    public partial class EcranEditeur : Form
    {
        private string sFichier;
        private bool bModifier;
        public EcranEditeur()
        {
            InitializeComponent();
            sFichier = "";
            bModifier = false;
        }
        public void FichierEnregistrer()
        {
            if (string.IsNullOrEmpty(sFichier))
            {
                SaveFileDialog saveF = new SaveFileDialog();
                saveF.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
                saveF.Title = "Enregistrer sous";

                if (saveF.ShowDialog() == DialogResult.OK)
                {
                    sFichier = saveF.FileName;
                    rtbTexte.SaveFile(sFichier, RichTextBoxStreamType.PlainText);
                    //rtbTexte.Modified = false;
                }
                else
                {
                    return; //annuler l'enregistrement
                }
            }
            else
            {
                rtbTexte.SaveFile(sFichier, RichTextBoxStreamType.PlainText);
                rtbTexte.Modified = false;
            }
            System.IO.File.WriteAllText(sFichier, rtbTexte.Text);
            bModifier = false;

        }

        private bool VerifierSauver()
        {
            if (bModifier)
            {
                DialogResult resultat = MessageBox.Show("Voulez vous enregistrer la modifications ?",
                    "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning
                    );

                if (resultat == DialogResult.Yes)
                {
                    FichierEnregistrer();
                    return true;
                }
                else if (resultat == DialogResult.No)
                {
                    return true; // continue sans enregistrement 
                }
                else
                {
                    return false; //annuler 
                }
            }
            else
            {
                return true; // le texte n'a pas cahnge / modifiee 
            }
        }

        private void rtbTexte_TextChanged(object sender, EventArgs e)
        {
            rtbTexte.Dock = DockStyle.Fill;
            bModifier = true;
        }

        private void pMenu_Paint(object sender, PaintEventArgs e)
        {
            pMenu.Dock = DockStyle.Top;

        }

        private void EcranEditeur_Load(object sender, EventArgs e)
        {
            sFichier = "";
            bModifier = false;
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!VerifierSauver())
                return; // l'utilisateur a annule l'operation

            rtbTexte.Clear();
            sFichier = "";
            bModifier = false;
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!VerifierSauver())
                return;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                sFichier = ofd.FileName;
                rtbTexte.Text = System.IO.File.ReadAllText(sFichier);

                bModifier = false;
            }
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FichierEnregistrer();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!VerifierSauver())
                return;

            this.Close();
        }
    }
}
