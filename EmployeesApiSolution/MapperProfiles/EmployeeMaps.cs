using AutoMapper;
using EmployeesApi.Data;
using EmployeesApi.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EmployeesApi.MapperProfiles;

public class EmployeeMaps : Profile
{
    public EmployeeMaps()
    {
        // Given I have an EmployeeEntity -> EmployeeSummaryListItemResponse
        CreateMap<EmployeeEntity, EmployeeSummaryListItemResponse>()
            .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id.ToString()));

        CreateMap<EmployeeEntity, EmployeeDetailsItemResponse>()
            .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id.ToString()));
    }
}