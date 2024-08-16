using PostmanClone.Library.ApiCallCenter.Models;
using PostmanClone.Library.SupportClasses;

namespace PostmanClone.Library.ApiCallCenter.Interfaces
{
    public interface IApiAccess
    {
        Task<ApiCallResultModel> CallApiAsync(string url, HttpAction action = HttpAction.GET);
        bool IsValidUrl(string url, bool acceptOnlyHttps = false);
    }
}