using AutoMapper;
using EmployeesApi.Data;

namespace EmployeesApi.Services;

public class EfCandidatesManager : IManageCandidates
{
    private readonly EmployeesDataContext _context;
    private readonly IMapper _mapper;
    private readonly MapperConfiguration _mapperConfig;

    public EfCandidatesManager(EmployeesDataContext context, IMapper mapper, MapperConfiguration mapperConfig)
    {
        _context = context;
        _mapper = mapper;
        _mapperConfig = mapperConfig;
    }

    public Task<CandidateResponseModel> CreateCandidateAsync(CandidateRequestModel request)
    {
        throw new NotImplementedException();
    }
}