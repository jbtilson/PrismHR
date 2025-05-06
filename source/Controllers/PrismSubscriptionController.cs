using System.Text.Json;
using PrismHRAPI.Extensions;
using PrismHRAPI.Models;
using PrismHRAPI.Models.PrismModels;
using RestSharp;
using static PrismHRAPI.Models.PrismModels.SubscriptionModels.EventResponse.SubscriptionEventModel;

namespace PrismHRAPI.Controllers;

public class PrismSubscriptionController
{

    public static APIReturnModel? GetEvents(string subscriptionId, string replayId, int? numberOfEvents = null, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            configuration ??= new Configuration();

            string queryString = $"?subscriptionId={subscriptionId}";
            queryString += $"&replayId={replayId}";
            if (numberOfEvents != null) queryString += $"&numberOfEvents={numberOfEvents}";

            RestResponse? response = new RestRequest().UsingEndpoint(endpoint: $"/subscription/v1/getEvents{queryString}", method: Method.Get, configuration: configuration, sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
            {
                var eventResponseModel = response.GetAPIReturn()?.ToModel<SubscriptionModels.EventResponse>();

                try
                {
                    List<SubscriptionModels.EventResponse.SubscriptionEventModel> subscriptionEventModels = new List<SubscriptionModels.EventResponse.SubscriptionEventModel>();

                    if (eventResponseModel != null)
                    {
                        SubscriptionModels.EventResponse? eventResponse = eventResponseModel.APIResult as SubscriptionModels.EventResponse;
                        if (eventResponse != null)
                        {
                            foreach (var item in eventResponse.subscriptionEvent)
                            {
                                if (item.additionalInformation == null)
                                {
                                    Console.WriteLine($"PrismSubscriptionController.GetEvents: additional information was null");
                                    item.additionalInfoObject = new AdditionalInformationModel();
                                }
                                else
                                {
                                    var addtlInfoObject = JsonSerializer.Deserialize<AdditionalInformationModel>(item.additionalInformation);
                                    if (addtlInfoObject == null)
                                    {
                                        Console.WriteLine($"PrismSubscriptionController.GetEvents: addtlInfoObject was null");
                                    }
                                    item.additionalInfoObject = addtlInfoObject ?? new AdditionalInformationModel();
                                }
                                subscriptionEventModels.Add(item);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"PrismSubscriptionController.GetEvents: eventResponse was null");
                        }
                        eventResponseModel.APIResult = subscriptionEventModels;
                    }
                    else
                    {
                        Console.WriteLine($"PrismSubscriptionController.GetEvents: eventResponseModel was null");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return eventResponseModel;
            }
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetNewEvents(string subscriptionId, int? numberOfEvents = null, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?subscriptionId={subscriptionId}";
            if (numberOfEvents != null) queryString += $"&numberOfEvents={numberOfEvents}";

            RestResponse? response = new RestRequest().UsingEndpoint(endpoint: $"/subscription/v1/getNewEvents{queryString}", method: Method.Get, configuration: configuration, sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<SubscriptionModels.EventResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetAllSubscriptions(string? userStringId = null, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = string.Empty;
            if (userStringId != null) queryString = $"?userStringId={userStringId}";

            RestResponse? response = new RestRequest().UsingEndpoint(endpoint: $"/subscription/v1/getAllSubscriptions{queryString}", method: Method.Get, configuration: configuration, sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<SubscriptionModels.SubscriptionResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetSubscription(string subscriptionId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?subscriptionId={subscriptionId}";

            RestResponse? response = new RestRequest().UsingEndpoint(endpoint: $"/subscription/v1/getSubscription{queryString}", method: Method.Get, configuration: configuration, sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<SubscriptionModels.SubscriptionResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? CancelSubscription(string subscriptionId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            configuration ??= new Configuration();

            string p = $"subscriptionId={subscriptionId}";

            RestResponse? response = new RestRequest().UsingEndpoint(endpoint: $"/subscription/v1/cancelSubscription", method: Method.Post, configuration: configuration, sessionId: sessionId)
                                                        .WithParameters(new List<RequestParameter>() { new RequestParameter(name: "application/x-www-form-urlencoded", value: p, type: ParameterType.RequestBody) })
                                                        .GetResponse();


            if (response != null)
                return response.GetAPIReturn()?.ToModel<SubscriptionModels.SubscriptionResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? CreateSubscription(string schemaName, string className, string? excludes = null, string? includes = null, string? clientId = null, string? description = null, string? userStringId = null, string? webhookUrls = null, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            configuration ??= new Configuration();

            // Build the parameters list
            string p = $"schemaName={schemaName}&className={className}";

            // These are all optional includes to the parameters
            if (excludes != null) p += $"&excludes={excludes}";
            if (includes != null) p += $"&includes={includes}";
            if (clientId != null) p += $"&clientId={clientId}";
            if (description != null) p += $"&description={description}";
            if (userStringId != null) p += $"&userStringId={userStringId}";
            if (webhookUrls != null) p += $"&webhookUrls={webhookUrls}";

            List<RequestParameter> requestParameters = new List<RequestParameter>();
            requestParameters.Add(new RequestParameter(name: "application/x-www-form-urlencoded", value: p, type: ParameterType.RequestBody));

            RestResponse? response = new RestRequest().UsingEndpoint(endpoint: $"/subscription/v1/createSubscription", method: Method.Post, configuration: configuration, sessionId: sessionId)
                                                        .WithParameters(requestParameters)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<SubscriptionModels.SubscriptionResponse>();
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

