using PrismHRAPI.Controllers;
using PrismHRAPI.Models.PrismModels;
using PrismHRAPI.Tests.Support;
using Xunit;

namespace PrismHRAPI.Tests.IntegrationTests;

public class PrismTimesheetTests : IClassFixture<PrismFixture>
{
    PrismFixture prismFixture;
    public PrismTimesheetTests(PrismFixture prismFixture)
    {
        this.prismFixture = prismFixture;
    }


    [Fact]
    public void GetTimeSheetDataTest()
    {
        //TODO: Evaluate the accuracy of GetTimeSheetData return
        if (int.TryParse(prismFixture.configuration["timesheettests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["timesheettests:batchId"]))
        {
            var y = PrismTimesheetController.GetTimeSheetData(
                clientId: clientId,
                batchId: prismFixture.configuration["timesheettests:batchId"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(TimesheetModels.TimesheetResponse), "Invalid type returned.");
                Assert.True(((TimesheetModels.TimesheetResponse)y.APIResult).timeSheetDataList != null, "Invalid result returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id or batch id could not be parsed.  Please check your appsettings.json or user settings.");
    }

}

