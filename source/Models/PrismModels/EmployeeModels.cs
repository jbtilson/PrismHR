using System.Text.Json.Serialization;
using PrismHRAPI.Support;
using static PrismHRAPI.Support.JSONConverterHelpers;

namespace PrismHRAPI.Models.PrismModels;

public class EmployeeModels
{
    public class EmployeeResponse : BaseModel
    {
        [JsonPropertyName("employee")]
        public List<EmployeeModel> employee { get; set; } = new();

        public class EmployeeModel : BaseModel
        {

            [JsonPropertyName("id")]
            public string? employeeId { get; set; }
            public string? lastName { get; set; }
            public string? firstName { get; set; }
            public string? middleInitial { get; set; }

            public string? geoCode { get { return person?.geoCode; } }
            public string? peoStartDate { get { return person?.peoStartDate; } }
            public string? gender { get { return person?.gender; } }
            public bool? highlyCompensated { get { return person?.highlyCompensated; } }
            public bool? keyEmployee { get { return person?.keyEmployee; } }
            public string? nickname { get { return person?.nickname; } }
            public string? birthDate { get { return person?.birthDate; } }

            public string? ethnicCode { get { return person?.ethnicCode; } }
            public string? driverLicenseId { get { return person?.driverLicenseId; } }
            public string? cobraSSN { get { return person?.cobraSSN; } }
            public bool? cobraOnly { get { return person?.cobraOnly; } }
            public string? maritalStatus { get { return person?.maritalStatus; } }
            public string? marriedDate { get { return person?.marriedDate; } }
            public string? smoker { get { return person?.smoker; } }
            public string? handicapped { get { return person?.handicapped; } }
            public string? blind { get { return person?.blind; } }
            public string? veteran { get { return person?.veteran; } }
            public string? vietnamVet { get { return person?.vietnamVet; } }
            public string? disabledVet { get { return person?.disabledVet; } }
            public string? hrpCitizenshipCountry { get { return person?.hrpCitizenshipCountry; } }
            public bool? deceased { get { return person?.deceased; } }
            public string? taxZipCode { get { return person?.taxZipCode; } }
            public string? overrideGeoCode { get { return person?.overrideGeoCode; } }
            public string? overrideGeoEndDate { get { return person?.overrideGeoEndDate; } }
            public string? deceasedDate { get { return person?.deceasedDate; } }
            public string? driverState { get { return person?.driverState; } }
            public string? driverLicenseExpireDate { get { return person?.driverLicenseExpireDate; } }
            public string? driverLicenseClass { get { return person?.driverLicenseClass; } }
            public bool? ohioFormC112 { get { return person?.ohioFormC112; } }
            public bool? unincorporatedResidence { get { return person?.unincorporatedResidence; } }
            public string? w2AddressLine1 { get { return person?.w2AddressLine1; } }
            public string? w2AddressLine2 { get { return person?.w2AddressLine2; } }
            public string? w2City { get { return person?.w2City; } }
            public string? w2State { get { return person?.w2State; } }
            public string? w2PostalCode { get { return person?.w2PostalCode; } }
            public bool? w2ElecForm { get { return person?.w2ElecForm; } }
            public string? w2ElecFormDate { get { return person?.w2ElecFormDate; } }
            public string? legacyEmployeeId { get { return person?.legacyEmployeeId; } }
            public bool? hispanic { get { return person?.hispanic; } }
            public bool? agricultureWorker { get { return person?.agricultureWorker; } }
            public string? otherProtectedVet { get { return person?.otherProtectedVet; } }
            public string? activeDutyBadgeVet { get { return person?.activeDutyBadgeVet; } }
            public string? recentlySeparatedVet { get { return person?.recentlySeparatedVet; } }
            public string? serviceMedalVet { get { return person?.serviceMedalVet; } }
            public string? preferredLanguage { get { return person?.preferredLanguage; } }
            public string? userId { get { return person?.userId; } }
            public string? personChecksum { get { return person?.personChecksum; } }
            public List<PersonModel.EmergencyContactModel>? emergencyContact { get { return person?.emergencyContact; } }
            public List<string>? employerId { get { return person?.employerId; } }

