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
    public partial class FormHorloge : Form
    {
        public FormHorloge()
        {
            InitializeComponent();
            this.DoubleBuffered = true;   
            timer1.Interval = 1000;       
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();  
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int largeur = ClientSize.Width;
            int hauteur = ClientSize.Height;

            int rayon = Math.Min(largeur, hauteur) / 2 - 20;

            int xc = largeur / 2;
            int yc = hauteur / 2;

               
            g.DrawEllipse(Pens.Black, xc - rayon, yc - rayon, rayon * 2, rayon * 2);

            
            DateTime maintenant = DateTime.Now;

            int heure = maintenant.Hour % 12;
            int minute = maintenant.Minute;
            int seconde = maintenant.Second;

              
            this.Text = maintenant.ToString("HH:mm:ss");

            
            double angleHeure = (heure + minute / 60.0) * 30;
            double angleMinute = (minute + seconde / 60.0) * 6;
            double angleSeconde = seconde * 6;

              
            DessinerAiguille(g, xc, yc, rayon * 0.5, angleHeure, 6);
            DessinerAiguille(g, xc, yc, rayon * 0.7, angleMinute, 4); 
            DessinerAiguille(g, xc, yc, rayon * 0.9, angleSeconde, 2); 
        }
        private void DessinerAiguille(Graphics g, int xc, int yc, double longueur, double angleDegre, int epaisseur)
        {
            double angleRad = (Math.PI / 180) * (angleDegre - 90);

            int x = xc + (int)(longueur * Math.Cos(angleRad));
            int y = yc + (int)(longueur * Math.Sin(angleRad));

            using (Pen p = new Pen(Color.Black, epaisseur))
            {
                g.DrawLine(p, xc, yc, x, y);
            }
        }


        private void FormHorloge_Load(object sender, EventArgs e)
        {

        }
    }
}
