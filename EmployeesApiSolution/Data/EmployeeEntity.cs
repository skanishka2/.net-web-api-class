using System.ComponentModel.DataAnnotations;

namespace EmployeesApi.Data
{
    public class EmployeeEntity
    {
        public string Id { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string Department { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

        public decimal Salary { get; set; } 
    }
}
