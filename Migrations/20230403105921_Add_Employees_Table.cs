public partial class Add_Employees_Table : Migration
// Represents the migration to add the `Employees` table.
{
    protected override void Up(MigrationBuilder migrationBuilder)
    // Defines actions to apply the migration (e.g., adding tables).
    {
        migrationBuilder.CreateTable(
            name: "Employees", 
            // Creates the `Employees` table.

            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                // Adds an `Id` column of type `int`, auto-incrementing starting from 1.

                Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                // Adds a `Name` column of type `nvarchar(max)` (variable-length string), not nullable.

                Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                // Adds a `Title` column of type `nvarchar(max)`, not nullable.
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Employees", x => x.Id);
                // Sets `Id` as the primary key for the `Employees` table.
            });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    // Defines actions to undo the migration (e.g., dropping tables).
    {
        migrationBuilder.DropTable(
            name: "Employees");
        // Drops the `Employees` table.
    }
}
