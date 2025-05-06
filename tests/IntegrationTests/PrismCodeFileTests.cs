using PrismHRAPI.Controllers;
using PrismHRAPI.Models.PrismModels;
using PrismHRAPI.Tests.Support;
using Xunit;

namespace PrismHRAPI.Tests.IntegrationTests;

public class PrismCodeFileTests : IClassFixture<PrismFixture>
{
    PrismFixture prismFixture;
    public PrismCodeFileTests(PrismFixture prismFixture)
    {
        this.prismFixture = prismFixture;
    }


    [Fact]
    public void GetUserDefinedFields_ClientDetailsTest()
    {
        if (int.TryParse(prismFixture.configuration["codefiletests:clientId"], out int clientId))
        {
            var y = PrismCodeFileController.GetUserDefinedFields_ClientDetails(
                clientId: clientId,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(CodeFileModels.CodeFileResponse), "Invalid type returned.");
                Assert.True(((CodeFileModels.CodeFileResponse)y.APIResult).customFields != null, "Invalid list returned.");
                Assert.True(((CodeFileModels.CodeFileResponse)y.APIResult).customFields?.Count > 0, "Invalid list count returned.");
            }
            else
                Assert.False(y == null, "The response was null");
            }
        else
            Assert.False(null, "The client id could not be parsed.  Please check your appsettings.json or user settings.");
    }
}

