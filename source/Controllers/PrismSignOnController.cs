using PrismHRAPI.Extensions;
using PrismHRAPI.Models;
using PrismHRAPI.Models.PrismModels;
using RestSharp;

namespace PrismHRAPI.Controllers;

public class PrismSignOnController
{
    public static APIReturnModel? ValidateTssoToken(string tssoToken, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/signOn/v1/validateTssoToken",
                                                            method: Method.Post,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .WithParameters(new List<RequestParameter>()
                                                        {
                                                            new RequestParameter(name: "application/x-www-form-urlencoded", value: $"tssoToken={tssoToken}", type: ParameterType.RequestBody)
                                                        })
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<SignOnModels.SignOnResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetFavorites(string userId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?userId={userId}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/signOn/v1/getFavorites{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();


            if (response != null)
                return response.GetAPIReturn()?.ToModel<SignOnModels.SignOnResponse>();
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

