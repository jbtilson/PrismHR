using PrismHRAPI.Controllers;
using PrismHRAPI.Models.PrismModels;
using PrismHRAPI.Tests.Support;
using Xunit;

namespace PrismHRAPI.Tests.IntegrationTests;

public class PrismSecurityTests : IClassFixture<PrismFixture>
{
    PrismFixture prismFixture;
    public PrismSecurityTests(PrismFixture prismFixture)
    {
        this.prismFixture = prismFixture;
    }


    [Fact]
    [Trait("Category", "Prism")]
    public void GetUserDetailsTest()
    {
        if (!string.IsNullOrEmpty(prismFixture.configuration["securitytests:userId"]))
        {
            var y = PrismSecurityController.GetUserDetails(
                prismUserId: prismFixture.configuration["securitytests:userId"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(SecurityModels.SecurityResponse), "Invalid type returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).userDetails != null, "Invalid result returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).userDetails?.id == prismFixture.configuration["securitytests:userId"], "Invalid value returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The user id could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetUserListTest()
    {
        if (int.TryParse(prismFixture.configuration["benefittests:clientId"], out int clientId))
        {
            var y = PrismSecurityController.GetUserList(
                clientId: clientId,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(SecurityModels.SecurityResponse), "Invalid type returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).userListResult != null, "Invalid result returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).userListResult?.userList != null, "Invalid result returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).userListResult?.userList.Count > 0, "Invalid count returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetUserRolesListTest()
    {
        var y = PrismSecurityController.GetUserRolesList(
            configuration: prismFixture.prismConfiguration,
            sessionId: prismFixture.prismSessionId);

        if (y != null)
        {
            prismFixture.prismSessionId = y.sessionId;
            Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
            Assert.True(y.APIResult?.GetType() == typeof(SecurityModels.SecurityResponse), "Invalid type returned.");
            Assert.True(((SecurityModels.SecurityResponse)y.APIResult).rolesList != null, "Invalid result returned.");
        }
        else
            Assert.False(y == null, "The response was null");
    }

    [Fact]
    public void GetUserRoleDetailsTest()
    {
        if (!string.IsNullOrEmpty(prismFixture.configuration["securitytests:roleId"]))
        {
            var y = PrismSecurityController.GetUserRoleDetails(
                roleId: prismFixture.configuration["securitytests:roleId"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(SecurityModels.SecurityResponse), "Invalid type returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).roleDetail != null, "Invalid result returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).roleDetail?.roleId == prismFixture.configuration["securitytests:roleId"], "Invalid value returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The role id could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetUserDataSecurityTest()
    {
        if (int.TryParse(prismFixture.configuration["benefittests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["securitytests:managerId"]))
        {
            var y = PrismSecurityController.GetUserDataSecurity(
                clientId: clientId,
                prismUserId: prismFixture.configuration["securitytests:managerId"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(SecurityModels.SecurityResponse), "Invalid type returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).dataSecurity != null, "Invalid result returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).dataSecurity?.clientId == prismFixture.configuration["securitytests:clientId"], "Invalid result returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id or manager id could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetEmployeeListTest()
    {
        if (int.TryParse(prismFixture.configuration["securitytests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["securitytests:managerId"]))
        {
            var y = PrismSecurityController.GetEmployeeList(
                clientId: clientId,
                prismUserId: prismFixture.configuration["securitytests:managerId"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(SecurityModels.SecurityResponse), "Invalid type returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).allowedEmployee != null, "Invalid result returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).allowedEmployee?.Count > 0, "Invalid count returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id or manager id could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetEmployeeClientListForEmployeeIdTest()
    {
        if (!string.IsNullOrEmpty(prismFixture.configuration["securitytests:employeeId"]))
        {
            var y = PrismSecurityController.GetEmployeeClientListForEmployeeId(
                employeeId: prismFixture.configuration["securitytests:employeeId"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(SecurityModels.SecurityResponse), "Invalid type returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).employeeClient != null, "Invalid result returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).employeeClient?.Count > 0, "Invalid count returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).employeeClient?.First().clientId == prismFixture.configuration["securitytests:clientId"], "Invalid value returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The employee id could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetEmployeeClientListForPrismIdTest()
    {
        if (!string.IsNullOrEmpty(prismFixture.configuration["securitytests:employeeUserId"]))
        {
            var y = PrismSecurityController.GetEmployeeClientListForPrismId(
                prismUserId: prismFixture.configuration["securitytests:employeeUserId"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(SecurityModels.SecurityResponse), "Invalid type returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).employeeClient != null, "Invalid result returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).employeeClient?.Count > 0, "Invalid count returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).employeeClient?.First().clientId == prismFixture.configuration["securitytests:clientId"], "Invalid value returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The employee user id could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetClientListTest()
    {
        if (!string.IsNullOrEmpty(prismFixture.configuration["securitytests:employeeUserId"]))
        {
            var y = PrismSecurityController.GetClientList(
                prismUserId: prismFixture.configuration["securitytests:employeeUserId"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(SecurityModels.SecurityResponse), "Invalid type returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).allowedClientId != null, "Invalid result returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).allowedClientId?.Count > 0, "Invalid count returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).allowedClientId?.First() == prismFixture.configuration["securitytests:clientId"], "Invalid value returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id or employee user id could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void IsClientAllowedTest()
    {
        if (int.TryParse(prismFixture.configuration["benefittests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["securitytests:employeeUserId"]))
        {
            var y = PrismSecurityController.IsClientAllowed(
                prismUserID: prismFixture.configuration["securitytests:employeeUserId"]!,
                clientId: clientId,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);
            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(SecurityModels.SecurityResponse), "Invalid type returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).isClientAllowed != null, "Invalid result returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).isClientAllowed == true, "Invalid value returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id or employee user id could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void IsEmployeeAllowedTest()
    {
        if (int.TryParse(prismFixture.configuration["securitytests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["securitytests:managerId"]) && !string.IsNullOrEmpty(prismFixture.configuration["securitytests:employeeId"]))
        {
            var y = PrismSecurityController.IsEmployeeAllowed(
                prismUserID: prismFixture.configuration["securitytests:managerId"]!,
                clientId: clientId,
                employeeId: prismFixture.configuration["securitytests:employeeId"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(SecurityModels.SecurityResponse), "Invalid type returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).isEmployeeAllowed != null, "Invalid result returned.");
                Assert.True(((SecurityModels.SecurityResponse)y.APIResult).isEmployeeAllowed == true, "Invalid value returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id or employee user id could not be parsed.  Please check your appsettings.json or user settings.");
    }
}

