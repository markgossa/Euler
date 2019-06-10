using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProblemSolver.Function.Contracts;
using ProblemSolver.Function.Models.Problem1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolver.Function.Services.Problem1
{
    public class Problem1FunctionService : IFunctionService<Problem1Output>
    {
        private readonly ICalculationService<Problem1Input, Problem1Output> Problem1CalculationService;

        public Problem1FunctionService(ICalculationService<Problem1Input, Problem1Output> problem1CalculationService)
        {
            Problem1CalculationService = problem1CalculationService;
        }

        public Problem1Output Process(string requestBody)
        {
            var input = JsonConvert.DeserializeObject<Problem1Input>(requestBody);
            var result = Problem1CalculationService.SolveProblem(input);
            result.Question = "Problem 1: Find the sum of all the multiples of 3 or 5 below 1000.";
            return result;
        }
    }
}
