using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolniPrimeri
{
    class Interfejs
    {
    }

    class MyFirstClass
    {
        public int age = 14;
        public string name = "Mira";
        private int jmbg = 1234;          //ne moze se naslediti
        protected int broj = 5;         // PROTECTED moze se koristiti samo u klasi naslednici

        public void poruka1()
        {
            Console.WriteLine(name);
        }
    }

    class MySecondClass : MyFirstClass,IPrimerInterfejsa
    {
        public int cipele = 46;
        public int patike = 33;

        public void poruka2()
        {
            base.age = 110 * broj;   //BASE je klasa koju nasledjuje
        }

        public new void poruka1()
        {              //OVERRIDE method!!!!!    NEW je obavezno!!!!!
            Console.WriteLine("Sada ce ispisati nesto drugo jer je method overridovan");

        }

        public void ispisi()
        {
            Console.WriteLine("Ovo je poruka iz metode nasledjene preko INTERFEJSA");
        }
    }

    interface IPrimerInterfejsa
    {
        void ispisi();
    }

    class Glavna1
    {
        static void Main(string[] args)
        {
            MySecondClass objekat = new MySecondClass();
            objekat.poruka1();
            objekat.poruka2();      //ovde promeni vrednost

            Console.WriteLine(objekat.age.ToString());      //ispisuje novu vrednost
            objekat.ispisi();
            Console.ReadLine();
        }
    }

}
