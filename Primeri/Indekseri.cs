using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//INDEKSERI se koriste kod private nizova da im se postavi properti kako kao geteri i seteri

namespace konzolniPrimeri
{
    class Indekseri
    {
        public string this[int index]
        {
            get { return MyArray[index]; }
            set { MyArray[index] = value; }
        }

        string[] MyArray = { "Adam", "Eva", "Joe" };
    }

    class MyClass27
    {
        static void Main(string[] args) {
            Indekseri ob = new Indekseri();
            ob[1] = "Maria";            //promena vrednosti
            Console.WriteLine(ob[1]);       //Maria

            Console.ReadKey();
       }
    }



}
