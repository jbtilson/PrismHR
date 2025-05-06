using System.Text.Json;
using PrismHRAPI.Controllers;
using PrismHRAPI.Models;
using RestSharp;

namespace PrismHRAPI.Extensions;

public static class RestSharpExtensions
{

    internal static TimeSpan OperationTimeOut => new(hours: 0, minutes: 2, seconds: 0);

    public static RestRequest UsingEndpoint(this RestRequest restRequest, string endpoint, Method method, string contentType = "application/x-www-form-urlencoded", Configuration? configuration = null, string? sessionId = null)
    {
        configuration ??= new Configuration();
        sessionId ??= BaseController.GetSessionID(configuration);
        if (!endpoint.StartsWith('/')) endpoint = $"/{endpoint}";

        restRequest = new RestRequest(resource: $"{configuration.BaseURL}{endpoint}", method: method)
        {
            Timeout = OperationTimeOut
        };
        restRequest.AddHeader("Content-Type", contentType);
        restRequest.AddHeader("sessionId", sessionId ?? "");

        return restRequest;
    }
    public static RestRequest UsingPostEndpoint(this RestRequest restRequest, string endpoint, Method method, string jsonBody, string contentType = "application/json", Configuration? configuration = null)
    {
        configuration ??= new Configuration();
        if (!endpoint.StartsWith('/')) endpoint = $"/{endpoint}";

        restRequest = new RestRequest(resource: $"{configuration.BaseURL}{endpoint}", method: method);
        restRequest.AddHeader("Content-Type", contentType);
        restRequest.AddHeader("Accept", contentType);
        restRequest.AddStringBody(body: jsonBody, dataFormat: DataFormat.Json);

        return restRequest;
    }

    public static RestRequest WithParameters(this RestRequest restRequest, List<RequestParameter> parameters)
    {
        foreach (var item in parameters)
        {
            restRequest.AddParameter(name: item.name, value: item.value, type: item.type);
        }
        return restRequest;
    }

    public static RestResponse? GetResponse(this RestRequest restRequest)
    {
        try
        {
            RestClient client = new RestClient(options: new RestClientOptions() { Timeout = OperationTimeOut });
            return client.Execute(request: restRequest);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    public static APIReturnModel? GetAPIReturn(this RestResponse restResponse)
    {
        if (restResponse.IsSuccessful && restResponse.Content != null)
        {
            var returnModel = JsonSerializer.Deserialize<APIReturnModel>(restResponse.Content);
            returnModel!.errorCode = "0";
            returnModel!.errorMessage = null;
            returnModel!.APIResult = restResponse.Content;
            if (returnModel!.sessionId == null)
                returnModel!.sessionId = $"{restResponse.Request.Parameters.FirstOrDefault(x => x.Name == "sessionId")?.Value}";

            return returnModel;
        }

        switch (restResponse.StatusCode)
        {
            case System.Net.HttpStatusCode.Forbidden:
                return new APIReturnModel() { errorCode = restResponse.StatusCode.ToString(), errorMessage = "The API authentication failed.", sessionId = null };
            default:
                return new APIReturnModel() { errorCode = restResponse.StatusCode.ToString(), errorMessage = restResponse.ErrorMessage ?? restResponse.Content, sessionId = null };
        }
    }

}