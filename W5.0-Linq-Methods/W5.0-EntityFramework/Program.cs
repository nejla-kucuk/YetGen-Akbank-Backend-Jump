
using W5._0_EntityFramework.Entities;
using W5._0_EntityFramework.Methods;
using W5._0_EntityFramework.Persistence;

Create createAuthorAndBook = new Create();
createAuthorAndBook.getCreate();

Console.WriteLine("-------------------------------");

// Delete deletedBook = new Delete();
// deletedBook.getDelete();


Console.WriteLine("-------------------------------");

GetAll getAll = new GetAll();
getAll.getAll();

Console.WriteLine("-------------------------------");

Update updatedBook = new Update();
updatedBook.getUpdate();




