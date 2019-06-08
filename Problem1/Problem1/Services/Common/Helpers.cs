using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolver.Services.Common
{
    public class Helpers
    {
        public List<int> GetEvenNumbers(List<int> numbers)
        {
            var result = numbers.Where(x => x % 2 == 0).ToList<int>();
            return result;
        }

        public int AddNumbers(List<int> numbers)
        {
            var result = numbers.Sum();
            return result;
        }
    }
}
