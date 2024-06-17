using EmployeemanagementSystem.DTO;
using EmployeemanagementSystem.Entities;

namespace EmployeemanagementSystem.Interface
{
    public interface IEmployeeBasicDetailsService
    {
        Task<EmployeesBasicDetailsDTO> AddEmployeeBasicDetails(EmployeesBasicDetailsDTO employeeBasicDetails);
        Task<IEnumerable<EmployeesBasicDetailsDTO>> GetAllEmployeeBasicDetails();
        Task<EmployeesBasicDetailsDTO> GetEmployeeBasicDetailsById(string id);
        Task<EmployeesBasicDetailsDTO> UpdateEmployeeBasicDetails(string id, EmployeesBasicDetailsDTO employeeBasicDetails);
        Task DeleteEmployeeBasicDetails(string id);
        Task<EmployeeFilterCriteria> GetAllEmployeesByPagination(EmployeeFilterCriteria employeeFilterCriteria);
    }
}
