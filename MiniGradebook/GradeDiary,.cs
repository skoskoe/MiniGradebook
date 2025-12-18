using System;
using System.Collections.Generic;

namespace MiniDiaryApp
{
    class GradeDiary
    {
        private List<int> grades = new List<int>();

        private const int MinGrade = 2;
        private const int MaxGrade = 6;

        public void AddGrade(int grade)
        {
            grades.Add(grade);
            Console.WriteLine("added.");
        }

        public void PrintAllGrades()
        {
            Console.WriteLine("grades:");

            for (int i = 0; i < grades.Count; i++)
            {
                Console.WriteLine($"g[{i}]={grades[i]}");
            }
        }

        public void PrintAverage()
        {
            if (grades.Count == 0)
            {
                Console.WriteLine("avg=0");
                return;
            }

            int sum = 0;

            foreach (var grade in grades)
            {
                sum += grade;
            }

            double avg = (double)sum / grades.Count;
            Console.WriteLine("avg=" + avg);
        }

        public void PrintStats()
        {
            int[] gradeCounters = new int[MaxGrade + 1];

            foreach (var grade in grades)
            {
                if (grade >= MinGrade && grade <= MaxGrade)
                {
                    gradeCounters[grade]++;
                }
            }

            for (int i = MinGrade; i <= MaxGrade; i++)
            {
                Console.WriteLine($"{i}: {gradeCounters[i]}");
            }

            int total = grades.Count;

            if (total > 0)
            {
                int fails = gradeCounters[MinGrade];
                Console.WriteLine("fail%=" + (fails * 100 / total));
                Console.WriteLine("pass%=" + ((total - fails) * 100 / total));
            }
        }
    }
}
