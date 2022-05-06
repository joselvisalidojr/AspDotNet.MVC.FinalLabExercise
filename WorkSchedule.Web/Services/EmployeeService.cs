using System.Linq;
using WorkSchedule.Data;
using WorkSchedule.Data.Entities;
using WorkSchedule.Web.Models;

namespace WorkSchedule.Web.Services
{
    public interface IEmployeeService
    {
        public PageResult<Employee> GetEmployeePage(int currentPage, int pageSize);
    }

    public class EmployeeService : GenericService, IEmployeeService
    {
        private IUnitOfWork unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public PageResult<Employee> GetEmployeePage(int currentPage, int pageSize)
        {
            var employeeList = unitOfWork.EmployeeRepository.Context.Employees.Where(e => e.Active == true);
            return GetPage<Employee>(employeeList, currentPage, pageSize);
        }
    }
}
