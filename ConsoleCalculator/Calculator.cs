namespace ConsoleCalculator
{
    class Calculator
    {
        private double GetNumber(string prompt)
        {
            double number;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out number))
                {
                    return number;
                }
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        public virtual void PerformCalculation()
        {
            Console.WriteLine("Performing calculation...");

            double num1 = GetNumber("Enter the first number: ");
            double num2 = GetNumber("Enter the second number: ");

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            IOperation operation = choice switch
            {
                1 => new Addition(),
                2 => new Subtraction(),
                3 => new Multiplication(),
                4 => new Division(),
                _ => throw new InvalidOperationException("Invalid operation choice.")
            };

            double result = operation.Execute(num1, num2);

            Console.WriteLine($"Result: {result}");
        }
    }
}
