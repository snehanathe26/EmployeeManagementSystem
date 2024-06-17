using EmployeemanagementSystem.DTO;

namespace EmployeemanagementSystem.Interface
{
    public interface IEmployeeAdditonalDetailsService 
    {

        Task<IEnumerable<EmployeeAdditionalDetailsDTO>> GetAllEmployeeAdditionalDetails();
        Task DeleteEmployeeAdditionalDetails(string id);
        Task<EmployeeAdditionalDetailsDTO> UpdateEmployeeAdditionalDetails(string id, EmployeeAdditionalDetailsDTO employeeAdditionalDetails);
        public Task<EmployeeAdditionalDetailsDTO> GetEmployeeAdditionalDetailsById(string id);
        Task<EmployeeAdditionalDetailsDTO> AddEmployeeAdditionalDetails(EmployeeAdditionalDetailsDTO employeeAdditionalDetails);

       
    }
}
    

