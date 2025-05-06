using PrismHRAPI.Controllers;
using PrismHRAPI.Models.PrismModels;
using PrismHRAPI.Tests.Support;
using Xunit;

namespace PrismHRAPI.Tests.IntegrationTests;

public class PrismTaxRateTests : IClassFixture<PrismFixture>
{
    PrismFixture prismFixture;
    public PrismTaxRateTests(PrismFixture prismFixture)
    {
        this.prismFixture = prismFixture;
    }

    [Fact]
    public void GetStateW4ParamsTest()
    {
        if (!string.IsNullOrEmpty(prismFixture.configuration["taxratetests:stateCode"]))
        {
            var y = PrismTaxRateController.GetStateW4Params(
                stateCode: prismFixture.configuration["taxratetests:stateCode"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(TaxRateModels.TaxRateResponse), "Invalid type returned.");
                Assert.True(((TaxRateModels.TaxRateResponse)y.APIResult).stateCode != null, "Invalid result returned.");
                Assert.True(((TaxRateModels.TaxRateResponse)y.APIResult).stateCode == prismFixture.configuration["taxratetests:stateCode"], "Invalid value returned.");
                Assert.True(((TaxRateModels.TaxRateResponse)y.APIResult).fields != null, "Invalid result returned.");
                Assert.True(((TaxRateModels.TaxRateResponse)y.APIResult).fields?.Count > 0, "Invalid count returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The state code could not be parsed.  Please check your appsettings.json or user settings.");
    }
}

