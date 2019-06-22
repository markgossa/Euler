using System;
using System.Collections.Generic;
using ProblemSolver.Function.Models.Problem1;
using ProblemSolver.Function.Services.Problem1;
using Xunit;

namespace ProblemSolver.Tests.Unit.Services.Problem1
{

    public class Problem1CalculationServiceTests
    {
        Problem1CalculationService Problem1CalculationService { get; set; }

        public Problem1CalculationServiceTests()
        {
            Problem1CalculationService = new Problem1CalculationService();
        }

        [Theory]
        [InlineData(3, 5, 10, 23)]
        [InlineData(3, 5, 1000, 233168)]
        public void Problem1CalculationService_SolveProblem_Returns_Correct_Answer(int number1, 
            int number2, int maxNumber, int expected)
        {
            var input = new Problem1Input()
            {
                InputNumbers = new List<int> { number1, number2 },
                MaxNumber = maxNumber
            };

            var output = Problem1CalculationService.SolveProblem(input);

            Assert.Equal(expected, output.Answer);
        }

        [Theory]
        [InlineData(3, 10)]
        public void Problem1CalculationService_FindMultiplesOfNumberUnderMaxNumber_Test1(int number, 
            int numberMax)
        {
            var output = Problem1CalculationService.FindMultiplesOfNumberUnderMaxNumber(number, numberMax);
            var expected = new List<int> { 3, 6, 9 };
            Assert.Equal(expected, output);
        }

        [Theory]
        [InlineData(5, 20)]
        public void Problem1CalculationService_FindMultiplesOfNumberUnderMaxNumber_Test2(int number,
            int numberMax)
        {
            var output = Problem1CalculationService.FindMultiplesOfNumberUnderMaxNumber(number, numberMax);
            var expected = new List<int> { 5, 10, 15 };
            Assert.Equal(expected, output);
        }
    }
}
