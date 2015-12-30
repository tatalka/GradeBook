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

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(stats.LetterGrade);

            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged2;

            book.Name = "olew's book";
            //Writenames(book.Name);

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
