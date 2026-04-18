namespace Albashiti_Mariam_25_26_ProjetC_ProgEven
{
    public partial class Mariam1 : Form
    {
        public Mariam1()
        {
            InitializeComponent();
            this.Size = new Size(800, 600);
            lblTest.AutoSize = true;
            lblTest.Size = new Size(200, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }


        }

        private void Mariam1_Load(object sender, EventArgs e)
        {
            lblTest.AutoSize = true;
            lblTest.Size = new Size(200, 50);
            // lblTest.Location = new Point(50, 30);
            //int largeurGroupe = Math.Max(lblTest.Width, btnName.Width);

            //lblTest.Left = (this.ClientSize.Width - lblTest.Width) / 2;
            // btnName.Left = (this.ClientSize.Width - btnName.Width) / 2;
            //centerPicture(pictureBox1);
            //centerPicture(pictureBox2);
        }

        private void btnName2_Click(object sender, EventArgs e)
        {
            EcranPrincipale fenetre2 = new EcranPrincipale();
            fenetre2.ShowDialog();
            //réaliser l'instanciation 
            //EcranPrincipale maFenetre = new EcranPrincipale();
            //maFenetre.Show();
        }

        private void btnDisp_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = !pictureBox1.Visible;
        }
        //private void centerPicture(PictureBox pic)
        //{
        //    pic.Top = (this.ClientSize.Height - pic.Height) / 2;
        //    pic.Left = (this.ClientSize.Width - pic.Width) / 2;
        //}

        private void Mariam1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Voulez vous vraiment fermner cette fenetre ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        bool isImage = true;
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (isImage)
            {
                pictureBox3.Image = Properties.Resources.w6ELgf;
                pictureBox4.Image = Properties.Resources._23cdab71a92f974b684233d262795f28;

            }
            else
            {
                pictureBox3.Image = Properties.Resources._23cdab71a92f974b684233d262795f28;
                pictureBox4.Image = Properties.Resources.w6ELgf;
            }
            isImage = !isImage;
            //Image temp = pictureBox3.Image;
            //pictureBox3.Image = pictureBox4.Image;
            //pictureBox4.Image = temp;
        }

        private void lblTest_Click(object sender, EventArgs e)
        {

        }

        private void btnSeance2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void btnSeance3_Click(object sender, EventArgs e)
        {
            EcranListe ecran = new EcranListe();
            ecran.ShowDialog();
        }

        private void btnSeance5_Click(object sender, EventArgs e)
        {
            EcranEditeur eD = new EcranEditeur();
            eD.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FicSpirographe fs = new FicSpirographe();
            fs.ShowDialog();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            EcranClavierSouris cs = new EcranClavierSouris();
            cs.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EcranExplorateur eW = new EcranExplorateur();
            eW.ShowDialog();
        }

        private void EcranIntegration_Click(object sender, EventArgs e)
        {
            EcranIntegration Ei = new EcranIntegration();
            Ei.ShowDialog();
        }
    }
}
