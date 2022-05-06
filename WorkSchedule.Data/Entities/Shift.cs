using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSchedule.Data.Entities
{
    public class Shift : BaseEntity
    {
        public int DayOfWeek { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan StartTime { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan EndTime { get; set; }
        [Column(TypeName = "tinyint")]
        public byte NumberOfEmployees { get; set; }
        public bool Active { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? Note { get; set; }

        public int PlacementContractID { get; set; }
        public PlacementContract PlacementContracts { get; set; }

        public ICollection<Schedule> Schedules { get; set; }
    }
}
