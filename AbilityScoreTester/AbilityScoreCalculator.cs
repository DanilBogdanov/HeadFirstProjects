using System;
using Microsoft.VisualBasic.CompilerServices;

namespace AbilityScoreTester
{
    public class AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;
        
        public void CalculateAbilityScore()
        {
            // Divide the roll result by the DivideBy field
            double divided = RollResult / DivideBy;
            // Add AddAmount to the result of that division
            int added = AddAmount + (int)divided;
            
            // If the result is too small, use Minimum
            if (added < Minimum)
            {
                Score = Minimum;
            } else
            {
                Score = added;
            }
        }
        
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability score: " + calculator.Score);
                Console.WriteLine("Press Q to quit, any other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;
            }
        }
        
        /// <summary>
        /// Writes a prompt and reads a double value from the console.
        /// </summary>
        /// <param name="lastUsedValue">The default value.</param>
        /// <param name="prompt">Promt to print to the console.</param>
        /// <returns></returns>
        private static double ReadDouble(double lastUsedValue, string prompt)
        {
            Console.Write($"{prompt} [{lastUsedValue}] ");
            if (double.TryParse(Console.ReadLine(), out double result))
            {
                Console.WriteLine($"\tusing value {result}");
                return result;
            }
            else
            {
                Console.WriteLine($"\tusing default value {lastUsedValue}");
                return lastUsedValue;
            }
        }
        /// <summary>
        /// Writes a prompt and reads an int value from the console.
        /// </summary>
        /// <param name="lastUserdValue">The default value</param>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private static int ReadInt(int lastUserdValue, string prompt)
        {
            Console.Write($"{prompt} [{lastUserdValue}] ");
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine($"\tusing value {result}");
                return result;
            }
            else
            {
                Console.WriteLine($"\tusing default value {lastUserdValue}");
                return lastUserdValue;
            }
        }
    }
}