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
            Gradebook gradeBook = new Gradebook();

            gradeBook.AddGrade(13.4f);
            gradeBook.AddGrade(13.1f);
            Console.WriteLine(gradeBook.GiveMaxValue());

            Console.WriteLine();
        }
    }
}
