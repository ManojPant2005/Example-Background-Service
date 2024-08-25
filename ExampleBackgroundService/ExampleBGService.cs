
namespace ExampleBackgroundService
{
    public class ExampleBGService : IHostedService
    {
        private readonly ILogger<ExampleBGService> _logger;
        public ExampleBGService(ILogger<ExampleBGService> logger)
        {
            logger = _logger;
        }
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("StartAsync");
        }
        public async Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("StopAsync");
        }
    }
}
