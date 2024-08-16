namespace PostmanClone.Library.HttpClientControl;

internal class HttpFactory
{
    private static readonly HttpClient httpClient = new();

    public static HttpClient GetHttpClient()
    { 
        return httpClient; 
    }
}
