using Portia.Net.HealthCheck.Core;
using Portia.Net.HealthCheck.Sample;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// The Health Check report service should be registered in DI
builder.Services.AddTransient<IHealthCheckReportService, HealthCheckReportServiceImpl>();

var app = builder.Build();


app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

// The middleware should be added after the authorization middleware (if exists)
app.UseHealthCheck();

app.MapControllers();

app.Run();
