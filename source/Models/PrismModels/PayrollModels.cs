using System.Text.Json.Serialization;
using PrismHRAPI.Support;
using static PrismHRAPI.Support.JSONConverterHelpers;

namespace PrismHRAPI.Models.PrismModels;

public class PayrollModels
{
    public class PayrollResponse : BaseModel
    {
        public ClientsWithVouchersModel clientsWithVouchers { get; set; } = new();

        public class ClientsWithVouchersModel : BaseModel
        {
            public List<string> payrollClient { get; set; } = new();
            public List<string> billingClient { get; set; } = new();
        }

        public double? total { get; set; } = 0;
        public double? startpage { get; set; } = 0;
        public double? count { get; set; } = 0;

        public List<PayrollVoucherModel> payrollVoucher { get; set; } = new();

        public class PayrollVoucherModel : BaseModel
        {
            public string? voucherId { get; set; }
            public string? status { get; set; }
            public string? type { get; set; }
            public string? voidDate { get; set; }
            public string? checkNumber { get; set; }
            public string? payDate { get; set; }
            public string? employeeId { get; set; }
            public string? payPeriod { get; set; }
            public string? payPeriodStart { get; set; }
            public string? payPeriodEnd { get; set; }
            public string? payGroup { get; set; }
            public string? dateProcessed { get; set; }
            public double? totalEarnings { get; set; }

            public List<EmployeeTaxModel> employeeTax { get; set; } = new();
            public class EmployeeTaxModel : BaseModel
            {
                public string? empTaxDeductCode { get; set; }
                public string? empTaxDeductCodeDesc { get; set; }
                public double? empTaxableAmount { get; set; }
                public double? empTaxAmount { get; set; }
                public double? empOverLimitAmount { get; set; }
            }

            public double? netPay { get; set; }
            public string? voidVoucherId { get; set; }
            public double? fitTaxableAmount { get; set; }
            public double? earnAmount { get; set; }
            public double? otherEarnAmount { get; set; }
            public string? wcHomeClass { get; set; }
            public string? wcState { get; set; }

            public List<WorkerCompModel> workerComp { get; set; } = new();
            public class WorkerCompModel : BaseModel
            {
                public string? wcClass { get; set; }
                public double? wcTaxablePay { get; set; }
                public double? wcPremAmount { get; set; }
                public double? wcBillAmount { get; set; }
                public double? wcPremBill { get; set; }
            }

            public List<EarningModel> earning { get; set; } = new();
            public class EarningModel : BaseModel
            {
                public string? payCode { get; set; }
                public string? payClass { get; set; }
                public string? payClassDescription { get; set; }
                public string? chargeDate { get; set; }
                public double? hoursUnits { get; set; }
                public double? hoursWorked { get; set; }
                public double? unitRate { get; set; }
                public double? payAmount { get; set; }
                public string? division { get; set; }
                public string? jobCode { get; set; }
                public string? shift { get; set; }
                public string? department { get; set; }
                public string? location { get; set; }
                public string? glCode { get; set; }
                public string? workComp { get; set; }
                public string? projWork { get; set; }
                public string? projPhase { get; set; }
            }

            public List<OtherEarningsDetailModel> otherEarningsDetail { get; set; } = new();
            public class OtherEarningsDetailModel : BaseModel
            {
                public string? otherEarnCode { get; set; }
                public string? otherEarnsDesc { get; set; }
                public double? otherEarnAmount { get; set; }

            }

            public List<FsaMatchModel> fsaMatch { get; set; } = new();
            public class FsaMatchModel : BaseModel
            {
                public string? code { get; set; }
                public string? description { get; set; }
                public double? matchAmt { get; set; }
                public string? acctType { get; set; }
            }

            public List<CompanyTaxModel> companyTax { get; set; } = new();
            public class CompanyTaxModel : BaseModel
            {
                public string? comTaxEntity { get; set; }
                public string? comTaxDeductCode { get; set; }
                public string? comTaxDeductCodeDesc { get; set; }
                public double? comExemptAmount { get; set; }
                public double? comShelteredAmount { get; set; }
                public double? comTaxableAmount { get; set; }
                public string? comTaxType { get; set; }
                public double? comTaxAmount { get; set; }
                public double? comOvrLimit { get; set; }
                public double? comTaxRate { get; set; }
                public string? comClientSutaRpt { get; set; }
            }

