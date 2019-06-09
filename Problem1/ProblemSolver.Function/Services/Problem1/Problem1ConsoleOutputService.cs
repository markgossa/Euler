using ProblemSolver.Function.Contracts;
using ProblemSolver.Function.Models.Problem1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolver.Function.Services.Problem1
{
    class Problem1ConsoleOutputService : IConsoleOutputService<Problem1Input, Problem1Output>
    {
        public void ReturnResults(Problem1Input input, Problem1Output output)
        {
            Console.WriteLine($"Numbers below {input.MaxNumber} and divisible by {input.InputNumbers[0]} or {input.InputNumbers[1]} are: {String.Join(", ", output.Numbers)}");
            Console.WriteLine($"Problem answer: {output.Answer}");
        }
    }
}
