using ExampleBackgroundService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHostedService<ExampleBGService>();

builder.Services.Configure<HostOptions>(x =>
{
    x.ServicesStartConcurrently = true;
    x.ServicesStopConcurrently = false;
});

var app = builder.Build();


app.Run();

