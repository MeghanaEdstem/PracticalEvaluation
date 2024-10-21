namespace PracticalEvaluation
{
    public class GradeSystem
    {
        private int[] grades = new int[30];

        public void Grading(int grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Append(grade);
            }
            else
            {
                Console.WriteLine("Grade must be between 0 and 100.");
            }
        }

        public double AverageOfGrade()
        {
            if (grades.Length == 0)
            {
                Console.WriteLine("Count of grades are never be 0");
            }
            double average = grades.Average();
            return average;
        }

        public int HighestGrade()
        {
            if (grades.Length == 0)
            {
                Console.WriteLine("Count of grades are never be 0");
            }
            int highestGrade = grades.Max();
            return highestGrade;
        }

        public int LowestGrade()
        {
            if (grades.Length == 0)
            {
                Console.WriteLine("Count of grades are never be 0");
            }
            int lowestGrade = grades.Min();
            return lowestGrade;
        }

        public void PassFailCount()
        {
            int passCount = 0;
            int failCount = 0;
            foreach (var grade in grades)
            {
                if (grade >= 50)
                {
                    passCount++;
                }
                else
                {
                    failCount++;
                }
            }
            Console.WriteLine("Number of students passed: " + passCount);
            Console.WriteLine("Number of students failed: " + failCount);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            GradeSystem gradeSystem = new GradeSystem();
            Console.WriteLine("Enter a grade (0-100): ");
            string? input = Console.ReadLine();
            gradeSystem.Grading(Convert.ToInt32(input));
            Console.WriteLine("Average: " + gradeSystem.AverageOfGrade());
            Console.WriteLine("Highest grade:" +  gradeSystem.HighestGrade());
            Console.WriteLine("Lowest grade: " + gradeSystem.LowestGrade());
            gradeSystem.PassFailCount();
        }
    }

}