using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSchedule.Data.Entities
{
    public class Employee : BaseEntity
    {
        [Required (ErrorMessage = "This field is required."), Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }
        [Required (ErrorMessage = "This field is required."), Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }
        [Column(TypeName = "char(12)")]
        [MaxLength(12)]
        [RegularExpression(@"((^(\d){12}$)|(^\d{11}$))", ErrorMessage = "Please enter a valid phone number. (E.g. 639123456789)")]
        public string HomePhone { get; set; }
        public bool Active { get; set; }

        public ICollection<Schedule> Schedules { get; set; }
        public ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
