using ClassJournal.AppCore.Models;
using Microsoft.AspNetCore.Mvc;
using ClassJournal.AppCore.Interfaces;

namespace ClassJournalAPI.ApiControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService classService)
        {
            _userService = classService;
        }

        // GET: api/User
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<UserModel> users = _userService.GetAll();
            return Ok(users);
        }

        // GET: api/User/7
        [HttpGet("{id}", Name = "GetUserById")]
        public IActionResult Get(int id)
        {
            UserModel user = _userService.Get(id);

            if (user == null)
            {
                return NotFound("No such record in database");
            }

            return Ok(user);
        }

        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] UserModel user)
        {
            if (user == null)
            {
                return BadRequest("Missing data");
            }

            _userService.Add(user);
            return CreatedAtRoute(
                "GetUserById",
                new { Id = user.Id },
                user);
        }

        // PUT: api/User/7
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UserModel user)
        {
            if (user == null)
            {
                return BadRequest("Missing data");
            }    

            UserModel recordToUpdate = _userService.Get(id);
            if (recordToUpdate == null)
            {
                return NotFound("No such record in database");
            }

            _userService.Update(recordToUpdate, user);
            return NoContent();
        }

        // DELETE: api/ApiWithActions/7
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            UserModel user = _userService.Get(id);
            if (user == null)
            {
                return NotFound("No such record in database");
            }

            _userService.Delete(user);
            return NoContent();
        }
    }
}