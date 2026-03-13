using EmployeeManagementAPI.Models;
namespace EmployeeManagementAPI.Repositories
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetAllAsync();

        Task<Department> GetByIdAsync(int id);

        Task<Department> CreateAsync(Department department);

        Task<bool> DeleteAsync(int id);
    }
}
