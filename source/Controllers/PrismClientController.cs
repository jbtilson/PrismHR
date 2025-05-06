using PrismHRAPI.Extensions;
using PrismHRAPI.Models;
using PrismHRAPI.Models.PrismModels;
using RestSharp;

namespace PrismHRAPI.Controllers;

public class PrismClientController
{
    public static APIReturnModel? GetClientMaster(int clientId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/clientMaster/v1/getClientMaster{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<ClientModels.ClientMasterResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetClientCodes(int clientId, string? options = "BenefitGroup+COBRA+Deduction+Department+Division+Ethnic+I9docs+Job+Location+Pay+PGroups+PositionClass+ProjClass+Project+Reason+Relation+RetirementPlan+Shift+Skill+Status+Type+Union+Workgroup", Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}";
            queryString += $"&options={options}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/clientMaster/v1/getClientCodes{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<ClientModels.ClientMasterResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetBenefitGroup(int clientId, List<string> groupId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}";
            foreach (var item in groupId)
            {
                queryString += $"&groupId={item}";
            }

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/clientMaster/v1/getBenefitGroup{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<ClientModels.ClientMasterResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetAllPrismClientContacts(int clientId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/clientMaster/v1/getAllPrismClientContacts{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<ClientModels.ClientMasterResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetClientList(bool inActive = false, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?inActive={(inActive == false ? "false" : "true")}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/clientMaster/v1/getClientList{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<ClientModels.ClientMasterResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetClientLocationDetails(int clientId, string locationId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}&locationId={locationId}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/clientMaster/v1/getClientLocationDetails{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<ClientModels.ClientMasterResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetPayGroupDetails(int clientId, string payGroupCode, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}&payGroupCode={payGroupCode}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/clientMaster/v1/getPayGroupDetails{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<ClientModels.ClientMasterResponse>();
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

