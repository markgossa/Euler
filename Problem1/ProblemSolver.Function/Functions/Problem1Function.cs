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
using ProblemSolver.Function.Models.Problem1;
using ProblemSolver.Function.Services.Problem1;

namespace ProblemSolver.Function.Functions
{
    public static class Problem1Function
    {
        [FunctionName("ProblemSolver")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]HttpRequest req,
            ILogger log)
        {
            var requestBody = new StreamReader(req.Body).ReadToEnd();
            var input = JsonConvert.DeserializeObject<Problem1Input>(requestBody);

            var problem1CalculationService = new Problem1CalculationService();
            var result = problem1CalculationService.SolveProblem(input);

            return new OkObjectResult(result);
        }
    }
}
