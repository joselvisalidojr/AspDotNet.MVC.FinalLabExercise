using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSchedule.Data;
using WorkSchedule.Data.Entities;

namespace WorkSchedule.Data.Repositories
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        Employee SoftDelete(int id);
    }
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(WorkScheduleContext context) : base(context)
        {
        }

        public Employee SoftDelete(int id)
        {
            var entity = this.FindByPrimaryKey(id);
            entity.Active = false;
            this.Context.Attach(entity);
            this.Context.Entry<Employee>(entity).State = EntityState.Modified;
            return entity;
        }
    }
}
