using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Albashiti_Mariam_25_26_ProjetC_ProgEven
{
    public partial class FicSpirographe : Form
    {
        Color cFond;
        Color cTrait;
        GraphicsPath gpSauvegarde;
        public FicSpirographe()
        {
            InitializeComponent();
            cFond = Color.CadetBlue;
            cTrait = Color.Azure;
            gpSauvegarde = null;
        }

        private void bGo_Click(object sender, EventArgs e)
        {
            int sommeValue = tbSommets.Value;
            int densiteValue = tbDensite.Value;
            int profindValue = tbProfondeur.Value;

            gpSauvegarde = new GraphicsPath();
            //determiner la centre de la zone apres le 340 px 
            int largeur = this.ClientSize.Width - 340;
            int hauteur = this.ClientSize.Height;
            int xc = 340 + (largeur / 2);
            int yc = hauteur / 2;
            //determine le rayon 
            double rayon = Math.Min(largeur, hauteur) / 3;
            //la position de la sommet :
            PointF[] points = new PointF[sommeValue];
            for(int i = 0; i < profindValue)
            for (int i = 0; i < sommeValue; i++)
            {
                double angle = (2 * Math.PI * i) / sommeValue;
                float xi = (float)(xc + rayon * Math.Cos(angle));
                float yi = (float)(yc + rayon * Math.Sin(angle));
                points[i] = new PointF(xi, yi);
            }
            gpSauvegarde.AddPolygon(points);
            this.Invalidate();
        }

        private void FicSpirographe_Paint(object sender, PaintEventArgs e)
        {
            if (gpSauvegarde != null)

            {

             e.Graphics.FillRectangle(

             new SolidBrush(cFond),

             new Rectangle(new Point(340, 0), ClientSize));

             e.Graphics.DrawPath(new Pen(cTrait), gpSauvegarde);

            }

        }

        private void bFond_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
                cFond = cd.Color;
            Invalidate();
            cd.AllowFullOpen = true;
            cd.ShowHelp = true;
            cFond = cd.Color;
        }

        private void bTrait_Click(object sender, EventArgs e)
        {
            ColorDialog td = new ColorDialog();

            if (td.ShowDialog() == DialogResult.OK)
                cTrait = td.Color;
            Invalidate();
            //td.AllowFullOpen = true;
            //td.ShowHelp = true;
            cTrait = td.Color;

        }
    }
}
