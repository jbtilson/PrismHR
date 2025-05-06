using PrismHRAPI.Extensions;
using PrismHRAPI.Models;
using PrismHRAPI.Models.PrismModels;
using RestSharp;

namespace PrismHRAPI.Controllers;

public class PrismBenefitController
	{
    public static APIReturnModel? GetBenefitPlanList(Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/benefits/v1/getBenefitPlanList",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<BenefitModels.BenefitResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetGroupBenefitPlan(string planId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?planId={planId}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/benefits/v1/getGroupBenefitPlan{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<BenefitModels.BenefitResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetClientBenefitPlans(int clientId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/benefits/v1/getClientBenefitPlans{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<BenefitModels.BenefitResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    } 
    public static APIReturnModel? GetClientBenefitPlanSetupDetails(int clientId, string planId, string planClass, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}";
            queryString += $"&planId={planId}";
            queryString += $"&planClass={planClass}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/benefits/v1/getClientBenefitPlanSetupDetails{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<BenefitModels.BenefitResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }        

    public static APIReturnModel? GetBenefitRule(int clientId, string? planId = null, string? groupPlanId = null, DateTime? effectiveDate = null, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}";
            if (!string.IsNullOrEmpty(planId)) queryString += $"&planId={planId}";
            if (!string.IsNullOrEmpty(groupPlanId)) queryString += $"&groupPlanId={groupPlanId}";
            if (effectiveDate != null) queryString += $"&effectiveDate={effectiveDate.Value.ToString("yyyy-MM-dd")}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/benefits/v1/getBenefitRule{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<BenefitModels.BenefitResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetActiveBenefitPlans(int clientId, string employeeId, DateTime? effectiveDate = null, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();
            
            string queryString = $"?clientId={clientId.ToClientId()}";
            queryString += $"&employeeId={employeeId}";
            if (effectiveDate != null) queryString += $"&effectiveDate={effectiveDate.Value.ToString("yyyy-MM-dd")}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/benefits/v1/getActiveBenefitPlans{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<BenefitModels.BenefitResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetBenefitPlans(int clientId, string employeeId, List<string>? planId = null, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}";
            queryString += $"&employeeId={employeeId}";
            if (planId != null)
            {
                foreach (var item in planId)
                {
                    queryString += $"&planId={item}";
                }
            }

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/benefits/v1/getBenefitPlans{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<BenefitModels.BenefitResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }
    public static APIReturnModel? GetGroupBenefitRates(string planId, DateTime? effectiveDate = null, string? networkId = null, string? options = null, string? planType = null, string? rateGroup = null, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?planId={planId}";
            if (effectiveDate != null) queryString += $"&effectiveDate={effectiveDate.Value.ToString("yyyy-MM-dd")}";
            if (!string.IsNullOrEmpty(networkId)) queryString += $"&networkId={networkId}";
            if (!string.IsNullOrEmpty(options)) queryString += $"&options={options}";
            if (!string.IsNullOrEmpty(planType)) queryString += $"&planType={planType}";
            if (!string.IsNullOrEmpty(rateGroup)) queryString += $"&rateGroup={rateGroup}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/benefits/v1/getGroupBenefitRates{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<BenefitModels.BenefitResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }


    public static APIReturnModel? GetEnrollmentPlanDetails(string offerType, string planId, DateTime? effectiveDate = null, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?planId={planId}&offerType={offerType}";
            if (effectiveDate != null) queryString += $"&effectiveDate={effectiveDate.Value.ToString("yyyy-MM-dd")}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/benefits/v1/getEnrollmentPlanDetails{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<BenefitModels.BenefitResponse>();
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

