using PrismHRAPI.Models;

namespace PrismHRAPI.Controllers;

internal class BaseController
{
    /// Uses the provided service credentials to get a new session id from the Prism API
    /// </summary>
    /// <param name="serviceCredentials">The service credentials to use for the call</param>
    /// <returns></returns>
    internal static string? GetSessionID(Configuration configuration)
    {
        APIReturnModel? sessionResult = PrismLoginController.CreatePEOSession(configuration);
        return sessionResult?.sessionId;
    }
}

