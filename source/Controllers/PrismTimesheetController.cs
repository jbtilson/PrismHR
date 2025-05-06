using PrismHRAPI.Extensions;
using PrismHRAPI.Models;
using PrismHRAPI.Models.PrismModels;
using RestSharp;

namespace PrismHRAPI.Controllers;

public class PrismTimesheetController
{
    public static APIReturnModel? GetTimeSheetData(string batchId, int clientId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?batchId={batchId}&clientId={clientId.ToClientId()}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/timesheet/v1/getTimeSheetData{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<TimesheetModels.TimesheetResponse>();
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
