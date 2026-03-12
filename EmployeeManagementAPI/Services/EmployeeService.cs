using EmployeeManagementAPI.Models; 
using EmployeeManagementAPI.Repositories;

namespace EmployeeManagementAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Employee> CreateEmployee(Employee employee)
        {
            return await _repository.AddAsync(employee);
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            return await _repository.UpdateAsync(employee);
        }

        public async Task<bool> DeleteEmployee(int id)
        {
            return await _repository.DeleteAsync(id);
        }

    }
}
