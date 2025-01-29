using WebApiEmployee__.Models;


namespace EmployeeManagement.Models.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
        Task<Employee> UpdateEmployee(Employee employee);
        Task AddEmployee(Employee employee);
        Task DeleteEmployee(int id);
    }
}
