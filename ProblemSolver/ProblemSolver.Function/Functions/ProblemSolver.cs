using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Newtonsoft.Json;
using ProblemSolver.Function.Contracts;
using ProblemSolver.Function.Models;
using ProblemSolver.Function.Models.Problem1;
using ProblemSolver.Function.Models.Problem2;

namespace ProblemSolver.Function.Functions
{
    public class ProblemSolver
    {
        private IFunctionService<Problem1Output> Problem1FunctionService { get; set; }
        private IFunctionService<Problem2Output> Problem2FunctionService { get; set; }

        public ProblemSolver(IFunctionService<Problem1Output> problem1FunctionService,
            IFunctionService<Problem2Output> problem2FunctionService)
        {
            Problem1FunctionService = problem1FunctionService;
            Problem2FunctionService = problem2FunctionService;
        }

        [FunctionName("ProblemSolver")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]HttpRequest req)
        {
            var requestBody = new StreamReader(req.Body).ReadToEnd();
            var problemNumber = JsonConvert.DeserializeObject<ProblemInfo>(requestBody);

            switch (problemNumber.ProblemNumber)
            {
                case 1:
                    {
                        return new OkObjectResult(Problem1FunctionService.Process(requestBody));
                    }

                case 2:
                    {
                        return new OkObjectResult(Problem2FunctionService.Process(requestBody));
                    }

                default:
                    return new BadRequestObjectResult($"Problem not found. Please enter a valid problem number.");
            }
        }
    }
}
