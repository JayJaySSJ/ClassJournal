using ClassJournal.API.Models;
using ClassJournal.API.RepositoryDependencies;
using Microsoft.AspNetCore.Mvc;

namespace ClassJournalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IClassJournalRepository<UserModel> _classJournalRepository;

        public UserController(IClassJournalRepository<UserModel> classJournalRepository)
        {
            _classJournalRepository = classJournalRepository;
        }

        // GET: api/User
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<UserModel> users = _classJournalRepository.GetAll();
            return Ok(users);
        }

        // GET: api/User/7
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            UserModel user = _classJournalRepository.Get(id);

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

            _classJournalRepository.Add(user);
            return CreatedAtRoute(
                "GET",
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

            UserModel recordToUpdate = _classJournalRepository.Get(id);
            if (recordToUpdate == null)
            {
                return NotFound("No such record in database");
            }

            _classJournalRepository.Update(recordToUpdate, user);
            return NoContent();
        }

        // DELETE: api/ApiWithActions/7
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            UserModel user = _classJournalRepository.Get(id);
            if (user == null)
            {
                return NotFound("No such record in database");
            }

            _classJournalRepository.Delete(user);
            return NoContent();
        }
    }
}