using PrismHRAPI.Controllers;
using PrismHRAPI.Models.PrismModels;
using PrismHRAPI.Tests.Support;
using Xunit;

namespace PrismHRAPI.Tests.IntegrationTests;

public class PrismLoginTests : IClassFixture<PrismFixture>
{
    PrismFixture prismFixture;
    public PrismLoginTests(PrismFixture prismFixture)
    {
        this.prismFixture = prismFixture;
    }


    [Fact]
    public void CheckPermissionsRequestStatusTest()
    {
        if (!string.IsNullOrEmpty(prismFixture.configuration["logintests:userId"]))
        {
            var y = PrismLoginController.CheckPermissionsRequestStatus(
                WebUserId: prismFixture.configuration["logintests:userId"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(LoginModels.CheckPermissionsRequestStatusResponse), "Invalid type returned.");
                Assert.True(((LoginModels.CheckPermissionsRequestStatusResponse)y.APIResult).ApprovalStatus != null, "Invalid result returned.");
            }
            else
                Assert.False(y == null, "The response was null");
            }
        else
            Assert.False(null, "The user id could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void CreatePEOSessionTest()
    {
        var y = PrismLoginController.CreatePEOSession(configuration: prismFixture.prismConfiguration);
        if (y != null)
        {
            prismFixture.prismSessionId = y.sessionId;
            Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
            Assert.True(y.sessionId != null, "Invalid result returned.");
        }
        else
            Assert.False(y == null, "The response was null");
    }

    [Fact]
    public void GetAPIPermissionsTest()
    {
        var y = PrismLoginController.GetAPIPermissions(
            configuration: prismFixture.prismConfiguration,
            sessionId: prismFixture.prismSessionId);

        if (y != null)
        {
            prismFixture.prismSessionId = y.sessionId;
            Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
            Assert.True(y.APIResult?.GetType() == typeof(LoginModels.GetAPIPermissionsStatusResponse), "Invalid type returned.");
            Assert.True(((LoginModels.GetAPIPermissionsStatusResponse)y.APIResult).CurrentPermissions != null, "Invalid result returned.");
        }
        else
            Assert.False(y == null, "The response was null");
    }

    // [Fact]
    // [Trait("Category", "Prism")]
    // public void InvalidateSessionTest()
    // {
    //     var y = PrismLoginController.InvalidateSession(sessionId: fixture.prismSessionId);
    //     if (y != null)
    //     {
    //         fixture.prismSessionId = null;
    //         Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
    //     }
    //     else
    //         Assert.False(y == null, "The response was null");
    // }

    // [Fact]
    // [Trait("Category", "Prism")]
    // public void KeepAliveTest()
    // {
    //     var y = PrismLoginController.KeepAlive(sessionId: fixture.prismSessionId);
    //     if (y != null)
    //     {
    //         fixture.prismSessionId = y.sessionId;
    //         Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
    //     }
    //     else
    //         Assert.False(y == null, "The response was null");
    // }

}
