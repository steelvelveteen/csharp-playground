using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace csharp_playground
{
    public class GreetingService: IGreetingService
    {
        private readonly ILogger<GreetingService> _logger;
        private readonly IConfiguration _configuration;

        public GreetingService(ILogger<GreetingService> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }
        public void Run()
        {
            for (int i = 0; i < _configuration.GetValue<int>("LoopTimes"); i++)
            {
                // Log the number
                _logger.LogInformation("Run number {runNumber}", i );
            }
            var env = _configuration.GetValue<string>("ASPNETCORE_ENVIRONMENT");
            _logger.LogInformation(env);
        }
    }
}