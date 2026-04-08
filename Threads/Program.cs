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
        static Mutex mutex = new Mutex();

        static void A()
        {
            for (int i = 0; i < N; i++)
            {
                mutex.WaitOne();
                try
                {
                    Console.Write($"A{iCommun}");
                    iCommun++;
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
        }

        static void B()
        {
            for (int i = 0; i < N; i++)
            {
                mutex.WaitOne();
                try
                {
                    Console.Write($"B{iCommun}");
                    iCommun++;
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
        }
    }
}
