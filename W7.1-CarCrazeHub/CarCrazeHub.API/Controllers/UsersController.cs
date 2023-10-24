using CarCrazeHub.API.Models;
using CarCrazeHub.Domain.Entities;
using CarCrazeHub.Persistence.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace CarCrazeHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly CarCrazeHubDbContext _dbContext;

        public UsersController()
        {
            _dbContext = new();
        }

        [HttpGet]
        public List<User> GetAll()
        {
            return _dbContext.Users.ToList();
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

            _dbContext.Users.Add(user);

            _dbContext.SaveChanges();
        }
    }
}

