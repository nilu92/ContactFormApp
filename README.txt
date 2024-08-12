dotnet ef migrations add InitialCreate
dotnet ef database update

In appsettings.Json

{
  
    "ConnectionStrings": {
      "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ContactFormAppDb;Trusted_Connection=True;MultipleActiveResultSets=true"
    },