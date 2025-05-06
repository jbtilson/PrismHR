using PrismHRAPI.Support;

namespace PrismHRAPI.Models.PrismModels;

public class TaxRateModels
{
    public class TaxRateResponse : BaseModel
    {
        public string? stateCode { get; set; }
        public string? stateName { get; set; }

        public List<FieldsModel> fields { get; set; } = new();
        public class FieldsModel : BaseModel
        {
            public string? name { get; set; }
            public string? label { get; set; }
            public string? required { get; set; }
            public string? type { get; set; }

            public List<AllowedValuesModel> allowedValues { get; set; } = new();
            public class AllowedValuesModel : BaseModel
            {
                public string? value { get; set; }
                public string? description { get; set; }

            }
        }
    }
}

