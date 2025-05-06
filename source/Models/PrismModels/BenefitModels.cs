using System.Text.Json.Serialization;
using PrismHRAPI.Support;
using static PrismHRAPI.Support.JSONConverterHelpers;

namespace PrismHRAPI.Models.PrismModels;

public class BenefitModels
{
    public class BenefitResponse : BaseModel
    {

        public List<BenefitPlanListModel> benefitPlanList { get; set; } = new List<BenefitPlanListModel>();
        public class BenefitPlanListModel : BaseModel
        {
            public string? planId { get; set; }
            public string? payeeId { get; set; }
            public string? planDesc { get; set; }
            public string? insuranceClass { get; set; }
            public string? insuranceClassDesc { get; set; }
        }

        public GroupBenefitPlanModel groupBenefitPlan { get; set; } = new GroupBenefitPlanModel();
        public class GroupBenefitPlanModel : BaseModel
        {
            public string? planId { get; set; }
            public string? planDescription { get; set; }
            public string? insClass { get; set; }
            public string? payeeId { get; set; }
            public string? costBasis { get; set; }
            public string? manualCalc { get; set; }
            public string? autoAdd { get; set; }
            public string? prDednCode { get; set; }
            public string? prDednCodepp { get; set; }
            public string? pr125Dedn { get; set; }
            public string? pr125Dednpp { get; set; }
            public string? billCode { get; set; }
            public string? prepayBillCode { get; set; }
            public string? offerTypeCode { get; set; }
            public string? section125 { get; set; }
            public string? cobraElectable { get; set; }
            public string? hdhpFlag { get; set; }
            public string? dpPlanId { get; set; }
            public string? clientSponsored { get; set; }
            public string? premRateGroups { get; set; }
            public string? singleCoverageGrossWages { get; set; }
            public string? stateContinuation { get; set; }
            public string? useWorkState { get; set; }
            public string? checksum { get; set; }

            public OtherProcessingParametersModel otherProcessingParameters { get; set; } = new OtherProcessingParametersModel();
            public class OtherProcessingParametersModel
            {
                public string? familyRatedMed { get; set; }
                public string? tobaccoBandedRates { get; set; }
                public string? genderBandedRates { get; set; }
                public string? spouseGenderBanded { get; set; }
                public string? wellnessBandedRates { get; set; }
                public string? useWellnessRatesAsDefault { get; set; }
                public string? ageBandMedicalBill { get; set; }
                public string? ageCalcMonth { get; set; }
                public string? ageCalcDay { get; set; }
                public string? lifeCovOpts { get; set; }
                public string? dependAgeLimit { get; set; }
                public string? dependAgeDeterminate { get; set; }

                public List<FamilyRatedMedDetailsModel> familyRatedMedDetails { get; set; } = new List<FamilyRatedMedDetailsModel>();
                public class FamilyRatedMedDetailsModel
                {
                    public string? frFromAge { get; set; }
                    public string? frToAge { get; set; }
                    public string? frMaxCalcD { get; set; }
                }

                public string? disabledDepEligible { get; set; }
                public string? disabledAltAgeLimit { get; set; }
                public string? zeroBillArrears { get; set; }
                public string? openEnrollMonth { get; set; }
                public string? openEnrollDay { get; set; }
                public string? flatCoverage { get; set; }
                public string? ltdStdPrem { get; set; }
                public string? ltdStdSalBand { get; set; }
                public string? lifeCalcType { get; set; }
                public string? spouseLifeAge { get; set; }
                public string? payRateMonth { get; set; }
                public string? payRateDay { get; set; }
                public string? networkInfo { get; set; }
                public string? networkRates { get; set; }
                public string? networkBillRates { get; set; }
                public string? newDetailPayRate { get; set; }
                public string? midMonthCov { get; set; }
                public string? allowMidMonthCovLifeEvents { get; set; }
                public string? wellnessBandedAssessDays { get; set; }
                public string? wellnessAccessDaysMnths { get; set; }
                public string? wellnessAccessBeforeAfter { get; set; }
                public string? carrierType { get; set; }
                public string? aetnaType { get; set; }
                public string? ltdStdLimit { get; set; }
                public string? useExtPrecisionRates { get; set; }
                public string? depLifeCalcType { get; set; }
                public string? depLifeAge { get; set; }
                public string? directlyCarried { get; set; }
                public string? ntxblLimit { get; set; }
            }

