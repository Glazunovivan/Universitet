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
            _context.Teachers.Add(teacher);
            _context.SaveChanges();

            return teacher;
        }
    }
}
