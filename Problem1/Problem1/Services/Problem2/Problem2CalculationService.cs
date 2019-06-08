using ProblemSolver.Contracts;
using ProblemSolver.Models.Problem2;
using ProblemSolver.Services.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolver.Services.Problem2
{
    public class Problem2CalculationService : ICalculationService<Problem2Input, Problem2Output>
    {
        private List<int> _fibonnaciSequence { get; set; }
        private int _maxNumber { get; set; }
        private int _fibonnaciSequenceEvenNumbers { get; set; }

        public Problem2CalculationService(Problem2Input input)
        {
            _maxNumber = input.MaxNumber;
        }

        private void GetFibonnaciSequence()
        {
            int i = 2;
            _fibonnaciSequence = new List<int>{ 1, 2 };

            while (true)
            {
                int nextNumber = this._fibonnaciSequence[i - 1] + this._fibonnaciSequence[i - 2];
                if (nextNumber > this._maxNumber)
                    break;
                else 
                    this._fibonnaciSequence.Add(nextNumber);

                i++;
            }
        }

        public Problem2Output SolveProblem(Problem2Input input)
        {
            this._maxNumber = input.MaxNumber;

            GetFibonnaciSequence();
            var helpers = new Helpers();
            var evenNumbers = helpers.GetEvenNumbers(_fibonnaciSequence);
            var sum = helpers.AddNumbers(evenNumbers);

            var result = new Problem2Output()
            {
                Numbers = evenNumbers,
                Answer = sum
            };

            return result;
        }
    }
}
