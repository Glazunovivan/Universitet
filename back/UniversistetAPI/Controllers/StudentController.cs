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
        public Student AddStudent(Student student)
        {
            //if (string.IsNullOrWhiteSpace(student.Name))
            //    return Ok("Укажите имя");

            //if (string.IsNullOrWhiteSpace(student.Name))
            //    return Ok("Укажите имя");


            _context.Students.Add(student);
            _context.SaveChanges();

            return student;
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(int id)
        {
            if (_context.Students.Where(x => x.Id == id).SingleOrDefault() is null)
            {
                return Ok("Студент не найден");
            }

            _context.Students.Remove(_context.Students.Where(x => x.Id == id).SingleOrDefault());
            _context.SaveChanges();

            return Ok();
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
