using System;
using System.Diagnostics;

namespace GestionProcessus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Récupérer le processus actuel
            Process processusCourant = Process.GetCurrentProcess();

            // Chercher si un autre processus du même nom tourne déjà
            Process[] processus = Process.GetProcessesByName(processusCourant.ProcessName);

            if (processus.Length > 1)
            {
                Console.WriteLine("Une instance de ce programme est déjà en cours d'exécution !");
                Console.WriteLine("Appuyez sur une touche pour quitter...");
                Console.ReadKey();
                return; // On quitte immédiatement
            }

            Console.WriteLine("Aucune autre instance détectée, le programme démarre !");
            Console.WriteLine("Appuyez sur une touche pour quitter...");
            Console.ReadKey();
            int choix;


            do
            {
                Console.WriteLine("========Seance 13==========");
                Console.WriteLine("Choissisez votre choix stp");
                Console.WriteLine("1.Lancer le bloc note");
                Console.WriteLine("2.Lancer PgmSecondaire");
                //Console.WriteLine("3.Devoir");
                Console.WriteLine("3.Exit");

                choix = int.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        Lance_Bloc_Note();
                        break;
                    case 2:
                        PgmSecondaire();
                        break;
                    //case 3:
                    //    Devoir();
                    //    break;
                    case 3:
                            System.Environment.Exit(1);
                            break;
                        default:
                            Console.WriteLine("Invalid choix");
                            break;
                        }
            }while(choix != 4);
            
        }
        public static void Lance_Bloc_Note()
        {
            Console.WriteLine("Lancement du bloc-note...");

            // Déclaration d'un objet Process
            Process monProcess = new Process();
            monProcess.StartInfo.FileName = "notepad.exe";
            monProcess.Start();

            Console.WriteLine("Bloc-note ouvert. Appuyez sur une touche pour quitter...");
            Console.ReadKey();

            // Fermeture du bloc-note s'il est encore actif
            if (!monProcess.HasExited)
            {
                monProcess.CloseMainWindow(); // fermeture propre
                monProcess.WaitForExit();
                Console.WriteLine("Bloc-note fermé.");
            }

            // Temps d'exécution
            TimeSpan duree = monProcess.ExitTime - monProcess.StartTime;
            Console.WriteLine($"Temps d'exécution du bloc-note : {duree.TotalSeconds:F2} secondes");

            Console.WriteLine("Fin du programme. Appuyez sur une touche...");
            Console.ReadKey();
        }
        public static void PgmSecondaire()
        {
            Console.WriteLine("=== Lancement de PgmSecondaire ===");

            Process p = new Process();
            p.StartInfo.FileName = @"D:\projet_programmation_C#_B2Q2\note\PgmSecondaire\bin\Debug\net8.0\PgmSecondaire.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            // Envoyer nom et prénom
            p.StandardInput.WriteLine("Dupont");
            p.StandardInput.WriteLine("Jean");

            // Récupérer la réponse
            string reponse = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            Console.WriteLine("Réponse de PgmSecondaire : " + reponse);
            Console.WriteLine("Appuyez sur une touche...");
            Console.ReadKey();
        }

        public static void Devoir()
        {
            
        }
    }
}
