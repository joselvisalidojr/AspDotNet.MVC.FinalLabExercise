using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSchedule.Data.Entities
{
    public class EmployeeSkill : BaseEntity
    {
        public int? Level { get; set; }
        public int? YearsOfExperience { get; set; }
        [Column(TypeName = "money")]
        public decimal? HourlyWage { get; set; }

        public int EmployeeID { get; set; }
        public Employee Employees { get; set; }

        public int SkillID { get; set; }
        public Skill Skills { get; set; }
    }
}
