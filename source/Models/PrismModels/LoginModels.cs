using System.Text.Json.Serialization;
using PrismHRAPI.Support;

namespace PrismHRAPI.Models.PrismModels;

public class LoginModels
{

    public class CreatePEOSessionResponse : BaseModel { }

    public class KeepAliveResponse : BaseModel
    {
        [JsonPropertyName("updateMessage")]
        public string? UpdateMessage { get; set; } = null;
    }

    public class InvalidateSessionResponse : BaseModel
    {
        [JsonPropertyName("updateMessage")]
        public string? UpdateMessage { get; set; } = null;
    }

    public class CheckPermissionsRequestStatusResponse : BaseModel
    {
        [JsonPropertyName("requestPendingApproval")]
        public bool RequestPendingApproval { get; set; }

        [JsonPropertyName("approvalStatus")]
        public string? ApprovalStatus { get; set; }
    }

    public class GetAPIPermissionsStatusResponse : BaseModel
    {
        [JsonPropertyName("currentPermissions")]
        public Permissions CurrentPermissions { get; set; } = new Permissions();

        public class Permissions : BaseModel
        {
            [JsonPropertyName("appVersion")]
            public string? AppVersion { get; set; }
            [JsonPropertyName("description")]
            public string? Description { get; set; }
            [JsonPropertyName("minApiVersion")]
            public string? MinApiVersion { get; set; }
            [JsonPropertyName("contactInfo")]
            public string? ContactInfo { get; set; }
            [JsonPropertyName("allowedIps")]
            public List<string> AllowedIps { get; set; } = new List<string>();

            public class Methods : BaseModel
            {
                [JsonPropertyName("service")]
                public string? Service { get; set; }
                [JsonPropertyName("options")]
                public List<string> Options { get; set; } = new List<string>();
                [JsonPropertyName("fromTime")]
                public string? FromTime { get; set; }
                [JsonPropertyName("toTime")]
                public string? ToTime { get; set; }
            }
        }
    }

}

