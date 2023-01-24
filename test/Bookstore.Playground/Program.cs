using ConsoleDump;
using Rhetos;
using Rhetos.Dom.DefaultConcepts;
using Rhetos.Logging;
using Rhetos.Utilities;

ConsoleLogger.MinLevel = EventType.Info; // Use EventType.Trace for more detailed log.
string rhetosHostAssemblyPath =  @"C:\Users\jpreksavec\source\repos\Bookstore\src\Bookstore.Service\bin\Debug\net7.0\Bookstore.Service.dll";
using (var scope = LinqPadRhetosHost.CreateScope(rhetosHostAssemblyPath))
{
    var context = scope.Resolve<Common.ExecutionContext>();
    var repository = context.Repository;

    // Query data from the `Common.Claim` table:

    var claims = repository.Common.Claim.Query()
        .Where(c => c.ClaimResource.StartsWith("Common.") && c.ClaimRight == "New")
        .ToSimple(); // Removes ORM navigation properties from the loaded objects.

    claims.ToString().Dump("Common.Claims SQL query");
    claims.Dump("Common.Claims items");

    // Add and remove a `Common.Principal`:

    var testUser = new Common.Principal { Name = "Test123", ID = Guid.NewGuid() };
    repository.Common.Principal.Insert(new[] { testUser });
    repository.Common.Principal.Delete(new[] { testUser });

    // Print logged events for the `Common.Principal`:

    repository.Common.LogReader.Query()
        .Where(log => log.TableName == "Common.Principal" && log.ItemId == testUser.ID)
        .ToList()
        .Dump("Common.Principal log");

    Console.WriteLine("Done.");

    //scope.CommitAndClose(); // Database transaction is rolled back by default.
}