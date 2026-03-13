using EmployeeManagementAPI.DTOs;
using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Repositories;

namespace EmployeeManagementAPI.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _repository;

        public DepartmentService(IDepartmentRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Department>> GetAllDepartmentsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Department> GetDepartmentByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Department> CreateDepartmentAsync(CreateDepartmentDto dto)
        {
            var department = new Department
            {
                Name = dto.Name
            };

            return await _repository.CreateAsync(department);
        }

        public async Task<bool> DeleteDepartmentAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}