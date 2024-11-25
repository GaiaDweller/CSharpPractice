using System;

class ConditionalStatementsExercise
{
    static void Main(string[] args)
    {
        // Task 1: Check for Even or Odd
        int number1 = 15;
        if (number1 % 2 == 0)
        {
            Console.WriteLine("number1 is Even.");
        }
        else
        {
            Console.WriteLine("number1 is Odd.");
        }
        // Use an if statement to check if 'number1' is even or odd.
        // Print a message indicating whether it's even or odd.
 

        // Task 2: Check for a Leap Year
        int year = 2024;
        if (year % 4 == 0)
        {
            if (year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("It is a Leap Year");
            }
            else
            {
                Console.WriteLine("Not a Leap year.");
            }
        }
        else
        {
            Console.WriteLine("Not a Leap Year");
        }
        // Use an if statement to check if 'year' is a leap year.
        // Print a message indicating whether it's a leap year or not.
 

        // Task 3: Determine the Largest Number
        int num1 = 25;
        int num2 = 30;
        if (num1 > num2)
        {
            Console.WriteLine(num1);
        }
        else
        {
            Console.WriteLine(num2);
        }
        // Use an if statement to determine which of 'num1' and 'num2' is larger.
        // Print the largest number.
   

 

        // Task 4: Check for Eligibility
        int age = 17;
        bool isStudent = true;
        if (age < 18 && isStudent)
        {
            Console.WriteLine("Eligable");
        }
        else
        {
            Console.WriteLine("Not Eligable");
        }
        // Use an if statement to check if a person is eligible for a student discount.
        // A person is eligible if their age is less than 18 and they are a student.
        // Print whether the person is eligible or not.


       }
   }