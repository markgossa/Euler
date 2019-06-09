using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolver.Contracts
{
    interface IConsoleInputService<out T>
    {
        T Welcome();
    }
}
