using PrismHRAPI.Extensions;
using PrismHRAPI.Models;
using PrismHRAPI.Models.PrismModels;
using RestSharp;

namespace PrismHRAPI.Controllers;

public class PrismDeductionController
	{
    public static APIReturnModel? GetGarnishmentPaymentHistory(int clientId, string employeeId, string? docketNumber = null, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}&employeeId={employeeId}";
            if (!string.IsNullOrEmpty(docketNumber)) queryString += "&docketNumber={docketNumber}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/deductions/v1/getGarnishmentPaymentHistory{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<DeductionModels.DeductionResponse>();
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

