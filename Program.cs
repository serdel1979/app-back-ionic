using WebApplication1;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var startup = new StartUp(builder.Configuration);

startup.ConfigureServices(builder.Services);


var app = builder.Build();

startup.Configure(app, app.Environment);

app.Run();
