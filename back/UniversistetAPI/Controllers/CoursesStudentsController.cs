using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversistetAPI.Data;
using UniversistetAPI.Models;

namespace UniversistetAPI.Controllers
{
    [Route("api/course_students")]
    [ApiController]
    public class CoursesStudentsController : ControllerBase
    {
        private MainContext _context;
        public CoursesStudentsController(MainContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseStudent>>> Get()
        {
            return Ok(await _context.CourseStudents.ToListAsync());
        }
    }
}
