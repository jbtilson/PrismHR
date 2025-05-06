using PrismHRAPI.Support;

namespace PrismHRAPI.Models.PrismModels;

public class CodeFileModels
{
    public class CodeFileResponse : BaseModel
    {
        public List<CustomFieldsModel> customFields { get; set; } = new();
        public class CustomFieldsModel : BaseModel
        {
            public string? typeId { get; set; }

            public List<FieldsModel> fields { get; set; } = new();
            public class FieldsModel : BaseModel
            {
                public string? key { get; set; }
                public string? label { get; set; }
                public string? type { get; set; }
                public string? mandatory { get; set; }
                public string? value { get; set; }
            }
            public string? checksum { get; set; }
        }
    }
}

