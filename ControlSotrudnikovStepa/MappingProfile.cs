using AutoMapper;
using ControlSotrudnikovStepa.Models;
using ControlSotrudnikovStepa.ViewModels;

namespace ControlSotrudnikovStepa
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Department, DepartmentDTO>();

            CreateMap<Position, PositionDTO>();

            CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.DepartmentName, act => act.MapFrom(src => src.Department.Name))
                .ForMember(dest => dest.PositionName, act => act.MapFrom(src => src.Position.Name));

            CreateMap<Timesheet, TimesheetDTO>()
                .ForMember(dest => dest.EmployeeName, act => act.MapFrom(src => src.Employee.FIO));
        }
    }
}
