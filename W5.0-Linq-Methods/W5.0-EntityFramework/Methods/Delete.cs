using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W5._0_EntityFramework.Persistence;

namespace W5._0_EntityFramework.Methods
{
   public class Delete
   {

        public void getDelete()
        {
            var context = new LibraryDbContext();

            context.Database.EnsureCreated();

            var bookToDelete = context.Books.FirstOrDefault(b => b.Title == "Book 2");

            if (bookToDelete != null)
            {
                context.Books.Remove(bookToDelete);
                context.SaveChanges();

                Console.WriteLine("Book is deleted succesfully :) ");
            }
        }


    }
}
