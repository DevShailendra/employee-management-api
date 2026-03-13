using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.DTOs;
namespace EmployeeManagementAPI.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetAllDepartmentsAsync();

        Task<Department> GetDepartmentByIdAsync(int id);

        Task<Department> CreateDepartmentAsync(CreateDepartmentDto dto);

        Task<bool> DeleteDepartmentAsync(int id);
    }
}
