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
        string sFichier = "";
        bool bModifier = false;
        public EcranEditeur()
        {
            InitializeComponent();
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
                    rtbTexte.Modified = false;
                }
            }
            else
            {
                rtbTexte.SaveFile(sFichier, RichTextBoxStreamType.PlainText);
                rtbTexte.Modified = false;
            }
            
        }

        private bool VerifierSauver()
        {
            if (!rtbTexte.Modified)
                return true;

            DialogResult reponse = MessageBox.Show("Voulez-vous sasivegarder les modifocation?" , 
                "Confirmation" , MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if(reponse == DialogResult.Yes)
            {
                FichierEnregistrer();
                return true;
            }
            else if (reponse == DialogResult.No)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void rtbTexte_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
