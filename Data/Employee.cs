namespace MSSQLApp.Data // Defines the `MSSQLApp.Data` namespace, organizing related classes together.
{
    public class Employee // Declares the `Employee` class, which represents an entity in the application.
    {
        public int Id { get; set; } 
        // Represents the primary key for the `Employee` entity. By convention, Entity Framework will treat a property named `Id` as the primary key.

        public string Name { get; set; } 
        // Holds the name of the employee. This property maps to a corresponding column in the database.

        public string Title { get; set; } 
        // Represents the job title or designation of the employee. This property also maps to a database column.
    }
}