            public List<StatesOfferedDetailsModel> statesOfferedDetails { get; set; } = new List<StatesOfferedDetailsModel>();
            public class StatesOfferedDetailsModel
            {
                public string? statesOffered { get; set; }
                public string? statePlanNo { get; set; }
            }

            public List<PlanNetworksModel> planNetworks { get; set; } = new List<PlanNetworksModel>();
            public class PlanNetworksModel
            {
                public string? networkId { get; set; }
                public string? serviceArea { get; set; }
                public string? zipCodesExist { get; set; }
                public string? networkInactive { get; set; }
            }

            public CarrierCodeMaintenanceModel carrierCodeMaintenance { get; set; } = new CarrierCodeMaintenanceModel();
            public class CarrierCodeMaintenanceModel
            {
                public string? carrierPlanId { get; set; }
                public string? carrierGrp { get; set; }
                public string? carrierSubDiv { get; set; }
                public string? carrierBranch { get; set; }
                public string? controlNo { get; set; }
                public string? nationalPlan { get; set; }
                public string? suffix { get; set; }
                public string? carrierZipFile { get; set; }
                public string? famPlanNoIncrement { get; set; }
                public string? extRiskFactors { get; set; }
                public string? rfAppliesTo { get; set; }
                public List<string> carrierCodes { get; set; } = new List<string>();

                public List<CarrierPlanDetailsModel> carrierPlanDetails { get; set; } = new List<CarrierPlanDetailsModel>();
                public class CarrierPlanDetailsModel
                {
                    public string? planNo { get; set; }
                    public string? tpaPlanNo { get; set; }
                    public string? tpaAcctNo { get; set; }
                    public string? extRiskFactor { get; set; }
                }
            }

            public WebEnrollmentParametersModel webEnrollmentParameters { get; set; } = new WebEnrollmentParametersModel();
            public class WebEnrollmentParametersModel
            {
                public string? webEnroll { get; set; }
                public string? anytimeEnrollWorkflow { get; set; }
                public string? carrierUrl { get; set; }
                public string? planDescUrl { get; set; }
                public string? approvalRequired { get; set; }
                public string? onHrpDisplayBenType { get; set; }
                public string? collectPcpInfo { get; set; }
                public string? pcpRequired { get; set; }
                public List<string> onAttrCode { get; set; } = new List<string>();
            }

            public CoverageAmountsModel coverageAmounts { get; set; } = new CoverageAmountsModel();
            public class CoverageAmountsModel
            {
                public string? eeCovStart { get; set; }
                public string? spCovStart { get; set; }
                public string? depCovStart { get; set; }
                public string? eeCovEnd { get; set; }
                public string? eeSalaryMultiplier { get; set; }
                public string? eeCovInc { get; set; }
                public string? spCovEnd { get; set; }
                public string? spCovInc { get; set; }
                public string? spElectPerc { get; set; }
                public string? spOnlyElig { get; set; }
                public string? depCovEnd { get; set; }
                public string? depCovInc { get; set; }
                public string? depElectPerc { get; set; }
                public string? dpOnlyElig { get; set; }
                public string? reducePremiumAlso { get; set; }

                public List<AgeReductionScheduleModel> ageReductionSchedule { get; set; } = new List<AgeReductionScheduleModel>();
                public class AgeReductionScheduleModel
                {
                    public string? lifeInsAge { get; set; }
                    public string? lifeInsAgeLimiter { get; set; }
                }
            }

            public GuaranteedIssueLimitsModel guaranteedIssueLimits { get; set; } = new GuaranteedIssueLimitsModel();
            public class GuaranteedIssueLimitsModel
            {
                public string? eeEligDays { get; set; }
                public string? eeNewElig { get; set; }
                public string? neSalaryMultiplier { get; set; }
                public string? eeOeEnroll { get; set; }
                public string? oeSalaryMultiplier { get; set; }
                public string? ceEeStepAmt { get; set; }
                public string? eeLeEnroll { get; set; }
                public string? leSalaryMultiplier { get; set; }
                public string? giRounding { get; set; }
                public string? spNewElig { get; set; }
                public string? spOeEnroll { get; set; }
                public string? ceSpStepAmt { get; set; }
                public string? spLeEnroll { get; set; }
                public string? depNewElig { get; set; }
                public string? depOeEnroll { get; set; }
                public string? ceDpStepAmt { get; set; }
                public string? dpLeEnroll { get; set; }
            }