            public string? emailAddress { get { return contactInformation.emailAddress; } }
            public string? addressLine1 { get { return contactInformation.addressLine1; } }
            public string? addressLine2 { get { return contactInformation.addressLine2; } }
            public string? city { get { return contactInformation.city; } }
            public string? state { get { return contactInformation.state; } }
            public string? zipcode { get { return contactInformation.zipcode; } }
            public string? zipSuffix { get { return contactInformation.zipSuffix; } }
            public string? county { get { return contactInformation.county; } }
            public string? schoolDistrict { get { return contactInformation.schoolDistrict; } }
            public string? homePhone { get { return contactInformation.homePhone; } }
            public string? mobilePhone { get { return contactInformation.mobilePhone; } }


            public PersonModel? person { get; set; }
            public class PersonModel : BaseModel
            {
                public string? ethnicCode { get; set; }

                public string? birthDate { get; set; }

                public string? driverLicenseId { get; set; }

                public string? cobraSSN { get; set; }

                public List<string> employerId { get; set; } = new List<string>();

                [JsonConverter(typeof(BoolConverter))]
                public bool? cobraOnly { get; set; }

                public string? geoCode { get; set; }

                public string? maritalStatus { get; set; }

                public string? marriedDate { get; set; }

                public string? smoker { get; set; }

                public string? peoStartDate { get; set; }

                public string? handicapped { get; set; }

                public string? blind { get; set; }

                public string? veteran { get; set; }

                public string? vietnamVet { get; set; }

                public string? disabledVet { get; set; }