            public string? batchId { get; set; }

            public List<DeductionModel> deduction { get; set; } = new();
            public class DeductionModel : BaseModel
            {
                public string? deductCode { get; set; }
                public string? deductDescription { get; set; }
                public double? deductAmount { get; set; }
                public string? deductType { get; set; }
                public string? deductUnionId { get; set; }
            }

            public List<OtherDeductionModel> otherDeduction { get; set; } = new();
            public class OtherDeductionModel : BaseModel
            {
                public string? otherDeductCode { get; set; }
                public string? otherDeductDescription { get; set; }
                public double? otherDeductAmount { get; set; }
                public string? otherDeductOneTimeSwitch { get; set; }
            }

            public List<BenefitModel> benefit { get; set; } = new();
            public class BenefitModel : BaseModel
            {
                public string? planId { get; set; }
                public double? premiumAmt { get; set; }
                public double? empContrib { get; set; }
                public double? empDeduct { get; set; }
                public string? coveragePeriod { get; set; }
                public string? adjRef { get; set; }
                public double? premiumCost { get; set; }
            }

            public string? bankAccount { get; set; }
            public string? checkNum { get; set; }
            public double? checkAmt { get; set; }
            public string? payStubType { get; set; }
            public string? checkAccountACH { get; set; }

            public List<DirectDepositModel> directDeposit { get; set; } = new();
            public class DirectDepositModel : BaseModel
            {
                public string? transitNum { get; set; }
                public string? accountNum { get; set; }
                public string? status { get; set; }
                public double? amount { get; set; }
            }

            public List<EmployerContributionsModel> employerContributions { get; set; } = new();
            public class EmployerContributionsModel : BaseModel
            {
                public string? code { get; set; }
                public string? description { get; set; }
                public double? amount { get; set; }
            }

            public RetirementModel retirement { get; set; } = new();
            public class RetirementModel : BaseModel
            {
                public string? planId { get; set; }
                public string? planYearPeriod { get; set; }
                public double? baseEarnings { get; set; }
                public double? electiveContributionsPreTax { get; set; }
                public double? catchUpContributionsPreTax { get; set; }
                public double? rothContributionsPostTax { get; set; }
                public double? rothCatchUpContributionsPostTax { get; set; }
                public double? employeeContributionsPostTax { get; set; }
                public double? employerMatchingContributions { get; set; }
                public double? employerNonElectiveContributions { get; set; }
                public double? employerSafeHarborMatchType1 { get; set; }
                public double? employerSafeHarborMatchType2 { get; set; }
                public double? peoMatchingContribution { get; set; }
                public double? employeeRetirementLoanPayments { get; set; }
            }

            public GlAcctDistributionModel glAcctDistribution { get; set; } = new();
            public class GlAcctDistributionModel : BaseModel
            {
                public double? glTotalDebit { get; set; }
                public double? glTotalCredit { get; set; }

                public List<GlDebitDataModel> glDebitData { get; set; } = new();
                public class GlDebitDataModel : BaseModel
                {
                    public string? glDebitAcct { get; set; }
                    public double? glDebitAmount { get; set; }

                    public List<DebitSegmentDetailModel> debitSegmentDetail { get; set; } = new();
                    public class DebitSegmentDetailModel : BaseModel
                    {
                        public string? debitSegmentName { get; set; }
                        public string? debitSegmentValue { get; set; }
                    }
                }

                public List<GlCreditDataModel> glCreditData { get; set; } = new();
                public class GlCreditDataModel : BaseModel
                {
                    public string? glCreditAcct { get; set; }
                    public double? glCreditAmount { get; set; }

                    public List<CreditSegmentDetailModel> creditSegmentDetail { get; set; } = new();
                    public class CreditSegmentDetailModel : BaseModel
                    {
                        public string? creditSegmentName { get; set; }
                        public string? creditSegmentValue { get; set; }
                    }
                }
            }

