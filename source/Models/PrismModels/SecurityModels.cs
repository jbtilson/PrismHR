using System.Text.Json.Serialization;
using PrismHRAPI.Support;
using static PrismHRAPI.Support.JSONConverterHelpers;

namespace PrismHRAPI.Models.PrismModels;

public class SecurityModels
{
    public class SecurityResponse : BaseModel
    {
        public UserDetailsModel userDetails { get; set; } = new();
        public class UserDetailsModel : BaseModel
        {
            public string? id { get; set; }
            public string? userType { get; set; }
            public string? userName { get; set; }
            public string? employeeId { get; set; }
            public string? employeeFirstName { get; set; }
            public string? employeeMiddleName { get; set; }
            public string? employeeLastName { get; set; }
            public string? emailAddress { get; set; }
            public string? mobilePhone { get; set; }
            public string? workPhone { get; set; }
            public string? title { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            public bool? activeUser { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            public bool? requireNewPassword { get; set; }
            public string? clientAccessGroup { get; set; }
            public List<string> userRole { get; set; } = new();
            public List<string> typeId { get; set; } = new();
            public List<string> allowedIpRange { get; set; } = new();
            public List<string> allowedProcesses { get; set; } = new();

            public List<HumanResourceRoleModel> humanResourceRole { get; set; } = new();
            public class HumanResourceRoleModel : BaseModel
            {
                public string? code { get; set; }
                public string? desc { get; set; }
            }

            public List<AccountManagementRoleModel> accountManagementRole { get; set; } = new();
            public class AccountManagementRoleModel : BaseModel
            {
                public string? code { get; set; }
                public string? desc { get; set; }
            }

            public List<SuppressPayrollWarningModel> suppressPayrollWarning { get; set; } = new();
            public class SuppressPayrollWarningModel : BaseModel
            {
                public string? code { get; set; }
                public string? desc { get; set; }
            }

            [JsonConverter(typeof(BoolConverter))]
            public bool? smfaUserEnabled { get; set; }
            public string? smfaExpirationPeriod { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            public bool? smfaPasswordReset { get; set; }
            public string? checksum { get; set; }
        }

        [JsonConverter(typeof(BoolConverter))]
        public bool? isClientAllowed { get; set; }

        [JsonConverter(typeof(BoolConverter))]
        public bool? isEmployeeAllowed { get; set; }

        public UserListResultModel userListResult { get; set; } = new();
        public class UserListResultModel : BaseModel
        {
            public List<userListsModel> userList { get; set; } = new();
        }
        public class userListsModel : BaseModel
        {
            public string? userTypeText
            {
                get
                {
                    // 'I' (service provider), 'M' (worksite manager), or 'A' (worksite trusted advisor)
                    switch ($"{userType}".ToUpper())
                    {
                        case "I":
                            return "Service Provider";
                        case "M":
                            return "Worksite Manager";
                        case "A":
                            return "Worksite Trusted Advisor";
                        default:
                            return null;
                    }
                }
            }
            public string? userId { get; set; }
            public string? userType { get; set; }
        }


        public List<RoleListsModel> rolesList { get; set; } = new();
        public class RoleListsModel : BaseModel
        {
            public string? roleId { get; set; }
            public string? description { get; set; }
            public string? roleType { get; set; }
        }

        public RoleDetailModel roleDetail { get; set; } = new();

        public class RoleDetailModel : BaseModel
        {

            public string? roleId { get; set; }
            public string? description { get; set; }
            public string? roleType { get; set; }

            public class FormAccessModel
            {
                public string? type { get; set; }
                public string? category { get; set; }
                public string? description { get; set; }
                public string? processId { get; set; }
                public string? access { get; set; }
                public List<FormAccessModel> formAccess { get; set; } = new();

                public class FieldSecurityModel
                {
                    public string? name { get; set; }
                    public string? description { get; set; }
                    public string? access { get; set; }
                    public string? required { get; set; }
                }
            }
        }

        public DataSecurityModel dataSecurity { get; set; } = new();

        public class DataSecurityModel : BaseModel
        {
            public string? clientId { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            public bool? clientAccess { get; set; }
            [JsonConverter(typeof(DateTimeConverter))]
            public DateTime? expirationDate { get; set; }
            public string? checksum { get; set; }
            public List<EntityAccessModel> entityAccess { get; set; } = new();

            public class EntityAccessModel
            {
                public string? typeCode { get; set; }
                public string? typeDesc { get; set; }
                public string? entityCode { get; set; }
                public string? entityName { get; set; }
                [JsonConverter(typeof(BoolConverter))]
                public bool? access { get; set; }

            }
        }

        public List<AllowedEmployeesModel> allowedEmployee { get; set; } = new();
        public class AllowedEmployeesModel
        {
            public string? employeeId { get; set; }
            public string? firstName { get; set; }
            public string? lastName { get; set; }
            public string? middleName { get; set; }
        }

        public List<EmployeeClientModel> employeeClient { get; set; } = new();
        public class EmployeeClientModel
        {
            public string? clientId { get; set; }
            public string? type { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            public bool? employeePortalAllowed { get; set; }
        }

        public List<string> allowedClientId { get; set; } = new();
    }
}

