namespace EmployeesApi.Data;

public class CandidateEntity
{
    public string Id { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public decimal RequiredSalaryMin { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public CandidateStatus Status { get; set; } = CandidateStatus.AwaitingManager;
    public DateTimeOffset DateCreated { get; set; }



}