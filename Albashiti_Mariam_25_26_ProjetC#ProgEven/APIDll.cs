using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Albashiti_Mariam_25_26_ProjetC_ProgEven
{
    public partial class APIDll : Form
    {
        private const int smLire = 0x0199;
        private const int smEcrire = 0x019A;

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public APIDll()
        {
            InitializeComponent();
        }


        private void APIDll_Load(object sender, EventArgs e)
        {

        }
    }
}
