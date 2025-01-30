using System;

namespace ConsoleCalculator
{
    /// <summary>
    /// put access modifier for each class ( public before classes)
    /// seprate program classess file done
    /// different between out and ref
    /// give me example for abstraction and interface
    /// handle the divide by zero process done
    /// Arrow function done
    /// virtual function done
    /// open/close princable done
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new BasicCalculator();
            calculator.PerformCalculation();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

