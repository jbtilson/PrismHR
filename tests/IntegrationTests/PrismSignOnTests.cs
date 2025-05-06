using PrismHRAPI.Controllers;
using PrismHRAPI.Models.PrismModels;
using PrismHRAPI.Tests.Support;
using Xunit;

namespace PrismHRAPI.Tests.IntegrationTests;

public class PrismSignOnTests : IClassFixture<PrismFixture>
{
    PrismFixture prismFixture;
    public PrismSignOnTests(PrismFixture prismFixture)
    {
        this.prismFixture = prismFixture;
    }

    [Fact]
    public void GetFavoritesTest()
    {
        if (!string.IsNullOrEmpty(prismFixture.configuration["signontests:userId"]))
        {
            var y = PrismSignOnController.GetFavorites(
                userId: prismFixture.configuration["signontests:userId"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(SignOnModels.SignOnResponse), "Invalid type returned.");
                Assert.True(((SignOnModels.SignOnResponse)y.APIResult).favorite != null, "Invalid result returned.");
                Assert.True(((SignOnModels.SignOnResponse)y.APIResult).favorite?.Count > 0, "Invalid count returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The user id could not be parsed.  Please check your appsettings.json or user settings.");
    }


}

