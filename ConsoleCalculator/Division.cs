using ConsoleCalculator;

public class Division : IOperation
{
    public double Execute(double a, double b)
    {
        while (b == 0) // Loop until a valid denominator is provided
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            Console.Write("Enter a new denominator: ");
            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                b = 0; // Ensures the loop continues
            }
        }
        return a / b;
    }
}
