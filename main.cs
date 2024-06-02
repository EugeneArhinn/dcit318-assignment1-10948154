using System;

class Program 
{
    static void Main(string[] args)
    {
        Console.Write("Enter a numerical grade between 0 and 100: ");
        int grade = Convert.ToInt32(Console.ReadLine());

        if (grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid grade. Please enter a value between 0 and 100.");
            return;
        }

        char letterGrade;
        if (grade >= 90)
        {
            letterGrade = 'A';
        }
        else if (grade >= 80)
        {
            letterGrade = 'B';
        }
        else if (grade >= 70)
        {
            letterGrade = 'C';
        }
        else if (grade >= 60)
        {
            letterGrade = 'D';
        }
        else
        {
            letterGrade = 'F';
        }

        Console.WriteLine($"Your letter grade is: {letterGrade}");
        Console.ReadLine(); // wait for user to press Enter
    }
}
