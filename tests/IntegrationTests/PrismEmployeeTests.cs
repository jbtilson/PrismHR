using PrismHRAPI.Controllers;
using PrismHRAPI.Models.PrismModels;
using PrismHRAPI.Tests.Support;
using Xunit;

namespace PrismHRAPI.Tests.IntegrationTests;

public class PrismEmployeeTests : IClassFixture<PrismFixture>
{
    PrismFixture prismFixture;
    public PrismEmployeeTests(PrismFixture prismFixture)
    {
        this.prismFixture = prismFixture;
    }

    [Fact]
    public void GetEmployeeTest()
    {
        if (int.TryParse(prismFixture.configuration["employeetests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["employeetests:employeeId"]))
        {
            var y = PrismEmployeeController.GetEmployee(
                employeeId: prismFixture.configuration["employeetests:employeeId"]!, 
                clientId: clientId, 
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(EmployeeModels.EmployeeResponse), "Invalid type returned.");
                Assert.True(((EmployeeModels.EmployeeResponse)y.APIResult).employee != null, "Invalid list returned.");
                Assert.True(((EmployeeModels.EmployeeResponse)y.APIResult).employee?.Count > 0, "Invalid list count returned.");
                Assert.True(((EmployeeModels.EmployeeResponse)y.APIResult).employee?.First().employeeId == prismFixture.configuration["employeetests:employeeId"], "Invalid result returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id or employee id(s) could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetEmployeeMultipleTest()
    {
        if (int.TryParse(prismFixture.configuration["employeetests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["employeetests:employeeId"]) && !string.IsNullOrEmpty(prismFixture.configuration["employeetests:employeeId2"]))
        {
            var y = PrismEmployeeController.GetEmployee(
                employeeId: new List<string>() { prismFixture.configuration["employeetests:employeeId"]!, prismFixture.configuration["employeetests:employeeId2"]! }, 
                clientId: clientId,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(EmployeeModels.EmployeeResponse), "Invalid type returned.");
                Assert.True(((EmployeeModels.EmployeeResponse)y.APIResult).employee != null, "Invalid list returned.");
                Assert.True(((EmployeeModels.EmployeeResponse)y.APIResult).employee?.Count > 0, "Invalid list count returned.");
            }
            else
                Assert.False(y == null, "The response was null");
            }
        else
            Assert.False(null, "The client id or employee id(s) could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetEmployeeListTest()
    {
        if (int.TryParse(prismFixture.configuration["employeetests:clientId"], out int clientId))
        {
            var y = PrismEmployeeController.GetEmployeeList(
                clientId: clientId, 
                includeTerms: true, 
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(EmployeeModels.EmployeeResponse), "Invalid type returned.");
                Assert.True(((EmployeeModels.EmployeeResponse)y.APIResult).employeeList.employeeId != null, "Invalid list returned.");
                Assert.True(((EmployeeModels.EmployeeResponse)y.APIResult).employeeList.employeeId?.Count > 0, "Invalid list count returned.");
            }
            else
                Assert.False(y == null, "The response was null");
            }
        else
            Assert.False(null, "The client id or type class could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetEmployeeListFulltimeTest()
    {
        if (int.TryParse(prismFixture.configuration["employeetests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["employeetests:typeClassFullTime"]))
        {
            var y = PrismEmployeeController.GetEmployeeList(
                clientId: clientId,
                typeClass: prismFixture.configuration["employeetests:typeClassFullTime"]!,
                includeTerms: true,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(EmployeeModels.EmployeeResponse), "Invalid type returned.");
                Assert.True(((EmployeeModels.EmployeeResponse)y.APIResult).employeeList.employeeId != null, "Invalid list returned.");
                Assert.True(((EmployeeModels.EmployeeResponse)y.APIResult).employeeList.employeeId?.Count > 0, "Invalid list count returned.");
            }
            else
                Assert.False(y == null, "The response was null");
            }
        else
            Assert.False(null, "The client id or employee id(s) could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetEmployeeListParttimeTest()
    {
        if (int.TryParse(prismFixture.configuration["employeetests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["employeetests:typeClassPartTime"]))
        {
            var y = PrismEmployeeController.GetEmployeeList(
                clientId: clientId,
                typeClass: prismFixture.configuration["employeetests:typeClassPartTime"]!,
                includeTerms: true,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(EmployeeModels.EmployeeResponse), "Invalid type returned.");
                Assert.True(((EmployeeModels.EmployeeResponse)y.APIResult).employeeList.employeeId != null, "Invalid list returned.");
                Assert.True(((EmployeeModels.EmployeeResponse)y.APIResult).employeeList.employeeId?.Count > 0, "Invalid list count returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id or type class could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetEmployeesTest()
    {
        if (int.TryParse(prismFixture.configuration["employeetests:clientId"], out int clientId))
        {
            var y = PrismEmployeeController.GetEmployees(
                clientId: clientId,
                includeTerms: false,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(EmployeeModels.EmployeeResponse), "Invalid type returned.");
                Assert.True(((EmployeeModels.EmployeeResponse)y.APIResult).employee != null, "Invalid list returned.");
                Assert.True(((EmployeeModels.EmployeeResponse)y.APIResult).employee.Count > 0, "Invalid list count returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id or type class could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetHistoryTest()
    {
        if (int.TryParse(prismFixture.configuration["employeetests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["employeetests:employeeId"]))
        {
            var y = PrismEmployeeController.GetHistory(
                clientId: clientId,
                employeeId: prismFixture.configuration["employeetests:employeeId"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(EmployeeModels.EmployeeResponse), "Invalid type returned.");
                Assert.True(((EmployeeModels.EmployeeResponse)y.APIResult).historyRecord != null, "Invalid list returned.");
                Assert.True(((EmployeeModels.EmployeeResponse)y.APIResult).historyRecord.Count > 0, "Invalid list count returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id or employee id(s) could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void LookupBySsnTest()
    {
        if (!string.IsNullOrEmpty(prismFixture.configuration["employeetests:ssn"]))
        {
            var y = PrismEmployeeController.LookupBySsn(
                ssn: prismFixture.configuration["employeetests:ssn"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(EmployeeModels.EmployeeResponse), "Invalid type returned.");
                Assert.True(((EmployeeModels.EmployeeResponse)y.APIResult).employeeAccounts != null, "Invalid list returned.");
                Assert.True(((EmployeeModels.EmployeeResponse)y.APIResult).employeeAccounts.Count > 0, "Invalid list count returned.");
                Assert.True(((EmployeeModels.EmployeeResponse)y.APIResult).employeeAccounts.First().employeeId == prismFixture.configuration["employeetests:employeeId"], "Invalid result returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id or employee id(s) could not be parsed.  Please check your appsettings.json or user settings.");
    }
}

