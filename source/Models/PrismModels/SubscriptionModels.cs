using System.Text.Json.Serialization;
using PrismHRAPI.Support;
using static PrismHRAPI.Support.JSONConverterHelpers;

namespace PrismHRAPI.Models.PrismModels;

public class SubscriptionModels
{

    public class SubscriptionResponse : BaseModel
    {
        [JsonPropertyName("subscription")]
        public List<SubscriptionModel> subscription { get; set; } = new List<SubscriptionModel>();

        public class SubscriptionModel : BaseModel
        {
            [JsonPropertyName("downloadId")]
            public string? DownloadId { get; set; }

            [JsonPropertyName("subscriptionId")]
            public string? subscriptionId { get; set; }

            [JsonPropertyName("clientId")]
            public string? clientId { get; set; }

            [JsonPropertyName("replayId")]
            public string? replayId { get; set; }

            [JsonPropertyName("userId")]
            public string? userId { get; set; }

            [JsonPropertyName("description")]
            public string? description { get; set; }

            [JsonPropertyName("userStringId")]
            public string? userStringId { get; set; }

            [JsonPropertyName("filter")]
            public List<FilterModel> filter { get; set; } = new List<FilterModel>();
            public class FilterModel : BaseModel
            {
                [JsonPropertyName("schemaName")]
                public string? schemaName { get; set; }

                [JsonPropertyName("className")]
                public string? className { get; set; }

                [JsonPropertyName("exclude")]
                public List<string> exclude { get; set; } = new List<string>();

                [JsonPropertyName("include")]
                public List<string> include { get; set; } = new List<string>();
            }

            [JsonPropertyName("webhookUrls")]
            public List<string> webhookUrls { get; set; } = new List<string>();
        }
    }

    public class EventResponse : BaseModel
    {
        [JsonPropertyName("subscriptionEvent")]
        public List<SubscriptionEventModel> subscriptionEvent { get; set; } = new List<SubscriptionEventModel>();

        [JsonPropertyName("replayId")]
        public string? replayId { get; set; }

        [JsonPropertyName("nextEvent")]
        public string? nextEvent { get; set; }

        public class SubscriptionEventModel : BaseModel
        {
            [JsonPropertyName("subscriptionId")]
            public string? subscriptionId { get; set; }

            [JsonPropertyName("eventId")]
            public string? eventId { get; set; }

            [JsonPropertyName("schemaName")]
            public string? schemaName { get; set; }

            [JsonPropertyName("className")]
            public string? className { get; set; }

            [JsonPropertyName("action")]
            public string? action { get; set; }

            [JsonPropertyName("eventTimestamp")]
            public double? eventTimestamp { get; set; }

            [JsonPropertyName("eventDate")]
            public string? eventDate { get; set; }

            [JsonPropertyName("eventTime")]
            public string? eventTime { get; set; }

            [JsonPropertyName("userStringId")]
            public string? userStringId { get; set; }

            [JsonPropertyName("objectId")]
            public string? objectId { get; set; }

            [JsonPropertyName("additionalInformation")]
            public string? additionalInformation { get; set; }

            public AdditionalInformationModel additionalInfoObject { get; set; } = new AdditionalInformationModel();

            public class AdditionalInformationModel : BaseModel
            {
                public string? prismUserName { get; set; }
                public string? userType { get; set; }

                [JsonConverter(typeof(BoolConverter))]
                public bool? isDirectDepositChanged { get; set; }
            }


            [JsonPropertyName("clientId")]
            public List<string> clientId { get; set; } = new List<string>();

            [JsonPropertyName("modifiedAttribute")]
            public List<string> modifiedAttribute { get; set; } = new List<string>();
        }
    }

}

