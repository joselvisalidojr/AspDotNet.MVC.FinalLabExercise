using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkSchedule.Data.Migrations
{
    public partial class SkillsDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql
                (
                    @"
                    INSERT INTO Skills 
                        (
                            Description
                        )
                    VALUES 
                        (
                            'Communication skill'
                        ),
                        (
                            'Visual Basic'
                        ),
                        (
                            'Database Administration'
                        ),
                        (
                            'Data Entry'
                        ),
                        (
                            'Team leading'
                        ),
                        (
                            'Power Builder'
                        ),
                        (
                            'Record Keeping'
                        ),
                        (
                            'Presentation Skill'
                        ),
                        (
                            'Convincing'
                        ),
                        (
                            'Learning'
                        ),
                        (
                            'Planning'
                        ),
                        (
                            'Project Management'
                        ),
                        (
                            'Time Keeping'
                        ),
                        (
                            'Analytical'
                        ),
                        (
                            'MS-Office'
                        ),
                        (
                            'Initiative'
                        ),
                        (
                            'Self Motivation'
                        ),
                        (
                            'Scheduling'
                        ),
                        (
                            'Interpersonal Skill'
                        ),
                        (
                            'Fullstack development'
                        )
                    "
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
