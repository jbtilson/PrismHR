using PrismHRAPI.Controllers;
using PrismHRAPI.Models.PrismModels;
using PrismHRAPI.Tests.Support;
using Xunit;

namespace PrismHRAPI.Tests.IntegrationTests;

public class PrismPayrollTests : IClassFixture<PrismFixture>
{
    PrismFixture prismFixture;
    public PrismPayrollTests(PrismFixture prismFixture)
    {
        this.prismFixture = prismFixture;
    }


    [Fact]
    public void GetClientsWithVouchers()
    {
        //TODO: Evaluate the accuracy of GetClientsWithVouchers return
        if (!string.IsNullOrEmpty(prismFixture.configuration["payrolltests:payDateStart"]) && !string.IsNullOrEmpty(prismFixture.configuration["payrolltests:payDateEnd"]))
        {
            var y = PrismPayrollController.GetClientsWithVouchers(
                payDateStart: DateTime.Parse(prismFixture.configuration["payrolltests:payDateStart"]!),
                payDateEnd: DateTime.Parse(prismFixture.configuration["payrolltests:payDateEnd"]!),
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(PayrollModels.PayrollResponse), "Invalid type returned.");
                Assert.True(((PayrollModels.PayrollResponse)y.APIResult).clientsWithVouchers != null, "Invalid result returned.");
                Assert.True(((PayrollModels.PayrollResponse)y.APIResult).clientsWithVouchers.billingClient != null, "Invalid result returned.");
                Assert.True(((PayrollModels.PayrollResponse)y.APIResult).clientsWithVouchers.payrollClient != null, "Invalid result returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id, employee id or benefit id(s) could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetPayrollVouchersTest()
    {
        //TODO: Evaluate the accuracy of GetPayrollVouchersTest return
        if (int.TryParse(prismFixture.configuration["payrolltests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["payrolltests:payDateStart"]) && !string.IsNullOrEmpty(prismFixture.configuration["payrolltests:payDateEnd"]))
        {
            var y = PrismPayrollController.GetPayrollVouchers(
                clientId: clientId,
                payDateStart: DateTime.Parse(prismFixture.configuration["payrolltests:payDateStart"]!),
                payDateEnd: DateTime.Parse(prismFixture.configuration["payrolltests:payDateEnd"]!),
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(PayrollModels.PayrollResponse), "Invalid type returned.");
                Assert.True(((PayrollModels.PayrollResponse)y.APIResult).payrollVoucher != null, "Invalid result returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id, employee id or benefit id(s) could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetPayrollVouchersEmployerContributionsTest()
    {
    //TODO: Evaluate the accuracy of GetPayrollVouchersEmployerContributionsTest return
    if (int.TryParse(prismFixture.configuration["payrolltests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["payrolltests:payDateStart"]) && !string.IsNullOrEmpty(prismFixture.configuration["payrolltests:payDateEnd"]))
        {
            var y = PrismPayrollController.GetPayrollVouchersEmployerContributions(
                clientId: clientId,
                payDateStart: DateTime.Parse(prismFixture.configuration["payrolltests:payDateStart"]!),
                payDateEnd: DateTime.Parse(prismFixture.configuration["payrolltests:payDateEnd"]!),
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(PayrollModels.PayrollResponse), "Invalid type returned.");
                Assert.True(((PayrollModels.PayrollResponse)y.APIResult).payrollVoucher != null, "Invalid result returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id, employee id or benefit id(s) could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetBillingVouchersTest()
    {
    //TODO: Evaluate the accuracy of GetBillingVouchersTest return
    if (int.TryParse(prismFixture.configuration["payrolltests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["payrolltests:payDateStart"]) && !string.IsNullOrEmpty(prismFixture.configuration["payrolltests:payDateEnd"]))
        {
            var y = PrismPayrollController.GetBillingVouchers(
                clientId: clientId,
                payDateStart: DateTime.Parse(prismFixture.configuration["payrolltests:payDateStart"]!),
                payDateEnd: DateTime.Parse(prismFixture.configuration["payrolltests:payDateEnd"]!),
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(PayrollModels.PayrollResponse), "Invalid type returned.");
                Assert.True(((PayrollModels.PayrollResponse)y.APIResult).billingVoucher != null, "Invalid result returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id, employee id or benefit id(s) could not be parsed.  Please check your appsettings.json or user settings.");
    }

    [Fact]
    public void GetBatchListByDateTest()
    {
        //TODO: Evaluate the accuracy of GetBillingVouchersTest return
        if (int.TryParse(prismFixture.configuration["payrolltests:clientId"], out int clientId) && !string.IsNullOrEmpty(prismFixture.configuration["payrolltests:dateType"]) && !string.IsNullOrEmpty(prismFixture.configuration["payrolltests:payDateStart"]) && !string.IsNullOrEmpty(prismFixture.configuration["payrolltests:payDateEnd"]))
        {
            var y = PrismPayrollController.GetBatchListByDate(
                clientId: clientId,
                dateType: prismFixture.configuration["payrolltests:dateType"]!,
                payDateStart: DateTime.Parse(prismFixture.configuration["payrolltests:payDateStart"]!),
                payDateEnd: DateTime.Parse(prismFixture.configuration["payrolltests:payDateEnd"]!),
                configuration: prismFixture.prismConfiguration,
                sessionId: prismFixture.prismSessionId);

            if (y != null)
            {
                prismFixture.prismSessionId = y.sessionId;
                Assert.True(y.errorCode == "0", $"ERROR: {y.errorCode} ({y.errorMessage})");
                Assert.True(y.APIResult?.GetType() == typeof(PayrollModels.PayrollResponse), "Invalid type returned.");
                Assert.True(((PayrollModels.PayrollResponse)y.APIResult).batchList != null, "Invalid result returned.");
            }
            else
                Assert.False(y == null, "The response was null");
        }
        else
            Assert.False(null, "The client id, date type, start date or end date could not be parsed.  Please check your appsettings.json or user settings.");
    }

}

