using System.Text.Json.Serialization;
using PrismHRAPI.Support;

namespace PrismHRAPI.Models.PrismModels;

public class SystemModels
{
    internal class GetDataResponse : BaseModel
    {

        [JsonPropertyName("downloadId")]
        public string? DownloadId { get; set; }
        [JsonPropertyName("buildStatus")]
        public string? BuildStatus { get; set; }
        [JsonPropertyName("dataObject")]
        public string? DataObject { get; set; }

    }

}

