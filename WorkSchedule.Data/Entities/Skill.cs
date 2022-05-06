using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSchedule.Data.Entities
{
    public class Skill : BaseEntity
    {
        [Column(TypeName = "nvarchar(100)")]
        public string Description { get; set; }
        public bool? RequiresTicket { get; set; }

        public ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
