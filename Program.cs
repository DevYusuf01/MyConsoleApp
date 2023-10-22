// See https://aka.ms/new-console-template for more information

// Firstname
// Lastname
// Age
//Location
// Fav color
// Hobby


/*Console.WriteLine("Enter your firstname: ");
string firstname = Console.ReadLine()!;

Console.WriteLine("Enter your lastname: ");
string lastname = Console.ReadLine()!;

Console.WriteLine("Enter your age: ");
string input = Console.ReadLine()!;
int age = Convert.ToInt32(input);

Console.WriteLine("Enter your location of residence: ");
string location = Console.ReadLine()!;

Console.WriteLine("What is your favourite color: ");
string favouritecolor = Console.ReadLine()!;

Console.WriteLine("What are your hobbies: ");
string hobby = Console.ReadLine()!;

string composition = "My name is " + firstname + " " + lastname + ". I am " + age + ". I am from " + location + ". My favorite color is " + favouritecolor + ". I love " + hobby +" ";
string compositionWithInterpolation = $"My name is {firstname} {lastname}, I am {age} years old. I live in {location}. My favorite color is {favouritecolor}. I love {hobby}.";

int textcount = composition.Length;
int indexing = composition.IndexOf('M');

Console.WriteLine(Environment.NewLine);
Console.WriteLine(composition);
Console.WriteLine(compositionWithInterpolation);
Console.WriteLine("composition text count: {0} M is at index {1}", textcount, indexing);
Console.WriteLine(Environment.NewLine);
*/

/* 
Arithmetic - +, -, /, *, %,
Assignment - =, +=, -=, *=, %=, /=
Comparision - <, >, ==, <=, >=, !=
Logical - &&, ||, !
Conditonal/Tenary - 2 == 1 ? true : false, 
Null operators -  ?(Nulable), ??(Null Coalescing Operator), !(Null Forgiving operator) 
Increment - ++
Decrement - -
*/


/*Console.WriteLine(2>1 && 17>4);
int a = 3;
Console.WriteLine(a += 5);
*/
/*
Console.Write("Enter a string literal: ");
string? a = Console.ReadLine();
int b = a!.Length;
string c = a ?? "No value returned";
Console.WriteLine($"string lenght: {b}");
Console.WriteLine($"Variable c: {c}");
*/
//int? d = null;

/*int e = d ?? 100;
Console.WriteLine($"Variable e: {e++}");
Console.WriteLine($"Variable e: {e++}");

Console.WriteLine(2 + 70 / 10);*/
using System.Runtime.CompilerServices;

class Program
{
static void Main()
{
    Console.Title = "Student Score Sheet";
    Console.Write("Enter the number of subjects taken: ");
    int noOfSubjectsTaken = int.Parse(Console.ReadLine()!);
    int[] scores = new int[noOfSubjectsTaken];
    string[] subjectNames = new string[noOfSubjectsTaken];
    double totalScore = 0;
    double averageScore = 0;

  for (int i = 0; i < noOfSubjectsTaken; i++)  
  {
    Console.Write($"Enter your subject name: ");
    subjectNames[i] = Console.ReadLine()!;

    Console.Write($"Enter score for {subjectNames[i]}: ");
    scores[i] = int.Parse(Console.ReadLine()!);

    totalScore += scores[i];
  }


Console.WriteLine();

averageScore += totalScore / noOfSubjectsTaken;
Console.WriteLine("Average Score: {0}\nTotal Score {1}", averageScore, totalScore);
}

}