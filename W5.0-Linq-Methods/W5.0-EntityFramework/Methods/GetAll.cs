using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W5._0_EntityFramework.Entities;
using W5._0_EntityFramework.Persistence;

namespace W5._0_EntityFramework.Methods
{
    public class GetAll
    {
        public void getAll()
        {

            var context = new LibraryDbContext();

            context.Database.EnsureCreated();

            var booksByJohnDoe = context.Books
                                        .Where(b => b.Author.Name == "John Doe")
                                        .ToList();

            foreach (var book in booksByJohnDoe)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author.Name}");
            }


        }
    }
}
