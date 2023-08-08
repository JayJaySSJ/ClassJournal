using ClassJournal.API.Models;
using ClassJournal.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ClassJournalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrainerController : ControllerBase
    {
        private readonly IClassJournalRepository<TrainerModel> _classJournalRepository;

        public TrainerController(IClassJournalRepository<TrainerModel> classJournalRepository)
        {
            _classJournalRepository = classJournalRepository;
        }

        // GET: api/Trainer
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<TrainerModel> trainers = _classJournalRepository.GetAll();
            return Ok(trainers);
        }

        // GET: api/Trainer/7
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            TrainerModel trainer = _classJournalRepository.Get(id);

            if (trainer == null)
            {
                return NotFound("No such record in database");
            }

            return Ok(trainer);
        }

        // POST: api/Trainer
        [HttpPost]
        public IActionResult Post([FromBody] TrainerModel trainer)
        {
            if (trainer == null)
            {
                return BadRequest("Missing data");
            }

            _classJournalRepository.Add(trainer);
            return CreatedAtRoute(
                "GET",
                new { Id = trainer.Id },
                trainer);
        }

        // PUT: api/Trainer/7
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TrainerModel trainer)
        {
            if (trainer == null)
            {
                return BadRequest("Missing data");
            }    

            TrainerModel recordToUpdate = _classJournalRepository.Get(id);
            if (recordToUpdate == null)
            {
                return NotFound("No such record in database");
            }

            _classJournalRepository.Update(recordToUpdate, trainer);
            return NoContent();
        }

        // DELETE: api/ApiWithActions/7
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            TrainerModel trainer = _classJournalRepository.Get(id);
            if (trainer == null)
            {
                return NotFound("No such record in database");
            }

            _classJournalRepository.Delete(trainer);
            return NoContent();
        }
    }
}