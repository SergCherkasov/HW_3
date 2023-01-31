using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3.UserInterface
{
    internal class UserInterface
    {
        public void Calculate()
        {
            CalculatorMechanics.CalculatorMechanics cm = new CalculatorMechanics.CalculatorMechanics();
            do
            {
                Console.Clear();
                Console.WriteLine($"\tWELCOME TO CALCULATOR APP!");
                Console.WriteLine();
                Console.WriteLine("Enter expression:");
                string exp = Console.ReadLine();
                exp = cm.SyntaxAnalyz(exp);
                Console.WriteLine();
                Console.WriteLine("Result of Your expression:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(cm.Counting(cm.TransformExpression(exp)));
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any Key to Continue...\nPress ESC for EXIT.");

            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
