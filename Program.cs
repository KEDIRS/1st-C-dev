using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter two numbers
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to choose an operation
        Console.WriteLine("Choose an arithmetic operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Division");
        Console.WriteLine("4. Multiplication");
        Console.Write("Enter your choice (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        // Perform the chosen operation using a switch block
        switch (choice)
        {
            case 1:
                Console.WriteLine($"The result of addition is: {number1 + number2}");
                break;
            case 2:
                Console.WriteLine($"The result of subtraction is: {number1 - number2}");
                break;
            case 3:
                if (number2 != 0)
                {
                    Console.WriteLine($"The result of division is: {number1 / number2}");
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                break;
            case 4:
                Console.WriteLine($"The result of multiplication is: {number1 * number2}");
                break;
            default:
                Console.WriteLine("Unrecognized character. Please choose a valid option (1-4).");
                break;
        }

        // Wait for user input before exiting
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
