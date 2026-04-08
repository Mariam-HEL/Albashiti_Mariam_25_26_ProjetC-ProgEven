using System;
using System.Threading;
using System.Windows.Input;
namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread threadA = new Thread(A);
            Thread threadB = new Thread(B);

            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            Console.WriteLine($"\n\niCommun final = {iCommun}");
            Console.WriteLine("Fin du programme !");
            Console.ReadKey();
        }
        const int N = 500;
        static int iCommun = 0;
        static object verrou = new object();

        static void A()
        {
            for (int i = 0; i < N; i++)
            {
                lock (verrou)
                {
                    Console.Write($"A{iCommun}");
                    iCommun++;
                }
            }
        }

        static void B()
        {
            for (int i = 0; i < N; i++)
            {
                lock (verrou)
                {
                    Console.Write($"B{iCommun}");
                    iCommun++;
                }
            }
        }
    }
}
