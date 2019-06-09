using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProblemSolver.Function.Models.Problem1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolver.Function.Services.Problem1
{
    public class Problem1FunctionService
    {
        public IActionResult Process(string requestBody)
        {
            var input = JsonConvert.DeserializeObject<Problem1Input>(requestBody);
            var problem1CalculationService = new Problem1CalculationService();
            var result = problem1CalculationService.SolveProblem(input);
            result.Question = "Problem 1: Find the sum of all the multiples of 3 or 5 below 1000.";
            return new OkObjectResult(result);
        }
    }
}
