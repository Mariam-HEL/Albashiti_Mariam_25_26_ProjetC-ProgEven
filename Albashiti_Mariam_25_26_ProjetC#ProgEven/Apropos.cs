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
    public partial class EcranAPropos : Form
    {
        Cursor ancienneCursor;
        public EcranAPropos()
        {
            InitializeComponent();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void btnConfirmer_MouseEnter(object sender, EventArgs e)
        {
           ancienneCursor = this.Cursor;
           this.Cursor = new Cursor("Test.png");
      
       }

       private void btnConfirmer_MouseLeave(object sender, EventArgs e)
        {
           this.Cursor = ancienneCursor;
        }

    }
}
