using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook gradeBook = new GradeBook();
            Console.WriteLine(gradeBook.Name); // powinno dac pusty string

            GradeBook secondBook = new GradeBook("Poziomka");
            Console.WriteLine(secondBook.Name);

        }
    }
}
