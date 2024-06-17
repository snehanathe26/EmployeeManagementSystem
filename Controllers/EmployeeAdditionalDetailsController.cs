using EmployeemanagementSystem.DTO;
using Microsoft.AspNetCore.Mvc;
using EmployeemanagementSystem.Interface;


namespace EmployeemanagementSystem.Controllers
{
    [Route("api/[Controller]/[action]")]
    [ApiController]
    public class EmployeeAdditionalDetailsController : Controller
    {

        private readonly IEmployeeAdditonalDetailsService _additionalDetailService;

        public EmployeeAdditionalDetailsController(IEmployeeAdditonalDetailsService visitorService)
        {
            _additionalDetailService = visitorService;
        }

        [HttpPost]
        public async Task<EmployeeAdditionalDetailsDTO> AddAdditionalDetail(EmployeeAdditionalDetailsDTO additionalDetailsDTO)
        {
            return await _additionalDetailService.AddEmployeeAdditionalDetails(additionalDetailsDTO);
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeAdditionalDetailsDTO>> GetAllEmployeeAdditionalDetails()
        {
            return await _additionalDetailService.GetAllEmployeeAdditionalDetails();
        }

        [HttpGet("{id}")]
        public async Task<EmployeeAdditionalDetailsDTO> GetEmployeeAdditionalDetailsById(string id)
        {
            return await _additionalDetailService.GetEmployeeAdditionalDetailsById(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployeeAdditionalDetails(string id, EmployeeAdditionalDetailsDTO additionalDetailsDTO)
        {
            try
            {
                var updatedEmployee = await _additionalDetailService.UpdateEmployeeAdditionalDetails(id, additionalDetailsDTO);
                return Ok(updatedEmployee);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateVisitor (Controller): {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeAdditionalDetails(string id)
        {
            await _additionalDetailService.DeleteEmployeeAdditionalDetails(id);
            return NoContent();
        }


    }
}
