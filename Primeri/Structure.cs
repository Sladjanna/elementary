using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolniPrimeri
{
    struct FullName1        //koristi samo varijable
    {
        public string FirstName;
        public string LastName;

    }
    struct FullName2            //koristi varijable i metodu
    {
        public string FirstName;
        public string LastName;

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
    struct FullName3        //koristi varijable, metodu i konstruktor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public FullName3(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }
        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }


    class Structure
    {
        static void Main(string[] args)
        {
            bool correct = false;
            string firstName, lastName;

            do
            {
                Console.WriteLine("Your first name: ");
                firstName = Console.ReadLine();

            } while (correct = String.IsNullOrWhiteSpace(firstName));

            do
            {
                Console.WriteLine("Your last name: ");
                lastName = Console.ReadLine();

            } while (correct = String.IsNullOrWhiteSpace(lastName));

            FullName1 fullName1;
            fullName1.FirstName = firstName;
            fullName1.LastName = lastName;

            Console.WriteLine($"\nYour full name through the structure with only variables.\n{fullName1.FirstName}{fullName1.LastName}");
            Console.WriteLine();

            FullName2 fullName2 = new FullName2();
            fullName2.FirstName = firstName;
            fullName2.LastName = lastName;

            Console.WriteLine($"\nYour full name through the structure with variables and a method.\n{fullName2.FullName()}");
            Console.WriteLine();

            FullName3 fullName3 = new FullName3(firstName, lastName);

            Console.WriteLine($"\nYour full name through the structure with variables,a constructor and a method.\n{fullName3.FullName()}");

            Console.ReadKey();
        }
    }
}