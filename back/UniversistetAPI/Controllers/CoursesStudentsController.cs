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


        /// <summary>
        /// Привязка курса к студенту
        /// </summary>
        /// <param name="id"></param>
        /// <param name="course"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddCourseForStudent(int idStudent, int idCourse)
        {
            if (_context.Students.Where(x=>x.Id == idStudent).SingleOrDefault() is null)
                return Content("Студент не найден");
            if (_context.Courses.Where(x => x.Id == idCourse).SingleOrDefault() is null)
                return Content("Курс не найден");

            var newCourseStudent = new CourseStudent();
            newCourseStudent.CourseId = idCourse;
            newCourseStudent.StudentId = idStudent;

            var course = _context.Courses.Where(x => x.Id == idCourse).SingleOrDefault();

            _context.CourseStudents.Add(newCourseStudent);
            _context.SaveChanges();

            return Content($"Курс {course} успешно");
        }
    }
}
