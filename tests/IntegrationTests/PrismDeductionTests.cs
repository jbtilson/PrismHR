using PrismHRAPI.Controllers;
using PrismHRAPI.Models.PrismModels;
using PrismHRAPI.Tests.Support;
using Xunit;

namespace PrismHRAPI.Tests.IntegrationTests;

public class PrismDeductionTests : IClassFixture<PrismFixture>
{
    PrismFixture prismFixture;
    public PrismDeductionTests(PrismFixture prismFixture)
    {
        this.prismFixture = prismFixture;
    }

    [Fact]
    public void GetGarnishmentPaymentHistoryTest()
    {
        if (int.TryParse(prismFixture.configuration["deductiontests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["deductiontests:employeeId"]))
        {
            var y = PrismDeductionController.GetGarnishmentPaymentHistory(
                clientId: clientId,
                employeeId: prismFixture.configuration["deductiontests:employeeId"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(DeductionModels.DeductionResponse), "Invalid type returned.");
                Assert.True(((DeductionModels.DeductionResponse)y.APIResult).paymentHistory != null, "Invalid result returned.");
                Assert.True(((DeductionModels.DeductionResponse)y.APIResult).paymentHistory?.Count > 0, "Invalid count returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id or employee id could not be parsed.  Please check your appsettings.json or user settings.");
    }
}

