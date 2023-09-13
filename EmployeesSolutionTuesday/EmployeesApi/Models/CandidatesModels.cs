using System.ComponentModel.DataAnnotations;

namespace EmployeesApi.Models;

public record CandidateRequestModel
{

    [Required]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    public string LastName { get; set; } = string.Empty;
    [Required]
    public decimal RequiredSalaryMin { get; set; }
    [Required]
    public string PhoneNumber { get; set; } = string.Empty;
    [Required, EmailAddress]
    public string EmailAddress { get; set; } = string.Empty;
    [Required]
    public string Notes { get; set; } = string.Empty;

  
}

public record CandidateResponseModel
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



public enum CandidateStatus
{
    AwaitingManager,
    Hired,
    Rejected



}