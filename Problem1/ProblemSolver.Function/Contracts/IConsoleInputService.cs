using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolver.Function.Contracts
{
    interface IConsoleInputService<out T>
    {
        T Welcome();
    }
}