            public List<PlanTypeDetailsModel> planTypeDetails { get; set; } = new List<PlanTypeDetailsModel>();
            public class PlanTypeDetailsModel
            {
                public string? planType { get; set; }
                public string? hdhpMaxContrib { get; set; }
                public string? hsaMatch { get; set; }
                public string? carrierCode1 { get; set; }
                public string? carrierCode2 { get; set; }
                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? typeObseleteDate { get; set; }
            }

            public CorporateAccountModel corporateAccount { get; set; } = new CorporateAccountModel();
            public class CorporateAccountModel
            {
                public string? corpDebitAcct { get; set; }
                public string? corpCreditAcct { get; set; }
            }

            public SpecialOptionsModel specialOptions { get; set; } = new SpecialOptionsModel();
            public class SpecialOptionsModel
            {
                public string? spouseDOBForDependent { get; set; }
                public string? useDedBillCode { get; set; }
                public string? skipRpt5500 { get; set; }
                public string? excludeEligReport { get; set; }
                public string? excludeBillingReport { get; set; }
                public string? stubName { get; set; }
                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? termDate { get; set; }
                public string? reconGroup { get; set; }
                public string? maxDaysPrior { get; set; }
                public string? commType { get; set; }
                public string? suppressPrintOnCheck { get; set; }
                public string? allowDescOvr { get; set; }
                public string? suppArrears { get; set; }
                public string? bondEPLIAddTipsForCalc { get; set; }
                public string? reportOnW2 { get; set; }
                public string? w2ReportCost { get; set; }
                public string? riskFactorByNetwork { get; set; }
                public string? stdLimitRounding { get; set; }
                public string? replacementPlan { get; set; }
                public string? ageRateDateFixedRateGuaranty { get; set; }
                public string? specOptgYears { get; set; }
                public string? useCurrentYearForAgeCalc { get; set; }
                public string? roundSalaryForBasis { get; set; }
                public string? ageCalcOnCoverage { get; set; }
                public string? excludeMedLimitCalc { get; set; }
                public string? calcDepG { get; set; }
                public string? deMinimusAmt { get; set; }
                public string? subtractDeMin { get; set; }
                public string? skipAcaReporting { get; set; }
                public string? selfInsured { get; set; }
                public string? notAcaMec { get; set; }
                public string? notAcaMv { get; set; }
                public string? reportAcaEmployee { get; set; }
                public string? reportAcaSpouse { get; set; }
                public string? reportAcaDependents { get; set; }
                public string? suppressFlatByPlan { get; set; }
                public string? suppressFlatByOffer { get; set; }
                public string? suppressAllOnArrears { get; set; }
            }

            public ParticipationRequirementModel participationRequirement { get; set; } = new ParticipationRequirementModel();
            public class ParticipationRequirementModel
            {
                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? participationReqDate { get; set; }
                public string? participationReqPerc { get; set; }
            }
        }

        public List<BenefitPlanOverviewModel> benefitPlanOverview { get; set; } = new List<BenefitPlanOverviewModel>();
        public class BenefitPlanOverviewModel : BaseModel
        {
            public string? planId { get; set; }

            public string? planDescription { get; set; }

            public string? rateGroup { get; set; }

            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? startDate { get; set; }

            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? endDate { get; set; }

            public string? template { get; set; }

            public List<string> groupRules { get; set; } = new List<string>();
        }

