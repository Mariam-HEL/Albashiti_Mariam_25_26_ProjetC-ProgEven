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
    public partial class EcranClavierSouris : Form
    {
        int nbGauche;
        int nbDroit;
        public EcranClavierSouris()
        {
            InitializeComponent();
        }

        private void pnlSouris_MouseMove(object sender, MouseEventArgs e)
        {
            tbxPositionX.Text = e.X.ToString();
            tbxPositionY.Text = e.Y.ToString();
        }

        private void pnlSouris_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                nbGauche++;
                //int compteur;
                //int.TryParse(tbxClicGauche.Text, out compteur);
                //compteur++;
                //tbxClicGauche.Text = compteur.ToString();
            }

            if (e.Button == MouseButtons.Right)
            {
                nbDroit++;
                //int compteur;
                //int.TryParse(tbxClicDroit.Text, out compteur);
                //compteur++;
                //tbxClicDroit.Text = compteur.ToString();
            }
            AfficherClic();
            int caseWidth = pnlSouris.Width / 3;
            int caseHeight = pnlSouris.Height / 3;

            int colonne = e.X / caseWidth;
            int ligne = e.Y / caseHeight;  
            lsbClavier.Items.Add($"Clic dans la case : Ligne {ligne + 1}, Colonne {colonne + 1}");
        }

        private void EcranClavierSouris_KeyDown(object sender, KeyEventArgs e)
        {
            lsbClavier.Items.Add("KeyDown: " + e.KeyCode.ToString());
        }

        private void EcranClavierSouris_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void EcranClavierSouris_KeyPress(object sender, KeyPressEventArgs e)
        {
            lsbClavier.Items.Add("KeyPress: " + e.KeyChar);
        }

        private void EcranClavierSouris_KeyUp(object sender, KeyEventArgs e)
        {
            lsbClavier.Items.Add("KeyPress: " + e.KeyCode.ToString());
        }
        private void AfficherClic()
        {
            tbxClicGauche.Text = nbGauche.ToString(); // Met à jour le TextBox du clic gauche
            tbxClicDroit.Text = nbDroit.ToString();   // Met à jour le TextBox du clic droit
        }

        private void butRAZ_Click(object sender, EventArgs e)
        {
            tbxClicGauche.Text = "0";
            tbxClicDroit.Text = "0";
            AfficherClic();
            lsbClavier.Items.Clear();
            tbxPositionX.Text = "0";
            tbxPositionY.Text = "0";
        }



    }
}
