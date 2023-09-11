using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    public class InfoController : ControllerBase
    {
        [HttpGet("/info")]
        public async Task<ActionResult> GetTheInfo()
        {
            return Ok($"its working and created at {DateTime.Now.ToLongTimeString()}");
        }

        [HttpGet("/blog/{year}/{month}/{day}")]
        public async Task<ActionResult> GetTheBlogStuff(int year, int month, int day)
        {
            return Ok($"showing the blog stuff for {year} {month} {day}");
        }

        [HttpGet("/colors")]
        public async Task<ActionResult> GetColors([FromQuery] string color = "Blue")
        {
            return Ok($"colour is {color}");
        }

        [HttpGet("/employees")]
        public async Task<ActionResult> GetEmployees([FromQuery] string department = "All")
        {
            var employees = new List<Employee>
        {
            new Employee("Bob Smith", "dev"),
            new Employee("Joe Jones", "dev"),
            new Employee("Sue Blue", "ceo")
        };
            if (department != "All")
            {
                var response = employees.Where(e => e.Department == department).ToList();
                return Ok(new ResponseType<List<Employee>>(response, department));
            }
            return Ok(new ResponseType<List<Employee>>(employees, department));
        }
        
        [HttpGet("/whoami")]
        public async Task<ActionResult> WhoAmI([FromHeader(Name = "User-Agent")] string userAgent, [FromHeader(Name = "X-Tacos")] string tacos)
        {
            return Ok($"you are running {userAgent} and give me some {tacos}");
        }

        [HttpPost("/bugReport")]
         public async Task<ActionResult> bugReport([FromBody] string report)
        {
            return Ok();
        }

    }

}

public record ResponseType<T>(T data, string Filter);
public record Employee(string Name, string Department);

public record CreateBugReportRequest
{
    public string Application { get; set; } = string.Empty;
    public string Issue { get; set; } = string.Empty;

}
