using ProblemSolver.Contracts;
using ProblemSolver.Models;
using ProblemSolver.Models.Problem1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver.Services.Problem1
{
    class Problem1CalculationService : ICalculationService<Problem1Input, Problem1Output>
    {
        List<int> FindNumbers(int number, int numberMax)
        {
            int i = 0;
            var numbers = new List<int>();
            while (true)
            {
                i += number;
                if (i >= numberMax)
                    break;

                if (i == 0)
                    continue;

                numbers.Add(i);
            }

            return numbers;
        }

        public Problem1Output SolveProblem(Problem1Input input)
        {
            var allNumbers = new List<int>();
            //Parallel.ForEach(input.InputNumbers, (number) =>
            //{
            //    var foundNumbers = FindNumbers(number, input.MaxNumber);
            //    allNumbers.AddRange(foundNumbers);
            //});

            var foundNumbers1 = FindNumbers(input.InputNumbers[0], input.MaxNumber);
            var foundNumbers2 = FindNumbers(input.InputNumbers[1], input.MaxNumber);
            allNumbers.AddRange(foundNumbers1);
            allNumbers.AddRange(foundNumbers2);

            var result = allNumbers
                .OrderBy(x => x)
                .Distinct();

            return new Problem1Output
            {
                Answer = result.Sum(),
                Numbers = result.ToList<int>()
            };
        }
    }
}
