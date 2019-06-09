using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ProblemSolver.Function.Models;
using ProblemSolver.Function.Models.Problem1;
using ProblemSolver.Function.Services.Problem1;

namespace ProblemSolver.Function.Functions
{
    public static class ProblemSolver
    {
        [FunctionName("ProblemSolver")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]HttpRequest req)
        {
            var requestBody = new StreamReader(req.Body).ReadToEnd();
            var problemNumber = JsonConvert.DeserializeObject<ProblemInfo>(requestBody);

            switch (problemNumber.ProblemNumber)
            {
                case 1:
                    {
                        var problem1FunctionService = new Problem1FunctionService();
                        return problem1FunctionService.Process(requestBody);
                    }
                default:
                    return new BadRequestObjectResult($"Problem not found. Please enter a valid problem number.");
            }
        }
    }
}
