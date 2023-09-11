using EmployeesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesApi.Controllers
{
    public class EmployeesController : ControllerBase
    {
        [HttpGet("/employees")]
        public async Task<ActionResult<EmployeeSummaryListResponse>> GetAllEmployess(string employee)
        {
            return Ok();
        }

        [HttpGet("/employees/id")]
        public async Task<ActionResult<EmployeeDetailsItemResponse>> GetEmployeeId(string employee)
        {
            return Ok();
        }

    }
}
