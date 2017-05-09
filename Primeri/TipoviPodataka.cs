using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolniPrimeri
{
    class TipoviPodataka
    {
        static void Main(string[] args)
        { 
        double xD = 1234.5678;
        double yD = xD + 0.0001;
        Console.WriteLine(xD);           //1234.5678
        Console.WriteLine(yD);           //1234.5679

        float xF = 1234.5678f;
        float yF = xF + 0.0001f;
        Console.WriteLine(xF);      //1234.568
        Console.WriteLine(yF);      //1234.568

        double x = 1234.5678;
        double y = x + 0.0001;
        float impreciseSum = (float)(x + y);
        Console.WriteLine(impreciseSum);        //2469.136
        }
}
}
