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

namespace Albashiti_Mariam_25_26_ProjetC_ProgEven
{
    public partial class EcranListe : Form
    {


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
                lbPersonne.Items.Add($"{tbNom.Text} ({cbQualite.SelectedItem})");
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

            if (index != -1 )
            {
                string ligneChoisi = lbPersonne.SelectedItems.ToString();
                string ligne = string.Join(" ", ligneChoisi);
                MessageBox.Show($"Index : {index}\ncontenu de la ligne choisi : {ligne}\n");
            }
        }
    }
}
