using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolniPrimeri
{
    class ExceptionPrimer
    {
        static void Main(string[] args)
        {
            List<double> run1 = new List<double>();
            List<double> run2 = new List<double>();

            for (int runs = 0; runs <= 10; runs++)
            {
                Stopwatch timer = new Stopwatch();

                try
                {
                    timer.Start();
                    for (int i = 0; i <= 10000; i++)
                    {
                        //Thread.Sleep(1);
                        if (i == 50)
                        {
                            throw new FileNotFoundException();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception");
                }
                timer.Stop();
                Console.WriteLine("End of run1: " + timer.ElapsedMilliseconds + " ms");
                run1.Add(timer.ElapsedMilliseconds);

                timer = new Stopwatch();

                try
                {
                    timer.Start();
                    for (int i = 0; i <= 10000; i++)
                    {
                        //Thread.Sleep(1);
                        if (i == 50)
                        {
                            throw new FileNotFoundException();
                        }
                    }
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("FileNotFoundException");
                }
                timer.Stop();
                Console.WriteLine("End of run2: " + timer.ElapsedMilliseconds + " ms");
                run2.Add(timer.ElapsedMilliseconds);
            }

            var avrg1 = run1.Average();
            var avrg2 = run2.Average();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Average for run1: " + avrg1);
            Console.WriteLine("Average for run2: " + avrg2);
            Console.ReadKey();
        }
    }
}
