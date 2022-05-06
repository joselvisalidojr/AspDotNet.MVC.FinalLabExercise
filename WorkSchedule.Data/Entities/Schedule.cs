using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSchedule.Data.Entities
{
    public class Schedule : BaseEntity
    {
        [Column(TypeName = "date")]
        public DateTime Day { get; set; }
        [Column(TypeName = "money")]
        public decimal HourlyWage { get; set; }
        public bool OverTime { get; set; }
        public int ShiftID { get; set; }
        public Shift Shifts { get; set; }

        public int EmployeeID { get; set; }
        public Employee Employees { get; set; }
    }
}
