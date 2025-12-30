using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// EduQuiz class simulates a console-based C# assessment system.
/// It displays a set of True/False questions, collects student responses,
/// evaluates each answer using case-insensitive string comparison,
/// calculates the total percentage score, and determines whether
/// the student has passed or failed the assessment based on the score.
/// </summary>
namespace BridgeLabzTraining.scenario_based
{
    internal class EduQuiz
    {
        public void Results()
        {
            Console.WriteLine("Welcome To Your C# Assessment ");
            Console.WriteLine();
            // Here are the Set of Questions which are to be asked in Assessmnet
            string[] questions =
{
    "C# is a case-sensitive language. (True/False)",
    "String is a value type in C#. (True/False)",
    "Strings in C# are immutable. (True/False)",
    "The == operator can be used to compare strings in C#. (True/False)",
    "StringBuilder is mutable. (True/False)",
    "C# supports multiple inheritance using classes. (True/False)",
    "Length is a property of the string class. (True/False)",
    "Null and empty string are the same. (True/False)",
    "ToUpper() changes the original string. (True/False)",
    "string.Equals() can compare strings ignoring case. (True/False)"
};
            Console.WriteLine();
            Console.WriteLine("Here Are Your Questions For Assessment");
            for(int i=0;i<questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
            }
            // Making an array to store correct answer

            string[] correctAnswer ={ "True", "False","True","True","True","False","True", "False", "False","True"};
            // Intalizing a Student Array where Students will Write There Answers

            string[] studentAnswer = new string[correctAnswer.Length];
            Console.WriteLine();
            Console.WriteLine("Enter Your Anwsers Here");
            for (int i = 0; i < correctAnswer.Length; i++)
            {
                studentAnswer[i] = Console.ReadLine();
            }
            DisplayAnswer(correctAnswer, studentAnswer);
            double percent = Percentage(correctAnswer, studentAnswer);
            Console.WriteLine(" The Total Percentage of Student is " + percent);
            if(percent>=50.0)
            {
                Console.WriteLine("Student has Passed The Assessment");
            }
            else
            {
                Console.WriteLine("Student has Failed The Assessment ");
            }
        }
         // Method to display wheather student's answer is wrong or right

        public void DisplayAnswer(string[] correct, string[] student)
        {
            for (int i = 0; i < correct.Length; i++)
            {
                bool result = string.Equals(correct[i], student[i], StringComparison.OrdinalIgnoreCase);
                if (result)
                {
                    Console.WriteLine("The  Answer to Question " + (i + 1) + " is " + "Correct");
                }
                else
                {
                    Console.WriteLine("The  Answer to Question " + (i + 1) + " is " + "InCorrect");
                }
            }
        }
        // Method to calculate the Percentage of the Student 

        public double Percentage(string[] correct, string[] student)
        {
            int right = 0;
            for (int i = 0; i < correct.Length; i++)
            {
                bool result = string.Equals(correct[i], student[i], StringComparison.OrdinalIgnoreCase);
                if (result)
                {
                    right++;
                }
            }
            double percent = ((double)right/correct.Length)*100.0;
            return percent;
        }
    }
}
