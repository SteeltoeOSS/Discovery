using System.Net.Http;

namespace Steeltoe.Discovery.Eureka
{
    public interface IEurekaDiscoveryClientHandlerProvider
    {
        HttpClientHandler GetHttpClientHandler();
    }
}