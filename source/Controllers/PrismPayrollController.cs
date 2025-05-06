using PrismHRAPI.Extensions;
using PrismHRAPI.Models;
using PrismHRAPI.Models.PrismModels;
using RestSharp;

namespace PrismHRAPI.Controllers;

public class PrismPayrollController
{
    public static APIReturnModel? GetClientsWithVouchers(DateTime payDateStart, DateTime payDateEnd, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?payDateStart={payDateStart.ToString("yyyy-MM-dd")}&payDateEnd={payDateEnd.ToString("yyyy-MM-dd")}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/payroll/v1/getClientsWithVouchers{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<PayrollModels.PayrollResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetPayrollVouchers(int clientId, DateTime payDateStart, DateTime payDateEnd, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}&payDateStart={payDateStart.ToString("yyyy-MM-dd")}&payDateEnd={payDateEnd.ToString("yyyy-MM-dd")}";
            queryString += $"&options=EmployerContribution";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/payroll/v1/getPayrollVouchers{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<PayrollModels.PayrollResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetPayrollVouchersEmployerContributions(int clientId, DateTime payDateStart, DateTime payDateEnd, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            //int pageIndex = 0;

            string queryString = $"?clientId={clientId.ToClientId()}&payDateStart={payDateStart.ToString("yyyy-MM-dd")}&payDateEnd={payDateEnd.ToString("yyyy-MM-dd")}";
            queryString += $"&options=EmployerContribution";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/payroll/v1/getPayrollVouchers{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<PayrollModels.PayrollResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetBillingVouchers(int clientId, DateTime payDateStart, DateTime payDateEnd, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}&payDateStart={payDateStart.ToString("yyyy-MM-dd")}&payDateEnd={payDateEnd.ToString("yyyy-MM-dd")}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/payroll/v1/getBillingVouchers{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<PayrollModels.PayrollResponse>();
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
    /// Use this operation to return a list of all payroll batches within a specified date range. If you want, you can also filter the results by pay group
    /// </summary>
    /// <param name="clientId">client identifier</param>
    /// <param name="dateType">whether to use pay periods, pay dates, or post dates when returning batches in the specified date range; valid values are PAY, PERIOD, and POST</param>
    /// <param name="payDateStart">starting date for the payroll batch range</param>
    /// <param name="payDateEnd">ending date for the payroll batch range</param>
    /// <param name="payGroup">enter a pay group if you want to only return batches associated with that group</param>
    /// <param name="configuration"></param>
    /// <param name="sessionId"></param>
    /// <returns></returns>
    public static APIReturnModel? GetBatchListByDate(int clientId, string dateType, DateTime payDateStart, DateTime payDateEnd, string? payGroup = null, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}&dateType={dateType}&startDate={payDateStart.ToString("yyyy-MM-dd")}&endDate={payDateEnd.ToString("yyyy-MM-dd")}";
            if (payGroup != null) queryString += "&payGroup={payGroup}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/payroll/v1/getBatchListByDate{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<PayrollModels.PayrollResponse>();
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

