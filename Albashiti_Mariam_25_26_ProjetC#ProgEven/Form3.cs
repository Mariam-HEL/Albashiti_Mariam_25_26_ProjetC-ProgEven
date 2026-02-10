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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //ou
            //Application.Exit();
        }
        private void NonImplementation()
        {
            MessageBox.Show(
                "Cette fonctionne n'est pas encore implementee",
                "Information",
                MessageBoxButtons.OK
                );
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NonImplementation();
        }

        private void barreDeProgressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranProgression progress = new EcranProgression();
            progress.ShowDialog();
        }

        private void editeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NonImplementation();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
           EcranAPropos ff = new EcranAPropos();
            ff.ShowDialog();
        }
    }
}
