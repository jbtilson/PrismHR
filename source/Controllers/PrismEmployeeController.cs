using PrismHRAPI.Extensions;
using PrismHRAPI.Models;
using PrismHRAPI.Models.PrismModels;
using RestSharp;

namespace PrismHRAPI.Controllers;

public class PrismEmployeeController
{
    public static APIReturnModel? GetEmployee(string employeeId, int? clientId = null , Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?employeeId={employeeId}";
            if (clientId != null) queryString += $"&clientId={clientId.ToClientId()}";
            queryString += "&options=Person,Client,Compensation,DirectDeposit,BenefitEnrollStatus,ScheduledDeductions,ContactInformation";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/employee/v1/getEmployee{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<EmployeeModels.EmployeeResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetEmployee(List<string> employeeId, int? clientId = null, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            bool firstAdded = false;
            string queryString = $"?";
            foreach (var item in employeeId)
            {
                if (!firstAdded)
                {
                    queryString += $"employeeId={item}";
                    firstAdded = true;
                }
                else
                    queryString += $"&employeeId={item}";
            }
            if (clientId != null) queryString += $"&clientId={clientId.ToClientId()}";
            queryString += "&options=Person,Client,Compensation,DirectDeposit,BenefitEnrollStatus,ScheduledDeductions,ContactInformation";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/employee/v1/getEmployee{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<EmployeeModels.EmployeeResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetEmployeeOnLeaveList(int clientId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}";
            queryString += $"&statusClass=L"; // include only on-leave employees

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/employee/v1/getEmployeeList{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<EmployeeModels.EmployeeResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetEmployeeList(int clientId, string? typeClass = null, bool includeTerms = false, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}";
            if (!string.IsNullOrEmpty(typeClass)) queryString += $"&typeClass={typeClass}"; // if no type class is specified we will end up with all types
            if (!includeTerms) queryString += "&statusClass=AL"; // include only active or on-leave employees

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/employee/v1/getEmployeeList{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<EmployeeModels.EmployeeResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetEmployees(int clientId, bool includeTerms = false, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            var result = new APIReturnModel() { errorCode = "0", errorMessage = string.Empty, sessionId = sessionId, APIResult = new EmployeeModels.EmployeeResponse() };
            var employees = new List<EmployeeModels.EmployeeResponse.EmployeeModel>();

            // Grab the employee list to start building the return with and make sure that it has returned data
            var employeeListResult = GetEmployeeList(clientId: clientId, includeTerms: includeTerms, configuration: configuration, sessionId: sessionId);
            if (employeeListResult == null || employeeListResult.APIResult == null) return new() { errorCode = "411", errorMessage = "The API did not return any employees for this client.", sessionId = null };

            // Grab employees from the return so that they can be looked up and make sure that there are returned employees
            var employeeList = ((EmployeeModels.EmployeeResponse)employeeListResult.APIResult).employeeList.employeeId;
            if(employeeList == null) return new() { errorCode = "411", errorMessage = "The API did not return any employees for this client.", sessionId = null };

            // Grab the just acquired session id so that we can reuse it for subsequent calls
            sessionId = employeeListResult.sessionId;
            result.sessionId = employeeListResult.sessionId;

            // Loop the employee ids and grab their details in batch for the return
            List<string> employeeIds = new();
            int eeIndex = 1;
            
            foreach (var employee in employeeList)
            {
                switch (eeIndex)
                {
                    case 20:
                        employeeIds.Add(employee);

                        var employeeDetailResult = GetEmployee(employeeId: employeeIds, clientId: clientId, configuration: configuration, sessionId: sessionId);
                        if (employeeDetailResult == null || employeeDetailResult.APIResult == null) continue;

                        var employeeDetail = ((EmployeeModels.EmployeeResponse)employeeDetailResult.APIResult).employee;
                        if (employeeDetail == null) continue;

                        employees.AddRange(employeeDetail);

                        eeIndex = 1;
                        employeeIds = new();

                        break;
                    default:
                        employeeIds.Add(employee);
                        eeIndex++;
                        break;
                }
            }

            // Grab any remaining entries that need added
            if(employeeIds.Count > 0)
            {
                var employeeDetailResults = GetEmployee(employeeId: employeeIds, clientId: clientId, configuration: configuration, sessionId: sessionId);
                if (employeeDetailResults != null && employeeDetailResults.APIResult != null)
                {
                    var employeeDetails = ((EmployeeModels.EmployeeResponse)employeeDetailResults.APIResult).employee;
                    if (employeeDetails != null)
                        employees.AddRange(employeeDetails);
                }
            }

            // Return a fully formatted response result
            result.APIResult = new EmployeeModels.EmployeeResponse() { employee = employees, employeeList = ((EmployeeModels.EmployeeResponse)employeeListResult.APIResult).employeeList };

            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? GetHistory(int clientId, string employeeId, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            string queryString = $"?clientId={clientId.ToClientId()}&employeeId={employeeId}";

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/employee/v1/getHistory{queryString}",
                                                            method: Method.Get,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<EmployeeModels.EmployeeResponse>();
            else
                return new APIReturnModel() { errorCode = "411", errorMessage = "The API returned a null response.", sessionId = null };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new APIReturnModel() { errorCode = "911", errorMessage = ex.Message, sessionId = null };
        }
    }

    public static APIReturnModel? LookupBySsn(string ssn, Configuration? configuration = null, string? sessionId = null)
    {
        try
        {
            if (configuration == null) configuration = new Configuration();

            RestResponse? response = new RestRequest().UsingEndpoint(
                                                            endpoint: $"/employee/v1/lookupBySsn",
                                                            method: Method.Post,
                                                            configuration: configuration,
                                                            sessionId: sessionId)
                                                        .WithParameters(new List<RequestParameter>()
                                                        {
                                                            new RequestParameter(name: "application/x-www-form-urlencoded", value: $"ssn={ssn}", type: ParameterType.RequestBody)
                                                        })
                                                        .GetResponse();

            if (response != null)
                return response.GetAPIReturn()?.ToModel<EmployeeModels.EmployeeResponse>();
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

