using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//punjenje generičke liste studenata

namespace konzolniPrimeri
{
    class Indexers
    {
    }

    class Student
    {
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public byte Age { get; set; }       
    }
    class University
    {
        private List<Student> listStudents;    //lista studenata će sadržavati objekte tipa Student

        public University()
        {
            listStudents = new List<Student>();     //umesto podataka u nekoj datoteci ili bazi podataka, jednostavno smestiti podatke o studentima 
                                                    //u našu listu u konstruktoru klase University
            listStudents.Add(new Student { StudentID = 1, FullName = "Manuel Radovanovic", Gender = "Male", Age = 40 });
            listStudents.Add(new Student { StudentID = 2, FullName = "Burton Skinner", Gender = "Male", Age = 45 });
            listStudents.Add(new Student { StudentID = 3, FullName = "Erica Hopper", Gender = "Female", Age = 36 });
            listStudents.Add(new Student { StudentID = 4, FullName = "Matthew Robinson", Gender = "Male", Age = 24 });
            listStudents.Add(new Student { StudentID = 5, FullName = "Allison Harvey", Gender = "Female", Age = 24 });
        }
        public string this[int StudentID]
        {
            get
            {
                return listStudents.FirstOrDefault(st => st.StudentID == StudentID).FullName;
            }
            set
            {
                listStudents.FirstOrDefault(st => st.StudentID == StudentID).FullName = value;
            }
        }

        public string this[string Gender] => listStudents.Count(st => st.Gender == Gender).ToString();
         }

    class MyIndexers
    {
        static void Main(string[] args)
        {
            University university = new University();

            Console.WriteLine("All students at the univesity:");
            Console.WriteLine(new String('-', 20));

            for (byte i = 1; i < 6; i++)
            {
                Console.WriteLine(university[i]);

            }

            Console.WriteLine(new String('-', 20));

            Console.WriteLine("Changed the name of Index 2:");
            university[2] = "Bill Gates";
            Console.WriteLine(university[2]);

            Console.WriteLine(new String('-', 20));

            Console.WriteLine("Total Male Students: " + university["Male"]);
            Console.WriteLine("Total Female Students: " + university["Female"]);

            Console.ReadKey();
        }
    }
}
