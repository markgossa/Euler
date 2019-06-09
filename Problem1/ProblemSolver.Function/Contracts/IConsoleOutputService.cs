using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolver.Function.Contracts
{
    interface IConsoleOutputService<in T1, in T2>
    {
        void ReturnResults(T1 problemInput, T2 problemOutput);
    }
}
