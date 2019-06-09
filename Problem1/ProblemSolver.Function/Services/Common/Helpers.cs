using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolver.Function.Services.Common
{
    public static class Helpers
    {
        public static List<int> GetEven(this List<int> numbers)
        {
            var result = numbers.Where(x => x % 2 == 0).ToList<int>();
            return result;
        }
    }
}
