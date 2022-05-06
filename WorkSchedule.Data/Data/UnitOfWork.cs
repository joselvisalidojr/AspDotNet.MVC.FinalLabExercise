using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSchedule.Data.Repositories;

namespace WorkSchedule.Data
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        public IEmployeeRepository EmployeeRepository { get; }
        public IEmployeeSkillsRepository EmployeeSkillsRepository { get; }
        public ISkillsRepository SkillsRepository { get; }
    }
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private WorkScheduleContext context;
        public IEmployeeRepository EmployeeRepository { get; private set; }
        public IEmployeeSkillsRepository EmployeeSkillsRepository { get; private set; }
        public ISkillsRepository SkillsRepository { get; private set; }

        public UnitOfWork(WorkScheduleContext context)
        {
            this.context = context;
            this.EmployeeRepository = new EmployeeRepository(context);
            this.EmployeeSkillsRepository = new EmployeeSkillsRepository(context);
            this.SkillsRepository = new SkillsRepository(context);
        }

        public async Task CommitAsync()
        {
            await this.context.SaveChangesAsync();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}
