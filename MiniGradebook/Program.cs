using System;

namespace MiniDiaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeDiary diary = new GradeDiary();
            bool isRunning = true;

            while (isRunning)
            {
                ShowMenu();
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        AddGrade(diary);
                        break;

                    case "2":
                        diary.PrintAllGrades();
                        break;

                    case "3":
                        diary.PrintAverage();
                        break;

                    case "4":
                        diary.PrintStats();
                        break;

                    case "5":
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("wrong");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("1 - add grade");
            Console.WriteLine("2 - show grades");
            Console.WriteLine("3 - average");
            Console.WriteLine("4 - stats");
            Console.WriteLine("5 - exit");
            Console.Write("choice: ");
        }

        static void AddGrade(GradeDiary diary)
        {
            Console.Write("grade: ");
            string gradeText = Console.ReadLine();

            int grade = int.Parse(gradeText);
            diary.AddGrade(grade);
        }
    }
}
