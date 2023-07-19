using System;

namespace Lab_1
{
    class Lab1
    {
        static void Main(string[] args)
        {
            // Create a string variable for use later
            int name;

            // Display a prompt to the user
            Console.Write("What is your name? ");

            // Capture the user's response
            name = int.Parse(Console.ReadLine());

            // Display a string literal combined with the value of the string variable
            // What does the "\n" do?

            Console.Write("Hello " + name + "\n");

            // Waits for the user to press a key
            // Allows us to read what was displayed
            Console.Write("Thank you for running my first lab! Press any key to end the application");
            Console.Read();

        }
    }
}