        public BenefitPlanDetailModel benefitPlanDetail { get; set; } = new BenefitPlanDetailModel();
        public class BenefitPlanDetailModel : BaseModel
        {
            public string? planId { get; set; }
            public string? planClass { get; set; }
            public string? status { get; set; }
            public string? startDate { get; set; }
            public string? stopDate { get; set; }
            public string? tpaPlanIdOvr { get; set; }
            public string? useBenefitGroups { get; set; }
            public string? benefitRateGroup { get; set; }
            public string? premiumRateGroup { get; set; }
            public string? pendingRateGroup { get; set; }
            public string? pendingRateGroupEffDate { get; set; }
            public string? benefitTemplateId { get; set; }
            public string? benefitPrepay { get; set; }
            public string? prePayOffset { get; set; }
            public string? useBillingWashRules { get; set; }
            public string? washRuleOnBeforeDate { get; set; }
            public string? yearlyDeductions { get; set; }
            public string? benefitCoverageEnds { get; set; }
            public string? benefitCafeEligibility { get; set; }
            public string? benefitBillingFreq { get; set; }
            public string? deductCycle { get; set; }
            public string? overMonth { get; set; }
            public string? overDay { get; set; }
            public string? networkSelectRule { get; set; }
            public string? carrierAcct { get; set; }
            public string? pendPremRateGrp { get; set; }
            public string? pendPremRateGrpDate { get; set; }
            public string? defaultNetworkId { get; set; }
            public string? benefitAutoEnroll { get; set; }
            public string? suppressOEAutoTerm { get; set; }
            public string? planSuppBenAdj { get; set; }
            public string? ruleDateToUse { get; set; }
            public string? earliestPremiumRateDate { get; set; }
            public string? earliestBillingRateDate { get; set; }
            public string? fringePayCode { get; set; }
            public string? addtoRetirementPay { get; set; }
            public string? hiMedicalBasePlan { get; set; }
            public string? includeExclude { get; set; }
            public List<string> payCodes { get; set; } = new List<string>();
            public List<string> eligStatus { get; set; } = new List<string>();
            public List<string> eligType { get; set; } = new List<string>();
            public string? eligAge { get; set; }
            public string? eligDayMonth { get; set; }
            public string? eligDaysFrom { get; set; }
            public string? eligHours { get; set; }
            public string? eligDays { get; set; }
            public string? eligMonths { get; set; }
            public string? eligDateUsed { get; set; }
            public string? autoEnroll { get; set; }
            public string? autoEnrollPercent { get; set; }
            public string? hsaAltMatch { get; set; }
            public string? hsaMatch { get; set; }
            public string? hsaMatchFreq { get; set; }
            public string? hsaAltFixedOneTime { get; set; }
            public string? checksum { get; set; }

            public List<RiskFactorModel> riskFactor { get; set; } = new List<RiskFactorModel>();
            public class RiskFactorModel
            {
                public string? premRiskFactorDate { get; set; }
                public string? adminSurcharge { get; set; }
                public string? premRiskFactor { get; set; }
                public string? premRiskExtFactor { get; set; }
                public string? premRiskNetwork { get; set; }
            }

            public List<Hi15RuleModel> hi15Rule { get; set; } = new List<Hi15RuleModel>();
            public class Hi15RuleModel
            {
                public string? benefitGroup { get; set; }
                public string? hiMedCalc { get; set; }
            }

            public List<HsaMatchDetailModel> hsaMatchDetail { get; set; } = new List<HsaMatchDetailModel>();
            public class HsaMatchDetailModel
            {
                public string? hsaEffDate { get; set; }
                public string? hsaBenPlanId { get; set; }
                public string? hsaBenPlanType { get; set; }
                public string? hsaBenFixedAmt { get; set; }
                public string? hsaTierPct { get; set; }
                public string? hsaLumpSum { get; set; }
            }
        }

        public List<BenefitRuleModel> benefitRule { get; set; } = new List<BenefitRuleModel>();
        public class BenefitRuleModel : BaseModel
        {
            public string? planId { get; set; }
            public string? groupPlanId { get; set; }
            public string? billingRateGroup { get; set; }
            public List<string> employmentStatus { get; set; } = new List<string>();
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? effectiveDate { get; set; }
            public string? ruleAmtMadeBy { get; set; }
            public string? eligDays { get; set; }
            public string? takeOnEmpExempt { get; set; }
            public string? altContributionPlan { get; set; }
            public string? altRateGroup { get; set; }
            public string? minimumAge { get; set; }
            public string? minDayOrMonth { get; set; }
            public string? minDayOrMonthValue { get; set; }
            public string? eligDaysFrom { get; set; }
            public string? eligDateUsed { get; set; }
            public List<string> employmentType { get; set; } = new List<string>();
            public string? exemptOrNonExempt { get; set; }
            public string? networkStopDate { get; set; }
            public string? checksum { get; set; }

            public List<RuleModel> rule { get; set; } = new List<RuleModel>();
            public List<RuleModel> historicalRule { get; set; } = new List<RuleModel>();
            public class RuleModel
            {
                public string? planType { get; set; }
                public string? method { get; set; }
                public string? companyEEBill { get; set; }
                public string? employeeEEBill { get; set; }
                public string? companyDepBill { get; set; }
                public string? employeeDepBill { get; set; }
                public string? companyContribution { get; set; }
                public string? employeeTotalContribution { get; set; }
                public string? totalBilled { get; set; }
                public string? employeePremiumBilled { get; set; }
                public string? dependentsPremiumBilled { get; set; }
            }

