namespace GradeBook
{
    internal class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
        public float HighestGrade { get; set; }
        public float LowestGrade { get; set; }
        public float AverageGrade { get; set; }

        public char LetterGrade
        {
            get
            {
                char result;
                if (AverageGrade>=90 )
                {
                    result = 'A';
                }
                else if (AverageGrade >= 80)
                {
                    result = 'B';
                }
                else if (AverageGrade >= 70)
                {
                    result = 'C';
                }
                else if (AverageGrade >=60)
                {
                    result = 'D';
                }
                else
                {
                    result = 'E';
                }
                return result;
            }
            
            //set; // readonly property
        }

        public string Description
        {
            get
            {
                string result;

                switch (LetterGrade)
                {
                    case 'A':
                        result = "Excelent";
                        break;
                    case 'B':
                        result = "Good";
                        break;
                    case 'C':
                        result = "Average";
                        break;
                    case 'D':
                        result = "Poor";
                        break; 
                    default:
                        result = "Failed";
                        break;
                }
                return result;
            }
        }
    }
}