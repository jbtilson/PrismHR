namespace PrismHRAPI.Models;

public class Configuration
{

    public string? BaseURL { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? PEOId { get; set; }

    /// <summary>
    /// Attempts to load the schema from the provided file
    /// </summary>
    /// <param name="fullFilePath">The full path, including file name, to load the schema from</param>
    /// <returns>The schema or null</returns>
    public SubscriptionSchema? GetSubscriptionSchema(string fullFilePath)
    {
        try
        {
            var file = File.ReadAllText(fullFilePath);
            return System.Text.Json.JsonSerializer.Deserialize<Configuration.SubscriptionSchema>(file);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    /// <summary>
    /// Prism's subscription schema
    /// </summary>
    public class SubscriptionSchema
    {

        public DeductionModel Deduction { get; set; } = new DeductionModel();
        public BenefitModel Benefit { get; set; } = new BenefitModel();
        public ClientModel Client { get; set; } = new ClientModel();
        public PayrollModel Payroll { get; set; } = new PayrollModel();
        public PrehiresModel Prehires { get; set; } = new PrehiresModel();
        public EmployeeModel Employee { get; set; } = new EmployeeModel();
        public SecurityModel Security { get; set; } = new SecurityModel();


        public class DeductionModel
        {
            public List<string> EmployeeArrears { get; set; } = new List<string>();
            public List<string> EmployeeDeductions { get; set; } = new List<string>();
            public List<string> EmployeeLoan { get; set; } = new List<string>();
            public List<string> Garnishment { get; set; } = new List<string>();
        }

        public class BenefitModel
        {
            public List<string> AbsenceJournal { get; set; } = new List<string>();
            public List<string> BenefitPlan { get; set; } = new List<string>();
            public List<string> CobraEnrollee { get; set; } = new List<string>();
            public List<string> Dependent { get; set; } = new List<string>();
            public List<string> Enrollment { get; set; } = new List<string>();
            public List<string> LifeEvent { get; set; } = new List<string>();
            public List<string> PaidTimeOff { get; set; } = new List<string>();
            public List<string> PTOAbsenceCode { get; set; } = new List<string>();
            public List<string> PTOPlan { get; set; } = new List<string>();
            public List<string> PTORegisterType { get; set; } = new List<string>();
            public List<string> RetirementLoan { get; set; } = new List<string>();
            public List<string> RetirementPlan { get; set; } = new List<string>();
            public List<string> SpendingAccounts { get; set; } = new List<string>();
        }

        public class ClientModel
        {
            public List<string> Contacts { get; set; } = new List<string>();
            public List<string> Deduction { get; set; } = new List<string>();
            public List<string> Department { get; set; } = new List<string>();
            public List<string> Division { get; set; } = new List<string>();
            public List<string> Job { get; set; } = new List<string>();
            public List<string> Location { get; set; } = new List<string>();
            public List<string> Master { get; set; } = new List<string>();
            public List<string> Pay { get; set; } = new List<string>();
            public List<string> Project { get; set; } = new List<string>();
            public List<string> Shift { get; set; } = new List<string>();
            public List<string> WCBillingModifiers { get; set; } = new List<string>();
        }

        public class PayrollModel
        {
            public List<string> BatchControl { get; set; } = new List<string>();
            public List<string> Completion { get; set; } = new List<string>();
        }

        public class PrehiresModel
        {
            public List<string> Prehires { get; set; } = new List<string>();
        }

        public class EmployeeModel
        {
            public List<string> Applicant { get; set; } = new List<string>();
            public List<string> DirectDeposit { get; set; } = new List<string>();
            public List<string> Client { get; set; } = new List<string>();
            public List<string> Compensation { get; set; } = new List<string>();
            public List<string> Events { get; set; } = new List<string>();
            public List<string> FutureEEChanges { get; set; } = new List<string>();
            public List<string> Health { get; set; } = new List<string>();
            public List<string> LeaveRequests { get; set; } = new List<string>();
            public List<string> Person { get; set; } = new List<string>();
            public List<string> PositionRate { get; set; } = new List<string>();
            public List<string> Skills { get; set; } = new List<string>();
        }

        public class SecurityModel
        {
            public List<string> ClientAccessGroup { get; set; } = new List<string>();
            public List<string> Users { get; set; } = new List<string>();
            public List<string> WebServiceUsers { get; set; } = new List<string>();
        }
    }
}