            public BasicContributionRuleModel basicContributionRule { get; set; } = new BasicContributionRuleModel();
            public class BasicContributionRuleModel
            {
                public string? contributionMethod { get; set; }
                public string? contributionAmount { get; set; }
                public string? depContributionAmount { get; set; }
            }

            public List<DisabilitySalaryBandRuleModel> disabilitySalaryBandRule { get; set; } = new List<DisabilitySalaryBandRuleModel>();
            public class DisabilitySalaryBandRuleModel
            {
                public string? fromAnnualSalary { get; set; }
                public string? toAnnualSalary { get; set; }
                public string? coverage { get; set; }
            }

            public DisabilityCoverageRuleModel disabilityCoverageRule { get; set; } = new DisabilityCoverageRuleModel();
            public class DisabilityCoverageRuleModel
            {
                public string? percentOfBase { get; set; }
                public string? roundingMethod { get; set; }
                public string? benefitAmount { get; set; }
                public string? alternateBaseCalc { get; set; }

                public List<LtdCoverageRuleModel> ltdCoverageRule { get; set; } = new List<LtdCoverageRuleModel>();
                public class LtdCoverageRuleModel
                {
                    public string? yearsOfService { get; set; }
                    public string? maximumCoverage { get; set; }
                }
            }

            public CoverageRuleModel coverageRule { get; set; } = new CoverageRuleModel();
            public class CoverageRuleModel
            {
                public string? multiplierPayBasis { get; set; }
                public string? payMultiplier { get; set; }
                public string? roundingMethod { get; set; }
                public string? roundBeforeAfter { get; set; }
                public string? coverageMaximum { get; set; }
                public string? coverageAmount { get; set; }
                public string? addToCalculatedCoverage { get; set; }

                public List<LifeInsuranceRuleModel> lifeInsuranceRule { get; set; } = new List<LifeInsuranceRuleModel>();
                public class LifeInsuranceRuleModel
                {
                    public string? yearsOfService { get; set; }
                    public string? payMultiplier { get; set; }
                }
            }
        }

