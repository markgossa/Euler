﻿using ProblemSolver.Function.Contracts;
using ProblemSolver.Function.Models.Problem2;
using ProblemSolver.Function.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolver.Function.Services.Problem2
{
    public class Problem2CalculationService : ICalculationService<Problem2Input, Problem2Output>
    {
        private List<int> _fibonnaciSequence { get; set; }
        private int _maxNumber { get; set; }

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
            var evenNumbers = _fibonnaciSequence.GetEven();
            var sum = evenNumbers.Sum();

            var result = new Problem2Output()
            {
                Numbers = evenNumbers,
                Answer = sum
            };

            return result;
        }
    }
}