                public string? hrpCitizenshipCountry { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? deceased { get; set; }

                public string? gender { get; set; }

                public string? taxZipCode { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? highlyCompensated { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? keyEmployee { get; set; }

                public string? overrideGeoCode { get; set; }

                public string? overrideGeoEndDate { get; set; }

                public string? nickname { get; set; }

                public string? deceasedDate { get; set; }

                public string? driverState { get; set; }

                public string? driverLicenseExpireDate { get; set; }

                public string? driverLicenseClass { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? ohioFormC112 { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? unincorporatedResidence { get; set; }

                public string? w2AddressLine1 { get; set; }

                public string? w2AddressLine2 { get; set; }

                public string? w2City { get; set; }

                public string? w2State { get; set; }

                public string? w2PostalCode { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? w2ElecForm { get; set; }

                public string? w2ElecFormDate { get; set; }

                public string? legacyEmployeeId { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? hispanic { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? agricultureWorker { get; set; }

                public string? otherProtectedVet { get; set; }

                public string? activeDutyBadgeVet { get; set; }

                public string? recentlySeparatedVet { get; set; }

                public string? serviceMedalVet { get; set; }

                public string? preferredLanguage { get; set; }

                public string? userId { get; set; }

                public string? personChecksum { get; set; }

                public List<EmergencyContactModel> emergencyContact { get; set; } = new List<EmergencyContactModel>();
                public class EmergencyContactModel : BaseModel
                {
                    public string? contactName { get; set; }
                    public string? contactInfo { get; set; }
                    public string? contactType { get; set; }
                    public string? contactRelationship { get; set; }
                }

                public List<AutoPoliciesModel> autoPolicies { get; set; } = new List<AutoPoliciesModel>();
                public class AutoPoliciesModel : BaseModel
                {
                    public string? autoInsurancePolicyId { get; set; }
                    public string? autoInsuranceCarrierName { get; set; }
                    public string? autoInsuranceHolderName { get; set; }
                    public string? autoInsurancePolicyStartDate { get; set; }
                    public string? autoInsurancePolicyExpDate { get; set; }
                }

                public List<VehicleDetailsModel> vehicleDetails { get; set; } = new List<VehicleDetailsModel>();
                public class VehicleDetailsModel : BaseModel
                {
                    public string? vehicleMake { get; set; }
                    public string? vehicleModel { get; set; }
                    public string? vehicleYear { get; set; }
                    public string? vehicleAddDate { get; set; }
                    public string? vehicleRemoveDate { get; set; }
                    public string? vehicleRegNo { get; set; }
                }
            }

            public DirectDepositModel? directDeposit { get; set; }
            public class DirectDepositModel : BaseModel
            {
                public string? achStatus { get; set; }

                public string? voucherType { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? suppressAccountPrint { get; set; }

                public string? directDepositChecksum { get; set; }

                public List<AchVoucherModel> achVoucher { get; set; } = new List<AchVoucherModel>();
                public class AchVoucherModel : BaseModel
                {
                    public string? transitNum { get; set; }
                    public string? accountNum { get; set; }
                    public string? accountType { get; set; }
                    public string? method { get; set; }
                    public decimal? amount { get; set; }
                    public decimal? limit { get; set; }
                    public string? status { get; set; }
                    public string? bankName { get; set; }
                    public string? voucherTypeOverride { get; set; }
                }
            }

            public ClientModel? client { get; set; }
            public class ClientModel : BaseModel
            {
                public string? employeeStatus { get; set; }

                public string? statusClass { get; set; }

                public string? statusDate { get; set; }

                public string? employeeType { get; set; }

                public string? typeClass { get; set; }

                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? typeDate { get; set; }

                public string? jobCode { get; set; }

                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? jobStartDate { get; set; }

                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? firstHireDate { get; set; }

                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? lastHireDate { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? flsaExempt { get; set; }

                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? seniorityDate { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? officer { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? workCompOfficer { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? scorpOwner { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? businessOwner { get; set; }

                public string? termReasonCode { get; set; }

                public string? termExplanation { get; set; }

                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? lastStatusChangeDate { get; set; }

                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? lastJobChangeDate { get; set; }

                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? newHireReportDate { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? employee1099 { get; set; }

                public string? clientEmployeeId { get; set; }

                public string? clockNum { get; set; }

                public string? primaryEmailSource { get; set; }

                public string? benefitEmail { get; set; }

                public string? rehireOk { get; set; }

                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? returnDate { get; set; }

                public string? workPhone { get; set; }

                public string? workPhoneExt { get; set; }

                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? probationDate { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? courtOrderMedical { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? childSpouseSupport { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? childSpouseArrears { get; set; }

                public string? addressLine1 { get; set; }

                public string? addressLine2 { get; set; }

                public string? city { get; set; }

                public string? state { get; set; }

                public string? zip { get; set; }

                public string? zipSuffix { get; set; }

                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? handbookMailDate { get; set; }

                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? handbookRecvDate { get; set; }

                public string? unionCode { get; set; }

                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? unionDate { get; set; }

                public string? subCostCenter { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? electronicOnboard { get; set; }

                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? electronicOnboardDate { get; set; }

                public string? reportsTo { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? onboardInProgress { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? backgroundTest { get; set; }

                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? backgroundTestDate { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? workersCompExempt { get; set; }

                public string? genderDesignation { get; set; }

                public string? preferredPronoun { get; set; }

                public string? clientChecksum { get; set; }

                public string? homeLocation { get; set; }

                public string? homeDivision { get; set; }

                public string? homeDepartment { get; set; }

                public string? workShift { get; set; }

                public string? projCostCenter { get; set; }

                public string? workGroupCode { get; set; }

                public string? benefitGroup { get; set; }

                public string? retirementBenefitGroup { get; set; }

                public string? workEmail { get; set; }

                public List<TransferInfoModel> transferInfo { get; set; } = new List<TransferInfoModel>();
                public class TransferInfoModel : BaseModel
                {
                    public string? transferStatus { get; set; }

                    public string? transferEmployeeId { get; set; }

                    public string? transferClientId { get; set; }

                    [JsonConverter(typeof(DateTimeConverter))]
                    public DateTime? transferDate { get; set; }
                }

                public List<PropertyModel> propertyModel { get; set; } = new List<PropertyModel>();
                public class PropertyModel : BaseModel
                {
                    public string? propertyCode { get; set; }

                    [JsonConverter(typeof(DateTimeConverter))]
                    public DateTime? propertyIssueDate { get; set; }

                    public string? propertySerialNumber { get; set; }

                    public string? propertyValue { get; set; }

                    [JsonConverter(typeof(DateTimeConverter))]
                    public DateTime? propertyReturnDate { get; set; }

                    public string? propertyComment { get; set; }
                }

                public List<HawaiiMedWaiversModel> hawaiiMedWaivers { get; set; } = new List<HawaiiMedWaiversModel>();
                public class HawaiiMedWaiversModel : BaseModel
                {
                    public string? medWaiverYear { get; set; }

                    public string? medWaiverReason { get; set; }
                }

                public List<CafeteriaPlanModel> cafeteriaPlan { get; set; } = new List<CafeteriaPlanModel>();
                public class CafeteriaPlanModel : BaseModel
                {
                    public string? planAmt { get; set; }

                    [JsonConverter(typeof(DateTimeConverter))]
                    public DateTime? planEffectiveDate { get; set; }
                }
            }

            public ContactInformationModel contactInformation { get; set; } = new ContactInformationModel();
            public class ContactInformationModel : BaseModel
            {
                public string? addressLine1 { get; set; }
                public string? addressLine2 { get; set; }
                public string? city { get; set; }
                public string? state { get; set; }
                public string? zipcode { get; set; }
                public string? zipSuffix { get; set; }
                public string? county { get; set; }
                public string? schoolDistrict { get; set; }
                public string? homePhone { get; set; }
                public string? mobilePhone { get; set; }
                public string? emailAddress { get; set; }
            }

            public CompensationModel compensation { get; set; } = new CompensationModel();
            public class CompensationModel : BaseModel
            {
                public string? ssn { get; set; }

                public string? payGroup { get; set; }

                public string? payPeriod { get; set; }

                public List<PayPeriodInfoModel> payPeriodInfo { get; set; } = new List<PayPeriodInfoModel>();
                public class PayPeriodInfoModel : BaseModel
                {
                    public string? periodCode { get; set; }

                    public string? periodBase { get; set; }
                }

                public string? defaultHours { get; set; }

                public string? payMethod { get; set; }

                public string? allocationTemplateId { get; set; }

                public List<PayAllocationModel> payAllocation { get; set; } = new List<PayAllocationModel>();
                public class PayAllocationModel : BaseModel
                {
                    public string? locationCode { get; set; }

                    public string? percent { get; set; }

                    public string? job { get; set; }

                    public string? deptCode { get; set; }

                    public string? project { get; set; }

                    public string? division { get; set; }
                }

                public string? standardHours { get; set; }

                public List<StateTaxModel> stateTax { get; set; } = new List<StateTaxModel>();
                public class StateTaxModel : BaseModel
                {
                    public string? stateCode { get; set; }

                    public string? nonResCertFiled { get; set; }

                    public string? filingStatus { get; set; }

                    public string? primaryAllowance { get; set; }

                    public string? secondaryAllowance { get; set; }

                    public string? exemptAmount { get; set; }

                    public string? supplExemptAmount { get; set; }

                    public string? overrideType { get; set; }

                    public string? overrideAmount { get; set; }

                    public string? reduceAddlWithholding { get; set; }

                    public string? fixedWithholding { get; set; }

                    public string? alternateCalc { get; set; }

                    public string? stateW4Filed { get; set; }

                    public string? stateW4Year { get; set; }

                    [JsonConverter(typeof(BoolConverter))]
                    public bool? multipleJobs { get; set; }

                    public decimal? dependents { get; set; }

                    public decimal? otherIncome { get; set; }

                    public decimal? deductions { get; set; }

                    public string? nonResCertYear { get; set; }
                }

                public string? hourlyPay { get; set; }

                public string? salary { get; set; }

                public string? workShift { get; set; }

                public string? paidThruDate { get; set; }

                public string? eicFileStatus { get; set; }

                public string? fedFilingStatus { get; set; }

                public string? fedWithholdAllowance { get; set; }

                public string? fedOverrideType { get; set; }

                public string? fedOverrideAmt { get; set; }

                public string? fedTaxCalc { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? fedMultipleJobs { get; set; }

                public decimal? fedDependents { get; set; }

                public decimal? fedOtherIncome { get; set; }

                public decimal? fedDeductions { get; set; }

                public string? hourlyPayRate { get; set; }

                public string? hourlyPayPeriod { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? deliverCheckHome { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? autoAcceptTimeSheet { get; set; }

                public string? longPayTable { get; set; }

                public string? longBasisDate { get; set; }

                public string? annualPay { get; set; }

                public string? effectiveDate { get; set; }

                public List<LocalTaxModel> localTax { get; set; } = new List<LocalTaxModel>();
                public class LocalTaxModel : BaseModel
                {
                    public string? authId { get; set; }

                    public string? filingStatus { get; set; }

                    public string? primaryAllowance { get; set; }

                    public string? nonResCert { get; set; }

                    public string? addlWithheld { get; set; }
                }

                public string? lastChangePct { get; set; }

                public string? lastChangeAmt { get; set; }

                public string? lastPayDate { get; set; }

                public string? quartile { get; set; }

                public string? compaRatio { get; set; }

                public string? benefitsBasePay { get; set; }

                public string? perDiemPay { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? taxCreditEmp { get; set; }

                public string? autoPayCode { get; set; }

                public List<string> altPayRate = new List<string>();

                public string? pensionStatus { get; set; }
                public string? profitSharing { get; set; }

                public List<EeImageModel> eeImage { get; set; } = new List<EeImageModel>();
                public class EeImageModel : BaseModel
                {
                    public string? masterId { get; set; }

                    [JsonConverter(typeof(DateTimeConverter))]
                    public DateTime? verifyDateTime { get; set; }

                    public string? verifyUserId { get; set; }
                }

                [JsonConverter(typeof(BoolConverter))]
                public bool? wagePlanCA { get; set; }

                public string? perfReviewLastDate { get; set; }

                public string? perfReviewNextDate { get; set; }

                public List<I9imageAuditModel> i9imageAudit { get; set; } = new List<I9imageAuditModel>();
                public class I9imageAuditModel : BaseModel
                {
                    public string? auditDate { get; set; }

                    public string? auditUser { get; set; }

                    public string? auditId { get; set; }

                    public string? auditStep { get; set; }
                }

                public string? perfReviewLastRating { get; set; }

                public string? compReviewNextDate { get; set; }

                public string? perfReviewLastTitle { get; set; }

                public string? fedW5Year { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? fedW5Filed { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? fedW4Filed { get; set; }

                public string? fedW4Year { get; set; }

                public List<LockInsModel> lockIns { get; set; } = new List<LockInsModel>();
                public class LockInsModel : BaseModel
                {
                    public string? state { get; set; }

                    public string? stateDate { get; set; }

                    public string? authUser { get; set; }
                }

                [JsonConverter(typeof(BoolConverter))]
                public bool? formI9Filed { get; set; }

                public string? formI9RenewDate { get; set; }

                public string? notes { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? ficaExempt { get; set; }

                public string? benefitsPerHour { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? perfAgreement { get; set; }

                public string? payRate2 { get; set; }

                public string? payRate3 { get; set; }

                public string? payRate4 { get; set; }

                public string? payChangeLastDate { get; set; }

                public string? overrideWorkGeocode { get; set; }

                public string? familyMemberMI { get; set; }

                public string? probationCodeMO { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? electronicPayStub { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? healthInsVT { get; set; }

                public string? lastWorkedDate { get; set; }

                public string? irsLockInDate { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? nonResAlien { get; set; }

                public string? alienRegExpDate { get; set; }

                public string? benefitSalary { get; set; }

                public string? citizenshipStatus { get; set; }

                public string? firstPayPeriodHours { get; set; }

                public string? compensationChecksum { get; set; }

                public string? providerNotifiedOn { get; set; }
            }

        }

        public EmployeeListModel employeeList { get; set; } = new();
        public class EmployeeListModel : BaseModel
        {
            public List<string>? employeeId { get; set; }
        }

        public List<HistoryRecordsModel> historyRecord { get; set; } = new();
        public class HistoryRecordsModel : BaseModel
        {
            public string? type { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? effectiveDate { get; set; }
            public string? newPositionCode { get; set; }

            public PayChangeModel payChange { get; set; } = new();
            public class PayChangeModel : BaseModel
            {
                public string? newStdHours { get; set; }
                public string? newPayRate { get; set; }
                public string? payPeriod { get; set; }
                public string? hourlyRate { get; set; }
                public string? annualPay { get; set; }
                public string? annualChangeAmt { get; set; }
                public string? percentChange { get; set; }
                public string? percentMidpoint { get; set; }
                public string? payMethod { get; set; }
                public string? reason { get; set; }
            }

            public LeaveModel leave { get; set; } = new();
            public class LeaveModel : BaseModel
            {
                public string? employeeStatusCode { get; set; }
                public string? employeeTypeCode { get; set; }
                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? expectedReturnDate { get; set; }
                public string? reason { get; set; }
            }

            public StatusChangeModel statusChange { get; set; } = new();
            public class StatusChangeModel : BaseModel
            {
                public string? employeeStatusCode { get; set; }
                public string? employeeTypeCode { get; set; }
                public string? type { get; set; }
            }

            public TerminationModel termination { get; set; } = new();
            public class TerminationModel : BaseModel
            {
                public string? employeeStatusCode { get; set; }
                public string? employeeTypeCode { get; set; }
                public string? reason { get; set; }
                public string? rehireOK { get; set; }
                public string? explanation { get; set; }
            }

            public DivisionChangeModel divisionChange { get; set; } = new();
            public class DivisionChangeModel : BaseModel
            {
                public string? divisionCode { get; set; }
            }

            public LocationChangeModel locationChange { get; set; } = new();
            public class LocationChangeModel : BaseModel
            {
                public string? locationCode { get; set; }
            }

            public DepartmentChangeModel departmentChange { get; set; } = new();
            public class DepartmentChangeModel : BaseModel
            {
                public string? departmentCode { get; set; }
            }

            public BenefitGroupChangeModel benefitGroupChange { get; set; } = new();
            public class BenefitGroupChangeModel : BaseModel
            {
                public string? benefitGroupCode { get; set; }
            }

            public WellnessStatusChangeModel wellnessStatusChange { get; set; } = new();
            public class WellnessStatusChangeModel : BaseModel
            {
                public string? wellnessStatus { get; set; }
            }
        }

        public List<EmployeeAccountsModel> employeeAccounts { get; set; } = new();
        public class EmployeeAccountsModel : BaseModel
        {
            public string? employeeId { get; set; }
            public string? clientId { get; set; }
            public string? typeFlag { get; set; }
            public string? typeDesc { get; set; }
            public string? lastName { get; set; }
            public string? firstName { get; set; }
            public string? employerId { get; set; }
        }
    }
}

