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

        [HttpPost]
        public Course AddCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();

            return course;
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCourser(int id)
        {
            _context.Courses.Remove(_context.Courses.Where(x=>x.Id == id).SingleOrDefault());
            _context.SaveChanges();
            return Ok();
        }
    }
}
