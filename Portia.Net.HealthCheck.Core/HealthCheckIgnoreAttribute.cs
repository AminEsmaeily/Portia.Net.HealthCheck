namespace Portia.Net.HealthCheck.Core
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class HealthCheckIgnoreAttribute : Attribute
    {
    }
}
