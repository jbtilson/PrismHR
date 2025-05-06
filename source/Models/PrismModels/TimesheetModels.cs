using PrismHRAPI.Support;

namespace PrismHRAPI.Models.PrismModels;

public class TimesheetModels
{

    public class TimesheetResponse : BaseModel
    {

        public string? batchId { get; set; }

        public List<TimeSheetDataListModel> timeSheetDataList { get; set; } = new List<TimeSheetDataListModel>();

        public class TimeSheetDataListModel
        {
            public string? employeeId { get; set; }
            public List<TimeSheetDataModel> timeSheetData { get; set; } = new List<TimeSheetDataModel>();
            public double? deduct1 { get; set; }
            public double? deduct2 { get; set; }
            public double? deduct3 { get; set; }

            public class TimeSheetDataModel
            {
                public string? chargeDate { get; set; }
                public string? payCode { get; set; }
                public double? hrsUnitsPaid { get; set; }
                public double? hoursWorked { get; set; }
                public double? payRate { get; set; }
                public double? payAmount { get; set; }
                public string? posCode { get; set; }
                public string? locnCode { get; set; }
                public string? divCode { get; set; }
                public string? deptCode { get; set; }
                public string? projCode { get; set; }
                public string? shiftCode { get; set; }
                public string? phaseCode { get; set; }
            }
        }

    }

}
