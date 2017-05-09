using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolniPrimeri
{
    class ThrowException
    {
        static void Main(string[] args)
        {
            Exception myException = new Exception("Ne moze biti prazno");

            string x = "";

            // if (x == "") throw new Exception("Ne moze x biti prazan");
            if (x == "") throw myException;

            Console.ReadLine();
        }
    }
}
