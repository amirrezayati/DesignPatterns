using System.Net;

namespace DesignPatternsTutorials.Structural.Decorator.AbstractDecorator;

public class HttpClientDecorator : HttpClient
{
    private readonly HttpClient _httpClient;

    public HttpClientDecorator(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public override HttpResponseMessage Send(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        if (request.RequestUri.AbsolutePath.Contains(""))
        {
            //
        }
       return _httpClient.Send(request, cancellationToken);
    }
}