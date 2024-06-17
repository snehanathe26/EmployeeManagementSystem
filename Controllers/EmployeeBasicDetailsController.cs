using EmployeemanagementSystem.DTO;
using EmployeemanagementSystem.Entities;
using EmployeemanagementSystem.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EmployeemanagementSystem.Controllers
{
    [Route("api/[Controller]/[action]")]
    [ApiController]
    public class EmployeeBasicDetailsController : Controller
    {
        private readonly IEmployeeBasicDetailsService _basicDetailService;

        public EmployeeBasicDetailsController(IEmployeeBasicDetailsService basicDetailService)
        {
            _basicDetailService = basicDetailService;
        }

        [HttpPost]
        public async Task<EmployeesBasicDetailsDTO> AddBasicDetail(EmployeesBasicDetailsDTO basicDetailsDTO)
        {
            var createdBasicDetail = await _basicDetailService.AddEmployeeBasicDetails(basicDetailsDTO);
            return createdBasicDetail;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeesBasicDetailsDTO>> GetAllEmployeeBasicDetails()
        {
            return await _basicDetailService.GetAllEmployeeBasicDetails();
        }

        [HttpGet("{id}")]
        public async Task<EmployeesBasicDetailsDTO> GetEmployeeBasicDetailsById(string id)
        {
            return await _basicDetailService.GetEmployeeBasicDetailsById(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployeeBasicDetails(string id, EmployeesBasicDetailsDTO basicDetailsDTO)
        {
            try
            {
                var updatedEmployee = await _basicDetailService.UpdateEmployeeBasicDetails(id, basicDetailsDTO);
                return Ok(updatedEmployee);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateVisitor (Controller): {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeBasiclDetails(string id)
        {
            await _basicDetailService.DeleteEmployeeBasicDetails(id);
            return NoContent();
        }

        [HttpPost]
        public async Task<EmployeeFilterCriteria> GetAllEmployeesByPagination(EmployeeFilterCriteria employeeFilterCriteria)
        {
            // var response = await _basicDetailService.GetAllEmployeesByPagination(employeeFilterCriteria);
            var response = await _basicDetailService.GetAllEmployeesByPagination(employeeFilterCriteria);
            return response;
        }


    }
}
