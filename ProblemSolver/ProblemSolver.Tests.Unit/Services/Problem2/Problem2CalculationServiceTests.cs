using System;
using System.Collections.Generic;
using ProblemSolver.Function.Models.Problem2;
using ProblemSolver.Function.Services.Problem2;
using Xunit;

namespace ProblemSolver.Tests.Unit.Services.Problem2
{

    public class Problem2CalculationServiceTests
    {
        Problem2CalculationService problem2CalculationService { get; set; }

        public Problem2CalculationServiceTests()
        {
            problem2CalculationService = new Problem2CalculationService();
        }

        [Theory]
        [InlineData(10, 10)]
        [InlineData(4000000, 4613732)]
        public void Problem2CalculationService_SolveProblem_Returns_Correct_Answer(int maxNumber, int expected)
        {
            var input = new Problem2Input()
            {
                MaxNumber = maxNumber
            };

            var output = problem2CalculationService.SolveProblem(input);

            Assert.Equal(expected, output.Answer);
        }
    }
}
