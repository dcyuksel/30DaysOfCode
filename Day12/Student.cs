namespace Day12
{
    using System.Linq;

    public class Student : Person
    {
        private int[] testScores;

        public Student(string firstName, string lastName, int identification, int[] testScores)
        {
            id = identification;
            this.lastName = lastName;
            this.firstName = firstName;
            this.testScores = testScores;
        }

        public char Calculate()
        {
            var averageGrade = GetAverage();

            if (averageGrade<=100 && averageGrade >= 90)
            {
                return 'O';
            }
            if (averageGrade < 90 && averageGrade >= 80)
            {
                return 'E';
            }
            if (averageGrade < 80 && averageGrade >= 70)
            {
                return 'A';
            }
            if (averageGrade < 70 && averageGrade >= 55)
            {
                return 'P';
            }
            if (averageGrade < 55 && averageGrade >= 40)
            {
                return 'D';
            }

            return 'T';
        }

        private int GetAverage()
        {
            return (int)testScores.Average();
        }
    }
}
