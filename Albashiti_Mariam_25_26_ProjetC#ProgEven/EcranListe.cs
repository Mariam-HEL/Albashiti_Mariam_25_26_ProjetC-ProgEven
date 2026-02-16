using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Albashiti_Mariam_25_26_ProjetC_ProgEven
{
    public partial class EcranListe : Form
    {
        private int numeroEncodage = 1;
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int smLire = 0x0199;
        private const int smEcrire = 0x019A;

        public EcranListe()
        {
            InitializeComponent();
        }
        private void bOuvrir_Click(object sender, EventArgs e)
        {
            string NomFichier;
            if (ofdOuvrir.ShowDialog() == DialogResult.OK)
            {
                NomFichier = ofdOuvrir.FileName;
                MessageBox.Show(NomFichier);
                string text = File.ReadAllText(NomFichier);
                lbPersonne.Items.Add(text);


            }

        }


        private void Activer(bool etat)
        {

            lbPersonne.Enabled = etat;
            bOuvrir.Enabled = etat;
            bEnregistrer.Enabled = etat;
            bAjouter.Enabled = etat;
            bSupprimer.Enabled = etat;

            gbDetail.Enabled = !etat;

        }

        private void EcranListe_Load(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            Activer(false);
        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex != -1)
            {
                lbPersonne.Items.RemoveAt(lbPersonne.SelectedIndex);
            }
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNom.Text) && cbQualite.SelectedIndex != -1)
            {
                lbPersonne.Items.Add(tbNom.Text + "("+ cbQualite.Text+")");
                int index = lbPersonne.Items.Count - 1;
                SendMessage(lbPersonne.Handle, smEcrire, index, numeroEncodage);
                numeroEncodage++;
                lbPersonne.Sorted = true;
            }
            else
            {
                MessageBox.Show("il faut que taper le nom et sa qualite , s'il vous plait", "Warning");
            }

        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            if (sfdEnregistrer.ShowDialog() == DialogResult.OK)
            {
                string NomFichier = sfdEnregistrer.FileName;

                string[] lignes = new string[lbPersonne.Items.Count];

                for (int i = 0; i < lbPersonne.Items.Count; i++)
                {
                    lignes[i] = lbPersonne.Items[i].ToString();
                }
                File.WriteAllLines(NomFichier, lignes);

            }
        }

        private void lbPersonne_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            int index = lbPersonne.SelectedIndex;


            if (index != -1)
            {
                int numeroCache = SendMessage(lbPersonne.Handle, smLire, index, 0);
                //var item = lbPersonne.SelectedItem;

                MessageBox.Show($"index : {index} contenu de la ligne choisi : {lbPersonne.SelectedItem} Numero d'encodage : {numeroCache}");
            }
        }
        //private int indexModifier = -1;
        private void bModifier_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez selectionner une personne a modifier ");
                return;
            }

            string nom = tbNom.Text.Trim();
            string qaulite = cbQualite.Text.Trim();

            if (string.IsNullOrEmpty(nom))
            {
                MessageBox.Show("Le nom ne doit pas etre vide", "Attention",MessageBoxButtons.OK,MessageBoxIcon.Error);
                tbNom.Focus();
                return;
            }

            int index = lbPersonne.SelectedIndex;
            lbPersonne.Items[index] = $"{nom} ({qaulite})";

            Activer(false);
        }
    }
}
