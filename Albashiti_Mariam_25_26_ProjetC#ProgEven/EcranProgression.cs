using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Albashiti_Mariam_25_26_ProjetC_ProgEven
{
    public partial class EcranProgression : Form
    {
        public EcranProgression()
        {
            InitializeComponent();
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void bExecuter_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            bExecuter.Enabled = false;
            bQuitter.Enabled = false;

            Random rnd = new Random();
            int nbFichiers = rnd.Next(5, 11);

            bpPrincipale.Minimum = 0;
            bpPrincipale.Maximum = nbFichiers;
            bpPrincipale.Value = 0;

            for (int i = 0; i < nbFichiers; i++)
            {
                int taille = rnd.Next(20, 100);
                pbSecondaire.Minimum = 0;
                pbSecondaire.Maximum = taille;
                pbSecondaire.Value = 0;

                for (int j = 0; j < taille; j++)
                {
                    await Task.Delay(1000);
                    pbSecondaire.Value++;
                }

                bpPrincipale.Value++;
            }

            Cursor = Cursors.Default;
            bExecuter.Enabled = true;
            bQuitter.Enabled = true;
        }


    }
    }

