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
    public partial class EcranIntegration : Form
    {
        delegate double fctAIntegrer(double x);
        public EcranIntegration()
        {
            InitializeComponent();
        }
        private double AireTrapeze(double fxGauche, double fxDroite, double largeur)
        {
            return (fxGauche + fxDroite) / 2.0 * largeur;
        }
        private double Polynome(double x)
        {
            return x * x + 2;
        }
        private void bPolynome_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(tbGauche.Text, out double xGauche) ||
        !double.TryParse(tbDroite.Text, out double xDroite) ||
        !int.TryParse(tbNbInt.Text, out int n) || n < 1)
            {
                MessageBox.Show("Veuillez entrer des valeurs valides (n ≥ 1).");
                return;
            }

            lbResultats.Items.Clear();
            lbResultats.Items.Add("=== Polynôme x²+2 ===");

            int[] multiplicateurs = { 1, 2, 4, 8, 16 };

            foreach (int mult in multiplicateurs)
            {
                int nbIntervalles = n * mult;
                double largeur = (xDroite - xGauche) / nbIntervalles;
                double somme = 0.0;

                for (int i = 0; i < nbIntervalles; i++)
                {
                    double xA = xGauche + i * largeur;
                    double xB = xGauche + (i + 1) * largeur;

                    somme += AireTrapeze(Polynome(xA), Polynome(xB), largeur);
                }

                lbResultats.Items.Add($"n = {nbIntervalles,6}  →  ∫ ≈ {somme:F8}");
            }
        }
        private double Trigonometrique(double x)
        {
            return Math.Sin(x);
        }

        private void bPointeurPolynome_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(tbGauche.Text, out double xGauche) ||
        !double.TryParse(tbDroite.Text, out double xDroite) ||
        !int.TryParse(tbNbInt.Text, out int n) || n < 1)
            {
                MessageBox.Show("Veuillez entrer des valeurs valides (n ≥ 1).");
                return;
            }

            lbResultats.Items.Clear();
            lbResultats.Items.Add("=== Trigonométrique sin(x) ===");

            int[] multiplicateurs = { 1, 2, 4, 8, 16 };

            foreach (int mult in multiplicateurs)
            {
                int nbIntervalles = n * mult;
                double largeur = (xDroite - xGauche) / nbIntervalles;
                double somme = 0.0;

                for (int i = 0; i < nbIntervalles; i++)
                {
                    double xA = xGauche + i * largeur;
                    double xB = xGauche + (i + 1) * largeur;

                    // Le calcul du sin(x) apparaît directement ici
                    somme += AireTrapeze(Trigonometrique(xA), Trigonometrique(xB), largeur);
                }

                lbResultats.Items.Add($"n = {nbIntervalles,6}  →  ∫ ≈ {somme:F8}");
            }
        }
        private double IntegrationTrapeze(fctAIntegrer f, double xGauche, double xDroit, int nInterval)
        {
            double largeur = (xDroit - xGauche) / nInterval;
            double somme = 0.0;

            for (int i = 0; i < nInterval; i++)
            {
                double xA = xGauche + i * largeur;
                double xB = xGauche + (i + 1) * largeur;

                // f(xA) et f(xB) appellent la fonction passée en argument
                somme += AireTrapeze(f(xA), f(xB), largeur);
            }

            return somme;
        }

        private void bPointeurPoly_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(tbGauche.Text, out double xGauche) ||
        !double.TryParse(tbDroite.Text, out double xDroite) ||
        !int.TryParse(tbNbInt.Text, out int n) || n < 1)
            {
                MessageBox.Show("Veuillez entrer des valeurs valides (n ≥ 1).");
                return;
            }

            lbResultats.Items.Clear();
            lbResultats.Items.Add("=== Pointeur – Polynôme x²+2 ===");

            int[] multiplicateurs = { 1, 2, 4, 8, 16 };

            foreach (int mult in multiplicateurs)
            {
                int nbIntervalles = n * mult;

                // On passe la méthode Polynome comme argument via le delegate
                double resultat = IntegrationTrapeze(Polynome, xGauche, xDroite, nbIntervalles);

                lbResultats.Items.Add($"n = {nbIntervalles,6}  →  ∫ ≈ {resultat:F8}");
            }
        }

        private void bPointeurTrigonometrique_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(tbGauche.Text, out double xGauche) ||
        !double.TryParse(tbDroite.Text, out double xDroite) ||
        !int.TryParse(tbNbInt.Text, out int n) || n < 1)
            {
                MessageBox.Show("Veuillez entrer des valeurs valides (n ≥ 1).");
                return;
            }

            lbResultats.Items.Clear();
            lbResultats.Items.Add("=== Pointeur – Trigonométrique sin(x) ===");

            int[] multiplicateurs = { 1, 2, 4, 8, 16 };

            foreach (int mult in multiplicateurs)
            {
                int nbIntervalles = n * mult;

                // On passe la méthode Trigonometrique comme argument via le delegate
                double resultat = IntegrationTrapeze(Trigonometrique, xGauche, xDroite, nbIntervalles);

                lbResultats.Items.Add($"n = {nbIntervalles,6}  →  ∫ ≈ {resultat:F8}");
            }
        }
    }
}
