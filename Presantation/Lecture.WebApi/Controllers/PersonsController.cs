using Lecture.Domain.Entities;
using Lecture.Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lecture.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : Controller
    {
        private readonly LectureDbContext _context;

        public PersonsController(LectureDbContext lectureDbContext)
        {
            _context = lectureDbContext;


            List<Person> people = new List<Person>
            {
                new Person { Id = Guid.NewGuid(), FirstName = "John", LastName = "Doe" },
                new Person { Id = Guid.NewGuid(), FirstName = "Jane", LastName = "Smith" },
                new Person { Id = Guid.NewGuid(), FirstName = "Alice", LastName = "Johnson" },
                new Person { Id = Guid.NewGuid(), FirstName = "Bob", LastName = "Brown" },
                new Person { Id = Guid.NewGuid(), FirstName = "Charlie", LastName = "Davis" }
            };
            _context.Person.AddRange(people);
            _context.SaveChanges();
            Console.WriteLine(string.Join("\n", people.Select(x => x.Id).ToList()));
        }


        [HttpGet]
        public string GetDefraudedPersonName(Guid personId)
        {

            var person = _context.Person.FirstOrDefault(x => x.Id == personId);

            return person is null ? "Coulnd't Find!" : person.FirstName;
        }

        public IActionResult Index()
        {
            return View();
        }


    }

    
}


   
