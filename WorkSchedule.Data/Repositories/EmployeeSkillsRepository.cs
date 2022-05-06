using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSchedule.Data;
using WorkSchedule.Data.DataTransferObjects;
using WorkSchedule.Data.Entities;

namespace WorkSchedule.Data.Repositories
{
    public interface IEmployeeSkillsRepository : IBaseRepository<EmployeeSkill>
    {
        IEnumerable<EmployeeSkillsDTO> GetEmployeeSkillsByEmployeeId(int employeeId);
        Boolean checkExistingSkill(int employeeId, int skillId);
    }
    public class EmployeeSkillsRepository : GenericRepository<EmployeeSkill>, IEmployeeSkillsRepository
    {
        public EmployeeSkillsRepository(WorkScheduleContext context) : base(context)
        {
        }

        public IEnumerable<EmployeeSkillsDTO> GetEmployeeSkillsByEmployeeId(int employeeId)
        {
            var employeeSkills = from e in this.Context.Employees
                                join es in this.Context.EmployeeSkills on e.ID equals es.EmployeeID
                                join s in this.Context.Skills on es.SkillID equals s.ID
                                 where e.ID == employeeId
                                 select new EmployeeSkillsDTO
                                {   
                                    EmployeeID = e.ID,
                                    SkillID = s.ID,
                                    SkillDescription = s.Description
                                };

            //var employeeSkillsList = this.Context.EmployeeSkills.Join(this.Context.Skills,
            //                         employeeSkill => employeeSkill.SkillID,
            //                         skill => skill.ID,
            //                         (employeeSkill, skill) => new EmployeeSkillsDTO
            //                         {
            //                             EmployeeID = employeeSkill.ID,
            //                             SkillID = skill.ID,
            //                             SkillDescription = skill.Description
            //                         }
            //                         );

            if (employeeSkills != null)
            {
                return employeeSkills.ToList();
            }
            return null;
        }

        public Boolean checkExistingSkill(int employeeId, int skillId)
        {
            EmployeeSkill exists = this.Context.EmployeeSkills.Where(x => x.EmployeeID == employeeId && x.SkillID == skillId).FirstOrDefault();
            if(exists != null)
            {
                return true;
            }
            return false;
        }
    }

}
