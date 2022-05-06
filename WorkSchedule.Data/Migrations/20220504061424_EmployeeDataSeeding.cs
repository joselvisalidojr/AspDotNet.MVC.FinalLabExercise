using Bogus;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Linq;

namespace WorkSchedule.Data.Migrations
{
    public partial class EmployeeDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var faker = new Faker("en");

            foreach (int num in Enumerable.Range(1, 100).Select(x => x))
            {
                migrationBuilder.InsertData(
                    table: "Employees",
                    columns: new[] { "FirstName", "LastName", "HomePhone", "Active" },
                    values: new object[] { faker.Name.FirstName(), faker.Name.LastName(), faker.Phone.PhoneNumber("63##########"), true }
                );
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
