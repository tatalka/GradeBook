using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Gradebook
    {
        public Gradebook()
        {

        }

        List<float> grades = new List<float>();

        internal void AddGrade(float v)
        {
            grades.Add(v);
        }

        internal float GiveMaxValue()
        {
            return grades.Max();
        }
    }
}
