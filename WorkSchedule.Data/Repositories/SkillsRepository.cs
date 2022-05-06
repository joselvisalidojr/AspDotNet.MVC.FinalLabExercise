using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSchedule.Data;
using WorkSchedule.Data.Entities;

namespace WorkSchedule.Data.Repositories
{
    public interface ISkillsRepository : IBaseRepository<Skill>
    {

    }
    public class SkillsRepository : GenericRepository<Skill>, ISkillsRepository
    {
        public SkillsRepository(WorkScheduleContext context) : base(context)
        {
        }
    }
}
