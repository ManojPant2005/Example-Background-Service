
namespace ExampleBackgroundService
{
    public class ExampleService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Console.WriteLine("Window Service");
                await Task.Delay(1000);
            }
        }
    }
}
