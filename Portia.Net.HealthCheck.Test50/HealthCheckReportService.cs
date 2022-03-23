using Portia.Net.HealthCheck.Core;
using System.Threading.Tasks;

namespace Portia.Net.HealthCheck.Test50
{
    public class HealthCheckReportService : IHealthCheckReportService
    {
        public Task SaveAPICallInformationAsync(RequestDetail requestDetail)
        {
            return Task.CompletedTask;
        }
    }
}
