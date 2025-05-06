using PrismHRAPI.Extensions;
using PrismHRAPI.Models;
using PrismHRAPI.Models.PrismModels;
using RestSharp;

namespace PrismHRAPI.Controllers;

public class PrismLoginController
{

    /// <summary>
    /// This API operation returns the status for the API permissions request.
    /// </summary>
    /// <param name="WebUserId">The web service user ID</param>
    /// <returns></returns>
    public static APIReturnModel? CheckPermissionsRequestStatus(string WebUserId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            RestResponse? response = new RestRequest()
                                            .UsingEndpoint(endpoint: $"/login/v1/checkPermissionsRequestStatus?webServiceUser={WebUserId}", method: Method.Get, configuration: configuration, sessionId: sessionId)
                                            .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<LoginModels.CheckPermissionsRequestStatusResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    /// <summary>
    /// Authenticate and create a session token that can be used with subsequent calls to API operations.
    /// </summary>
    /// <returns></returns>
    public static APIReturnModel? CreatePEOSession(Configuration? configuration = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            RestResponse? response = new RestRequest().UsingEndpoint(endpoint: "/login/v1/createPeoSession", method: Method.Post, configuration: configuration, sessionId: string.Empty)
                                                        .WithParameters(new List<RequestParameter>()
                                                        {
                                                            new RequestParameter(name: "application/x-www-form-urlencoded", value: $"username={configuration.Username}&password={configuration.Password}&peoId={configuration.PEOId}", type: ParameterType.RequestBody)
                                                        })
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    /// <summary>
    /// This API operation returns the current API permissions for the logged in web service user.
    /// </summary>
    /// <returns></returns>
    public static APIReturnModel? GetAPIPermissions(Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            RestResponse? response = new RestRequest()
                                            .UsingEndpoint(endpoint: "/login/v1/getAPIPermissions", method: Method.Get, configuration: configuration, sessionId: sessionId)
                                            .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<LoginModels.GetAPIPermissionsStatusResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    /// <summary>
    /// Use this method to ping and keep a session alive. You will require a valid session id to perform this operation.
    /// </summary>
    /// <returns></returns>
    public static APIReturnModel? InvalidateSession(Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            RestResponse? response = new RestRequest()
                                            .UsingEndpoint(endpoint: "/login/v1/invalidateSession", method: Method.Post, configuration: configuration, sessionId: sessionId)
                                            .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<LoginModels.InvalidateSessionResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    /// <summary>
    /// Use this method to ping and keep a session alive. You will require a valid session id to perform this operation.
    /// </summary>
    /// <returns></returns>
    public static APIReturnModel? KeepAlive(Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            RestResponse? response = new RestRequest()
                                            .UsingEndpoint(endpoint: "/login/v1/keepAlive", method: Method.Post, configuration: configuration, sessionId: sessionId)
                                            .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<LoginModels.KeepAliveResponse>();
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

