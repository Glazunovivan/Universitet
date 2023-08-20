using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversistetAPI.Data;
using UniversistetAPI.Models;

namespace UniversistetAPI.Controllers
{
    [ApiController]
    [Route("api/courses")]
    public class CourseController : Controller
    {
        private MainContext _context;

        public CourseController(MainContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> Get()
        {
            return Ok(await _context.Courses.ToListAsync());

        }

        [HttpGet("{id}")]
        public Course GetById(int id)
        {
            var course = _context.Courses.Where(x=>x.Id == id).SingleOrDefault();

            return course;
        }
    }
}
