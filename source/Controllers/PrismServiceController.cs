using PrismHRAPI.Extensions;
using PrismHRAPI.Models;
using PrismHRAPI.Models.PrismModels;
using RestSharp;

namespace PrismHRAPI.Controllers;

public class PrismServiceController
{

    //private static int waitTime = 5000;

    private static APIReturnModel? GetData(string queryString, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            RestResponse? response = new RestRequest()
                            .UsingEndpoint(endpoint: $"/system/v1/getData{queryString}", method: Method.Get, configuration: configuration, sessionId: sessionId)
                            .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<SystemModels.GetDataResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }
}

