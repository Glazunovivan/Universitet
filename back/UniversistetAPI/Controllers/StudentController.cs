using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversistetAPI.Data;
using UniversistetAPI.Models;

namespace UniversistetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private MainContext _context;

        public StudentController(MainContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> Get()
        {
            var result = await _context.Students.Include(x=>x.Group).ToListAsync();

            return Ok(result);

        }

        [HttpGet("{id}")]
        public Student GetById(int id)
        {
            var student = _context.Students.Where(x => x.Id == id).SingleOrDefault();

            return student;
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            if (string.IsNullOrWhiteSpace(student.Name))
                return BadRequest("Укажите имя");
            if (string.IsNullOrWhiteSpace(student.Lastname))
                return BadRequest("Укажите фамилию");

            _context.Students.Add(student);
            _context.SaveChanges();

            return Ok(student);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(int id)
        {
            if (_context.Students.Where(x => x.Id == id).SingleOrDefault() is null)
            {
                return BadRequest("Студент не найден");
            }

            _context.Students.Remove(_context.Students.Where(x => x.Id == id).SingleOrDefault());
            _context.SaveChanges();

            return Ok("Студент удалён из системы");
        }

        [HttpPut]
        public ActionResult UpdateStudent(Student student)
        {
            if (_context.Students.Where(x => x.Id == student.Id).SingleOrDefault() is null)
            {
                return Ok("Преподаватель не найден");
            }
            _context.Students.Update(student);
            _context.SaveChanges();

            return Ok();
        }
    }
}
