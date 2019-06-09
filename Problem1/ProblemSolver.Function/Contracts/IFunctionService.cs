using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolver.Function.Contracts
{
    public interface IFunctionService<out T>
    {
        T Process(string requestBody);
    }
}
