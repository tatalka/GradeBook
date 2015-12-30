using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
            Name = "default_name";
        }
        public GradeBook(string GradeBookName)
        {
            grades = new List<float>();
            Name = GradeBookName;
        }

        public void WriteGrades(TextWriter @out)
        {
            @out.WriteLine("Here comes the grades:");
            foreach (var grade in grades)
            {
                @out.WriteLine(grade);
            }
        }

        public void AddGrade (float grade)
        {
            if (grade >= 0 && grade <100)
            {
                grades.Add(grade);
            }
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            
                stats.HighestGrade = grades.Max();
                stats.LowestGrade = grades.Min();
                stats.AverageGrade = grades.Average();

            return stats;
        }

        private string _name;
        public string Name
        {
            get
            {return _name; }
            set
            {
                if (_name != value)
                {
                    var oldValue = _name;
                    _name = value;
                    if (String.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("empty name given!");
                    }
                    if (NameChanged!=null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.OldValue = oldValue;
                        args.NewValue = value;
                        NameChanged(this, args);
                    }
                }
            }
        }
        public event NamedChangedDelegate NameChanged;
        private List<float> grades;
    }
}
