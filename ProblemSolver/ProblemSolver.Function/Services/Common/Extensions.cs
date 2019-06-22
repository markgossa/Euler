using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolver.Function.Services.Common
{
    public static class Extensions
    {
        public static List<int> GetEven(this List<int> numbers)
        {
            var result = numbers.Where(x => x % 2 == 0).ToList<int>();
            return result;
        }

        public static List<int> GetFactors(this int number)
        {
            var potentialFactors = new List<int>();
            potentialFactors.AddRange(Enumerable.Range(1, number));
            var factors = potentialFactors.Where(x => number % x == 0).ToList<int>();

            return factors;
        }

        public static bool IsPrime(this int number)
        {
            var factors = number.GetFactors();
            if (factors.Count == 2 && factors[0] == 1 && factors[1] == number)
                return true;
            else
                return false;
        }

        public static List<int> GetPrime(this List<int> numbers)
        {
            var result = numbers.Where(x => x.IsPrime()).ToList<int>();
            return result;
        }
    }
}
