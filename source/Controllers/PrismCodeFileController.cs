using PrismHRAPI.Extensions;
using PrismHRAPI.Models;
using PrismHRAPI.Models.PrismModels;
using RestSharp;

namespace PrismHRAPI.Controllers;

public class PrismCodeFileController
	{
    public static APIReturnModel? GetUserDefinedFields_ClientDetails(int clientId, List<string>? typeIdList = null, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}&fieldType=ClientDetails";
            if (typeIdList != null)
            {
                foreach (var item in typeIdList)
                {
                    queryString += $"&typeId={item}";
                }
            }
            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/codeFiles/v1/getUserDefinedFields{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<CodeFileModels.CodeFileResponse>();
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

