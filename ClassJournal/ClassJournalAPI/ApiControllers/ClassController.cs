using ClassJournal.AppCore.Interfaces;
using ClassJournal.AppCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassJournal.API.ApiControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassController : ControllerBase
    {
        private readonly IClassService _classService;

        public ClassController(IClassService classService)
        {
            _classService = classService;
        }

        // GET: api/Class
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<ClassModel> classes = _classService.GetAll();
            return Ok(classes);
        }

        // GET: api/Class/7
        [HttpGet("{id}", Name = "GetClassById")]
        public IActionResult Get(int id)
        {
            ClassModel classModel = _classService.Get(id);

            if (classModel == null)
            {
                return NotFound("No such record in database");
            }

            return Ok(classModel);
        }

        // POST: api/Class
        [HttpPost]
        public IActionResult Post([FromBody] ClassModel classModel)
        {
            if (classModel == null)
            {
                return BadRequest("Missing data");
            }

            _classService.Add(classModel);
            return CreatedAtRoute(
                "GetClassById",
                new { Id = classModel.Id },
                classModel);
        }

        // PUT: api/Class/7
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ClassModel classModel)
        {
            if (classModel == null)
            {
                return BadRequest("Missing data");
            }

            ClassModel recordToUpdate = _classService.Get(id);
            if (recordToUpdate == null)
            {
                return NotFound("No such record in database");
            }

            _classService.Update(recordToUpdate, classModel);
            return NoContent();
        }

        // DELETE: api/ApiWithActions/7
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            ClassModel classModel = _classService.Get(id);
            if (classModel == null)
            {
                return NotFound("No such record in database");
            }

            _classService.Delete(classModel);
            return NoContent();
        }
    }
}