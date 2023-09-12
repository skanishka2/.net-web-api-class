namespace EmployeesApi.Controllers;



public class CandidatesController : ControllerBase
{
    

    [HttpPost("/candidates")]
    public async Task<ActionResult<CandidateResponseModel>> AddACandidate([FromBody] CandidateRequestModel request)
    {
        CandidateResponseModel response = await _candidateManager.CreateCandidateAsync(request);
        return Ok(request);
    }
}