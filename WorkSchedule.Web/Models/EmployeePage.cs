using System.Collections.Generic;
using WorkSchedule.Data.Entities;

namespace WorkSchedule.Web.Models
{
    public class EmployeePage
    {
        public List<Employee> EmployeeList { get; set; }

        public int CurrentPageIndex { get; set; }

        public int PageCount { get; set; }
    }
}