        public List<BenefitPlanModel> benefitPlan { get; set; } = new List<BenefitPlanModel>();
        public class BenefitPlanModel : BaseModel
        {
            public string? planId { get; set; }
            public string? description { get; set; }
            public string? status { get; set; }
            public string? insClass { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? coverageStart { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? coverageEnd { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? deductionStart { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? deductionEnd { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? cobraStart { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            public bool? section125 { get; set; }
            public List<string>? gtlVoucherNumber { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? overrideCoverageEnd { get; set; }
            public string? carrierPlanId { get; set; }
            public string? networkId { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            public bool? reportedToCarrier { get; set; }
            public string? doctorId { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            public bool? seenByDoctor { get; set; }
            public string? dentalPlanId { get; set; }
            public string? alternateNetworkId { get; set; }
            public string? carrierEmployeeId { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? eligibleReported { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? enrollPkgSent { get; set; }
            public string? waiveReason { get; set; }
            public string? waiveReasonCode { get; set; }
            public string? providerId { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? overrideGTLStart { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? cobraNoticeDue { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? cobraNoticeSent { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? cobraNoticeSpouseSent { get; set; }
            public string? cobraNoticeDueType { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? autoEnroll { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            public bool? prepayRefunded { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? coverageRefund { get; set; }
            public string? refundCoveragePeriod { get; set; }
            public string? refundClientBill { get; set; }
            public string? refundEEContrib { get; set; }
            public string? refundInsureCost { get; set; }
            public List<RateGuarantyModel> rateGuaranty = new List<RateGuarantyModel>();
            public class RateGuarantyModel
            {
                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? rateGuarantyStart { get; set; }
                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? rateGuarantyEnd { get; set; }
            }
            public List<GroupTermLifeModel> groupTermLife { get; set; } = new List<GroupTermLifeModel>();
            public class GroupTermLifeModel
            {
                public string? gtlTaxYear { get; set; }
                public string? gtlAccruedYTD { get; set; }
            }
            public List<PlanDetailModel> planDetail { get; set; } = new List<PlanDetailModel>();
            public class PlanDetailModel
            {
                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? effectiveDate { get; set; }
                public string? planType { get; set; }
                public string? coverage { get; set; }
                public string? spouseCoverage { get; set; }
                public string? dependentCoverage { get; set; }
                public string? employeePremium { get; set; }
                public string? dependentPremium { get; set; }
                public string? employeeContrib { get; set; }
                public string? peoPremium { get; set; }
                public string? eePremiumContrib { get; set; }
                public string? cobraFee { get; set; }
                public string? hawaiiMax15Amt { get; set; }
                public string? giPendEE { get; set; }
                public string? giPendSP { get; set; }
                public string? giPendDP { get; set; }
                [JsonConverter(typeof(BoolConverter))]
                public bool? updatedCarrier { get; set; }
                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? cobraNoticeSpouseDue { get; set; }
                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? cobraNoticeSpouseSent { get; set; }
                public List<DependentModel> dependent { get; set; } = new List<DependentModel>();
                public class DependentModel
                {
                    public string? dependentId { get; set; }
                    public string? networkId { get; set; }
                    [JsonConverter(typeof(BoolConverter))]
                    public bool? reportedToCarrier { get; set; }
                    public string? doctorId { get; set; }
                    [JsonConverter(typeof(BoolConverter))]
                    public bool? seenByDoctor { get; set; }
                    [JsonConverter(typeof(DateTimeConverter))]
                    public DateTime? coverageStart { get; set; }
                    [JsonConverter(typeof(DateTimeConverter))]
                    public DateTime? coverageEnd { get; set; }
                    [JsonConverter(typeof(DateTimeConverter))]
                    public DateTime? overrideCoverageEnd { get; set; }
                }
                public List<BeneficiaryModel> beneficiary { get; set; } = new List<BeneficiaryModel>();
                public class BeneficiaryModel
                {
                    public string? benefId { get; set; }
                    public string? benefType { get; set; }
                    public string? benefPercent { get; set; }
                    public string? benefPrecedence { get; set; }
                }
            }
        }

        public List<BenefitRateModel> billingRate { get; set; } = new List<BenefitRateModel>();
        public List<BenefitRateModel> premiumRate { get; set; } = new List<BenefitRateModel>();
        public class BenefitRateModel : BaseModel
        {
            public string? planId { get; set; }
            public string? networkId { get; set; }
            public string? networkDesc { get; set; }
            public string? rateGroup { get; set; }
            public string? planType { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? effectiveDate { get; set; }
            public string? employeeGender { get; set; }
            public string? spouseGender { get; set; }
            public double? percentOfGrossWages { get; set; }
            public List<BenefitRateDetailsModel> benefitRateDetails { get; set; } = new List<BenefitRateDetailsModel>();
            public class BenefitRateDetailsModel : BaseModel
            {
                public string? fromAge { get; set; }
                public string? toAge { get; set; }
                public double? wellnessBillAmount { get; set; }
                public double? employeeBillPremAmount { get; set; }
                public double? dependentBillPremAmount { get; set; }
                public double? employeeNonTobaccoPremium { get; set; }
                public double? depNonTobaccoPremium { get; set; }
                public double? depTobaccoPremium { get; set; }
                public double? nonWellnessBillAmount { get; set; }
                public double? depWellnessBillAmount { get; set; }
                public double? nonSmokerPremium { get; set; }
                public double? smokerPremium { get; set; }
                public double? smokingSpousePremium { get; set; }
                public double? nonSmokingSpousePremium { get; set; }
                public double? lifeDependentsPremium { get; set; }
                public double? disabilityPremiumAmount { get; set; }
                public double? fromAnnualSalary { get; set; }
                public double? toAnnualSalary { get; set; }
                public double? costPerEmployee { get; set; }
                public double? tobaccoSurcharge { get; set; }
                public double? ratePerHundred { get; set; }
            }
            public string? checksum { get; set; }
        }

        public List<EnrollmentPlanDetailsModel> enrollmentPlanDetails { get; set; } = new();
        public class EnrollmentPlanDetailsModel
        {
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? detailsDate { get; set; }

            public List<PlanDetailsModel> planDetails { get; set; } = new();
            public class PlanDetailsModel
            {
                public string? field { get; set; }
                public string? value { get; set; }
                public string? key { get; set; }
            }
            public string? participantRequirement { get; set; }

            public string? planApplication { get; set; }
            public string? descriptionText { get; set; }
            public string? termsAndConditions { get; set; }
            public string? employeeAcknowledgeQuestion { get; set; }
            public string? proxyAcknowledgeQuestion { get; set; }
            public string? acknowledgeResponseEmpAffirm { get; set; }
            public string? acknowledgeResponseEmpDeclination { get; set; }
            public string? acknowledgeResponseProxyAffirm { get; set; }
            public string? acknowledgeResponseProxyDeclination { get; set; }
            public string? checksum { get; set; }
        }
    }
}

