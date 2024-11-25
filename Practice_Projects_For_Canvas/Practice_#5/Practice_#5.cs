using System;


class StringManipulationExercise
{
    static void Main(string[] args)
    {
        // Task 1: Concatenate Strings
        string firstName = "John";
        string lastName = "Doe";
        
        // Combine the 'firstName' and 'lastName' to create a full name.
        // Print the full name to the console.
        // Hint: Use string concatenation or interpolation.
        Console.WriteLine($"{firstName} {lastName}");

        // Task 2: Uppercase and Lowercase
        string text = "This is a sample text.";
        string upper = text.ToUpper();
        string lower = text.ToLower();
        // Convert 'text' to uppercase and store it in a new variable.
        // Convert 'text' to lowercase and store it in another new variable.
        // Print both the uppercase and lowercase versions.
        Console.WriteLine($"Upper: {upper} \nLower: {lower}");


        // Task 3: Substring
        string sentence = "The quick brown fox jumps over the lazy dog.";
        string substring = sentence.Substring(10, 5);
        Console.WriteLine(substring);
        // Extract the word "brown" from 'sentence' and store it in a new variable.
        // Print the extracted word.


        // Task 4: Replace
        string originalString = "C# is a popular programming language.";
        string originalString2 = originalString.Replace("C#", "CSharp");
        Console.WriteLine(originalString2);
        // Replace "C#" with "CSharp" in 'originalString'.
        // Print the modified string.


        // Task 5: String Length
        string someText = "This is a random piece of text.";
        Console.WriteLine($"{someText.Length}");
        // Calculate and print the length (number of characters) of 'someText'.

        }
    }