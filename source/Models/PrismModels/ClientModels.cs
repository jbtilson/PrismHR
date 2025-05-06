using System.Text.Json.Serialization;
using PrismHRAPI.Support;
using static PrismHRAPI.Support.JSONConverterHelpers;

namespace PrismHRAPI.Models.PrismModels;

public class ClientModels
{
    public class ClientMasterResponse : BaseModel
    {
        [JsonPropertyName("clientMaster")]
        public ClientModel clientMaster { get; set; } = new();

        public class ClientModel : BaseModel
        {
            public string? id { get; set; }

            public string? clientName { get; set; }

            public string? costCenter { get; set; }

            public string? subCostCenter { get; set; }

            public string? serviceType { get; set; }

            public string? categoryCode { get; set; }

            public string? stateCode { get; set; }

            public string? zipCode { get; set; }

            public string? legalName { get; set; }

            public string? arClientNumber { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? divisionRequired { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? departmentRequired { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? shiftRequired { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? empNumbersUsed { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? autoEmpNumber { get; set; }

            public string? worksitePayrollApproval { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? projectRequired { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? workGroupRequired { get; set; }

            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? payrollDate { get; set; }

            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? statusDate { get; set; }

            public string? status { get; set; }

            public string? deliverChecks { get; set; }

            public string? employerId { get; set; }

            public string? minCheckAmt { get; set; }

            public string? maxCheckAmt { get; set; }

            public string? deliveryMethod { get; set; }

            public string? mainPhoneExt { get; set; }

            public string? addressLine1 { get; set; }

            public string? addressLine2 { get; set; }

            public string? city { get; set; }

            public string? zipSuffix { get; set; }

            public string? mainPhone { get; set; }

            public string? fax { get; set; }

            public string? websiteUrl { get; set; }

            public string? emailAddress { get; set; }

            public string? businessDescription { get; set; }

            public string? sicCode { get; set; }

            public string? federalIdNumber { get; set; }

            public string? billFormat { get; set; }

            public string? groupCode { get; set; }

            public string? hoursType1 { get; set; }

            public string? hoursType2 { get; set; }

            public string? hoursType3 { get; set; }

            public string? hoursType4 { get; set; }

            public string? hoursType5 { get; set; }

            public string? flatType1 { get; set; }

            public string? flatType2 { get; set; }

            public string? extraHeading1 { get; set; }

            public string? extraHeading2 { get; set; }

            public string? corporationType { get; set; }

            public string? controlGroupCompany { get; set; }

            public string? cafeteriaPlan { get; set; }

            public string? hsaPlanId { get; set; }

            public string? glClientNo { get; set; }

            public string? billTemplate { get; set; }

            public string? wcPolicy { get; set; }

            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? wcPolicyEffDate { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? wcLocationBased { get; set; }

            public string? flsaRuleset { get; set; }

            public string? flsaWeekEnds { get; set; }

            public string? satPayOnDay { get; set; }

            public string? sunPayOnDay { get; set; }

            public string? satPayBefAft { get; set; }

            public string? sunPayBefAft { get; set; }

            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? contractDate { get; set; }

            public string? abbrvName { get; set; }

            public string? annualHours { get; set; }

            public string? sortField1 { get; set; }

            public string? sortField2 { get; set; }

            public string? sortField3 { get; set; }

            public string? billBySort { get; set; }

            public string? billInvBreakField { get; set; }

            public string? consultant { get; set; }

            public string? salesperson { get; set; }

            public string? payrollRep { get; set; }

            public string? checkIssueAcct { get; set; }

            public string? checkPrintStyle { get; set; }

            public string? invoiceCopies { get; set; }

            public string? remitCopies { get; set; }

            public string? receiptCheckAcct { get; set; }

            public string? adjAchDays { get; set; }

            public string? serviceTermReason { get; set; }

            public string? garnCheckIssueAcct { get; set; }

            public string? directDepositAccount { get; set; }

            public string? manualAccount { get; set; }

            public string? onDemandChecksAccount { get; set; }

            public string? payCardAccount { get; set; }

            public string? nesOffset { get; set; }

            public string? rateOrMarkup { get; set; }

            public string? billAddressLine1 { get; set; }

            public string? billAddressLine2 { get; set; }

            public string? billZipCode { get; set; }

            public string? billCity { get; set; }

            public string? billStateCode { get; set; }

            public string? billZipSuffix { get; set; }

            public string? billAddrClientId { get; set; }

            public string? newHireAlert { get; set; }

            public string? clientAccountingCode { get; set; }

            public string? garnEftIssueAcct { get; set; }

            public string? definitionId { get; set; }

            public string? cutbackCheckAcct { get; set; }

            public string? broker { get; set; }

            public string? onboardStatus { get; set; }

            public string? nyMctOvrRate { get; set; }

            public string? naicsCode { get; set; }

            public string? benefitRep { get; set; }

            public string? riskManager { get; set; }

            public string? depositType { get; set; }

            public string? depositAmt { get; set; }

            public string? handbookId { get; set; }

            public string? aftPostPreMailThreshold { get; set; }

            public string? achHoldThreshold { get; set; }

            public string? taxCalcOptions { get; set; }

            public string? taxLimitBasis { get; set; }

            public string? glTemplateCode { get; set; }

            public string? nySdiEmployerRate { get; set; }

            public string? wcPolicySubId { get; set; }

            public string? deduct401kOnSupp { get; set; }

            public string? coordinator { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? recomputeOvertime { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? jobRates { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? remoteTechSupport { get; set; }

            public string? processingSchedule { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? perDiemRateSource { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? clientAccounting { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? adjTipShortfall { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? suppressAutoBenAdj { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? suppressEmpAch { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? singlePayGroup { get; set; }

            public string? elecPayStub { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? useWcRateTemplate { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? calcWcOn1099Emp { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? wvUseFedMinRate { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? elecW2Form { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? nySdiEmployerCalc { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? adjTipsToMin { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? doNotService { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? clientModDiscount { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? aftPostPreMailHold { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? clientHdhp { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? financialInst { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? newHireOnBoard { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? newHireBenEnroll { get; set; }

            public string? paperlessDelivery { get; set; }

            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? clientAgrmtRecvDate { get; set; }

            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? depositDate { get; set; }

            public List<string> invoiceNotes { get; set; } = new List<string>();

            public List<string> faxBackNotes { get; set; } = new List<string>();

            public List<string> featureCode { get; set; } = new List<string>();

            public string? achStatus { get; set; }

            public string? i9Approver { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? contractorsAllowed1099 { get; set; }

            public string? checksum { get; set; }

            [JsonConverter(typeof(BoolConverter))]
            public bool? everify { get; set; }

            public List<PayCodeModel> payCode { get; set; } = new List<PayCodeModel>();
            public class PayCodeModel
            {
                public string? payCodeId { get; set; }
                public string? printOnPayStub { get; set; }
            }

            public List<DeductionCodeModel> deductionCode { get; set; } = new List<DeductionCodeModel>();
            public class DeductionCodeModel
            {
                public string? deductionCodeId { get; set; }
                public string? printOnPayStub { get; set; }
                public string? worksiteUserSelectable { get; set; }
            }

            public List<ArrearsModel> arrear { get; set; } = new List<ArrearsModel>();
            public class ArrearsModel
            {
                public string? loanDeductionCodeId { get; set; }
            }

            public List<EmployeeTypesModel> employeeType { get; set; } = new List<EmployeeTypesModel>();
            public class EmployeeTypesModel
            {
                public string? typeCodeId { get; set; }
            }

            public List<EmployeeStatusesModel> employeeStatus { get; set; } = new List<EmployeeStatusesModel>();
            public class EmployeeStatusesModel
            {
                public string? statusCodeId { get; set; }
            }

            public List<ReasonsModel> reason { get; set; } = new List<ReasonsModel>();
            public class ReasonsModel
            {
                public string? reasonCodeId { get; set; }
            }

            public List<ObservedHolidaysModel> observedHoliday { get; set; } = new List<ObservedHolidaysModel>();
            public class ObservedHolidaysModel
            {
                public string? name { get; set; }
                public string? description { get; set; }
                public List<string>? holidayDate { get; set; }
            }

            public List<AltEmployerModel> altEmployer { get; set; } = new List<AltEmployerModel>();
            public class AltEmployerModel
            {
                public string? altEmployerId { get; set; }
                public string? altCostCtr { get; set; }
                public string? altAchAcct { get; set; }
                public string? altCheckingAcct { get; set; }
            }

            public List<RetireModel> retire { get; set; } = new List<RetireModel>();
            public class RetireModel
            {
                public string? retirePlan { get; set; }
                public string? thirdPartyPlanId { get; set; }
            }

            public List<BillFixedModel> billFixed { get; set; } = new List<BillFixedModel>();
            public class BillFixedModel
            {
                public string? billFixedSpecRate { get; set; }
                public string? billFixedSpecFrom { get; set; }
                public string? billFixedSpecTo { get; set; }
            }

            public List<HolidayPayModel> holidayPay { get; set; } = new List<HolidayPayModel>();
            public class HolidayPayModel
            {
                public string? holidayOnDay { get; set; }
                public string? holidayPayOnDay { get; set; }
                public string? holidayPayBefAft { get; set; }
            }

            public List<SdiDednModel> sdiDedn { get; set; } = new List<SdiDednModel>();
            public class SdiDednModel
            {
                public string? sdiTaxCode { get; set; }
                public string? sdiDednCode { get; set; }
            }

            public List<ClientTaxModel> clientTax { get; set; } = new List<ClientTaxModel>();
            public class ClientTaxModel
            {
                public string? suiState { get; set; }
                public string? suiStateEmpId { get; set; }
                public string? stateTaxId { get; set; }
                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? ctrStartDate { get; set; }
                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? ctrEndDate { get; set; }
                public string? suiSecondaryId { get; set; }
            }

            public List<RedirModel> redir { get; set; } = new List<RedirModel>();
            public class RedirModel
            {
                public string? redirTaxCode { get; set; }
                public string? redirToTaxCode { get; set; }
            }

            //public List<RegRebuildModel> regRebuild { get; set; } = new List<RegRebuildModel>();
            //public class RegRebuildModel
            //{
            //    [JsonConverter(typeof(DateTimeConverter))]
            //    public DateTime? regRebuildDate { get; set; }
            //    public string? regRebuildUser { get; set; }
            //    public string? regRebuildReason { get; set; }
            //    public string? regRebuildYear { get; set; }
            //}

            public List<CommissionModel> commission { get; set; } = new List<CommissionModel>();
            public class CommissionModel
            {
                public string? commSalesperson { get; set; }
                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? commDateFrom { get; set; }
                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? commDateTo { get; set; }
                public string? commAmount { get; set; }
                [JsonConverter(typeof(BoolConverter))]
                public bool? commFlatPct { get; set; }
                public string? commBasedOn { get; set; }
                public string? commBasedOnPlan { get; set; }
            }

            public List<BillEventModel> billEvent { get; set; } = new List<BillEventModel>();
            public class BillEventModel
            {
                public string? billEvtCode { get; set; }
                public string? billEvtRate { get; set; }
                public string? billEvtSpecialRate { get; set; }
                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? billEvtSpecialFrom { get; set; }
                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? billEvtSpecialTo { get; set; }
            }

            public List<ReportFeeModel> reportFee { get; set; } = new List<ReportFeeModel>();
            public class ReportFeeModel
            {
                public string? rptCode { get; set; }
                public string? rptFee { get; set; }
            }

            public List<MySupportTeamDashboardModel> mySupportTeamDashboard { get; set; } = new List<MySupportTeamDashboardModel>();
            public class MySupportTeamDashboardModel
            {
                public string? dashFieldName { get; set; }
                public string? dashFieldValue { get; set; }
            }
        }

        [JsonPropertyName("clientCodes")]
        public ClientCodesModel clientCodes { get; set; } = new();

        public class ClientCodesModel : BaseModel
        {
            public int? total { get; set; } = 0;
            public int? startpage { get; set; } = 0;
            public int? count { get; set; } = 0;
            public string? clientId { get; set; }

            public List<BenefitGroupCodeModel> benefitGroupCode { get; set; } = new List<BenefitGroupCodeModel>();
            public class BenefitGroupCodeModel : BaseModel
            {
                public string? id { get; set; }
                public string? description { get; set; }
            }

            public List<CitizenshipStatusCodesModel> citizenshipStatusCodes { get; set; } = new List<CitizenshipStatusCodesModel>();
            public class CitizenshipStatusCodesModel : BaseModel
            {
                public string? code { get; set; }
                public string? description { get; set; }
            }

            public List<string> cobraEventCode { get; set; } = new List<string>();

            public List<DeductionCodeModel> deductionCode { get; set; } = new List<DeductionCodeModel>();
            public class DeductionCodeModel : BaseModel
            {
                public string? id { get; set; }

                public string? description { get; set; }

                public string? type { get; set; }

                public string? calculationMethod { get; set; }

                public decimal? defaultAmount { get; set; } = 0;

                public string? defaultPeriods { get; set; }

                public string? creditAccount { get; set; }

                public string? thirdPartyReimburse { get; set; }

                public string? formW2Box { get; set; }

                public string? formW2Code { get; set; }

                public string? debitArrears { get; set; }

                public string? creditArrears { get; set; }

                public string? maximum { get; set; }

                public string? certifiedDescription { get; set; }

                public string? toArrears { get; set; }

                public string? payeeCode { get; set; }

                public string? payStubName { get; set; }

                public string? timeSheetHeading { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? mandatory { get; set; }

                public string? clientRebateBillCode { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? clientSection125 { get; set; }

                public string? billCodeJobRate { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? client401K { get; set; }

                public string? unionRelated { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? clientMedicalPlan { get; set; }

                public string? allowDescOverride { get; set; }

                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? obsoleteDate { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? client401kCatchUp { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? clientHSA { get; set; }

                public decimal? changeDateTime { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? clientFSADependentCare { get; set; }

                public string? printOnPaystub { get; set; }

                public string? inPayCode { get; set; }

                public string? qualifiedTuitionPlan { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? client409a { get; set; }

                public string? matchPercent { get; set; }

                public string? paystubDescription { get; set; }

                public string? cutbackRequired { get; set; }

                public string? clearDeductionBeforeImport { get; set; }

                public string? kperscontribution { get; set; }

                public string? mtrbcontribution { get; set; }
            }

            public List<DepartmentCodeModel> departmentCode { get; set; } = new List<DepartmentCodeModel>();
            public class DepartmentCodeModel : BaseModel
            {
                public string? id { get; set; }

                public string? deptName { get; set; }

                public string? glCode { get; set; }

                public string? glSegment2 { get; set; }

                public string? perDiemPct { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? deptObsolete { get; set; }

                public List<MiscGlModel> miscGl { get; set; } = new List<MiscGlModel>();
                public class MiscGlModel
                {
                    public string? miscGlCount { get; set; }

                    public string? miscGlDescription { get; set; }

                    public string? miscGlSegment { get; set; }
                }
            }

            public List<DivisionCodeModel> divisionCode { get; set; } = new List<DivisionCodeModel>();
            public class DivisionCodeModel : BaseModel
            {
                public string? id { get; set; }

                public string? divisionName { get; set; }

                public string? glCode { get; set; }

                public string? divTransferAcct { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? divObsolete { get; set; }

                public string? glSegment2 { get; set; }

                public string? glSegment3 { get; set; }
            }

            public List<EthnicCodeModel> ethnicCode { get; set; } = new List<EthnicCodeModel>();
            public class EthnicCodeModel : BaseModel
            {
                public string? id { get; set; }

                public string? description { get; set; }

                public string? reportCode { get; set; }
            }

            public List<I9DocumentsModel> i9Documents { get; set; } = new List<I9DocumentsModel>();
            public class I9DocumentsModel : BaseModel
            {
                public string? code { get; set; }

                public string? description { get; set; }

                public List<IssuingAuthoritiesModel> issuingAuthorities { get; set; } = new List<IssuingAuthoritiesModel>();
                public class IssuingAuthoritiesModel
                {
                    public string? code { get; set; }

                    public string? description { get; set; }
                }
            }

            public List<JobCodeModel> jobCode { get; set; } = new List<JobCodeModel>();
            public class JobCodeModel : BaseModel
            {
                public string? id { get; set; }

                public string? jobTitle { get; set; }

                public string? glSegmentCode { get; set; }

                public string? jobClass { get; set; }

                public string? payGrade { get; set; }

                public string? alaskaJobCode { get; set; }

                public string? perDiemPct { get; set; }

                public string? prevailWage { get; set; }

                public string? priceCode { get; set; }

                public string? probationDays { get; set; }

                public string? unionCodeOverride { get; set; }

                public string? jobDescription { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? jobObsolete { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? supervisory { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? adaRequirements { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? salesPosition { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? tippedPosition { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? indirectTipped { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? dotFlag { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? wcLocationBased { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? flsaExempt { get; set; }
            }

            public List<LocationCodeModel> locationCode { get; set; } = new List<LocationCodeModel>();
            public class LocationCodeModel : BaseModel
            {
                public string? id { get; set; }

                public string? locationName { get; set; }

                public string? geoCode { get; set; }

                public string? addressLine1 { get; set; }

                public string? addressLine2 { get; set; }

                public string? zipCode { get; set; }

                public string? zipSuffix { get; set; }

                public string? city { get; set; }

                public string? county { get; set; }

                public string? state { get; set; }

                public string? workCompState { get; set; }

                public string? latitude { get; set; }

                public string? longitude { get; set; }

                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? obsoleteDate { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? locationObsolete { get; set; }

                public List<LocationContactsModel> locationContacts { get; set; } = new List<LocationContactsModel>();
                public class LocationContactsModel : BaseModel
                {
                    public string? contactName { get; set; }

                    public string? contactDescription { get; set; }

                    public string? emailAddress { get; set; }

                    public string? telephone { get; set; }

                    public string? fax { get; set; }
                }
            }

            public List<PayCodeModel> payCode { get; set; } = new List<PayCodeModel>();
            public class PayCodeModel : BaseModel
            {
                public string? id { get; set; }

                public string? payType { get; set; }

                public string? calcMethod { get; set; }

                public string? payDescription { get; set; }

                public string? w2FormBox { get; set; }

                public string? w2FormCode { get; set; }

                public string? workCompTaxable { get; set; }

                public string? payReason { get; set; }

                public string? compensationType { get; set; }

                public string? payClass { get; set; }

                public string? rateClass { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? flag401k { get; set; }

                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? obsoleteDate { get; set; }

                public string? talxPayType { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? productiveWork { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? excludeACACalc { get; set; }
            }

            public List<PayGroupsModel> payGroups { get; set; } = new List<PayGroupsModel>();
            public class PayGroupsModel : BaseModel
            {
                public string? payGroupCode { get; set; }
                public string? description { get; set; }
            }

            public List<PositionClassModel> positionClass { get; set; } = new List<PositionClassModel>();
            public class PositionClassModel : BaseModel
            {
                public string? id { get; set; }

                public string? description { get; set; }

                public string? eeoJobGroup { get; set; }

                public string? eeoJobClass { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? flsaExempt { get; set; }

                public List<WcClassResultModel> wcClassResult { get; set; } = new List<WcClassResultModel>();
                public class WcClassResultModel : BaseModel
                {
                    public string? wcState { get; set; }

                    public string? wcClass { get; set; }
                }
            }

            public List<ProjectClassesModel> projectClasses { get; set; } = new List<ProjectClassesModel>();
            public class ProjectClassesModel : BaseModel
            {
                public string? projectClass { get; set; }
                public string? description { get; set; }
            }

            public List<ProjectCodeModel> projectCode { get; set; } = new List<ProjectCodeModel>();
            public class ProjectCodeModel : BaseModel
            {
                public string? id { get; set; }

                public string? description { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? certPayroll { get; set; }

                public string? certPayrollRptFmt { get; set; }

                public string? wageDecisionNumber { get; set; }

                public string? projectCity { get; set; }

                public string? projectState { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? unionProject { get; set; }

                public string? unionCode { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? projObsolete { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? otherWcCoverage { get; set; }

                public string? projectClass { get; set; }

                public string? projectClassDescription { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? trackPhases { get; set; }

                public string? checksum { get; set; }

                public List<ProjectPhaseModel> projectPhase { get; set; } = new List<ProjectPhaseModel>();
                public class ProjectPhaseModel : BaseModel
                {
                    public string? id { get; set; }
                    public string? description { get; set; }
                }
            }

            public List<ReasonCodeModel> reasonCode { get; set; } = new List<ReasonCodeModel>();
            public class ReasonCodeModel : BaseModel
            {
                public string? id { get; set; }

                public string? description { get; set; }

                public string? validActions { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? obsolete { get; set; }

                public string? obsoleteDate { get; set; }

                public string? tpaSeparationCode { get; set; }

                public string? terminationType { get; set; }
            }

            public List<RelationCodesModel> relationCodes { get; set; } = new List<RelationCodesModel>();
            public class RelationCodesModel : BaseModel
            {
                public string? code { get; set; }

                public string? description { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? obsolete { get; set; }
            }

            public List<RetirementPlanCodeModel> retirementPlanCode { get; set; } = new List<RetirementPlanCodeModel>();
            public class RetirementPlanCodeModel : BaseModel
            {
                public string? id { get; set; }
                public string? description { get; set; }
            }

            public List<ShiftCodeModel> shiftCode { get; set; } = new List<ShiftCodeModel>();
            public class ShiftCodeModel : BaseModel
            {
                public string? id { get; set; }

                public string? description { get; set; }

                public string? mileageRate { get; set; }

                public string? perDiemRate { get; set; }

                public string? diffMethod { get; set; }

                public string? diffAmt { get; set; }

                public string? regPayCode { get; set; }

                public string? otPayCode { get; set; }

                public string? otPayFactor { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? inclInPayRate { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? otDiffStraigtPay { get; set; }
            }

            public List<SkillCodesModel> skillCodes { get; set; } = new List<SkillCodesModel>();
            public class SkillCodesModel : BaseModel
            {
                public string? code { get; set; }

                public string? description { get; set; }

                public string? differentialMethod { get; set; }

                public decimal? differentialAmount { get; set; } = 0;

                public List<CoursesModel> courses { get; set; } = new List<CoursesModel>();
                public class CoursesModel
                {
                    public string? courseCode { get; set; }

                    public string? courseName { get; set; }

                    public int? pointsEarned { get; set; } = 0;

                    public string? certifies { get; set; }
                }
            }

            public List<StatusCodeModel> statusCode { get; set; } = new List<StatusCodeModel>();
            public class StatusCodeModel : BaseModel
            {
                public string? id { get; set; }

                public string? description { get; set; }

                public string? statusClass { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? obsolete { get; set; }
            }

            public List<TypeCodeModel> typeCode { get; set; } = new List<TypeCodeModel>();
            public class TypeCodeModel : BaseModel
            {
                public string? id { get; set; }

                public string? description { get; set; }

                public string? abbrDescription { get; set; }

                public string? typeClass { get; set; }

                public string? validActions { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? seasonal { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? statutoryEmployee { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? onlineBenefitsElig { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? autoTermIneligBenefits { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? autoEnrollEligBenefits { get; set; }

                public string? obsolete { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? serviceProviderOnly { get; set; }
            }

            public List<WorkgroupCodeModel> workgroupCode { get; set; } = new List<WorkgroupCodeModel>();
            public class WorkgroupCodeModel : BaseModel
            {
                public string? id { get; set; }
                public string? description { get; set; }
            }

            public List<UnionCodesModel> unionCodes { get; set; } = new List<UnionCodesModel>();
            public class UnionCodesModel : BaseModel
            {
                public string? code { get; set; }
                public string? name { get; set; }
            }
        }

        [JsonPropertyName("benefitGroupResult")]
        public List<BenefitGroupResultModel> benefitGroupResult { get; set; } = new();

        public class BenefitGroupResultModel : BaseModel
        {
            public string? groupId { get; set; }
            public string? groupName { get; set; }
            public string? retirementOrBenefitPlan { get; set; }
            public string? stopNewUseOn { get; set; }
            public string? stopAllUseOn { get; set; }

            public List<EligibleBenefitsModel> eligibleBenefits { get; set; } = new List<EligibleBenefitsModel>();
            public class EligibleBenefitsModel : BaseModel
            {
                public string? planId { get; set; }
            }
            public List<CafeteriaPlanContribsModel> cafeteriaPlanContribs { get; set; } = new List<CafeteriaPlanContribsModel>();
            public class CafeteriaPlanContribsModel : BaseModel
            {
                public string? effectiveDate { get; set; }
                public string? contribAmount { get; set; }
                public string? eeFirstDollar { get; set; }
                public string? eePremiumOnly { get; set; }
            }
            public string? checksum { get; set; }
        }

        public PrismClientContactResultModel prismClientContactResult { get; set; } = new();

        public class PrismClientContactResultModel : BaseModel
        {
            public List<PrismClientContactModel> prismClientContact { get; set; } = new();
        }
        public class PrismClientContactModel : BaseModel
        {
            public string? contactId { get; set; }
            public string? contactType { get; set; }
            public string? contactName { get; set; }
            public string? contactTitle { get; set; }
            public string? contactPhone { get; set; }
            public string? contactPhoneExt { get; set; }
            public string? contactEmail { get; set; }
            public string? contactAddress { get; set; }
            public string? contactCity { get; set; }
            public string? contactState { get; set; }
            public string? contactZip { get; set; }
            public string? contactZipSuffix { get; set; }
            public string? comments { get; set; }
            public string? checksum { get; set; }
            public string? contactCellPhone { get; set; }
        }

        public ClientListResultModel clientListResult { get; set; } = new();
        public class ClientListResultModel : BaseModel
        {
            public List<ClientListModel> clientList { get; set; } = new();
        }
        public class ClientListModel : BaseModel
        {
            public string? clientId { get; set; }
            public string? clientName { get; set; }
        }

        public LocationDetailsModel locationDetails { get; set; } = new();
        public class LocationDetailsModel : BaseModel
        {
            public string? clientId { get; set; }
            public string? locationId { get; set; }
            public string? locationName { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            public bool? locationObsolete { get; set; }
            public string? geoCode { get; set; }
            public string? addressLine1 { get; set; }
            public string? addressLine2 { get; set; }
            public string? city { get; set; }
            public string? state { get; set; }
            public string? county { get; set; }
            public string? zipCode { get; set; }
            public string? zipSuffix { get; set; }
            public string? workCompState { get; set; }
            public string? latitude { get; set; }
            public string? longitude { get; set; }

            public List<LocationContactModel> locationContact { get; set; } = new();
            public class LocationContactModel : BaseModel
            {
                public string? contactName { get; set; }
                public string? contactDescription { get; set; }
                public string? emailAddress { get; set; }
                public string? telephone { get; set; }
                public string? fax { get; set; }
            }

            public List<string> eligibleBenefitPlans { get; set; } = new();

            public List<LocationBasedSUIModel> locationBasedSUI { get; set; } = new();
            public class LocationBasedSUIModel : BaseModel
            {
                public string? clSutaState { get; set; }
                public string? clSutaStart { get; set; }
                public string? clSutaEnd { get; set; }
                public string? clSutaStateId { get; set; }
            }

            public LocationAchModel locationAch { get; set; } = new();
            public class LocationAchModel : BaseModel
            {
                public string? checkAcct { get; set; }
                public string? achAcct { get; set; }
                public string? garnCheckAcct { get; set; }
                public string? garnEFTCheckAcct { get; set; }
                public string? locAchStatus { get; set; }
                public string? abaNumber { get; set; }
                public string? bankAcctNo { get; set; }
                public string? checkSave { get; set; }
            }

            public string? glCode { get; set; }
            public string? glCode2 { get; set; }
            public string? glCode3 { get; set; }
            public string? ovrClientAccting { get; set; }
            public string? salesTaxCode { get; set; }
            public string? clSutaFein { get; set; }
            public string? orTransit { get; set; }
            public double? sbTaxPcnt { get; set; }
            public string? wcPolicyId { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? addDate { get; set; }
            public string? workSiteId { get; set; }
            public string? flsaRuleSet { get; set; }
            public string? unionLocation { get; set; }
            public string? tipFlsaRuleSet { get; set; }
            public string? eeoUnitNbr { get; set; }
            public string? eeoOvrLocn { get; set; }
            public string? faxNumber { get; set; }
            public string? altSuiState { get; set; }
            public string? dfltOvrWorkGeoCode { get; set; }
            public string? entityId { get; set; }

            public List<SbeaInEligibilityPeriodsModel> sbeaInEligibilityPeriods { get; set; } = new();
            public class SbeaInEligibilityPeriodsModel : BaseModel
            {
                public string? sbeaFailStartDate { get; set; }
                public string? sbeaFailEndingDate { get; set; }
            }

            public string? deptCode { get; set; }
            public string? divCode { get; set; }
            public string? projectCode { get; set; }

            public List<CityTaxesModel> cityTaxes { get; set; } = new();
            public class CityTaxesModel : BaseModel
            {
                public string? cityTaxAuth { get; set; }
                public double? cityTaxRate { get; set; }
            }

            public string? storyCount { get; set; }
            public string? highestFlrOccupied { get; set; }
            public string? constructType { get; set; }
            public string? yearBuilt { get; set; }
            public string? sprinklers { get; set; }
            public string? maxCapacity { get; set; }

            public List<MinimumWagesModel> minimumWages { get; set; } = new();
            public class MinimumWagesModel : BaseModel
            {
                public string? minRateDate { get; set; }
                public double? minWage { get; set; }
                public double? minCashWage { get; set; }
                public double? minWageMinor { get; set; }
                public double? minCashWageMinor { get; set; }
            }

            public string? adultAge { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? obsoleteDate { get; set; }
            public string? eeo1QuestionD2 { get; set; }
            public string? payGroup { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            public bool? subjToOhioSers { get; set; }
            public string? takeOnFacility { get; set; }
            public string? locationType { get; set; }

            public List<EligibleEmployersModel> eligibleEmployers { get; set; } = new();
            public class EligibleEmployersModel : BaseModel
            {
                public string? eligibleEmployer { get; set; }
                public string? employerName { get; set; }
            }
            public string? checksum { get; set; }
        }

        public PayGroupDetailsModel payGroupDetails { get; set; } = new();
        public class PayGroupDetailsModel : BaseModel
        {
            public string? payGroupCode { get; set; }
            public string? description { get; set; }
            public string? paySchedule { get; set; }
            public string? workWeekEndsOn { get; set; }
            public string? processingSchedule { get; set; }
            public string? payrollNumber { get; set; }
            public string? payDate { get; set; }
            public string? periodStartDate { get; set; }
            public string? periodEndDate { get; set; }
            public string? periodNumber { get; set; }

            public AltBillingAddressModel altBillingAddress { get; set; } = new();
            public class AltBillingAddressModel : BaseModel
            {
                public string? billAddress1 { get; set; }
                public string? billAddress2 { get; set; }
                public string? billCity { get; set; }
                public string? billState { get; set; }
                public string? stateName { get; set; }
                public string? billZipSuffix { get; set; }
                public string? billZipCode { get; set; }
            }
            public string? checksum { get; set; }
        }

    }
}

