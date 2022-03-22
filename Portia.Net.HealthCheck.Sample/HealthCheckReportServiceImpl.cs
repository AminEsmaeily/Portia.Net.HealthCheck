using Newtonsoft.Json;
using Portia.Net.HealthCheck.Core;
using System.Diagnostics;

namespace Portia.Net.HealthCheck.Sample
{
    public class HealthCheckReportServiceImpl : IHealthCheckReportService
    {
        public Task SaveAPICallInformationAsync(RequestDetail requestDetail)
        {
            // Using this method, you can save all collected information in a cloud, local, or third-party database.
            // It is highly recommended to save the tracked information in another database than the main one due to decrease the performance issue

            Debugger.Log(0, "Health Check", JsonConvert.SerializeObject(requestDetail, Formatting.Indented));
            return Task.CompletedTask;
        }
    }
}
