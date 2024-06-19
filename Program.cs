using System;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;

namespace EvaluateGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many grades you want to input: ");
            int numberOfGrades = Convert.ToInt16(Console.ReadLine());

            double[] grades = new double[numberOfGrades];

            GradeChecker(grades);

            Console.WriteLine("END OF USER INPUT");
            Console.WriteLine("PROCESSING GRADES....");

            double average = Average(grades);

            Console.WriteLine($"Your Average Grade is: {Average(grades)}, {Remarks(average)}.");
        }
        public static void GradeChecker(double[] grades)
        {
            for (int counter = 0; counter < grades.Length; counter++)
            {
                Console.Write("Input grade: ");
                double grade = Convert.ToInt16(Console.ReadLine());

                if (grade > 0 && grade <= 100)
                {
                    grades[counter] = grade;
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                    counter --;
                }
            }
        }
        public static double Sum(double[] grades)
        {
            double sum = 0;
            for (int counter = 0; counter < grades.Length; counter++)
            {
                sum = sum + grades[counter];
            }
            return sum;
        }
        public static double Average(double[] grades )
        {
            double sum = Sum(grades);
            double average = sum / grades.Length;

            return average;
        }
        public static string Remarks(double average)
        {

            string message = average <= 50 ? "YOU FAILED" :
                             average > 50 && average <= 70 ? "FAIR" :
                             average > 70 && average <= 80 ? "GOOD" :
                             average > 80 && average <= 90 ? "VERY GOOD" :
                             average > 90 && average <= 100 ? "EXCELLENT" : "";
            return message;
        }
    }
}