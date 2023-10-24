using CarCrazeHub.API.Models;
using CarCrazeHub.Domain.Entities;
using CarCrazeHub.Persistence.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace CarCrazeHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly CarCrazeHubDbContext _context;

        public UsersController(CarCrazeHubDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        [HttpPost]
        public void CreateUser([FromBody] CreateUserRequest createUserRequest)
        {
            User user = new()
            {
                FirstName = createUserRequest.FirstName,
                LastName = createUserRequest.LastName,
                CreatedOn = DateTime.UtcNow,
                CreatedByUserId = "nejlakucuk"
            };

            _context.Users.Add(user);

            _context.SaveChanges();
        }
    }
}