            public AsoClientGLAcctDistributionModel asoClientGLAcctDistribution { get; set; } = new();
            public class AsoClientGLAcctDistributionModel : BaseModel
            {
                public List<AsoCreditsModel> asoCredits { get; set; } = new();
                public class AsoCreditsModel : BaseModel
                {
                    public string? glCreditAcct { get; set; }
                    public string? glCreditAcctDesc { get; set; }
                    public double? glTotalCredit { get; set; }
                }

                public List<AsoDebitsModel> asoDebits { get; set; } = new();
                public class AsoDebitsModel : BaseModel
                {
                    public string? glDebitAcct { get; set; }
                    public string? glDebitAcctDesc { get; set; }
                    public double? glTotalDebit { get; set; }
                }
            }

            public List<TaxFilingStatusModel> taxFilingStatus { get; set; } = new();
            public class TaxFilingStatusModel : BaseModel
            {
                public string? taxAuthId { get; set; }
                public string? taxAuthName { get; set; }
                public string? filingStatus { get; set; }
                public string? allowances { get; set; }
                public string? overrideType { get; set; }
                public string? overrideAmount { get; set; }
            }

            public WcInformationModel wcInformation { get; set; } = new();
            public class WcInformationModel : BaseModel
            {
                public string? wcPolicy { get; set; }
                public List<string> wcNotEligible { get; set; } = new();
                public List<string> wcSheltered { get; set; } = new();
                public List<string> wcOverBillRate { get; set; } = new();
                public List<string> wcBillIncludeCredit { get; set; } = new();
                public List<string> wcBillAmtIncludeCredit { get; set; } = new();
                public string? wcWeekEndDate { get; set; }
                public string? wcPolicyYearEnd { get; set; }
                public List<string> wcPremiumPay { get; set; } = new();
                public List<string> wcTria { get; set; } = new();
                public string? wcRateTemplate { get; set; }
                public List<string> wcOverBillAmt { get; set; } = new();
                public List<string> wcGrossRate { get; set; } = new();
                public List<string> wcStraightPay { get; set; } = new();
                public List<string> wcPremAmt { get; set; } = new();
                public List<string> wcClass { get; set; } = new();
                public List<string> wcBasePay { get; set; } = new();
                public List<string> wcBillAmt { get; set; } = new();
                public List<string> wcTaxablePay { get; set; } = new();
                public List<string> wcPremiumBill { get; set; } = new();
                public List<string> wcAccruedAmt { get; set; } = new();
                public string? wcState { get; set; }
                public List<string> wcHoursWorked { get; set; } = new();
                public List<string> wcEarnNonComp { get; set; } = new();
                public List<string> wcPayLocationReg { get; set; } = new();
                public List<string> wcPayLocationOT { get; set; } = new();
                public List<string> wcPayLocationBreakCode { get; set; } = new();
                public List<string> wcRecalcDifference { get; set; } = new();
                public List<string> wcLocationState { get; set; } = new();
                public List<string> wcLocationPolicy { get; set; } = new();
                public List<string> wcLocationYearEndDate { get; set; } = new();
                public List<string> wcLocationTemplate { get; set; } = new();
                public List<string> wcPayLocationExp { get; set; } = new();
            }

            public List<FromArrearsModel> fromArrears { get; set; } = new();
            public class FromArrearsModel : BaseModel
            {
                public string? dedCode { get; set; }
                public string? dedDescription { get; set; }
                public string? arrearsAmt { get; set; }
                public string? arrearsDate { get; set; }
                public string? arrearsRefNo { get; set; }
                public string? coveragePeriod { get; set; }
                public string? planId { get; set; }
                public string? unionId { get; set; }
                public string? loanNo { get; set; }
            }

            public List<ToArrearsModel> toArrears { get; set; } = new();
            public class ToArrearsModel : BaseModel
            {
                public string? dedCode { get; set; }
                public string? dedDescription { get; set; }
                public string? arrearsAmt { get; set; }
                public string? coveragePeriod { get; set; }
                public string? planId { get; set; }
                public string? unionId { get; set; }
                public string? loanNo { get; set; }
            }

