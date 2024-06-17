
using EmployeemanagementSystem.DTO;
using EmployeemanagementSystem.Entities;
using AutoMapper;

namespace EmployeemanagementSystem.Common
{
    public class AutoMapperFile:Profile
    {
        public AutoMapperFile()
        {
            CreateMap<EmployeesBasicDetailsDTO, EmployeesBasicDetailsEntity>().ReverseMap();
            CreateMap<EmployeeAdditionalDetailsDTO, EmployeeAdditionalDetailsEntity>().ReverseMap();
           
        }

        
    }
}
