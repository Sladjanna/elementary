using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolniPrimeri
{
    class Delegati_2
    {
        private int var;
        public int Var
        {
            get { return var; }

        }
        public static void Funk1(int x)
        {
            Console.WriteLine("Pozvana je prva funkcija(metoda) {0}", x);
        }
        public static void Funk2(int x)
        {
            Console.WriteLine("Pozvana je druga funkcija(metoda) {0}", x);
        }
        public void Funk3(int x)
        {
            Console.WriteLine("Pozvana je treća funkcija(metoda) {0}", x + var);
        }
        public Delegati_2() { }
        public Delegati_2(int x)
        {
            this.var = x;
        }
    }
    class DelegatiGlavni
    {
        public delegate void Deleg(int vrijednost);       //ovdje deklariramo delegat Deleg

        static void Main(string[] args)
        {
            Deleg del = new Deleg(Delegati_2.Funk1);    //ovdje stvaramo delegat del koji pokazuje na prvu funkciju 
            del(5);

            Console.WriteLine("-----------------------------------------");
            del += new Deleg(Delegati_2.Funk2);     //ovdje samo dodajemo na drugu funkciju
            del(16);

            Console.WriteLine("----------------------------------------");
            Delegati_2 o = new Delegati_2(10);  //da bismo pristupili trećoj funkciji moramo stvoriti (instancu)
            Deleg del2 = new Deleg(o.Funk3);    //objekt o  preko kojeg pristupamo trećoj metodi.
            del += del2;                  
            del(23);

            Console.WriteLine("---------------------------------------");
            del -= new Deleg(Delegati_2.Funk1);
            del(2345);
            Console.ReadKey();
        }
    }
}
