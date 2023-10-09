using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W5._0_EntityFramework.Persistence;

namespace W5._0_EntityFramework.Methods
{
    public class Update
    {

        public void getUpdate()
        {
            var context = new LibraryDbContext();

            context.Database.EnsureCreated();

            var bookToUpdate = context.Books.FirstOrDefault(b => b.Title == "Book 1");

            if (bookToUpdate != null)
            {
                bookToUpdate.Title = "Updated Book 1";
                context.SaveChanges();
            }



        }
    }
}
