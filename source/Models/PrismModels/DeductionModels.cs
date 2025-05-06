using System.Text.Json.Serialization;
using PrismHRAPI.Support;
using static PrismHRAPI.Support.JSONConverterHelpers;

namespace PrismHRAPI.Models.PrismModels;

public class DeductionModels
{
    public class DeductionResponse : BaseModel
    {
        public List<PaymentHistoryModel> paymentHistory { get; set; } = new();
        public class PaymentHistoryModel : BaseModel
        {
            public string? docketNumber { get; set; }

            public List<GarnishmentCheckInfoModel> garnishmentCheckInfo { get; set; } = new();
            public class GarnishmentCheckInfoModel : BaseModel
            {
                public string? payDate { get; set; }
                [JsonConverter(typeof(DateTimeConverter))]
                public DateTime? paidOn { get; set; }
                public string? checkNum { get; set; }
                public string? voucherId { get; set; }
                public string? checkAmount { get; set; }
                public string? achRefId { get; set; }
                public string? amountDue { get; set; }
            }
        }
    }
}