            public string? importBatchNo { get; set; }
        }


        public List<BillingVoucherModel> billingVoucher { get; set; } = new();
        public class BillingVoucherModel
        {
            public string? voucherId { get; set; }
            public string? batchNumber { get; set; }
            public string? voucherStatus { get; set; }
            public string? employeeId { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? payDate { get; set; }
            public string? invoice { get; set; }
            public string? division { get; set; }
            public string? department { get; set; }
            public string? location { get; set; }
            public string? shift { get; set; }
            public string? position { get; set; }
            public string? project { get; set; }
            public string? compensation { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? voidDate { get; set; }
            public List<double> adminWcFeeDscnts { get; set; } = new();

            public List<double> adminFeeWageBills { get; set; } = new();
            public List<double> adminFeeHoursBills { get; set; } = new();
            public List<double> adminFeeFlatBills { get; set; } = new();
            public List<double> adminFeeMinMaxes { get; set; } = new();
            public List<double> adminFeeWageDscnts { get; set; } = new();
            public List<double> adminFeeHoursDscnts { get; set; } = new();
            public List<double> adminFeeFlatDscnts { get; set; } = new();

            public double? adminFeeOverbillOASDI { get; set; }
            public double? adminFeeOverbillFICA { get; set; }
            public double? adminFeeOverbillFUTA { get; set; }
            public double? adminFeeOverbillSUTA { get; set; }
            public double? adminFeeOverbillMISC { get; set; }
            public double? adminFeeOverbillWCO { get; set; }
            public double? adminFeeOverbillWCP { get; set; }

            public List<BillTaxesModel> billTaxes { get; set; } = new();
            public class BillTaxesModel
            {
                public string? comTaxType { get; set; }
                public double? comBillAmt { get; set; }
            }

            public List<BillingDetailsModel> billingDetails { get; set; } = new();
            public class BillingDetailsModel
            {
                public string? billCode { get; set; }
                public string? billType { get; set; }
                public double? billAmt { get; set; }
            }

            public List<SumBillingsModel> sumBillings { get; set; } = new();
            public class SumBillingsModel
            {
                public string? billCode { get; set; }
                public string? billCodeDescription { get; set; }
                public double? billAmt { get; set; }
            }

            public List<BillSortModel> billSort { get; set; } = new();
            public class BillSortModel
            {
                public string? sort { get; set; }
                public string? billCode { get; set; }
                public string? billCodeDescription { get; set; }
                public double? billAmt { get; set; }
                public double? billDisc { get; set; }
                public double? billCost { get; set; }
            }

            public class AsoClientGLAcctDistribution
            {
                public List<AsoCredits> asoCredits { get; set; } = new();
                public List<AsoDebits> asoDebits { get; set; } = new();
                public class AsoCredits
                {
                    public string? glCreditAcct { get; set; }
                    public string? glCreditAcctDesc { get; set; }
                    public double? glTotalCredit { get; set; }
                }

                public class AsoDebits
                {
                    public string? glDebitAcct { get; set; }
                    public string? glDebitAcctDesc { get; set; }
                    public double? glTotalDebit { get; set; }
                }
            }

            public List<PeoClientAccounting> peoClientAccounting { get; set; } = new();
            public class PeoClientAccounting
            {
                public string? glAccount { get; set; }
                public double? glDebit { get; set; }
                public double? glCredit { get; set; }
                public string? glHoursWorked { get; set; }
                public string? glHoursUnits { get; set; }
            }

        }


        public List<BatchListModel> batchList { get; set; } = new();
        public class BatchListModel
        {
            public string? batchId { get; set; }
            public string? payDate { get; set; }
            public string? batchType { get; set; }
            public string? batchStatus { get; set; }
            public List<PayGroupModel> payGroup { get; set; } = new();

            public class PayGroupModel
            {
                public string? payGroupId { get; set; }
                public string? payPeriodStartDate { get; set; }
                public string? payPeriodEndDate { get; set; }
                public string? weeksWorked { get; set; }
                public string? deductPeriod { get; set; }

            }
        }
    }
}

