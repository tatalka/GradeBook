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
            GradeBook book = new GradeBook("Scott's Book");
            book.AddGrade(91f);
            book.AddGrade(89.1f);
            book.AddGrade(75f);

            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("{0} {1}",stats.LetterGrade, stats.Description);

            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged2;
            
            try
            {
                book.Name = "";
            }
            catch (Exception)
            {
                Console.WriteLine("zlapalem exception");
            }

            Console.WriteLine();
        }

        private static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("Name changed from {0} to {1}", args.OldValue, args.NewValue);
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("cos innego {0}", args.ToString());
        }
    }
}
