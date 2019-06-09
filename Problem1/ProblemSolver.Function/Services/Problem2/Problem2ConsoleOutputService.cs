using ProblemSolver.Function.Contracts;
using ProblemSolver.Function.Models.Problem2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolver.Function.Services.Problem2
{
    class Problem2ConsoleOutputService : IConsoleOutputService<Problem2Input, Problem2Output>
    {
        public void ReturnResults(Problem2Input input, Problem2Output output)
        {
            Console.WriteLine($"Even Fibonacci numbers below {input.MaxNumber} are: {String.Join(", ", output.Numbers)}");
            Console.WriteLine($"Problem answer: {output.Answer}");
        }
    }
}
