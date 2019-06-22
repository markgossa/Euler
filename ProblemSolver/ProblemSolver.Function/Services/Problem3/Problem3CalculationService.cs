using ProblemSolver.Function.Contracts;
using ProblemSolver.Function.Models.Problem3;
using ProblemSolver.Function.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolver.Function.Services.Problem3
{
    public class Problem3CalculationService : ICalculationService<Problem3Input, Problem3Output>
    {
        Problem3Input Problem3Input = new Problem3Input()
        {
            Number = 600851475143
        };

        public Problem3Output SolveProblem(Problem3Input input)
        {
            throw new NotImplementedException();
        }
    }
}
