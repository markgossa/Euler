using ProblemSolver.Contracts;
using ProblemSolver.Models.Problem2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolver.Services.Problem1
{
    class Problem2ConsoleInputService : IConsoleInputService<Problem2Input>
    {
        public Problem2Input Welcome()
        {
            Console.WriteLine($"Hello! Weclome to Problem 2.");

            Console.WriteLine($"Enter your maximum number");
            int maxNumber = int.Parse(Console.ReadLine());

            var problem2Input = new Problem2Input
            {
                MaxNumber = maxNumber
            };

            return problem2Input;
        }
    }
}
