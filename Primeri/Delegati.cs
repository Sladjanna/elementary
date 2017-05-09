using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolniPrimeri
{
    class Delegati
    {
        delegate void Print(string patrametar);     //deklarisan delegat
        static public DateTime time;
        static void Main(string[] args)
        {
            Print guest1, guest2, guest3, guest4;
            string line = new String('-', 20);

            guest1 = new Print(LogIn);      //inicijalizacija delegata
            guest2 = new Print(LogOut);
            guest3 = guest1 + guest2;
            guest4 = guest3 - guest1;

            Console.WriteLine(line + Environment.NewLine);

            Console.WriteLine("Manuel Radovanovic is going to log in!" + Environment.NewLine);
            guest1("Manuel Radovanovic-1");
            Console.WriteLine(line);

            Console.WriteLine("Ella Napolis is going to log out!" + Environment.NewLine);
            guest2("Ella Napolis-2");
            Console.WriteLine(line);

            Console.WriteLine("Martine Moor is going to log in and log out!" + Environment.NewLine);
            guest3("Martine Moor-3");
            Console.WriteLine(line);

            Console.WriteLine("Charles Junger is going to log in and log out! But we need only time when loged out!" + Environment.NewLine);
            guest4("Charles Junger-4");
            Console.WriteLine(line);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }

        static void LogIn(string name)
        {
            time = DateTime.Now;
            Console.WriteLine(name + " is log in " + time + Environment.NewLine);

        }
        static void LogOut(string name)
        {
            time = DateTime.Now;
            Console.WriteLine(name + " is log out " + time + Environment.NewLine);

        }

    }
}
