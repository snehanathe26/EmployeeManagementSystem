using EmployeemanagementSystem.Entities;

namespace EmployeemanagementSystem.CosmoDB
{
    public interface ICosmosDBService
    {
        //Generic Function for all services
        Task<T> Add<T>(T entity);
        Task<T> Update<T>(string id, T entity);

        //Additional Details Function
        Task DeleteAdditionalDetails(string id);
        Task<EmployeeAdditionalDetailsEntity> GetEmployeeAdditionalDetailsById(string id);
        Task<IEnumerable<EmployeeAdditionalDetailsEntity>> GetAllAdditionalDetails();


        //Baisc Details Function
        Task<EmployeesBasicDetailsEntity> GetEmployeeBasicDetailsById(string id);
        Task DeleteBasicDetails(string id);
        Task<IEnumerable<EmployeesBasicDetailsEntity>> GetAllBasicDetails();

    }
}
