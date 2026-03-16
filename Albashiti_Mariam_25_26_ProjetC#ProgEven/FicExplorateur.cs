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
    public partial class EcranExplorateur : Form
    {
        public EcranExplorateur()
        {
            InitializeComponent();
        }
        private void EcranExplorateur_Load(object sender, EventArgs e)
        {
            RemplirTreeView();
            // configuration du ListView
            lvFichiers.View = View.Details;
            lvFichiers.FullRowSelect = true;
            lvFichiers.GridLines = true; // optionnel, pour mieux voir les colonnes

            // ajouter les colonnes
            lvFichiers.Columns.Clear();
            lvFichiers.Columns.Add("NOM", 200);
            lvFichiers.Columns.Add("TAIL", 100);
            lvFichiers.Columns.Add("CREA", 110);
            lvFichiers.Columns.Add("MODI", 110);
        }
        private void RemplirTreeView()
        {
            tvRepertoire.Nodes.Clear();

            TreeNode racine = new TreeNode("Poste de travail");
            tvRepertoire.Nodes.Add(racine);

            string[] disques = Environment.GetLogicalDrives();

            foreach (string disque in disques)
            {
                TreeNode nodeDisque = new TreeNode(disque);
                // On ajoute un noeud fictif pour montrer la flèche + expansion
                nodeDisque.Nodes.Add("...");
                racine.Nodes.Add(nodeDisque);
            }

            racine.Expand();
        }

        private void LireRepertoires(TreeNode noeud, string chemin)
        {
            try
            {
                string[] repertoires = Directory.GetDirectories(chemin);

                foreach (string rep in repertoires)
                {
                    TreeNode nouveauNoeud = new TreeNode(Path.GetFileName(rep));
                    if (Directory.GetDirectories(rep).Length > 0)
                        nouveauNoeud.Nodes.Add("...");

                    noeud.Nodes.Add(nouveauNoeud);
                }
            }
            catch
            {
            }
        }
        private void lvFichiers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tvRepertoire_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode noeud = e.Node;

            if (noeud.Nodes.Count == 1 && noeud.Nodes[0].Text == "...")
            {
                noeud.Nodes.Clear();

                string chemin = GetFullPath(noeud);
                LireRepertoires(noeud, chemin);
            }
        }
        private string GetFullPath(TreeNode node)
        {
            if (node.Parent == null || node.Parent.Text == "Poste de travail")
                return node.Text;

            Stack<string> stack = new Stack<string>();
            TreeNode current = node;
            while (current != null && current.Text != "Poste de travail")
            {
                stack.Push(current.Text);
                current = current.Parent;
            }

            string chemin = stack.Pop();
            while (stack.Count > 0)
            {
                chemin = Path.Combine(chemin, stack.Pop());
            }

            return chemin;
        }
       
        private void LireFichiers(string chemin)
        {
            lvFichiers.Items.Clear();

            try
            {
                DirectoryInfo di = new DirectoryInfo(chemin);
                foreach (FileInfo fi in di.GetFiles())
                {
                    if ((fi.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                        continue;

                    ListViewItem item = new ListViewItem(fi.Name);
                    item.SubItems.Add((fi.Length / 1024.0).ToString("F2") + " KB");
                    item.SubItems.Add(fi.CreationTime.ToString());
                    item.SubItems.Add(fi.LastWriteTime.ToString());
                    lvFichiers.Items.Add(item);
                }
            }
            catch
            {
                // Dossiers proteges
            }
        }

        
        private void RecupererTousFichiers(string dossier, List<FileInfo> listeFichiers)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(dossier);
                listeFichiers.AddRange(di.GetFiles());
               
                foreach (DirectoryInfo sousDossier in di.GetDirectories())
                {
                    if ((sousDossier.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                        continue;

                    RecupererTousFichiers(sousDossier.FullName, listeFichiers);
                }
            }
            catch
            {
            }
        }
        private void tvRepertoire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode noeud = e.Node;
            if (noeud.Text == "Poste de travail") return;

            string chemin = GetFullPath(noeud);
            LireFichiers(chemin);
        }
        
        private string RecupererCheminComplet(TreeNode node)
        {
            
            if (node.Parent != null && node.Parent.Text == "Poste de travail")
                return node.Text;
            Stack<string> stack = new Stack<string>();
            TreeNode current = node;
            while (current != null && current.Text != "Poste de travail")
            {
                stack.Push(current.Text);
                current = current.Parent;
            }
            // combiner tous les morceaux pour obtenir le chemin complet
            string chemin = stack.Pop(); // commence par le disque, ex: "C:\"
            while (stack.Count > 0)
            {
                chemin = Path.Combine(chemin, stack.Pop());
            }

            return chemin;
        }
        private void LireDisques()
        {
            tvRepertoire.Nodes.Clear();

            TreeNode racine = new TreeNode("Poste de travail");
            tvRepertoire.Nodes.Add(racine);

            string[] disques = Environment.GetLogicalDrives();
            foreach (string disque in disques)
            {
                TreeNode nodeDisque = new TreeNode(disque);
                nodeDisque.Nodes.Add("...");
                racine.Nodes.Add(nodeDisque);
            }

            racine.Expand();
        }
        private void tsaPetitesIcones_Click(object sender, EventArgs e)
        {
            lvFichiers.View = View.SmallIcon;
        }

        private void tsaGrandesIcones_Click(object sender, EventArgs e)
        {
            lvFichiers.View = View.LargeIcon;
        }

        private void tsaListe_Click(object sender, EventArgs e)
        {
            lvFichiers.View = View.List;
        }

        private void tsaDetail_Click(object sender, EventArgs e)
        {
            lvFichiers.View = View.Details;
        }

    }
}
