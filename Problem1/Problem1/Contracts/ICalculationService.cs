using ProblemSolver.Models.Problem1;
using System.Collections.Generic;

namespace ProblemSolver.Contracts
{
    internal interface ICalculationService<in T1, out T2>
    {
        T2 SolveProblem(T1 input);
    }
}