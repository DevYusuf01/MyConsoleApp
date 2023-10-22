using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.obj
{
      public class PlayingWithList
{
    public void StudentScoreSheetWithList()
    {
        List<Subject> subjects = new List<Subject>();
        Console.Write("Enter no of subjects taken: ");
        int noOfSubjectTaken = int.Parse(Console.ReadLine()!);
        double totalScore = 0;
        double averageScore = 0;

        for (int i = 0; i < noOfSubjectTaken; i++)
        {
            Console.Write("Enter subject name: ");
            string subjectName = Console.ReadLine()!;

            Console.Write("Enter subject score: ");
            int subjectScore = int.Parse(Console.ReadLine()!);
            Subject subject = new(subjectName, subjectScore);

            subjects.Add(subject);
            totalScore += subjectScore;
        }
        averageScore += totalScore / noOfSubjectTaken;

        Console.WriteLine();

        foreach (var subject in subjects)
        {
            Console.WriteLine($"{subject._name}: {subject._score}");
        }

        Console.WriteLine();
        Console.WriteLine("Total Score {1}\nAverage Score: {0}", Math.Round(averageScore, 2), totalScore);
    }
}

public class Subject
{
    public string _name;
    public int _score;

    public Subject(string name, int score)
    {
        _name = name;
        _score = score;
    }
}  
    
}
