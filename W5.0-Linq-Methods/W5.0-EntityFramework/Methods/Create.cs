using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W5._0_EntityFramework.Entities;
using W5._0_EntityFramework.Persistence;

namespace W5._0_EntityFramework.Methods
{
    public class Create
    {

        public void getCreate() {

            var context = new LibraryDbContext();

            context.Database.EnsureCreated();

            var author = new Author { Name = "John Doe" };
            var book1 = new Book { Title = "Book 1", Author = author };
            var book2 = new Book { Title = "Book 2", Author = author };

            context.Authors.Add(author);
            context.Books.AddRange(book1, book2);
            context.SaveChanges();

            Console.WriteLine("Author and books is saved succesfully :) ");
        }
        
    }
}
