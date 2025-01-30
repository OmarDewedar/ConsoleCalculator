using ConsoleCalculator;

public class Division : IOperation
{
    public double Execute(double a, double b)
    {
        while (b == 0) // Keep asking for a valid denominator
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            Console.Write("Enter a new denominator: ");
            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                b = 0; // Ensures the loop continues
            }
        }

        double quotient = a / b;
        double remainder = a % b; // Get the remainder

        Console.WriteLine($"Quotient: {quotient}");
        if (remainder != 0)
        {
            Console.WriteLine($"Remainder: {remainder}");
        }

        return quotient; // Returning quotient only, remainder is displayed separately
    }
}
