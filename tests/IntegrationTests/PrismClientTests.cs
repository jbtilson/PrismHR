using PrismHRAPI.Controllers;
using PrismHRAPI.Models.PrismModels;
using PrismHRAPI.Tests.Support;
using Xunit;

namespace PrismHRAPI.Tests.IntegrationTests;

public class PrismClientTests : IClassFixture<PrismFixture>
{
    PrismFixture prismFixture;
    public PrismClientTests(PrismFixture prismFixture)
    {
        this.prismFixture = prismFixture;
    }

    [Fact]
    public void GetClientMasterTest()
    {
        if (int.TryParse(prismFixture.configuration["clienttests:clientId"], out int clientId))
        {
            var y = PrismClientController.GetClientMaster(
                clientId: clientId,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(ClientModels.ClientMasterResponse), "Invalid type returned.");
                Assert.True(((ClientModels.ClientMasterResponse)y.APIResult).clientMaster != null, "Invalid list returned.");
                Assert.True(((ClientModels.ClientMasterResponse)y.APIResult).clientMaster?.id == prismFixture.configuration["clienttests:clientId"], "Invalid result returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetClientCodesTest()
    {
        if (int.TryParse(prismFixture.configuration["clienttests:clientId"], out int clientId))
        {
            var y = PrismClientController.GetClientCodes(
                clientId: clientId,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(ClientModels.ClientMasterResponse), "Invalid type returned.");
                Assert.True(((ClientModels.ClientMasterResponse)y.APIResult).clientCodes != null, "Invalid type returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetBenefitGroupTest()
    {
        if (int.TryParse(prismFixture.configuration["clienttests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["clienttests:benefitGroupId"]))
        {
            var y = PrismClientController.GetBenefitGroup(
                clientId: clientId,
                groupId: new List<string>() { prismFixture.configuration["clienttests:benefitGroupId"]! },
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(ClientModels.ClientMasterResponse), "Invalid type returned.");
                Assert.True(((ClientModels.ClientMasterResponse)y.APIResult).benefitGroupResult != null, "Invalid list returned.");
                Assert.True(((ClientModels.ClientMasterResponse)y.APIResult).benefitGroupResult?.Count > 0, "Invalid list count returned.");
            }
        }
        else
            Assert.False(null, "The client id or benefit group id could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetAllPrismClientContactsTest()
    {
        if (int.TryParse(prismFixture.configuration["clienttests:clientId"], out int clientId))
        {
            var y = PrismClientController.GetAllPrismClientContacts(
                clientId: clientId,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(ClientModels.ClientMasterResponse), "Invalid type returned.");
                Assert.True(((ClientModels.ClientMasterResponse)y.APIResult).prismClientContactResult.prismClientContact != null, "Invalid list returned.");
                Assert.True(((ClientModels.ClientMasterResponse)y.APIResult).prismClientContactResult.prismClientContact?.Count > 0, "Invalid list count returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetClientListActiveTest()
    {
        if (int.TryParse(prismFixture.configuration["clienttests:clientId"], out int clientId))
        {
            var y = PrismClientController.GetClientList(
                inActive: false,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(ClientModels.ClientMasterResponse), "Invalid type returned.");
                Assert.True(((ClientModels.ClientMasterResponse)y.APIResult).clientListResult.clientList != null, "Invalid list returned.");
                Assert.True(((ClientModels.ClientMasterResponse)y.APIResult).clientListResult.clientList?.Count > 0, "Invalid list count returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetClientListInActiveTest()
    {
        if (int.TryParse(prismFixture.configuration["clienttests:clientId"], out int clientId))
        {
            var y = PrismClientController.GetClientList(
                inActive: true,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(ClientModels.ClientMasterResponse), "Invalid type returned.");
                Assert.True(((ClientModels.ClientMasterResponse)y.APIResult).clientListResult.clientList != null, "Invalid list returned.");
                Assert.True(((ClientModels.ClientMasterResponse)y.APIResult).clientListResult.clientList?.Count > 0, "Invalid list count returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetClientLocationDetailsTest()
    {
        if (int.TryParse(prismFixture.configuration["clienttests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["clienttests:locationId"]))
        {
            var y = PrismClientController.GetClientLocationDetails(
                clientId: clientId,
                locationId: prismFixture.configuration["clienttests:locationId"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(ClientModels.ClientMasterResponse), "Invalid type returned.");
                Assert.True(((ClientModels.ClientMasterResponse)y.APIResult).locationDetails != null, "Invalid list returned.");
                Assert.True(((ClientModels.ClientMasterResponse)y.APIResult).locationDetails.locationId == prismFixture.configuration["clienttests:locationId"], "Invalid value returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id or location id could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetPayGroupDetailsTest()
    {
        if (int.TryParse(prismFixture.configuration["clienttests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["clienttests:payGroupCode"]))
        {
            var y = PrismClientController.GetPayGroupDetails(
                clientId: clientId, payGroupCode: prismFixture.configuration["clienttests:payGroupCode"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(ClientModels.ClientMasterResponse), "Invalid type returned.");
                Assert.True(((ClientModels.ClientMasterResponse)y.APIResult).payGroupDetails != null, "Invalid list returned.");
                Assert.True(((ClientModels.ClientMasterResponse)y.APIResult).payGroupDetails.payGroupCode == prismFixture.configuration["clienttests:payGroupCode"], "Invalid value returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id or pay group id could not be parsed.  Please check your appsettings.json or user settings.");
    }

}

