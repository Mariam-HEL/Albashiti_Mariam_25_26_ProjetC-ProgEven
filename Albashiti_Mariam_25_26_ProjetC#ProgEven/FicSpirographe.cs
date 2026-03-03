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
            int iSommets = tbSommets.Value;      
            int iDensite = tbDensite.Value;      
            int iProfondeur = tbProfondeur.Value; 

            if (iDensite <= 0) iDensite = 1;

           
            int zoneX = gbParametrag.Right + 10;
            int largeur = ClientSize.Width - zoneX - 10;
            int hauteur = ClientSize.Height - 20;

            
            double xc = zoneX + largeur / 2.0;
            double yc = hauteur / 2.0;

            
            double rayon = Math.Min(largeur, hauteur) / 2.0 - 10;

            
            gpSauvegarde = new GraphicsPath();

            
            double[] sx = new double[iSommets + 1];
            double[] sy = new double[iSommets + 1];

            for (int i = 0; i <= iSommets; i++)
            {
                sx[i] = xc + rayon * Math.Cos(2 * Math.PI * i / iSommets);
                sy[i] = yc + rayon * Math.Sin(2 * Math.PI * i / iSommets);
            }

         
            double distanceStop = rayon * iProfondeur / 100.0;

            while (true)
            {
                
                for (int i = 0; i < iSommets; i++)
                {
                    gpSauvegarde.AddLine(
                        (float)sx[i], (float)sy[i],
                        (float)sx[i + 1], (float)sy[i + 1]);
                }

                
                double[] sxNew = new double[iSommets + 1];
                double[] syNew = new double[iSommets + 1];

                for (int i = 0; i < iSommets; i++)
                {
                    sxNew[i] = sx[i] + (sx[i + 1] - sx[i]) / iDensite;
                    syNew[i] = sy[i] + (sy[i + 1] - sy[i]) / iDensite;
                }

                
                sxNew[iSommets] = sxNew[0];
                syNew[iSommets] = syNew[0];

                   
                double dx = sxNew[0] - xc;
                double dy = syNew[0] - yc;
                double distance = Math.Sqrt(dx * dx + dy * dy);

                  
                if (distance < distanceStop)
                    break;

                  
                sx = sxNew;
                sy = syNew;
            }   
            Invalidate(new Rectangle(zoneX, 0, largeur, ClientSize.Height));
        }
        //private void bGo_Click(object sender, EventArgs e)
        //{
        //    int iSommet = tbSommets.Value;
        //    int densiteValue = tbDensite.Value;
        //    int profindValue = tbProfondeur.Value;

        //    gpSauvegarde = new GraphicsPath();
        //    //determiner la centre de la zone apres le 340 px 
        //    int largeur = this.ClientSize.Width - 340;
        //    int hauteur = this.ClientSize.Height;
        //    int xc = 340 + (largeur / 2);
        //    int yc = hauteur / 2;
        //    //determine le rayon 
        //    double rayon = Math.Min(largeur, hauteur) / 3;
        //    double[] sx = new double[iSommet+1];
        //    double[] sy = new double[iSommet + 1];
        //    //la position de la sommet :
        //    //PointF[] points = new PointF[iSommet];
        //    for(int i = 0; i < iSommet; i++)
        //    {
        //        double angle = (2 * Math.PI * i) / iSommet;
        //        sx[i] = xc + rayon * Math.Cos(angle);
        //        sy[i] = yc + rayon * Math.Sin(angle);
        //    }
        //    //fermer la polygune
        //    sx[iSommet] = sx[0];
        //    sy[iSommet] = sy[0];

        //    for (int j = 0; j < profindValue; j++)
        //    {
        //        //double[] sx = new double[iSommet + 1 ];
        //        //double[] sy = new double[iSommet + 1];
        //        //PointF[] points = new PointF[iSommet+1];
        //        //double rayonActuel = rayon - (j * rayon /profindValue);
        //        for (int i = 0; i <= iSommet; i++)
        //        {
        //            gpSauvegarde.AddLine(
        //        (float)sx[i],
        //        (float)sy[i],
        //        (float)sx[i + 1],
        //        (float)sy[i + 1] );
        //            //double angle = (2 * Math.PI * i) / iSommet;
        //            //double decalalge = j * densiteValue * (2 * Math.PI) / iSommet;
        //            //double angleDecaler = angle + decalalge;
        //            //float xi = (float)(xc + rayonActuel * Math.Cos(angleDecaler));
        //            //float yi = (float)(yc + rayonActuel * Math.Sin(angleDecaler));
        //            //points[i] = new PointF(xi, yi);
        //        }
        //         //gpSauvegarde.AddPolygon(points);
        //        for(int i = 0;i <iSommet; i++)
        //        {
        //            sx[i] = sx[i] + (sx[i + 1]) / densiteValue;
        //            sy[i] = sy[i] + (sy[i+ 1]) / densiteValue;
        //        }
        //        sx[iSommet] = sx[0];
        //        sy[iSommet ] = sy[0];


        //    }
        //    this.Invalidate();


        //}

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
