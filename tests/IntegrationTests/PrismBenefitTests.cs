using PrismHRAPI.Controllers;
using PrismHRAPI.Models.PrismModels;
using PrismHRAPI.Tests.Support;
using Xunit;

namespace PrismHRAPI.Tests.IntegrationTests;

public class PrismBenefitTests : IClassFixture<PrismFixture>
{
    PrismFixture prismFixture;
    public PrismBenefitTests(PrismFixture prismFixture)
    {
        this.prismFixture = prismFixture;
    }


    [Fact]
    public void GetBenefitPlansTest()
    {
        if (int.TryParse(prismFixture.configuration["benefittests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["benefittests:employeeId"]) && !string.IsNullOrEmpty(prismFixture.configuration["benefittests:benefitId"]) && !string.IsNullOrEmpty(prismFixture.configuration["benefittests:benefitId2"]))
        {
            var y = PrismBenefitController.GetBenefitPlans(
                clientId: clientId,
                employeeId: prismFixture.configuration["benefittests:employeeId"]!,
                planId: new() { prismFixture.configuration["benefittests:benefitId"]!, prismFixture.configuration["benefittests:benefitId2"]! },
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(BenefitModels.BenefitResponse), "Invalid type returned.");
                Assert.True(((BenefitModels.BenefitResponse)y.APIResult).benefitPlan != null, "Invalid result returned.");
                Assert.True(((BenefitModels.BenefitResponse)y.APIResult).benefitPlan?.Count > 0, "Invalid result returned.");
                Assert.True(((BenefitModels.BenefitResponse)y.APIResult).benefitPlan?.First().planId == prismFixture.configuration["benefittests:benefitId"] || ((BenefitModels.BenefitResponse)y.APIResult).benefitPlan?.First().planId == prismFixture.configuration["benefittests:benefitId2"], "Invalid value(s) returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id, employee id or benefit id(s) could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetBenefitPlanListTest()
    {
        var y = PrismBenefitController.GetBenefitPlanList(
            configuration: prismFixture.prismConfiguration,
            sessionId: prismFixture.prismSessionId);

        if (y != null)
        {
            prismFixture.prismSessionId = y.sessionId;
            Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
            Assert.True(y.APIResult?.GetType() == typeof(BenefitModels.BenefitResponse), "Invalid type returned.");
            Assert.True(((BenefitModels.BenefitResponse)y.APIResult).benefitPlanList != null, "Invalid result returned.");
            Assert.True(((BenefitModels.BenefitResponse)y.APIResult).benefitPlanList?.Count > 0, "Invalid result returned.");
        }
        else
            Assert.False(y == null, "The response was null");
    }

    [Fact]
    public void GetGroupBenefitPlanTest()
    {
        if (!string.IsNullOrEmpty(prismFixture.configuration["benefittests:benefitId"]))
        {
            var y = PrismBenefitController.GetGroupBenefitPlan(
                planId: prismFixture.configuration["benefittests:benefitId"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(BenefitModels.BenefitResponse), "Invalid type returned.");
                Assert.True(((BenefitModels.BenefitResponse)y.APIResult).groupBenefitPlan != null, "Invalid result returned.");
                Assert.True(((BenefitModels.BenefitResponse)y.APIResult).groupBenefitPlan?.planId == prismFixture.configuration["benefittests:benefitId"], "Invalid value returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The benefit id could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetClientBenefitPlansTest()
    {
        if (int.TryParse(prismFixture.configuration["benefittests:clientId"], out int clientId))
        {
            var y = PrismBenefitController.GetClientBenefitPlans(
                clientId: clientId,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(BenefitModels.BenefitResponse), "Invalid type returned.");
                Assert.True(((BenefitModels.BenefitResponse)y.APIResult).benefitPlanOverview != null, "Invalid result returned.");
                Assert.True(((BenefitModels.BenefitResponse)y.APIResult).benefitPlanOverview?.Count > 0, "Invalid count returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetClientBenefitPlanSetupDetailsTest()
    {
        if (int.TryParse(prismFixture.configuration["benefittests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["benefittests:benefitId"]) && !string.IsNullOrEmpty(prismFixture.configuration["benefittests:benefitPlanClass"]))
        {
            var y = PrismBenefitController.GetClientBenefitPlanSetupDetails(
                clientId: clientId,
                planId: prismFixture.configuration["benefittests:benefitId"]!,
                planClass: prismFixture.configuration["benefittests:benefitPlanClass"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(BenefitModels.BenefitResponse), "Invalid type returned.");
                Assert.True(((BenefitModels.BenefitResponse)y.APIResult).benefitPlanDetail != null, "Invalid result returned.");
                Assert.True(((BenefitModels.BenefitResponse)y.APIResult).benefitPlanDetail?.planId == prismFixture.configuration["benefittests:benefitId"], "Invalid value returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id, benefit plan class or benefit id(s) could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetBenefitRuleTest()
    {
        if (int.TryParse(prismFixture.configuration["benefittests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["benefittests:benefitId"]))
        {
            var y = PrismBenefitController.GetBenefitRule(
                clientId: clientId,
                planId: prismFixture.configuration["benefittests:benefitId"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(BenefitModels.BenefitResponse), "Invalid type returned.");
                Assert.True(((BenefitModels.BenefitResponse)y.APIResult).benefitRule != null, "Invalid result returned.");
                Assert.True(((BenefitModels.BenefitResponse)y.APIResult).benefitRule?.Count > 0, "Invalid count returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id or benefit id(s) could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetActiveBenefitPlansTest()
    {
        if (int.TryParse(prismFixture.configuration["benefittests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["benefittests:employeeId"]))
        {
            var y = PrismBenefitController.GetActiveBenefitPlans(
                clientId: clientId,
                employeeId: prismFixture.configuration["benefittests:employeeId"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(BenefitModels.BenefitResponse), "Invalid type returned.");
                Assert.True(((BenefitModels.BenefitResponse)y.APIResult).benefitPlan != null, "Invalid result returned.");
                Assert.True(((BenefitModels.BenefitResponse)y.APIResult).benefitPlan?.Count > 0, "Invalid count returned.");
            }
            else
                Assert.False(y == null, "The response was null");
            }
        else
            Assert.False(null, "The client id or employee id could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetGroupBenefitRatesTest()
    {
        if (!string.IsNullOrEmpty(prismFixture.configuration["benefittests:benefitId"]))
        {
            var y = PrismBenefitController.GetGroupBenefitRates(
                planId: prismFixture.configuration["benefittests:benefitId"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(BenefitModels.BenefitResponse), "Invalid type returned.");
                Assert.True(((BenefitModels.BenefitResponse)y.APIResult).billingRate != null, "Invalid result returned.");
                Assert.True(((BenefitModels.BenefitResponse)y.APIResult).billingRate?.Count > 0, "Invalid count returned.");
                Assert.True(((BenefitModels.BenefitResponse)y.APIResult).premiumRate != null, "Invalid result returned.");
                Assert.True(((BenefitModels.BenefitResponse)y.APIResult).premiumRate?.Count > 0, "Invalid count returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id or benefit id(s) could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetEnrollmentPlanDetailsTest()
    {
        if (!string.IsNullOrEmpty(prismFixture.configuration["benefittests:benefitId"]))
        {
            var y = PrismBenefitController.GetEnrollmentPlanDetails(
                offerType: prismFixture.configuration["benefittests:offertype"]!,
                planId: prismFixture.configuration["benefittests:benefitId2"]!,
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(BenefitModels.BenefitResponse), "Invalid type returned.");
                Assert.True(((BenefitModels.BenefitResponse)y.APIResult).enrollmentPlanDetails != null, "Invalid result returned.");
                Assert.True(((BenefitModels.BenefitResponse)y.APIResult).enrollmentPlanDetails?.Count > 0, "Invalid count returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id or benefit id(s) could not be parsed.  Please check your appsettings.json or user settings.");
    }


}

