using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversistetAPI.Data;
using UniversistetAPI.Models;

namespace UniversistetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private MainContext _context;

        public TeacherController(MainContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teacher>>> Get()
        {
            return Ok(await _context.Teachers.ToListAsync());

        }

        [HttpGet("{id}")]
        public Teacher GetById(int id)
        {
            var teacher = _context.Teachers.Where(x => x.Id == id).SingleOrDefault();

            return teacher;
        }

        [HttpPost]
        public Teacher AddTeacher(Teacher teacher)
        {
            //if (string.IsNullOrWhiteSpace(teacher.Name))
            //    return Ok("Укажите имя");

            //if (string.IsNullOrWhiteSpace(teacher.Name))
            //    return Ok("Укажите имя");


            _context.Teachers.Add(teacher);
            _context.SaveChanges();

            return teacher;
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteTeacher(int id)
        {
            if (_context.Teachers.Where(x => x.Id == id).SingleOrDefault() is null)
            {
                return Ok("Преподаватель не найден");
            }

            _context.Teachers.Remove(_context.Teachers.Where(x => x.Id == id).SingleOrDefault());
            _context.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateTeacher(Teacher teacher)
        {
            if (_context.Teachers.Where(x => x.Id == teacher.Id).SingleOrDefault() is null)
            {
                return Ok("Преподаватель не найден");
            }
            _context.Teachers.Update(teacher);
            _context.SaveChanges();

            return Ok();
        }
    }
}
