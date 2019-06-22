using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using ProblemSolver.Function.Contracts;
using ProblemSolver.Function.Models.Problem1;
using ProblemSolver.Function.Models.Problem2;
using ProblemSolver.Function.Services.Problem1;
using ProblemSolver.Function.Services.Problem2;
using ProblemSolver.Function.Services.Problem3;

[assembly: FunctionsStartup(typeof(ProblemSolver.Function.Configuration.Startup))]

namespace ProblemSolver.Function.Configuration
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<ICalculationService<Problem1Input, Problem1Output>, Problem1CalculationService>();
            builder.Services.AddSingleton<ICalculationService<Problem2Input, Problem2Output>, Problem2CalculationService>();
            builder.Services.AddSingleton<IFunctionService<Problem1Output>, Problem1FunctionService>();
            builder.Services.AddSingleton<IFunctionService<Problem2Output>, Problem2FunctionService>();
            builder.Services.AddSingleton<IFunctionService<Problem3Output>, Problem3FunctionService>();
        }
    }
}