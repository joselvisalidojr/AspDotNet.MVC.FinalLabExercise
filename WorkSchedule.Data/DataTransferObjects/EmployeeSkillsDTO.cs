using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSchedule.Data.DataTransferObjects
{
    public class EmployeeSkillsDTO
    {
        public int EmployeeID { get; set; }
        public int SkillID { get; set; }
        public string SkillDescription { get; set; }
    }
}
