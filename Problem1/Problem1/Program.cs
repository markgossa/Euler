using ProblemSolver.Services.Problem1;
using ProblemSolver.Services.Problem2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProblemSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            //var problem1ConsoleInputService = new Problem1ConsoleInputService();
            //var input = problem1ConsoleInputService.Welcome();

            //var stopwatch = new Stopwatch();
            //stopwatch.Start();

            //var problem1CalculationService = new Problem1CalculationService();
            //var output = problem1CalculationService.SolveProblem(input);
            //var problem1ConsoleOutputService = new Problem1ConsoleOutputService();
            //problem1ConsoleOutputService.ReturnResults(input, output);

            //stopwatch.Stop();

            //Console.WriteLine($"Time taken: {stopwatch.Elapsed.Milliseconds}ms");

            var problem2ConsoleInputService = new Problem2ConsoleInputService();
            var input = problem2ConsoleInputService.Welcome();

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var problem2CalculationService = new Problem2CalculationService();
            var output = problem2CalculationService.SolveProblem(input);
            var problem2ConsoleOutputService = new Problem2ConsoleOutputService();
            problem2ConsoleOutputService.ReturnResults(input, output);

            stopwatch.Stop();

            Console.WriteLine($"Time taken: {stopwatch.Elapsed.Milliseconds}ms");
        }
    }
}
