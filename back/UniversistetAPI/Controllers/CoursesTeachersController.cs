using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversistetAPI.Data;
using UniversistetAPI.Models;

namespace UniversistetAPI.Controllers
{
    [Route("api/course_teachers")]
    [ApiController]
    public class CoursesTeachersController : ControllerBase
    {
        private MainContext _context;
        public CoursesTeachersController(MainContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseStudent>>> Get()
        {
            return Ok(await _context.CourseTeachers.ToListAsync());
        }

        [HttpPost]
        public IActionResult AddCourseForTeacher(int idTeacher, int idCourse)
        {
            if (_context.Teachers.Where(x => x.Id == idTeacher).SingleOrDefault() is null)
                return Content("Преподаватель не найден");
            if (_context.Courses.Where(x => x.Id == idCourse).SingleOrDefault() is null)
                return Content("Курс не найден");

            var newCourseTeacher = new CourseTeacher();
            newCourseTeacher.CourseId = idCourse;
            newCourseTeacher.TeacherId = idTeacher;

            var course = _context.Courses.Where(x => x.Id == idCourse).SingleOrDefault();

            _context.CourseTeachers.Add(newCourseTeacher);
            _context.SaveChanges();

            return Content($"Курс {course} успешно");
        }

    }
}
