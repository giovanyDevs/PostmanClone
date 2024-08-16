using PostmanClone.Library.ApiCallCenter.Interfaces;
using PostmanClone.Library.ApiCallCenter.Models;
using PostmanClone.Library.HttpClientControl;
using PostmanClone.Library.SupportClasses;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace PostmanClone.Library.ApiCallCenter;

public class ApiAccess : IApiAccess
{
    public async Task<ApiCallResultModel> CallApiAsync(
        string url,
        HttpAction action = HttpAction.GET)
    {
        ApiCallResultModel result = new()
        {
            Request = LoadRequestModel(new(HttpMethod.Get, url))
        };

        HttpClient client = HttpFactory.GetHttpClient();

        using HttpResponseMessage response = await client.GetAsync(url);
        {
            result.Responce = await LoadResponseModelAsync(response);
        }

        return result;
    }

    public bool IsValidUrl(string url, bool acceptOnlyHttps = false)
    {
        Uri? validUri;

        if (string.IsNullOrEmpty(url))
        { return false; }
        else if (Uri.TryCreate(url, UriKind.Absolute, out validUri) is false)
        { return false; }

        if (acceptOnlyHttps is true && validUri?.Scheme != Uri.UriSchemeHttps)
        { return false; }

        return true;
    }

    #region Http Result Process
    private static HttpRestModel LoadRequestModel(HttpRequestMessage request, string? requestBody = null)
    {
        string HttpHeaders = GetReadableHeaders(request.Headers);

        string httpBody = LoadReadableJson(requestBody ?? string.Empty);

        return new()
        {
            StartLine = $"{request.Method} {request.RequestUri} HTTP/{request.Version}",
            HttpHeaders = HttpHeaders,
            HttpBody = httpBody
        };
    }

    private static async Task<HttpRestModel> LoadResponseModelAsync(HttpResponseMessage response)
    {
        string HttpHeaders = GetReadableHeaders(response.Headers);

        string httpBody = LoadReadableJson(await response.Content.ReadAsStringAsync());

        return new()
        {
            StartLine = $"HTTP/{response.Version} {(int)response.StatusCode} {response.ReasonPhrase}",
            HttpHeaders = HttpHeaders,
            HttpBody = httpBody
        };
    }

    private static string GetReadableHeaders(HttpHeaders Headers)
    {
        StringBuilder headers = new();

        foreach (var header in Headers)
        {
            headers.AppendLine($"{header.Key}: {string.Join(", ", header.Value)}");
        }

        return headers.ToString();
    }

    private static string LoadReadableJson(string unformatedJson)
    {
        if (string.IsNullOrEmpty(unformatedJson))
        { return unformatedJson; }
        else if (unformatedJson.IsJson() is false)
        { return string.Empty; }

        var JsonElement = JsonSerializer.Deserialize<JsonElement>(unformatedJson);

        string httpBody = JsonSerializer.Serialize(JsonElement,
                                                  new JsonSerializerOptions { WriteIndented = true });
        return httpBody;
    }
    #endregion
}
