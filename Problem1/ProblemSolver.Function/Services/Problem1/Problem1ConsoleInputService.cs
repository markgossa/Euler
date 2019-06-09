using ProblemSolver.Function.Contracts;
using ProblemSolver.Function.Models.Problem1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolver.Function.Services.Problem1
{
    class Problem1ConsoleInputService : IConsoleInputService<Problem1Input>
    {
        public Problem1Input Welcome()
        {
            Console.WriteLine($"Hello! Weclome to Problem 1.");

            Console.WriteLine($"Enter your first number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your second number");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your maximum number");
            int maxNumber = int.Parse(Console.ReadLine());

            var problem1Input = new Problem1Input
            {
                InputNumbers = new List<int>
                {
                    number1,
                    number2
                },
                MaxNumber = maxNumber
            };

            return problem1Input;
        }
    }
}
