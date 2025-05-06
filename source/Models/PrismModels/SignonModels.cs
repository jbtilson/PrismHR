using System.Text.Json.Serialization;
using PrismHRAPI.Support;
using static PrismHRAPI.Support.JSONConverterHelpers;

namespace PrismHRAPI.Models.PrismModels;

public class SignOnModels
{
    public class SignOnResponse : BaseModel
    {
        public string? ssoToken { get; set; }
        public string? redirectUrl { get; set; }

        public PrismUserModel prismUser { get; set; } = new();
        public class PrismUserModel : BaseModel
        {
            public string? userId { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            public bool? isNew { get; set; }
        }

        public UserInfoModel userInfo { get; set; } = new();
        public class UserInfoModel : BaseModel
        {
            public string? valid { get; set; }
            public string? userId { get; set; }
            public string? userType { get; set; }
            public string? employeeId { get; set; }
            public string? clientID { get; set; }
            public string? component { get; set; }
            public string? clockNumber { get; set; }
            public string? clientName { get; set; }
            public string? employeeNumber { get; set; }
            public string? peoName { get; set; }
            public string? systemType { get; set; }
            public string? email { get; set; }
            public string? username { get; set; }
            public string? legalName { get; set; }
            public string? acctName { get; set; }
            public string? installedName { get; set; }
            public string? firstName { get; set; }
            public string? middleName { get; set; }
            public string? lastName { get; set; }
            public string? managerType { get; set; }
            public string? customField { get; set; }

            public VendorUserInfoResponse vendorInfo { get; set; } = new();
            public class VendorUserInfoResponse : BaseModel
            {
                public List<VendorUserInfoModel> vendorUserInfo { get; set; } = new();
                public List<VendorClientInfoModel> vendorClientInfo { get; set; } = new();
            }
            public class VendorUserInfoModel : BaseModel
            {
                public string? fieldId { get; set; }
                public string? fieldValue { get; set; }
                public string? fieldDesc { get; set; }
            }
            public class VendorClientInfoModel : BaseModel
            {
                public string? fieldId { get; set; }
                public string? fieldValue { get; set; }
                public string? fieldDesc { get; set; }
            }
        }

        public List<FavoritesModel> favorite { get; set; } = new();
        public class FavoritesModel : BaseModel
        {
            public string? name { get; set; }
            public string? formId { get; set; }
        }
    }
}

