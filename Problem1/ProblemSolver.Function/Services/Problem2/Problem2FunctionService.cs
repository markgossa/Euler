using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProblemSolver.Function.Contracts;
using ProblemSolver.Function.Models.Problem2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolver.Function.Services.Problem2
{
    public class Problem2FunctionService : IFunctionService
    {
        private readonly ICalculationService<Problem2Input, Problem2Output> Problem2CalculationService;

        public Problem2FunctionService(ICalculationService<Problem2Input, Problem2Output> problem1CalculationService)
        {
            Problem2CalculationService = problem1CalculationService;
        }

        public IActionResult Process(string requestBody)
        {
            var input = JsonConvert.DeserializeObject<Problem2Input>(requestBody);
            var result = Problem2CalculationService.SolveProblem(input);
            result.Question = "Problem 2: By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.";
            return new OkObjectResult(result);
        }
    }
}
