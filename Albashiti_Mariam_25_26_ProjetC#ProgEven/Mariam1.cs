namespace Albashiti_Mariam_25_26_ProjetC_ProgEven
{
    public partial class Mariam1 : Form
    {
        public Mariam1()
        {
            InitializeComponent();
            this.Size = new Size(800, 600);
            this.MaximizeBox = false;
            this.MaximizeBox = false;
            lblTest.AutoSize = true;
            lblTest.Size = new Size(200, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Mariam1_Load(object sender, EventArgs e)
        {
            lblTest.AutoSize = true;
            lblTest.Size = new Size(200, 50);
            lblTest.Location = new Point(50, 30);
            int largeurGroupe = Math.Max(lblTest.Width, btnName.Width);

            lblTest.Left = (this.ClientSize.Width - lblTest.Width) / 2;
            btnName.Left = (this.ClientSize.Width - btnName.Width) / 2;
        }

        private void btnName2_Click(object sender, EventArgs e)
        {
            EcranPrincipale fenetre2 = new EcranPrincipale();
            fenetre2.Show();
            //réaliser l'instanciation 
            //EcranPrincipale maFenetre = new EcranPrincipale();
            //maFenetre.Show();
        }
    }
}
