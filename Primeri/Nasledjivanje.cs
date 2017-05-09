using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolniPrimeri
{
    class Nasledjivanje
    {

    }
    class Klasa1
    {
        public int age = 14;
        public string name = "Mira";
        private int jmbg = 1234;
        protected int broj = 5;         // PROTECTED moze se koristiti samo u klasi naslednici

        public void poruka1()
        {
            Console.WriteLine(name);
        }
    }

    class Klasa2 : Klasa1
    {
        public int cipele = 46;
        public int patike = 33;

        public void poruka2()
        {
            base.age = 100 * broj;   //BASE je klasa koju nasledjuje
        }

        public new void poruka1()
        {              //OVERRIDE method!!!!!    NEW je obavezno!!!!!
            Console.WriteLine("Sada ce ispisati nesto drugo jer je method overridovan");

        }
    }
        class Glavna
        {
            static void Main(string[] args)
            {
                Klasa2 objekat = new Klasa2();
                objekat.poruka1();
                objekat.poruka2();      //ovde promeni vrednost

                Console.WriteLine(objekat.age.ToString());      //ispisuje novu vrednost
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }

