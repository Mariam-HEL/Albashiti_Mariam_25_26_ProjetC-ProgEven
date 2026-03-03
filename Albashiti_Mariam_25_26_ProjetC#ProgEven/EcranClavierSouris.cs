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
                int compteur;
                int.TryParse(tbxClicGauche.Text, out compteur);
                compteur++;
                tbxClicGauche.Text = compteur.ToString();
            }

            if (e.Button == MouseButtons.Right)
            {
                int compteur;
                int.TryParse(tbxClicDroit.Text, out compteur);
                compteur++;
                tbxClicDroit.Text = compteur.ToString();
            }
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
    }
}
