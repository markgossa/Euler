using ProblemSolver.Function.Models.Problem1;
using System.Collections.Generic;

namespace ProblemSolver.Function.Contracts
{
    public interface ICalculationService<in T1, out T2>
    {
        T2 SolveProblem(T1 input);
    }
}