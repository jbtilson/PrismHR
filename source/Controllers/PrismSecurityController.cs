using PrismHRAPI.Extensions;
using PrismHRAPI.Models;
using PrismHRAPI.Models.PrismModels;
using RestSharp;

namespace PrismHRAPI.Controllers;

public class PrismSecurityController
{
    public static APIReturnModel? GetUserDetails(string prismUserId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?prismUserId={prismUserId}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/prismSecurity/v1/getUserDetails{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<SecurityModels.SecurityResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetUserList(int clientId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/prismSecurity/v1/getUserList{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<SecurityModels.SecurityResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetUserRolesList(Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/prismSecurity/v1/getUserRolesList",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();
            if (response != null)
                return response.GetAPIReturn()?.ToModel<SecurityModels.SecurityResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetUserRoleDetails(string roleId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?roleId={roleId}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/prismSecurity/v1/getUserRoleDetails{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<SecurityModels.SecurityResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetUserDataSecurity(int clientId, string prismUserId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}&prismUserId={prismUserId}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/prismSecurity/v1/getUserDataSecurity{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<SecurityModels.SecurityResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetEmployeeList(int clientId, string prismUserId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}&prismUserId={prismUserId}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/prismSecurity/v1/getEmployeeList{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<SecurityModels.SecurityResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetEmployeeClientListForPrismId(string prismUserId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?prismUserId={prismUserId}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/prismSecurity/v1/getEmployeeClientList{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<SecurityModels.SecurityResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetEmployeeClientListForEmployeeId(string employeeId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?employeeId={employeeId}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/prismSecurity/v1/getEmployeeClientList{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<SecurityModels.SecurityResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetClientList(string prismUserId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?prismUserId={prismUserId}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/prismSecurity/v1/getClientList{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<SecurityModels.SecurityResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? IsClientAllowed(string prismUserID, int clientId, Configuration? configuration = null, string? sessionId = null)
    {

        if (configuration == null) configuration = new Configuration();

        string queryString = $"?clientId={clientId.ToClientId()}&prismUserId={prismUserID}";

        RestResponse? response = new RestRequest().UsingEndpoint(
                                                        endpoint: $"/prismSecurity/v1/isClientAllowed{queryString}",
                                                        method: Method.Get,
                                                        configuration: configuration,
                                                        sessionId: sessionId)
                                                    .GetResponse();

        if (response != null)
            return response.GetAPIReturn()?.ToModel<SecurityModels.SecurityResponse>();
        else
            return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };
    }

    public static APIReturnModel? IsEmployeeAllowed(string prismUserID, int clientId, string employeeId, Configuration? configuration = null, string? sessionId = null)
    {

        if (configuration == null) configuration = new Configuration();

        string queryString = $"?clientId={clientId.ToClientId()}&prismUserId={prismUserID}&employeeId={employeeId}";

        RestResponse? response = new RestRequest().UsingEndpoint(
                                                        endpoint: $"/prismSecurity/v1/isEmployeeAllowed{queryString}",
                                                        method: Method.Get,
                                                        configuration: configuration,
                                                        sessionId: sessionId)
                                                    .GetResponse();

        if (response != null)
            return response.GetAPIReturn()?.ToModel<SecurityModels.SecurityResponse>();
        else
            return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };
    }

    public static APIReturnModel? UpdateManagerUserRole(string prismUserID, int checksum, List<string> userRoles, List<string> humanResourceRoles, Configuration? configuration = null, string? sessionId = null)
    {

        if (configuration == null) configuration = new Configuration();
        if (sessionId == null) sessionId = BaseController.GetSessionID(configuration);

        var body = @"{" + "\n" +
            @$"  ""sessionId"": ""{sessionId}""," + "\n" +
            @$"  ""prismUserId"": ""{prismUserID}""," + "\n" +
            @$"  ""checksum"": ""{checksum}""," + "\n" +
            @"  ""userRole"": [" + "\n";

        int roleIndex = 1;
        foreach (var role in userRoles)
        {
            body += @$"    ""{role}""";
            if (roleIndex < userRoles.Count)
            {
                body += @"," + "\n";
                roleIndex++;
            }
            else
                body += "\n";
        }
        body += @"  ]," + "\n";
        body += @"  ""humanResourceRole"": [" + "\n";


        roleIndex = 1;
        foreach (var role in humanResourceRoles)
        {
            body += @$"    ""{role}""";
            if (roleIndex < humanResourceRoles.Count)
            {
                body += @"," + "\n";
                roleIndex++;
            }
            else
                body += "\n";
        }
        body += @"  ]" + "\n";
        body += @"}";

        RestResponse? response = new RestRequest().UsingPostEndpoint(
                                                        endpoint: $"/prismSecurity/v1/updateManagerUserRole",
                                                        method: Method.Post,
                                                        jsonBody: body,
                                                        configuration: configuration)
                                                    .GetResponse();

        if (response != null)
            return response.GetAPIReturn()?.ToModel<SecurityModels.SecurityResponse>();
        else
            return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };
    }


}